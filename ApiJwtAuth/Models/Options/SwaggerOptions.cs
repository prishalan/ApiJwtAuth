using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJwtAuth.Models.Options
{
    public class SwaggerOptions
    {
        public string Description { get; set; }
        public string RouteTemplate { get; set; }
        public string UIEndpoint { get; set; }
    }
}
