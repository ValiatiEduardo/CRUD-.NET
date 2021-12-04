using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRUD.NET
{
    public class Startup
    {
       public void Configuration (IApplicationBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            var formatters = config.Formatters;
        }
    }
}
