namespace Celeste.Mod.CelesteChannel;

public class CelesteChannelModuleSettings : EverestModuleSettings
{
    [SettingMaxLength(50)]
    public string ServerURL { get; set; }

    [SettingMaxLength(50)]
    public string Token { get; set; }
}