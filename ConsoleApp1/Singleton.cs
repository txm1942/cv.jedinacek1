public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();
    public Databaze databaze;
    private Singleton(){
        databaze = new Databaze("host", "jmeno", "heslo");
    }
    public static Singleton VratInstanci()
    {
        return instance;
    }
}
