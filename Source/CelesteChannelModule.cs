using System;

namespace Celeste.Mod.CelesteChannel;

public class CelesteChannelModule : EverestModule
{
    public static CelesteChannelModule Instance { get; private set; }

    public override Type SettingsType => typeof(CelesteChannelModuleSettings);
    public static CelesteChannelModuleSettings Settings => (CelesteChannelModuleSettings)Instance._Settings;

    public CelesteChannelModule()
    {
        Instance = this;
    }

    public override void Load()
    {
        Everest.Events.Player.OnDie += player => new NewDeathRequest(player.Position, player.level).Perform();
    }

    public override void Unload()
    {
    }
}