using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class Mammal : IAnimal
    {
        private string ac = "Млекопитающее";
        public string AnimalClass { get { return ac; } }

        public string AnimalSpecies { get; set; }
    }
}
