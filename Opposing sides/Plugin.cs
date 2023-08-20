using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opposing_sides
{
    public class Plugin : Plugin<Config>
    {
        private Config config = new Config();
        public override string Name => "Opposing sides";
        public override string Author => "Sakred_";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Log.Warn("The plugin is in beta. More features will appear in the plugin soon. If bugs are found, leave a feedback by clicking on the link capybara-scpsl.com/feedback .");
            Exiled.Events.Handlers.Player.TriggeringTesla += OnActivatingTesla;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= OnActivatingTesla;
            base.OnDisabled();
        }

        public void OnActivatingTesla(TriggeringTeslaEventArgs ev)
        {
            if (config.Reactivate == true)
            {
                if (Round.EscapedDClasses > Round.EscapedScientists && ev.Player.Role.Team == Team.ChaosInsurgency)
                {
                    ev.IsAllowed = false;
                }
                else
                {
                    ev.IsAllowed = true;
                }
            }
            else
            {
                if (Round.EscapedDClasses >= config.EscapeCount && ev.Player.Role.Team == Team.ChaosInsurgency)
                {
                    ev.IsAllowed = false;
                }
                else
                {
                    ev.IsAllowed = true;
                }
            }
        }
    }

}
