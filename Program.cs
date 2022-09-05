using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

public delegate void Video36Delegate(string Message);
public delegate void Video39Delegate();
class program
{
    interface Ivideo35_A { void A_print(); }
    class Video_A : Ivideo35_A {
        public void A_print()
        {
            Console.WriteLine("Method A");
        }
    }
    interface Ivideo35_B {
        void B_print();
    }

    class Video_B : Ivideo35_B {
        public void B_print()
        {
            Console.WriteLine("Method B");
        }
    }

    class Video35 : Ivideo35_A, Ivideo35_B {
        Video_A VA = new Video_A();
        Video_B VB = new Video_B();
        public void A_print()
        {
            VA.A_print();
        }
        public void B_print()
        {
            VB.B_print();
        }

    }

    public static void Video36(string Message1) {
        Console.WriteLine(Message1);
    }
    public delegate bool Video38Delegate(Video37 emp1);
    public class Video37
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static void PEmployee(List<Video37> employeelist, Video38Delegate Promotion) {
            foreach (Video37 video37 in employeelist)
            {
                if (Promotion(video37))
                {
                    Console.WriteLine("Employee is promoted");
                }
                else
                {
                    Console.WriteLine("Employee will be promoted in next quarter");
                }
            }

        }
    }

    public static void Video39() {
        Console.WriteLine("First Method Called");
    }  
    public static void Video39_B() {
        Console.WriteLine("Second Method Called");
    }  
    public static void Video39_C() {
        Console.WriteLine("Third Method Called");
    }

    public static void Video44()
    {
        try
        {
            Console.WriteLine("Enter Numerator");
            int Numerator;
            bool isnumsucc = Int32.TryParse(Console.ReadLine(), out Numerator);
            if (isnumsucc)
            {
                Console.WriteLine("Please Enter Denominator");
                int Denominator;
                bool isden = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (isden && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Results = {0}", Result);
                }
                else
                {
                    if (Denominator == 0)
                    {
                        Console.WriteLine("Denominaotr cannot be zero");
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Numerator should be a valid number");
            }
        }
        catch (Exception ex)
        {

        }

    }

    public class Video45
    {
        public string Name { get; set; }
        public Video45Gender Gender { get; set; }
    }

    public class Video49
    {
        private int _id;
        protected int name;

        public int ID 
        { 
            get { 
                return _id; 
            } 
            set { 
                _id = value; 
            }
        }
    }

    public class Video49_2 : Video49
    {
        public void PrintID()
        {
            Video49_2 v49_2 = new Video49_2();
            v49_2.name=1;
           // base.name = 1; does the same work as above
        }
    }
    public class Video52
    {
        //you can add message for reminding during future maintenance and modifications.
        [Obsolete("Method is outdated, use list")]
        public static void add(int a, int b) { }
        public static void Video52_Method(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
        }
        //with the help of reflection we can access assemblies name during meta deta.
    }

    
    static void Main()
    {

        //Video35 v35= new Video35();
        //v35.A_print();
        //v35.B_print();

        Video36Delegate v36D = new Video36Delegate(Video36);
        //type safe function pointer
        v36D("Hello from Delegate");

        List<Video37> emp1 = new List<Video37>();
        emp1.Add(new Video37() { ID = 1, Name = "emp1", Salary = 400 });
        emp1.Add(new Video37() { ID = 2, Name = "emp2", Salary = 500 });

        //Video37.PEmployee(emp1);
        Video38Delegate Promotion = new Video38Delegate(Promote);
        //Video37.PEmployee(emp1, Promotion);
        Video37.PEmployee(emp1,emp1=>emp1.Salary>=5);
        //////////////////////////////////////////39/////////////////////////////////////////
        
        
        Video39Delegate v39D = new Video39Delegate(Video39);
        Video39Delegate v39D_2 = new Video39Delegate(Video39_B);
        Video39Delegate v39D_3 = new Video39Delegate(Video39_C);
        Video39Delegate v39D_Final=v39D+v39D_2-v39D_3;
        //we can use minus sign to exclude any delegate we want
        v39D_Final();
        /////////////////////////////////////39_2//////////////////////////////////


        Video39Delegate v39D2 = new Video39Delegate(Video39);
        v39D2 += Video39_B;
        v39D2 += Video39_C;
        v39D2 -= Video39_B;
        v39D2();

        //////////////////////////////40/////////////////////////////////////////////////
        ///


        // they are added to delegate invokation list, they invoked in the same order
        StreamReader streamreader = null;
        try 
        {
            streamreader = new StreamReader(@"C:\Users\Spursol-Rethek Kumar\Desktop\1Data-test.txt");
            Console.WriteLine("Video 40 \n");
            Console.WriteLine(streamreader.ReadToEnd());
            
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.FileName);
        }
        //general exception at bottom and specific at top
        catch (Exception ex)
        {
            //exceptions directly or indirectly inherit from exception-> exception is generic
            Console.WriteLine(ex.Message);
            // will give a meaning full message
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
            // stack trace will give you a line where exception is being thrown

        }
        //finally is imp because if there is an exception in any catch code then nothing will execute after it
        finally
        {
            //finally block is optional
            if(streamreader != null)
                streamreader.Close();
            Console.WriteLine("Finally block executed");
            //imp to release resources in finally block because it will surely execute
        }
        //////////////////////////////////////////////////////////////////////////////////
        ///
        try
        {
            try
            {
                Console.WriteLine("Enter first number:41");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter first number:41");
                int ln = Convert.ToInt32(Console.ReadLine());

                int Result = fn / ln;

                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string FilePath = @"C:\Users\Spursol-Rethek Kumar\Desktop\1Datad-test.txt";
                if (File.Exists(FilePath))
                {
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.Write(ex.GetType().Name);
                    sw.Write("\n");
                    sw.WriteLine(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a problem");
                }
                else
                {
                    throw new FileNotFoundException(FilePath + "is not present", ex);
                }

            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("Current Exception={0}", exception.GetType().Name);
            Console.WriteLine("Inner Exception={0}",exception.InnerException.GetType().Name);
        }
        /////////////////////////////////////////42//////////////////////////////////////////////
        /// Inner exception allow us to track original exceptions
        try
        {
            throw new Video42Exception("Video 42 custom error handling");
        }
        catch (Video42Exception v42c) {
        Console.WriteLine(v42c.Message);
        }
        ////////////////////////////////////44///////////////////////////////////////////////////////
        Console.WriteLine();
        Console.WriteLine();
        //Video44();

        Video45[] v45 = new Video45[3];
        v45[0] = new Video45
        {
            Name = "C1",
            Gender=Video45Gender.Male
         
        };
        v45[1] = new Video45
        {
            Name = "C2",
            Gender = Video45Gender.Male
         
        };
        v45[2] = new Video45
        {
            Name = "C3",
            Gender=Video45Gender.Female
            //Enums help replacing integrals with constants
            // first we create enums just like a class, then we replace class definition of field with enum name
            // later we replace them in function switch cases
         
        };
        
        
        
        //foreach(Video45 v45_2 in v45)
       // {
        //    Console.WriteLine("Name={0} && Gender={1}", v45_2.Name, Video45GetGender(v45_2.Gender));
        //}
        
        
        /////////////////////////47////////////////////////////////////////////////
        ///
        Console.WriteLine();
        Console.WriteLine();
        int[] Values= (int[])Enum.GetValues(typeof(Video45Gender));
        foreach(int value in Values)
        {
            Console.WriteLine(value);
        }
        string[] Names = (string[])Enum.GetNames(typeof(Video45Gender));
        foreach (string name in Names)
        {
            Console.WriteLine(name);
        }
        //enums are value types
        /////////////////////////////////////////////48////////////////////////////////////////////////////
        //type members can have only two access modifiers (internal &Public)

        /////////////////////////////////////////////49///////////////////////////////////////////////
        Video49 v49 = new Video49();
        v49.ID = 123;
        Console.WriteLine(v49.ID);
        //////////////////////////////////////50//////////////////////////////////////
        //Types(Class/structs/enums/delegates) can have only two type access modifiers internal and public.
        //default access modifier for types is internal
        //default access modifiers for type members is private.(c1 etc)
    }

    public enum Video45Gender
    {
        Male,Female
    }
    public static string Video45GetGender(Video45Gender gender)
    {
        switch (gender)
        {
            case Video45Gender.Male:
                return "Male Gender";
            case Video45Gender.Female:
                return "Female Gender";
            default:
                return "Invalid Data detected";
        }
    }
    public class Video42Exception : Exception
    {
        public Video42Exception():base(){}
        public Video42Exception(string Message) : base(Message) { }

        public Video42Exception(string Message, Exception InnerException): base(Message, InnerException) { }
        
        public Video42Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    
    }

    public static bool Promote(Video37 v37)
        {
        if (v37.Salary > 400)
        {
            return true;
        }
        else
        {
            return false;
        }
            }
}