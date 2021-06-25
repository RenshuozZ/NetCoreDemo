using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadAppsetttingConfig.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetSectionBindingController : ControllerBase
    {

        private readonly MySettingsConfiguration _settings;
        public GetSectionBindingController(IConfiguration configuration, MySettingsConfiguration mySettingsConfiguration)
        {
            //_settings = new MySettingsConfiguration();
            //configuration.GetSection("AppSettings").Bind(_settings);
            _settings = mySettingsConfiguration;
        }

        [HttpGet("section_binding")]
        public string GetSection_Binding()
        {
            var isTest = _settings?.MyProjectConfig?.IsTest;
            return _settings?.MyProjectConfig?.Name;
        }


        [HttpGet("section_preBinding")]
        public string GetSection_PreBinding()
        {
            var isTest = _settings?.MyProjectConfig?.IsTest;
            return _settings?.MyProjectConfig?.Name;
        }
    }
}
