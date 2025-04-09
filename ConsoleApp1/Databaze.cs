using System;

 public class Databaze
{
    private string host;
    private string jmeno;
    private string heslo;

    public Databaze(string host, string jmeno, string heslo)
    {
        this.host = host;
        this.jmeno = jmeno;
        this.heslo = heslo;
    }

    public void Pripojit()
    {
        Console.WriteLine("pripojeno na databazi jako " + host);
    }
}
