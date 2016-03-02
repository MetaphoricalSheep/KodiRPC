using System.Linq;
using System.Reflection;
using KodiRPC.RPC.Specifications.Properties.Video.Details;

namespace KodiRPC.RPC.Specifications.Properties
{
    public class GetMoviesProperties : MovieProperties
    {
        public static string[] All()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;

            return declaringType?.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Select(field => field.GetValue(null) as string).ToArray();
        }
    }
}