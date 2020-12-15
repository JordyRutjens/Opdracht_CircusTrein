using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_CircusTrein
{
    public class Train
    {
        public List<TrainWagon> wagonCount = new List<TrainWagon>();

        public void AddAnimalsToWagon(Animal animalToAdd)
        {   
            bool NewWagonNeeded = true;

            for (int i = 0; i < wagonCount.Count; i++)
            {
                if (wagonCount[i].AddAnimalIfSafe(animalToAdd, wagonCount[i]))
                {
                    if (wagonCount[i].EnoughCapacity(wagonCount[i].getSize(), (int)animalToAdd.PointsToAdd, 10))
                    {
                        wagonCount[i].AddAnimal(animalToAdd);
                        NewWagonNeeded = false;
                        break;
                    }
                }
            }

            int id = (wagonCount.Count > 0) ? wagonCount.Count + 1 : 1;

            if (NewWagonNeeded)
            {
                TrainWagon wagon = new TrainWagon();
                AddWagon(wagon);
                wagonCount[wagonCount.Count - 1].AddAnimal(animalToAdd);
            }
        }

        public List<Animal> GetWagonAnimals(int id)
        {
            return wagonCount[id].GetAllAnimals();
        }
        public List<TrainWagon> AllWagons()
        {
            return wagonCount;
        }

        public void AddWagon(TrainWagon wagon)
        {
            wagonCount.Add(wagon);
        }
    }
}