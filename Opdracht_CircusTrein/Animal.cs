using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_CircusTrein
{
    public class Animal
    {
        public enum AnimalType
        {
            Meat,
            Plants
        };
        public enum AnimalSize
        {
            Small,
            Medium,
            Large
        };

        public AnimalType animalType;
        public AnimalSize animalSize;

        public int animalValue;

        public AnimalSize GetAnimalSize
        {
            get { return animalSize; }
            set { animalSize = value; }
        }
        public AnimalType GetAnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        //public void setAnimal(Form_Main.AnimalType type, Form_Main.AnimalSize size)
        //{
        //    animalSize = size;
        //    animalType = type;

        //}

        public int PointsToAdd { get; private set; }

        public Animal(AnimalType type, AnimalSize size)
        {
            animalSize = size;
            animalType = type;
            animalValue = Convert.ToInt32(size);

            switch (GetAnimalSize)
            {
                case AnimalSize.Small:
                    PointsToAdd = 1;
                    break;
                case AnimalSize.Medium:
                    PointsToAdd = 3;
                    break;
                case AnimalSize.Large:
                    PointsToAdd = 5;
                    break;
            }
        }
        public override string ToString()
        {
            return $"FoodType: {animalType} | Size: {animalSize} | Points: {PointsToAdd}";
        }
    }
}
