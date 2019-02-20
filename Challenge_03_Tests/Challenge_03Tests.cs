using System;
using Challenge_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_03_Tests
{
    [TestClass]
    public class Challenge_03Tests
    {

        OutingsRepository _outingsRepo = new OutingsRepository();

        [TestMethod]
        public void OutingsRepository_GetOutingsList_ShouldReturnCorrectCount()
        {
            
                //Arrange
                var _outingsList = _outingsRepo.GetOutingsList();  //when do you use var vs. the list of menu "Type"

                //Act
                var actual = _outingsList.Count;
                var expected = 0;

                //Assert
                Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, EventType.Golf )]
        [DataRow(2, EventType.Bowling)]
        [DataRow(3, EventType.Amusement_Park)]
        [DataRow(10, EventType.Concert)]
        public void OutingsRepository_GetTypeFromInput_ShouldReturnCorrectType(int input, EventType type)
        {
            //arrange
            //see above

            //act
            var actual = _outingsRepo.GetTypeFromInput(input);
            var expected = type;

            //assert

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OutingsRepository_GetOutingsCostByType_ShouldReturnCorrectAmount()
        {
            _outingsRepo.GetOutingsList();

            //Arrange
            Outings ConcertOutingOne = new Outings();    //you are basically creating a new object with values to test
            ConcertOutingOne.TypeOfEvent = EventType.Concert;  //property on left, enum value on right
            ConcertOutingOne.TotalEventCost = 100;
            _outingsRepo.AddOutingsToList(ConcertOutingOne);

            Outings ConcertOutingTwo = new Outings();
            ConcertOutingTwo.TypeOfEvent = EventType.Concert;  //property on left, enum value on right
            ConcertOutingTwo.TotalEventCost = 200;
            _outingsRepo.AddOutingsToList(ConcertOutingTwo);

            //Act
            double actual = _outingsRepo.GetOutingsCostByType(EventType.Concert);
            double expected = 300;

            //Assert 
            Assert.AreEqual(expected, actual);



        }
    }
}
