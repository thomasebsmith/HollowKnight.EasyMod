using Modding;

namespace EasyMod;
using static Utils;

public abstract class ModBase : Mod, ITogglableMod
{
    private IDictionary<string, Func<int, int>> intOverrides =
        new Dictionary<string, Func<int, int>>();

    public ModBase(string modName) : base(modName)
    {
    }

    protected void OverrideInt(string name, Func<int, int> calculateValue)
    {
        if (intOverrides.TryGetValue(name, out var calculateValueOld))
        {
            intOverrides[name] = Compose(calculateValue, calculateValueOld);
        }
        else
        {
            intOverrides[name] = calculateValue;
        }
    }

    protected int GetInt(string name, int orig)
    {
        if (intOverrides.TryGetValue(name, out var calculateValue))
        {
            return calculateValue(orig);
        }
        return orig;
    }

    public abstract void Unload();
}
