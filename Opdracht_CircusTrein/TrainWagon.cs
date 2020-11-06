using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_CircusTrein
{
    class TrainWagon
    {
        public int WagonCapacity { get; private set; }
        public int ID { get; private set; }
        public int MaxCapacity { get; } = 10;
        public List<Animal> _animals = new List<Animal>();

        public TrainWagon()
        {
            _animals = new List<Animal>();
        }

        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }
        public int getSize()
        {
            int s = 0;
            foreach (var item in _animals)
            {
                s += (int)item.PointsToAdd;
            }
            return s;
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
        public bool EnoughCapacity(int wagonSize, int animalSize, int maxWagonSize)
        {
            bool r = false;

            if (wagonSize + animalSize <= maxWagonSize)
            {
                r = true;
            }

            return r;
        }

        public bool AddAnimalIfSafe(Animal newAnimal, TrainWagon wagon)
        {
            bool safe = true;

            foreach (var AnimalInWagon in wagon.GetAllAnimals())
            {
                if (newAnimal.GetAnimalType == Form_Main.AnimalType.Meat)
                {
                    if (AnimalInWagon.GetAnimalType == Form_Main.AnimalType.Meat)
                    {
                        safe = false; // One of the two animals will be eaten.
                    }
                    if (AnimalInWagon.GetAnimalType == Form_Main.AnimalType.Plants && AnimalInWagon.animalValue <= newAnimal.animalValue)
                    {
                        safe = false;
                    }
                }

                if (newAnimal.GetAnimalType == Form_Main.AnimalType.Plants)
                {
                    if (AnimalInWagon.GetAnimalType == Form_Main.AnimalType.Meat && AnimalInWagon.GetAnimalType >= newAnimal.GetAnimalType)
                    {
                        safe = false;
                    }
                }
            }

            return safe;
        }

        private bool AnimalSuccesfullyAdded(Animal newAnimal)
        {
            WagonCapacity += newAnimal.PointsToAdd;
            _animals.Add(newAnimal);
            return true;
        }

        public override string ToString()
        {
            return "Wagon";
        }
    }
}

