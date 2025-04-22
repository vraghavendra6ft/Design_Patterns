namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonNonThread fromTeacher = SingletonNonThread.GetInstance();

            fromTeacher.PrintDetails("Teacher Notes");

            SingletonNonThread fromStudent = SingletonNonThread.GetInstance();
            fromStudent.PrintDetails("From Student");

            // using Lazy loading
            SingletonUsingLazy fromPolice = SingletonUsingLazy.GetInstance();
            fromPolice.PrintDetails("From Police");

            SingletonUsingLazy fromLawyer = SingletonUsingLazy.GetInstance();
            fromPolice.PrintDetails("From Lawyer");

            // using eager loading
            Parallel.Invoke(
                 //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                 () => PrintTeacherDetails(),
                 //Let us Assume PrintStudentdetails method is Invoked by Thread-2
                 () => PrintStudentdetails()
                 );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            SingletonUsingEager fromTeacher = SingletonUsingEager.GetInstance();
            fromTeacher.PrintDetails("From Eager Loading : Teacher");
        }
        private static void PrintStudentdetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            SingletonUsingEager fromStudent = SingletonUsingEager.GetInstance();
            fromStudent.PrintDetails("From Eager Loading : Student");
        }
    }
}
