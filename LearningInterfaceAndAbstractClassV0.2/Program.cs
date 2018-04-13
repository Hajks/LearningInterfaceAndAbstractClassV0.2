using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tallguy tallguy = new Tallguy() { Name = "Tomek", Height = 178 };
            tallguy.TalkAboutYourSelf();
            tallguy.Honk();
            System.Console.Read();
        }
    }
}
