namespace EasyMod;

public static class Utils
{
    public static Func<T, V> Compose<T, U, V>(Func<U, V> f, Func<T, U> g) =>
        x => f(g(x));
}
