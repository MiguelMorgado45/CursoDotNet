namespace TeresaSA;

public static class ExtensionesFloat
{
    public const float Cambio = 18.64f;
    public static float ToPesos(this float total)
    {
        return total * Cambio;
    }
}