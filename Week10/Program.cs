
namespace Week10
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Examples

            // Animal a = new Animal();
            // a.Eat();
            // a.MakeSound();

            // Dog d = new Dog();
            // d.Eat();
            //// d.Bark();
            // d.MakeSound();

            // Bird b = new Bird();
            // b.Eat();
            // //b.Singing();
            // b.MakeSound();


            // Dog dog = new Dog();
            //Dog dog = new Dog("Hello");

            #endregion

            //IMessageService messageService = new SmsService();
            //MessageSender(messageService);
            //MessageSender(new EmailService());
            //MessageSender(new TeleGraph());

            // MessageService ms= new MessageService();

            //MessageService messageService = new SmsService();
            //MessageSender(messageService);
            //MessageSender(new EmailService());
            //MessageSender(new TeleGraph());

            //polymorphism example
            List<Animal> animals = new List<Animal>()
            {
                new Animal(),
                new Dog(),
                new Bird(),

            };


            foreach (var animal in animals)
            {
                animal.Eat();
            }

    }

    //  static void MessageSender(IMessageService messageService)
    //{
    //    messageService.SendMessage();
    //}

    //static void MessageSender(MessageService messageService)
    //{
    //    messageService.SendMessage();
    //}



    //polymorphism example


}

    #region Inherticance 0

    //class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Eating....");
    //    }

    //    public virtual void MakeSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Dog:Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Barking....");
    //    }

    //    //public void Bark()
    //    //{
    //    //    Console.WriteLine("Barking....");
    //    //}
    //}

    //class Bird : Animal
    //{
    //    public Bird()
    //    {
    //        //this.Eat();
    //        //base.Eat();
    //    }

    //    //overriding
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Singing....");
    //    }

    //    //hiding
    //    public new void Eat()
    //    {
    //        Console.WriteLine("Bird Eating....");
    //    }

    //    //public void Singing()
    //    //{
    //    //    Console.WriteLine("Singing....");
    //    //}
    //}

    //class Weka:Bird
    //{
    //    public Weka()
    //    {
    //        Eat();
    //    }
    //}
    #endregion

    #region Inheritance and Overloaded Constructors (Kalıtım ve Aşırı Yüklenmiş Yapıcılar)

    //class Animal
    //{
    //    public Animal()
    //    {
    //        Console.WriteLine("public Animal()");
    //    }

    //    public Animal(string name)
    //    {
    //        Console.WriteLine("public Animal(string name)");
    //    }

    //    public Animal(string name,int age)
    //    {
    //        Console.WriteLine("public Animal(string name,int age)");
    //    }
    //}

    //class Dog: Animal 
    //{
    //    public Dog() : base()
    //    {
    //        Console.WriteLine("public Dog() : base()");
    //    }

    //    public Dog(string name):base(name)
    //    {
    //        Console.WriteLine("public Dog(string name):base(name)");
    //    }
    //}

    #endregion

    #region Single Inheritance (Tekil Kalıtım)

    //public class Animal { }
    ////derived : base
    //public class Dog : Animal { }

    #endregion

    #region Multilevel Inheritance (Çok Seviyeli Kalıtım)   >=2  level

    //public class Animal
    //{
    //    public void Eat(){}
    //}
    //public class Mammals:Animal{}
    //public class Dog : Mammals { }

    #endregion

    #region Hierarchical Inheritance (Hiyerarşik Kalıtım)

    //public class Animal { }
    //public class Dog : Animal { }
    //public class Cat : Animal { }

    #endregion

    #region Multiple Inheritance (Through Interface) (Çoklu Kalıtım - Arayüz ile)
    //public class Animal { }
    //public interface IAnimal { }
    //public interface IMammal { }
    //public class Dog :Animal, IAnimal, IMammal { }

    #endregion

    #region Hybrid Inheritance (Through Interface) (Melez Kalıtım - Arayüz ile)
    //public class Animal { }
    //public interface IAnimal { }
    //public interface IMammal { }
    //public class Dog : Animal, IAnimal, IMammal { }

    #endregion

    #region Interfaces

    //interface ICalculator
    //{
    //    //props
    //    //methods
    //    event EventHandler ExampleEvent;
    //    int this[int index] { get; set; }
    //    int Id { get; set; }
    //    int Add(int a, int b);
    //    int Subtract(int a, int b);
    //    int Multiply(int a, int b);
    //    int Divide(int a, int b);
    //}

    //class Math:ICalculator
    //{
    //    public event EventHandler? ExampleEvent;

    //    public int this[int index]
    //    {
    //        get => throw new NotImplementedException();
    //        set => throw new NotImplementedException();
    //    }

    //    public int Id { get; set; }

    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }

    //    public int Multiply(int a, int b)
    //    {
    //        return a * b;
    //    }

    //    public int Divide(int a, int b)
    //    {
    //        return a / b;
    //    }
    //}


    //public interface IVehicle
    //{
    //    void Drive();
    //}

    //public interface IPerson
    //{
    //    string Name { get; set; }
    //    int Age { get; set; }
    //}
    //public interface ILogger
    //{
    //    void Log(string message);
    //}

    //public interface IAnimal
    //{
    //    void MakeSound();
    //}

    //public interface IMammal : IAnimal
    //{
    //    void GiveBirth();
    //}

    //class MyClass: IMammal,ILogger,IPerson
    //{
    //    public void MakeSound()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GiveBirth()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Log(string message)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}




    //interface IRepository<T>
    //{
    //    T GetById(int id);
    //    IEnumerable<T> GetAll();
    //    void Add(T entity);
    //    void Update(T entity);
    //    void Delete(T entity);
    //}
    //class DepartmentRepository:IRepository<Department>
    //{
    //    public Department GetById(int id)
    //    {
    //        //....logic
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetAll()
    //    {
    //        //....logic
    //        throw new NotImplementedException();
    //    }

    //    public void Add(Department entity)
    //    {
    //        //....logic
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Department entity)
    //    {
    //        //....logic
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Department entity)
    //    {
    //        //....logic
    //        throw new NotImplementedException();
    //    }
    //}
    //class HumanRepository:IRepository<Human>
    //{
    //    public Human GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Human> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Add(Human entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Human entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Human entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Department
    //{
    //    public int Id { get; set; }
    //    public string  Name { get; set; }
    //}
    //class Human
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}



    //interface IMessageService
    //{
    //    void SendMessage();
    //}
    //class SmsService : IMessageService
    //{
    //    public void SendMessage()
    //    {
    //        Console.WriteLine("Sms message sent...");
    //    }
    //}
    //class EmailService : IMessageService
    //{
    //    public void SendMessage()
    //    {
    //        Console.WriteLine("Email message sent...");
    //    }
    //}
    //class TeleGraph :IMessageService
    //{
    //    public void SendMessage()
    //    {
    //        Console.WriteLine("Telegraph message sent...");
    //    }
    //}






    #endregion

    #region Abstract Classes

    abstract class MessageService
    { 
        public  abstract  void  SendMessage();

        public virtual void  CheckConnection()
        {
            Console.WriteLine("Connection checked");
        }

        private int a = 2;
    }

    class SmsService : MessageService
    {
        public override void SendMessage()
        {
            Console.WriteLine("Sms message sent...");
        }

        public sealed override void CheckConnection()
        {
           //....
        }
    }

    //class Whatsup : SmsService
    //{
      
    //}
    class EmailService : MessageService
    {
        public override void SendMessage()
        {
            Console.WriteLine("Email message sent...");
        }
    }
    class TeleGraph : MessageService
    {
        public override void SendMessage()
        {
            Console.WriteLine("Telegraph message sent...");
        }
    }

    #endregion

    #region PolyMoprhism

    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Eating....");
        }
    }

    class Bird : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Bird Eating....");
        }
    }

    #endregion

}

