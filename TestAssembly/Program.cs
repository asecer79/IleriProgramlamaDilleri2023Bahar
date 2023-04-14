using Week07;

namespace TestAssembly
{
    //outside assembly.....
    
    class Program
    {

        static void Main(string[] args)
        {
            Test t = new Test();
            //t.salary = 3500;//err
            //t.address = "ATAKENT 2";//err
            //t.tckNumber = "9999"; //err,
            // t.age = 15; //err, 
            t.name = "Müslüm";
            t.SetAge(25);
            t.name = "Hasan";

        }
    }

    class SubTestOther : Test
    {
        public void M()
        {
            base.salary = 4500;
            //base.address = "ATAKENT 2";//err
            base.tckNumber = "9999";
            // this.testId = 3;
            //base.age = 34; //error 
            base.name = "as";
            base.name = "Karaca";
            base.SetAge(36);
        }
    }
}