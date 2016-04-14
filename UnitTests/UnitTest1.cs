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

        
        //public void MovieCost()
        //{
        //    Database myDatabase = new Database();

        //    Assert.Equals(myDatabase.Cost(MovieYear: < 5));



        //}

        



    }

        
}

