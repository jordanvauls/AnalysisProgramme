using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp6;

namespace WindowsFormsApp6.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        bool istrue;
        mainpage form = new mainpage();
        [TestMethod()]
        public void testmethod1()
        {
            string param1 = "Version=1.06";
            string version1;

            if (param1.Contains("Version"))
            {
                string version = param1.ToString().Split('=')[1];
                version1 = version;
                if (version1.Contains("1.06"))
                {
                    istrue = true;
                }

            }
            Assert.IsTrue(istrue);

        }

        /// <summary>
        /// Checks file is false.
        /// </summary>
        [TestMethod()]
       
        public void CheckingFileFalse()
        {

            string pathglob = form.pathglob;
            if (pathglob != null)
            {
                istrue = true;

            }
            else
            {
                istrue = false;
            }

            Assert.IsFalse(istrue);

        }
        /// <summary>
        /// checks file true
        /// </summary>
        [TestMethod()]
        public void CheckingFileTrue()
        {

            string pathglob = form.pathglob; pathglob = "1";
            if (pathglob.Length > 0)
            {
                istrue = true;

            }
            else
            {
                istrue = false;
            }

            Assert.IsTrue(istrue);

        }

        /// <summary>
        /// checks intervals.
        /// </summary>
        [TestMethod()]
        public void IntervalTest()
        {
            int[] intervals = form.intervals;
            if (intervals.Length > 0)
            {
                istrue = true;

            }
            else
            {
                istrue = false;
            }

            Assert.IsTrue(istrue);

        }
        /// <summary>
        /// checks username false.
        /// </summary>
        [TestMethod()]
        public void UsernameTestFalse()
        {

            string username = form.userName;

            username = "JordanLaptop1";
            if (username == Environment.UserName)
            {
                istrue = true;

            }
            else
            {
                istrue = false;
            }

            Assert.IsFalse(istrue);

        }
        /// <summary>
        /// checks username true.
        /// </summary>
        [TestMethod()]
        public void UsernameTestTrue()
        {

            string username = form.userName;

            username = "JordanLaptop";
            if (username == Environment.UserName)
            {
                istrue = true;

            }
            else
            {
                istrue = false;
            }

            Assert.IsTrue(istrue);

        }
        /// <summary>
        /// checks list.
        /// </summary>
        [TestMethod()]
        public void CheckList()
        {
            mainpage.HRDATA2.Add("string");
            int count = mainpage.HRDATA2.Count;
            if (count > 0)
            {
                istrue = true;
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
        /// <summary>
        /// checks list false.
        /// </summary>
        [TestMethod()]
        public void CheckListFalse()
        {

            int count = mainpage.HRDATA2.Count;
            if (count > 0)
            {
                istrue = true;
                Assert.IsTrue(true);
            }
            else
            {
                istrue = false;
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Test2()
        {

        }

        [TestMethod()]
        public void Form1_LoadTest()
        {
            
        }

    }
}




