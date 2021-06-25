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
    public class GetSectionController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GetSectionController( IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("section")]
        public string GetSection()
        {
            var isTest= bool.Parse(_configuration.GetSection("AppSettings").GetSection("MyProjectConfig").GetSection("IsTest").Value);
            return _configuration.GetSection("AppSettings").GetSection("MyProjectConfig").GetSection("Name").Value;
        }

        [HttpGet("section_getValue")]
        public string GetSection_GetValue()
        {
            bool isTest = _configuration.GetSection("AppSettings").GetSection("MyProjectConfig").GetValue<bool>("IsTest");
            return _configuration.GetSection("AppSettings").GetSection("MyProjectConfig").GetValue<string>("Name");
        }

        [HttpGet("section_getValue_inline")]
        public string GetSection_GetValue_Inline()
        {
            bool isTest = _configuration.GetValue<bool>("AppSettings:MyProjectConfig:IsTest");
            return _configuration.GetValue<string>("AppSettings:MyProjectConfig:Name");
        }
    }
}
