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
        // TODO: apply any hooks that should always be active
    }

    public override void Unload()
    {
        // TODO: unapply any hooks applied in Load()
    }
}
