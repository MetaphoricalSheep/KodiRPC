using KodiRPC.RPC.Specifications.Properties.Video.Details;
using System.Linq;
using System.Reflection;

namespace KodiRPC.RPC.Specifications.Properties
{
    public class GetMovieDetailsProperties : MovieProperties
    {
        public static string[] All()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;

            return declaringType?.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                .Select(field => field.GetValue(null) as string).ToArray();
        }
    }
}
