using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public Vendor[] RetrieveArray()
        {
            var vendors = new Vendor[2]
                {
                    new Vendor()
                    { VendorId = 1, CompanyName = " ABC Corp", Email = "abc@abc.com" },
                    new Vendor()
                    { VendorId = 2, CompanyName = "XYZ inc", Email = "xyz@xyz.com" }
                };

            return vendors;
        }

        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor()
                    { VendorId = 1, CompanyName = " ABC Corp", Email = "abc@abc.com" } },
                { "XYZ Inc", new Vendor()
                    { VendorId = 2, CompanyName = "XYZ inc", Email = "xyz@xyz.com" }}
                };

            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                Console.WriteLine($"Key: {key} Value: {vendor}");
            }

            return vendors;

        }


        public List<Vendor> Retrieve()
        {
            var vendors = new List<Vendor>();

            if (vendors == null)
            {
                vendors.Add(new Vendor()
                { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor()
                { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }
            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }
            foreach (var vendor in vendors)
            {
                // Console.WriteLine(vendor);
            }
            return vendors;
        }



        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }

    }