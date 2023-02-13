using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public interface IAnimal
    {
        string AnimalClass { get; }

        string AnimalSpecies { get; set; }
    }
}
