// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;

class Program1
{
    public static void Main()  //Bir şey dönmesini beklemiyorsak void kullanılır.
    {
        //Kisi k1 = new Musteri();
        //k1.Ad = "Ali";
        //k1.Soyad = "Demir";
        //Console.WriteLine(k1.ToString());
    } //End Main

    public static void Samp1()
    {
        ArrayList ar = new ArrayList();
        ar.Add(1);
        ar.Add(2);
        ar.Add(3);
        ar.Add(4);
        ar.Add(5);

        for (int i = 0; i < ar.Count; i++)
        {
            Console.WriteLine(ar[i]);
        }
    }
}
