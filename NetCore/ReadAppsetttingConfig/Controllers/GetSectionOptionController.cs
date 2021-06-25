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
    public class GetSectionOptionController : ControllerBase
    {


     
        private readonly IOptions<MySettingsConfiguration> _optionsSetting;
        private readonly IOptionsSnapshot<MySettingsConfiguration> _optionsSnapshotSetting;
        public GetSectionOptionController( IConfiguration configuration, IOptions<MySettingsConfiguration> optionsSetting,IOptionsSnapshot<MySettingsConfiguration> optionsSnapshotSetting)
        {
            _optionsSnapshotSetting = optionsSnapshotSetting;
            _optionsSetting = optionsSetting;
        }

        [HttpGet("section_option")]
        public string GetSection_Option()
        {
            return _optionsSetting.Value.MyProjectConfig.Name;
        }

        [HttpGet("section_option_snapshot")]
        public string GetSection_Option_Snapshot()
        {
            return _optionsSnapshotSetting.Value.MyProjectConfig.Name;
        }

    }
}
