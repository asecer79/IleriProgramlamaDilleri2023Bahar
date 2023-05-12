using System.ComponentModel;

namespace Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TypeOfClasses

            //Book book = new Book();
            //double x = (int)0;
            //BookAbstract historyBook0 = new HistoryBook();
            //BookAbstract fiction = new FictionBook();
            //HistoryBook historyBook1 = new HistoryBook();
            //var historyBook2 = new HistoryBook();

            //Console.WriteLine(MathHelper.GetAreaOfCircle(4));

            //Car car = new Car();

            //AppHelper appHelper = new AppHelper();

            #endregion

            #region StructExample
            //Human h1 = new Human();
            //h1.age = 10;
            //Console.WriteLine(h1.age);
            //ChangeValue1(h1);
            //Console.WriteLine(h1.age);


            //HumanC h2 = new HumanC();
            //h2.age = 10;
            //Console.WriteLine(h2.age);
            //ChangeValue2(h2);
            //Console.WriteLine(h2.age);


            #endregion


            #region ExtensionMethod Examples

            //string fName = "Aydın";
        
            //Console.WriteLine(fName.TersCevir());

            //Console.WriteLine(fName.Sayi());

            int num = 15;

            //Console.WriteLine(num.Kuvvet(2));

            //Console.WriteLine(25.Kuvvet(2));


            var sayi = Console.ReadLine();

            Console.WriteLine((sayi.ToInt() * 15).Kuvvet(2));

            #endregion

        }


        static void ChangeValue1(Human h)
        {
            h.age = 25;
            Console.WriteLine(h.age);
        }

        static void ChangeValue2(HumanC h)
        {
            h.age = 25;
            Console.WriteLine(h.age);
        }
    }

    #region TypeOfClasess

    class FictionBook : BookAbstract
    {
        public override void M2()
        {
            throw new NotImplementedException();
        }
    }


    //regular class , can be initialized (new ), can be inherited, can inherit, can implement
    class Book
    {
        public string ISBN { get; set; }
        public string Name { get; }

        void M1()
        {

        }
    }

    //abstract classes, cannot be initialized (not new ), can be inherited, can inherit, can implement
    abstract class BookAbstract
    {
        public string ISBN { get; set; }
        public string Name { get; }

        public void M1()
        {

        }

        public abstract void M2();
    }
    class HistoryBook : BookAbstract
    {
        public override void M2()
        {
            throw new NotImplementedException();
        }
    }

    //static class, can not be initialized (not new), can not be inherited, can not inherit, can not implement
    static class MathHelper
    {
        public static readonly float PI = 3.14f;

        public static float GetAreaOfCircle(float r)
        {
            return PI * r * r;
        }

        public static float GetCircumferenceOfCircle(float r)
        {
            return 2 * PI * r;
        }
    }

    //sealed class, can be initialized (new), can not be inherited, can inherit, can implement
    sealed class Car
    {
        public string Plate { get; set; }
        public string Model { get; set; }
    }


    //partial class, can be initialized (new ), can be inherited, can inherit, can implement

    partial class AppHelper
    {
        public void M1()
        {

        }
        public void M2()
        {

        }
        public void M3()
        {

        }
    }

    #endregion

    #region Structs  
    //value type

    struct Human
    {
        public int age;
      
    }

    class HumanC
    {
        public int age;

    }

    #endregion

    #region Extension Methos

    static class StringHelper
    {
        public static string TersCevir(this string val)
        {
            var charArray = val.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int Sayi(this string val)
        {
            return val.Length;

        }

        public static int ToInt(this string val)
        {
            return Convert.ToInt32(val);

        }
    }

    static class IntHelper
    {
        public static int Kuvvet(this int taban, int us)
        {
            int carpim = 1;
            for (int i = 1; i <= us; i++)
            {
                carpim *= taban;
            }

            return carpim;
        }
    }



    #endregion


}



