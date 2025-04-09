public class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.VratInstanci();  
        singleton.databaze.Pripojit();                  

        Singleton singleton2 = Singleton.VratInstanci();
        if (singleton == singleton2)
        {
            Console.WriteLine("obe instance jsou stejne");
        }
        else
        {
            Console.WriteLine("instance jsou jine");
        }
    }
}