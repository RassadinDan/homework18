using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class Amphibian : IAnimal
    {
        private string ac = "Земноводное";
        public string AnimalClass { get { return ac; } }

        public string AnimalSpecies { get; set; }

        public Amphibian(string species)
        {
            AnimalSpecies = species;
        }

        public override string ToString()
        {
            return $"{AnimalClass}, {AnimalSpecies}";
        }
    }
}
