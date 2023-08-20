using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace Opposing_sides
{
    public class Config : IConfig
    {
        [Description("Enable or disable the plugin.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Not used")]
        public bool Debug { get; set; }
        [Description("If Reativate = true, then the Tesla gates will turn off if more Class D personnel escaped than scientists and will turn on if more scientists escaped than Class D personnel.")]
        public bool Reactivate { get; set; } = true;
        [Description("If Reactivate = false, then the Tesla gateы will be disabled after the number of Class D personnel specified in the EscapeCount parameter escapes.")]
        public int EscapeCount { get; set; } = 3;
    }
}
