using System.Collections.Generic;
using System.Threading.Tasks;

using KubernetesPoC.Models;
using KubernetesPoC.Services;

using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Options;

namespace KubernetesPoC.Controllers {
    [ApiController]
    [Route ("[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DemoConsulConfigController : ControllerBase {
        private readonly DemoAppSettings _options;

        public DemoConsulConfigController (IOptionsSnapshot<DemoAppSettings> options) {
            _options = options.Value;
        }

        [HttpGet]
        //[AllowAnonymous]
        public DemoAppSettings GetAllAsync () {
            return _options;
        }
    }
}