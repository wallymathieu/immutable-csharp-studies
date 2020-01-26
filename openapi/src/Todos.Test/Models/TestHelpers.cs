
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Todos.Test
{
    public class TestHelpers
    {
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
                {
                    OverrideSpecifiedNames = true
                }
            }
        };

    }

}
