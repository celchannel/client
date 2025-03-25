using Microsoft.Xna.Framework;

namespace Celeste.Mod.CelesteChannel;

public class NewDeathRequest : APIRequest
{
    protected override string Target => "newdeath";

    public int AreaSID { get; }
    public string LevelName { get; }
    public char Side { get; }
    public bool GoldenBerry { get; }
    public float PositionX { get; }
    public float PositionY { get; }

    public NewDeathRequest(Vector2 position, Level level)
    {
        AreaSID = level.Session.Area.ID;
        LevelName = level.Session.LevelData.Name;
        Side = (char)('A' + level.Session.Area.Mode);
        GoldenBerry = level.Session.GrabbedGolden;
        PositionX = position.X;
        PositionY = position.Y;
    }
}