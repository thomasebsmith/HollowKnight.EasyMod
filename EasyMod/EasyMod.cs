using Modding;

namespace EasyMod;

public class EasyMod : ModBase
{
    public EasyMod() : base(nameof(EasyMod))
    {
    }

    public override void Initialize()
    {
        Log("Initializing...");
    }

    public override void Unload()
    {
        Log("Unloading...");
    }

    public override string GetVersion() => "0.1";
}
