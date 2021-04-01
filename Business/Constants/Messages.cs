using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorNameInvalid = "Hata! Renk adı en az 2 karakter olmalı";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandNameInvalid = "Hata! Marka adı en az 2 karakter olmalı";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string DailyPriceInvalid = "Arabanın günlük ücreti 0'dan küçük olamaz.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CompanyNameInvalid = "Şirket ismi en az 2 karakter olmalıdır.";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string PasswordInvalid = "Şifre En az 6 karakter olmalıdır.";

        public static string RentalAdded = "Araç Kiralandı.";
        public static string RentalDeleted = "Araç Geri Alındı";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi";
        public static string DateInvalid = "Bu araç teslim edilmemiştir ve kiralanamaz.";

    }
}
