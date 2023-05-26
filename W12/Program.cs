using System.Collections;
using System.Reflection.Metadata;

namespace Week12
{

    public delegate void MyDelegate(string msg);
    public delegate double MathOps(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            //var c1 = new Complex(-2, 35);  // = 1 + i 
            //var c2 = new Complex(-2, 3);   // = 2 + 3i
            //var c3 = new Complex(Double.Sqrt(5), 35);

            //var c4 = c3 + 5;

            //var c5 = 5 + c4;

            //var sum = c1 + c2 - c3 * c2 / c3 - c1;

            //var numc1 = (Complex)"(3,-9)";

            //var numc2 = (Complex)(Console.ReadLine());

            //Console.WriteLine(numc2*2);

            //Console.WriteLine(numc1);

            //Console.WriteLine(c1 == c2);

            //Console.WriteLine((15 * (sum + c2) * (-9)) / c4);


            //var data =new MyNumbers();

            //foreach (var number in data)
            //{
            //    Console.WriteLine(number);
            //}


            //List<Person> people = new List<Person>();
            //people.Add(new Person { Age = 61,Name = "x"});
            //people.Add(new Person { Age = 3, Name = "Program" });
            //people.Add(new Person { Age = 2, Name = "A" });
            //people.Add(new Person { Age = 8, Name = "d" });

            //people.Sort();

            //foreach (var person in people)
            //{
            //    Console.WriteLine(((Person)person).Name);
            //}

            //Person p1 = new Person(){Age = 15,Name = "Ay"};
            //p1.Dispose();
            //MyList list = new MyList();
            //List<int> list2 = new List<int>();
            //list2.Add(1);


            #endregion
            

            //MyDelegate del = ShowMessage;

            //del.Invoke("how are you");

            //DoProcess(1,2,ShowMessage);

            //DoMathOperation(2, 4, ProcessSelector(1));
            //DoMathOperation(2, 4, Subtract);
            //DoMathOperation(2, 4, Divide);
            //DoMathOperation(2, 4, Product);


            MathOps del = Sum; //Multicast delegates
            del += Subtract;
            del += Divide;
            del += Product;

            del.Invoke(1, 2);

            Action<double, double, MathOps> dop = DoMathOperation;

            dop(1, 2, Divide);

            Action<double, double, MathOps> m = (x, y, callback) =>
            {
                var res = callback(x, y);
                Console.WriteLine(res);
            };

            m(3, 4, Divide);

            Func<double, double, double> f1 = Sum;

            Func<double, double, double> f2 = (x, y) =>
            {
                return x + y;
            };

            Console.WriteLine(f1(3,4));

        }

        static void DoMathOperation(double x, double y, MathOps callback)
        {
            var res = callback(x, y);
            Console.WriteLine(res);
        }

        static MathOps ProcessSelector(int n)
        {
            if (n==1)
            {
                return Sum;
            }
            if (n == 2)
            {
                return Subtract;
            }
            if (n == 3)
            {
                return Product;
            }
            if (n == 4)
            {
                return Divide;
            }

            throw new Exception("Method bulunamadı");
        }


        static double Sum(double x, double y)
        {
            return x + y;

        }

        static double Subtract(double x, double y)
        {
            return x - y;

        }

        static double Product(double x, double y)
        {
            return x * y;

        }

        static double Divide(double x, double y)
        {
            return x / y;

        }

        public static void DoProcess(int a, int b, MyDelegate callback)
        {

            var res = a * b;
            callback(res.ToString());
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

    //IEnumerable<T>  //generic <>
    class MyNumbers : IEnumerable<int>
    {

        private int[] Numbers { get; set; } = new[] { 1, 5, 3, 69, 4 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (var number in Numbers)
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    //IComparable<T>
    class Person : IComparable<Person>, IDisposable
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public int CompareTo(Person? other)
        {
            return this.Age.CompareTo(other.Age);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.

            disposed = true;
        }
    }

    //ICollection<T>

    class MyList : ICollection<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
    }

    //IList<T>
    class MyList2 : IList<Person>
    {
        public IEnumerator<Person> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Person item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Person item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(Person item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Person item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public Person this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }




}


