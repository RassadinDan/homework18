using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    internal interface IAnimal
    {
        string AnimalClass { get; }

        string AnimalSpecies { get; set; }
    }
}
