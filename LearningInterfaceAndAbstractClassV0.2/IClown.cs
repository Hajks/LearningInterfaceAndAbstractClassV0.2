using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._2
{
    interface IClown //Again we create methods and "fields".
    {
        string FunnyThingsIHave { get; } //Even if interface can't containt fields it can use accessor "get" which other objects will see as normal field.
        void Honk();
    }
}
