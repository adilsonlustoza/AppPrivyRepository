using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using NSwag.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AppPrivy.WebAppApi.Filters
{
    public class SwaggerExcludeFilter : Swashbuckle.AspNetCore.SwaggerGen.ISchemaFilter
    {
        #region ISchemaFilter Members

        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            
        }

        [Obsolete]
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            {
                if (schema.Properties.Count == 0)
                    return;

                const BindingFlags bindingFlags = BindingFlags.Public |
                                                  BindingFlags.NonPublic |
                                                  BindingFlags.Instance;
                var memberList = context.Type
                                    .GetFields(bindingFlags).Cast<MemberInfo>()
                                    .Concat(context.Type
                                    .GetProperties(bindingFlags));

                var excludedList = memberList.Where(m =>
                                                    m.GetCustomAttribute<SwaggerIgnoreAttribute>()
                                                    != null)
                                             .Select(m =>
                                                 (m.GetCustomAttribute<JsonPropertyAttribute>()
                                                  ?.PropertyName
                                                  ?? m.Name));

                foreach (var excludedName in excludedList)
                {
                    if (schema.Properties.ContainsKey(excludedName))
                        schema.Properties.Remove(excludedName);
                }
            }
        }
            

        #endregion
    }
}
