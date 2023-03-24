using System.Runtime.InteropServices;

namespace Week04
{
    struct Ders
    {
        public int dersId;
        public string dersAdi;

    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Data Types

            #region 01 Value Types

            #region Primitive Types

            // Değer tipleri (primitif tipler ve yapılar)
            byte byteDeger = 255;
            sbyte sbyteDeger = -128;
            short shortDeger = 32767;
            ushort ushortDeger = 65535;
            int intDeger = 42;
            uint uintDeger = 4294967295;
            long longDeger = 9223372036854775807;
            ulong ulongDeger = 18446744073709551615;
            float floatDeger = 3.14f;
            double doubleDeger = 3.1415926535;
            decimal decimalDeger = 3.14159265358979323846m;
            char charDeger = 'A';
            bool boolDeger = true;

            #endregion

            #region Struct Types
            Ders ders1 = new Ders();
            ders1.dersId = 1;
            ders1.dersAdi = "İleri Prog. ";

            DateTime tarihSaat = DateTime.Now;
            TimeSpan zamanFarki = DateTime.Now - DateTime.Now.AddYears(40);





            #endregion

            #endregion

            #region 02 Reference Types

            #endregion


        }
    }
}



