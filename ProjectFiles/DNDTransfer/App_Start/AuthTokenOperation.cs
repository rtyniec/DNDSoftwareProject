using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace DNDTransfer.App_Start//this class is a document filter
{
    public class AuthTokenOperation : IDocumentFilter//add a new route called /token in the auth category, command is POST and type of data should be application/x-www-form-urlencoded
    {
        public void Apply(SwaggerDocument swaggerDoc, SchemaRegistry schemaRegistry, IApiExplorer apiExplorer)
        {
            swaggerDoc.paths.Add("/token", new PathItem
            {
                post = new Operation
                {
                    tags = new List<string> { "Auth" },
                    consumes = new List<string>
                        {
                            "application/x-www-form-urlencoded"

                        },
                    parameters = new List<Parameter>
                        {
                            new Parameter
                            {
                                type = "string",
                                name = "grant_type",
                                required = true,
                                @in = "formData",
                                @default = "password"
                            },
                            new Parameter
                            {
                                type = "string",
                                name = "username",
                                required = false,
                                @in = "formData"
                            },
                            new Parameter
                            {
                                type = "string",
                                name = "password",
                                required = false,
                                @in = "formData"
                            }
                        }
                }
            });
        }
    }
}