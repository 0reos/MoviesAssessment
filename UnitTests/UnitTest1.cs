using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesAssessment;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectionStringToDB()
        {
            //Testing the connection string works through seeing if the DGVMovies is filled or not
            Database myDatabase = new Database();
            
            Assert.IsTrue(myDatabase.ConnectionTestFillDGVMovies());
        }

        [TestMethod]
        public void MovieCost5Dollars()
        {
            //Testing that then movie cost if issuing a movie under 5 years old equals $5.00
            Database myDatabase = new Database();

            string Expected = "$5.00";
            string Actual = myDatabase.Cost("2014");

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void MovieCost2Dollars()
        {
            //Testing that the movie cost if issuing a movie over 5 years old equals $2.00
            Database myDatabase = new Database();

            string Expected = "$2.00";
            string Actual = myDatabase.Cost("2001");

            Assert.AreEqual(Expected, Actual);
        }




    }

        
}

