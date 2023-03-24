// See https://aka.ms/new-console-template for more informati


class program
{
    static void Main(string[] args)
    {
        Penjumlahan<int> a = new Penjumlahan<int>();
        int q = a.JumlahTigaAngka(13, 02, 21);
        Console.WriteLine(q);
    }
}

public class Penjumlahan<T>
{
    public int JumlahTigaAngka(T a, T b, T c)
    {
        dynamic aa = (dynamic)a;
        dynamic bb = (dynamic)b;
        dynamic cc = (dynamic)c;

        return aa + bb + cc;
    }
}