using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Mehsul elave edildi";
        public static string ProductNameInvalid = "Mehsul adi duzgun deyil";
        public static string MaintenanceTime = "Sistem texniki qulluqda";
        public static string ProductListed = "Mehsullar listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriyada max 10 mehsul ola biler";
        internal static string ProductNameAlreadyExists = "Bu adda mehsul artiq movcuddur";
    }
}
