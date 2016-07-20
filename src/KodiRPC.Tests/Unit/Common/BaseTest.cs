using System;
using System.Collections;
using System.Reflection;
using KodiRPC.ExceptionHandling.RPC;
using KodiRPC.Responses.Types.Media;
using KodiRPC.Responses.Types.Video;
using KodiRPC.RPC.RequestResponse;
using Newtonsoft.Json;
using Stream = KodiRPC.Responses.Types.Video.Stream;
using NUnit.Framework;
using KodiRPC.Responses.Types.Video.Details;
using KodiRPC.RPC.RequestResponse.Params;

namespace KodiRPC.Tests.Unit.Common
{
    public class BaseTest
    {
        public JsonRpcResponse<T> MakeFauxRequest<T>(string file)
        {
            string json;

            try
            {
                json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/../../App_Data/" + file);
            }
            catch (Exception)
            {
                json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"/../../App_Data/error.json");
            }

            var response = JsonConvert.DeserializeObject<JsonRpcResponse<T>>(json);

            if (response.Error == null)
            {
                return response;
            }

            var internalServerErrorException = new RpcInternalServerErrorException(response.Error.Message)
            {
                RpcErrorCode = response.Error.Code
            };

            throw internalServerErrorException;
        }

        public static void AssertThatPropertyValuesAreEquals(object actual, object expected)
        {
            var properties = expected.GetType().GetProperties();

            foreach (var property in properties)
            {
                var expectedValue = property.GetValue(expected, null);
                var actualValue = property.GetValue(actual, null);

                if (actualValue is IList)
                {
                    AssertThatListsAreEquals(property, (IList)actualValue, (IList)expectedValue, expected.GetType().ToString());
                }
                else if (actualValue is Streams || actualValue is Resume || actualValue is Artwork || actualValue is UniqueId || 
                    actualValue is Limits)
                {
                    AssertThatPropertyValuesAreEquals(actualValue, expectedValue);
                }
                else if (!Equals(expectedValue, actualValue))
                {
                    Assert.Fail("Property {0}.{1} does not match. Expected: {2} but was: {3}",
                        property.DeclaringType?.Name, property.Name, expectedValue, actualValue);
                }
            }
        }

        private static void AssertThatListsAreEquals(PropertyInfo property, IList actualList, IList expectedList, string parentType)
        {
            if (actualList?.Count != expectedList?.Count)
            {
                Assert.Fail("Property {0}.{1} does not match. Expected IList containing {2} elements but was IList containing {3} elements\nParent Type: {4}", 
                    property.PropertyType.Name, property.Name, expectedList?.Count, actualList?.Count, parentType);
            }

            for (var i = 0; i < actualList?.Count; i++)
            {
                if (actualList[i] is Cast || actualList[i] is Stream.Video || actualList[i] is Stream.Audio || actualList[i] is Stream.Subtitle || 
                    actualList[i] is Episode || actualList[i] is TvShow || actualList[i] is Movie || actualList[i] is Season)
                {
                    AssertThatPropertyValuesAreEquals(actualList[i], expectedList[i]);
                }
                else if  (!Equals(actualList[i], expectedList[i]))
                {
                    Assert.Fail(
                        "Property {0}.{1} does not match. Expected IList with element {1} equals to {2} but was IList with element {1} equals to {3}",
                        property.PropertyType.Name, property.Name, expectedList[i], actualList[i]);
                }
            }
        }
    }
}