using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadAppsetttingConfig
{
    public sealed class MySettingsConfiguration
    {
        public const string AppSettings = "AppSettings";
        public string SettingConfig { get; set; }
        public MyProjectConfig MyProjectConfig { get; set; }
    }

    public sealed class MyProjectConfig
    {
        public bool IsTest { get; set; }
        public string Name { get; set; }
    }
}
