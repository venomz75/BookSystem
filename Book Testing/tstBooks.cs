﻿using System;
using BookClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Book_Testing
{
    [TestClass]
    public class tstBooks
    {
        //valid test data
        int BookID = 4;
        string Title = "Oxford English Dictionary";
        DateTime DatePublished = Convert.ToDateTime("1/2/1884");
        int Stock = 50;
        float Price = 9.99F;
        bool AvailableOnline = false;

        [TestMethod]
        public void InstanceOK()
        {   
            //create book object
            clsBook ABook = new clsBook();
            //assert class exists
            Assert.IsNotNull(ABook);
        }

        [TestMethod]
        public void BookIDOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            Int32 TestData = 5;

            //assign test data to property
            book1.BookID = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.BookID, TestData);
        }

        [TestMethod]
        public void TitleOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            string TestData = "Example Book Title";

            //assign test data to property
            book1.Title = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.Title, TestData);
        }

        [TestMethod]
        public void DatePublishedOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            DateTime TestData = DateTime.Now.Date;

            //assign test data to property
            book1.DatePublished = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.DatePublished, TestData);
        }

        [TestMethod]
        public void StockOK()
        {
            //create book object
            clsBook ABook = new clsBook();
            //test data to assign to property
            int TestData = 5;

            //assign test data to property
            ABook.Stock = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(ABook.Stock, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            float TestData = 9.99F;

            //assign test data to property
            book1.Price = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.Price, TestData);
        }

        [TestMethod]
        public void AvailableOnlineOK()
        {   
            //create book object
            clsBook book1 = new clsBook();
            //test data to assign to property
            bool TestData = true;

            //assign test data to property
            book1.AvailableOnline = TestData;
            //assert the test data and property hold the same value
            Assert.AreEqual(book1.AvailableOnline, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            int BookID = 1;
            found = ABook.Find(BookID);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestBookIDFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;

            found = ABook.Find(BookID);
            if (ABook.BookID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;
            found = ABook.Find(BookID);
            if (ABook.Title != "Test")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;
            found = ABook.Find(BookID);
            if (ABook.DatePublished != Convert.ToDateTime("12/12/2012"))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStockFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;
            found = ABook.Find(BookID);
            if (ABook.Stock != 3)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;
            found = ABook.Find(BookID);
            if (ABook.Price != 9.99F)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestAvailableOnlineFound()
        {
            clsBook ABook = new clsBook();
            bool found = false;
            bool ok = true;
            int BookID = 1;
            found = ABook.Find(BookID);
            if (ABook.AvailableOnline != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
        }

        [TestMethod]
        public void BookIDMinMinusOne()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 0;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreNotEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void BookIDMin()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 1;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void BookIDMinPlusOne()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 2;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void BookIDMaxMinusOne()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 2147483646;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void BookIDMax()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 2147483647;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreEqual(ErrorMsg, "");
        }

        [TestMethod]
        public void BookIDMid()
        {
            clsBook ABook = new clsBook();
            string ErrorMsg = "";
            int BookID = 1073741823;
            ErrorMsg = ABook.Valid(Title, DatePublished, Stock, Price, AvailableOnline);
            Assert.AreEqual(ErrorMsg, "");
        }

            
    }
}
