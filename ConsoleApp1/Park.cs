using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum BeslenmeTip
    {
        Ot,
        Et
    }
    public class Hayvan
    {
        public BeslenmeTip BeslenmeTürü;
    }
    public abstract class Kedigiller:Hayvan
    {
        public bool Tirmanma = true;
        public void Girla()
        {
            Console.WriteLine("Gırrrrrr");
        }
        public abstract void Ses();
    }
    public class Aslan : Kedigiller
    {
        public override void Ses()
        {
            throw new NotImplementedException();
        }
    }
    public class Kedi : Kedigiller
    {
        public override void Ses()
        {
            throw new NotImplementedException();
        }
    }
}
