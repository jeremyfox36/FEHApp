using Microsoft.VisualStudio.TestTools.UnitTesting;
using FEHServicesLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace FEHServicesLib.Tests
{
    [TestClass()]
    public class LMomentsTests
    {
        float[] amaxData = {410,1150,899,420,3100,2530,758,1220,1330,1410,3100,2470,929,586,450,1040,1470,1070,2050,1430,3070,2360,1050,1900,1130,674,683,1500,2600,3480,1430,809,1010,1510,1650,1880,1470,1920,2530,1490
};
        //probability weighted moments
        float beta0 = 1549.20f;
        float beta1 = 1003.89f;
        float beta2 = 759.02f;
        //L-moments, rounded to integers
        int Lambda1 = 1549;
        int lambda2 = 458;
        int lambda3 = 80;

        [TestMethod()]
        public void Beta0Test()
        {
            LMoments lMoments = new LMoments();

            Assert.AreEqual(beta0, lMoments.Beta0(amaxData));
        }

        [TestMethod()]
        public void Beta1Test()
        {
            LMoments lMoments = new LMoments();
            float answer = lMoments.Beta1(amaxData);
            Debug.WriteLine(answer);
            Assert.AreEqual(beta1, answer);
        }

        [TestMethod()]
        public void Beta2Test()
        {
            LMoments lMoments = new LMoments();
            float answer = lMoments.Beta2(amaxData);
            Debug.WriteLine(answer);
            Assert.AreEqual(beta2, answer);
        }

        [TestMethod()]
        public void Lambda2Test()
        {
            LMoments lMoments = new LMoments();
            float answer = lMoments.Lambda2(amaxData);
            Debug.WriteLine(answer);
            Assert.AreEqual(lambda2, (int)answer);
        }
    }
}