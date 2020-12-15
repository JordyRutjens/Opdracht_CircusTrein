using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Opdracht_CircusTrein;

namespace Circustrein.Tests
{
    [TestClass]
    public class TrainWagonTests
    {
        [TestMethod]
        public void Can_Add_Animal_To_TrainWagon()
        {
            // Arrange
            TrainWagon w = new TrainWagon();
            bool Filled = false;

            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));
            
            if (w.getSize() != 0)
            {
                Filled = true;
            }

            // Assert
            Assert.IsTrue(Filled);
        }

        [TestMethod]
        public void Cant_Have_2_Carnivores_In_One_TrainWagon()
        {
            // Arrange
            TrainWagon w = new TrainWagon();

            bool expected = false;

            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium));

            bool actual = w.AddAnimalIfSafe(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium), w);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Cant_Go_Over_The_TrainWagon_Capacity()
        {
            // Arrange
            TrainWagon w = new TrainWagon();
            bool expected = false;
            
            // Act
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Medium));
            w.AddAnimal(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Small));

            bool actual = w.EnoughCapacity(w.getSize(), (int)Animal.AnimalSize.Large, 10);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
