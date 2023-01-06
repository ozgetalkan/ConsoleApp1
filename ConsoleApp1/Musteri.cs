using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kisi
{
    public string Ad;
    public string Soyad;
    public override string ToString()
    {
        return Ad + " " + Soyad;
    }
}

public class Arkadas : Kisi
{

}

public class Musteri : Kisi
{
    public int MusteriNo;
    public decimal Bakiye;
    public decimal IndirimYap(decimal indirim)  //Fonksiyonun imzası
    {
        return Bakiye - indirim;
    }
    public override string ToString()
    {
        return MusteriNo.ToString() + " - " + Ad + " " + Soyad;
    }

}

