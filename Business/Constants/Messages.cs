using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Succesfully Added";
        public static string ProductNameInvalid = "The product name must be at least 2 characters!";
        public static string MaintenanceTime = "System is under maintenance";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountofCategoryError = "There can be a maximum of 10 products in a category";
        public static string ProductNameAlreadyExists = "There is already another product with this name";
        public static string CategoryLimitExceded = "New products cannot be added because the category limit has been exceeded";
    }
}
