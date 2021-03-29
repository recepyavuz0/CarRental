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

    }
}
