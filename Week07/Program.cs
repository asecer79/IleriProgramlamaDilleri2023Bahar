using System.Buffers;

namespace Week07
{
    //internal.....

    class Program
    {

        static void Main(string[] args)
        {
            Test t = new Test();
            t.salary = 3500;
            t.address = "ATAKENT 2";
            t.name = "Ahmet";
            //t.tckNumber = "9999"; //err, 
            //t.age = 15; err, 

            t.SetAge(25);
            t.name = "Hasan";

        }
    }


    public class Test
    {
        private int age = 5;
        protected string tckNumber = "1235";
        public string name = "Ahmet";
        internal string address = "ATAKENT";
        protected internal decimal salary = 1500;

        public void SetAge(int age)
        {
            name = "Ali";
            salary = 2500;
            address = "Atakent 3";
            tckNumber = "321654";
            this.age = age;//with in class ok!
        }
    }
    //class  derivedClass:baseClass
    public class SubTest : Test
    {
        
        private int testId = 1;
        public void M()
        {
            base.salary = 4500;
            base.address = "Atakent ";
            base.tckNumber = "9999";
            base.name = "Alican";

            this.testId = 3;
            //base.age = 34; error 
            base.name = "as";
            base.SetAge(36);
        }
    }
}