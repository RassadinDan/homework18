using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
     public static class Factory
    {
        /// <summary>
        /// Создает экземпляры разных классов животных, реализующих IAnimal интерфейс.
        /// </summary>
        /// <param name="AnimalClass"></param>
        /// <param name="AnimalSpecies"></param>
        /// <returns></returns>
        public static IAnimal NewAnimal(string AnimalClass, string AnimalSpecies)
        {
            switch (AnimalClass)
            {
                case "Млекопитающее": return new Mammal(AnimalSpecies);
                case "Птица": return new Bird(AnimalSpecies);
                case "Земноводное": return new Amphibian(AnimalSpecies);
                default: return new NullAnimal(AnimalSpecies);
            }
        }
    }
}
