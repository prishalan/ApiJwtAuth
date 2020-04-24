using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJwtAuth.Configuration.V1
{
    public  static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private static readonly string Base = $"{Root}/{Version}";

        public static class Values
        {
            public static readonly string GetAll = $"{Base}/values";
        }
    }
}
