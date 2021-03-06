namespace EasyMod;

public enum Charm
{
    GatheringSwarm,
    WaywardCompass,
    Grubsong,
    StalwartShell,
    BaldurShell,
    FuryOfTheFallen,
    QuickFocus,
    LifebloodHeart,
    LifebloodCore,
    DefendersCrest,
    Flukenest,
    ThornsOfAgony,
    MarkOfPride,
    SteadyBody,
    HeavyBlow,
    SharpShadow,
    SporeShroom,
    Longnail,
    ShamanStone,
    SoulCatcher,
    SoulEater,
    GlowingWomb,
    FragileHeart,
    FragileHeartBroken,
    UnbreakableHeart,
    FragileGreed,
    FragileGreedBroken,
    UnbreakableGreed,
    FragileStrength,
    FragileStrengthBroken,
    UnbreakableStrength,
    NailmastersGlory,
    JonisBlessing,
    ShapeOfUnn,
    Hiveblood,
    DreamWielder,
    Dashmaster,
    QuickSlash,
    SpellTwister,
    DeepFocus,
    GrubberflysElegy,
    WhiteFragment,
    Kingsoul,
    VoidHeart,
    Sprintmaster,
    Dreamshield,
    Weaversong,
    Grimmchild,
    CarefreeMelody,
}

public static class CharmExtensions
{
    public static String GetName(this Charm charm) => "CHARM_NAME_" +
        charm switch
        {
            Charm.GatheringSwarm => "1",
            Charm.WaywardCompass => "2",
            Charm.Grubsong => "3",
            Charm.StalwartShell => "4",
            Charm.BaldurShell => "5",
            Charm.FuryOfTheFallen => "6",
            Charm.QuickFocus => "7",
            Charm.LifebloodHeart => "8",
            Charm.LifebloodCore => "9",
            Charm.DefendersCrest => "10",
            Charm.Flukenest => "11",
            Charm.ThornsOfAgony => "12",
            Charm.MarkOfPride => "13",
            Charm.SteadyBody => "14",
            Charm.HeavyBlow => "15",
            Charm.SharpShadow => "16",
            Charm.SporeShroom => "17",
            Charm.Longnail => "18",
            Charm.ShamanStone => "19",
            Charm.SoulCatcher => "20",
            Charm.SoulEater => "21",
            Charm.GlowingWomb => "22",
            Charm.FragileHeart => "23",
            Charm.FragileHeartBroken => "23_BRK",
            Charm.UnbreakableHeart => "23_G",
            Charm.FragileGreed => "24",
            Charm.FragileGreedBroken => "24_BRK",
            Charm.UnbreakableGreed => "24_G",
            Charm.FragileStrength => "25",
            Charm.FragileStrengthBroken => "25_BRK",
            Charm.UnbreakableStrength => "25_G",
            Charm.NailmastersGlory => "26",
            Charm.JonisBlessing => "27",
            Charm.ShapeOfUnn => "28",
            Charm.Hiveblood => "29",
            Charm.DreamWielder => "30",
            Charm.Dashmaster => "31",
            Charm.QuickSlash => "32",
            Charm.SpellTwister => "33",
            Charm.DeepFocus => "34",
            Charm.GrubberflysElegy => "35",
            Charm.WhiteFragment => "36_A",
            Charm.Kingsoul => "36_B",
            Charm.VoidHeart => "36_C",
            Charm.Sprintmaster => "37",
            Charm.Dreamshield => "38",
            Charm.Weaversong => "39",
            Charm.Grimmchild => "40",
            Charm.CarefreeMelody => "40_N",
            _ => throw new ArgumentOutOfRangeException(nameof(charm), "Invalid enum member")
        };
}
