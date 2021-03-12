using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string ProductNameAlreadyExists = "Bu adda mehsul artiq movcuddur";
        public static string CategoryLimitExceded = "Kategoriya limiti kecdiyi ucun yeni mehsul elave edilmedi";
        public static string AuthorizationDenied = "Icazeniz yoxdur";
        public static string UserRegistered = "Ugurla qeydiyyatdan kecdiniz";
        public static string UserNotFound = "Istifadeci tapilmadi";
        public static string PasswordError = "Sifre yanlisdir";
        public static string SuccessfulLogin = "Ugurlu daxil olma";
        public static string UserAlreadyExists = "Bele bir istifadeci artiq movcuddur";
        public static string AccessTokenCreated = "Access token ugurla yaradildi";
    }
}
