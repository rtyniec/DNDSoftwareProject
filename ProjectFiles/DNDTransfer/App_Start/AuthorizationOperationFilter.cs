using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace DNDTransfer.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter//this will add the token parameter to every api call
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if(operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {

                name = "Authorization",
                required = false,//some methods will/do not need authorization
                @in = "header",
                description = "access token",
                type = "string"

            });
        }
    }
}