using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            var repository = new VendorRepository();
            var expected = 42;

            var actual = repository.RetrieveValue<int>("Select ...", 42);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveValueStringTest()
        {
            var repository = new VendorRepository();
            var expected = "test";

            var actual = repository.RetrieveValue<string>("Select ...", "test");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>
            {
                new Vendor()
                { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" },
                new Vendor()
                { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }
            };

            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

        [TestMethod()]
        public void RetrieveWithInteratorTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                { new Vendor()
                { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
                { new Vendor()
                { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } }
            };

            var vendorIterator = repository.RetrieveWithIterator();
            foreach (var item in vendorIterator)
            {
                Console.WriteLine(item);
            }

            var actual = vendorIterator.ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetriveAllTest()
        {
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                { new Vendor()
                {VendorId = 3, CompanyName = "Manchester Firm", Email = "Manchester@Firm.co.uk" }},
                {new Vendor()
                {VendorId = 4, CompanyName = "Pitterson Empire", Email = "Warren@Pitterson.co.uk" }},
                { new Vendor()
                {VendorId = 5, CompanyName = "Rebel Ltd", Email = "Rebel@Alliance.co.uk" }},
                { new Vendor()
                {VendorId = 6, CompanyName = "Chess Ltd", Email = "King@ChessLtd.co.uk" }},
                { new Vendor()
                {VendorId = 7, CompanyName = "Checkmate Productions", Email = "Gameover@Checkmate.co.uk" }},
                { new Vendor()
                {VendorId = 8, CompanyName = "Kellys Ltd", Email = "Sinead@Kelly.co.uk" }},
            };

            var vendors = repository.RetrieveAll();

            //var vendorQuery = from v in vendors
            //                  where v.CompanyName.Contains("Ltd")
            //                  orderby v.CompanyName
            //                  select v;

            //var vendorQuery = vendors.Where(FilterCompanies).OrderBy(OrderCompaniesByName);

            var vendorQuery = vendors.Where(v => v.CompanyName.Contains("Ltd"))
                                     .OrderBy(v => v.CompanyName);


            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }

    }
    }
