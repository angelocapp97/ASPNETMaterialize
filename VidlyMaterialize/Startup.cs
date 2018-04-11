using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(VidlyMaterialize.Startup))]
namespace VidlyMaterialize
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}