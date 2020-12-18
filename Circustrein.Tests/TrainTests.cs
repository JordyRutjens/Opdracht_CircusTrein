using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Opdracht_CircusTrein;


namespace Circustrein.Tests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void Can_add_animal_to_trainWagon()
        {
            // Arrange
            Train train = new Train();

            // Act
            for (int i = 0; i < 4; i++)
            {
                train.AddWagon(new TrainWagon());
            }

            List<TrainWagon> wlist = train.AllWagons();
            
            // Assert
            Assert.AreEqual(4, wlist.Count);
        }

        [TestMethod]
        public void Get_all_animals_in_trainWagon()
        {
            // Arrange
            Train train = new Train();
            for (int i = 0; i < 3; i++)
            {
                train.AddAnimalsToWagon(new Animal(Animal.AnimalType.Plants, Animal.AnimalSize.Medium));
            }
            train.AddAnimalsToWagon(new Animal(Animal.AnimalType.Meat, Animal.AnimalSize.Large));

            //Act
            int actualAmountOfAnimals = train.GetAnimalFromWagon(0).Count;

            // Assert
            Assert.AreEqual(3, actualAmountOfAnimals);
        }
    }
}
