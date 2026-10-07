

namespace OOP04_SmartDelivery
{
    #region PART 01: THEORETICAL QUESTIONS


    #region Q1: Abstraction
    /*
    a) What is Abstraction in Object-Oriented Programming?
       - Abstraction is the process of hiding the complex implementation details and showing only the essential features of an object. It focuses on WHAT an object does rather than HOW it does it.
    
    b) Why is abstraction considered one of the four pillars of OOP?
       - Because it reduces complexity, increases reusability, and helps in creating a clear boundary between the user of the system and the implementer.

    */
    #endregion

    #region Q2: Abstract Classes vs. Interfaces
    /*
   a) What is the difference between an Abstract Class and an Interface?
      - Abstract Class: Can have implementation (fields, non-abstract methods) and abstract methods. A class can inherit only ONE abstract class.
      - Interface: Can only have method/property signatures (no implementation, no fields). A class can implement MULTIPLE interfaces.

   b) When would you choose an Interface instead of an Abstract Class?
      - Choose an Interface when you want to define a contract or capability (like ITrackable, IInsurable) that can be shared across unrelated classes.
      - Choose an Abstract Class when you want to share core logic, fields, and a common base identity among closely related classes.

   c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
      - No, a class CANNOT inherit from multiple abstract classes (C# does not support multiple class inheritance).
      - Yes, a class CAN implement multiple interfaces.
   ===================================================================================
   */
    #endregion

    #endregion

    #region Main Program
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Smart Delivery!");
        }
    }
    #endregion
}