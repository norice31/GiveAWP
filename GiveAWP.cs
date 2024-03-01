using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Modules.Cvars;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Timers;
using CounterStrikeSharp.API.Core.Attributes;

namespace GiveAWP
{
    public class GiveAWP : BasePlugin
    {
        public override string ModuleName => "GiveAWP";
        public override string ModuleVersion => "v1";
        public override string ModuleAuthor => "nomixe";

    [GameEventHandler]
        public HookResult EventPlayerSpawn(EventPlayerSpawn @event, GameEventInfo info)
        {
            if (@event == null) return HookResult.Continue;
            var player = @event.Userid;
            if (player == null || !player.IsValid || player.PlayerPawn == null || !player.PlayerPawn.IsValid || player.PlayerPawn.Value == null || !player.PlayerPawn.Value.IsValid)return HookResult.Continue;
            var playerid = player.SteamID;

            player.GiveNamedItem("weapon_awp");
            return HookResult.Continue;
        }
    }
}