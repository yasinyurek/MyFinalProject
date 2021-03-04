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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public  static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategorideki en fazla 15 olabilir" ;
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";
        internal static string UserRegistered = "Kayıt oldu";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError="Parola Hatalı";
        internal static string SuccessfulLogin="Giriş Başarılı";
        internal static string UserAlreadyExists="Kullanıcı zaten mevcut";
        internal static string AccessTokenCreated= "Token Oluşturuldu";
    }
}
