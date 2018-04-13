using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._2
{
    public class Tallguy : IClown // Implementing interface IClown.
    {
        public string Name;
        public int Height;
        public void TalkAboutYourSelf()
        {
            Console.WriteLine("Nazywam sie " + Name + " i mam " + Height + " centrymetrów wzrostu.");
        }
        public string FunnyThingsIHave //we have to add FunnyThings and Honk to compile our program properly. 
        {
            get
            {
                return "Mam super buty";
            }
        }
        public void Honk()
        {
            Console.WriteLine("Tuuuut tuuuut!");
        }

    }
}
