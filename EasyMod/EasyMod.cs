using Modding;

namespace EasyMod;

public class EasyMod : Mod, ITogglableMod
{
    public EasyMod() : base(nameof(EasyMod))
    {
    }

    public override void Initialize()
    {
        Log("Initializing...");
    }

    public void Unload()
    {
        Log("Unloading...");
    }

    public override string GetVersion()
    {
        return "0.1";
    }
}
