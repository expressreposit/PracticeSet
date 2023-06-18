using System;

namespace SOLIDDESIGNPRINCIPLES
{
    class Program   //  Single Responsibility Principles.
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IUser // Minimum requirement of user login methods.
    {
        bool Login(string userName, string Password);
        bool Registration(string userName, string Password, string emailId);

        //bool SendEmail(string emailContent);    // SendEmail and HandleError define separate interface bcz it has different functionality.
        //void HandleError(string error);
    }
    interface ISendEmail
    {
        bool SendEmail(string emailContent);
    }
    interface ILogger
    {
        void LogError(string error);
    }
}

/*
        In Single Responsibility Principle
            Each class and module should focus on a single task at a time
            Everything in the class should be related to that single purpose
            There can be many members in the class as long as they related to the single responsibility
            With SRP, classes become smaller and cleaner
            Code is less fragile 
        1. A class should have only one reason to change.
        2. Which means, every module or class should have responsibility over a single part of the functionality provided by the software, 
            and that responsibility should be entirely encapsulated by the class
        3. Maintainability : Maintainable systems are very important to the organisations.
        4. Testability : Test driven development (TDD) is required when we design and develop large scale systems
        5. Flexibility and Extensibility : Flexibility and extensibility is a very much desirable factor of enterprise applications.Hence we should design the application to make it flexible so that it can be adapt to work in different ways and extensible so that we can add new features easily. 
        6. Parallel Development : It is one of the key features in the application development as it is not practical to have the entire development team working simultaneously on the same feature or component. 
        7. Loose Coupling : We can address many of the requirements listed above by ensuring that our design results in an application that loosely couples many parts that makes up the application.
 */