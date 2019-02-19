using System;
using System.Collections.Generic;
using Challenge_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_02_Tests
{
    [TestClass]
    public class Challenge_02Tests
    {
        ClaimRepository _claimRepo = new ClaimRepository();

        [TestMethod]
        public void ClaimRepository_GetClaimQueue_ShouldReturnCorrectCount()
        {
            //arrange
            Queue<Claim> claimQueue = _claimRepo.GetClaimQueue();

            //act
            var actual = claimQueue.Count;
            var expected = 0;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void
            ClaimRepository_AddClaimToQueue_ShouldReturnCorrectCount()
        {
            //arrange
            var claimQueue = _claimRepo.GetClaimQueue();
            var claim = new Claim();
            _claimRepo.AddClaimToQueue(claim);

            //act
            var actual = claimQueue.Count;
            var expected = 1;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void
            ClaimRepository_DequeueClaimFromQueue_ShouldReturnCorrectCount()
        {
            //arrange
            var claimQueue = _claimRepo.GetClaimQueue();
            var claim = new Claim();
            _claimRepo.AddClaimToQueue(claim);
            _claimRepo.DequeueClaimFromQueue();

            //act
            var actual = claimQueue.Count;
            var expected = 0;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [DataTestMethod]
        [DataRow(1,ClaimType.Car)]
        [DataRow(2, ClaimType.Home)]
        [DataRow(3,ClaimType.Theft)]
        [DataRow(10,ClaimType.Home)]
        public void
            ClaimRepository_GetTypeFromInput_ShouldReturnCorrectType(int input, ClaimType type)
        {
            //arrange
            //see above

            //act
            var actual = _claimRepo.GetTypeFromInput(input);
            var expected = type;

            //assert

            Assert.AreEqual(actual, expected);
        }
    }
}
