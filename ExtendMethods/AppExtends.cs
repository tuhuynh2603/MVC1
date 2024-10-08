using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;

namespace MVC1.ExtendMethods
{
    public static class AppExtends
    {
        public static void AddStatusCodePage(this IApplicationBuilder app)
        {
            app.UseStatusCodePages(appError =>
                {
                    appError.Run(async context =>
                    {
                        var respone = context.Response;
                        var code = respone.StatusCode;
                        
                        var content = @$"<html>
                        <head>
                        <title> {code} </title>
                        </head>
                        <body>

                        <p style='color:red; font-size 30px'> Error happended {code} - {(HttpStatusCode)code} </p>
                        </body>
                        ";
                        await respone.WriteAsync(content);
                    });
                }
            );
        }
    }
}

