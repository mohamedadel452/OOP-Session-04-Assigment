

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

    #region PART 02: PRACTICAL IMPLEMENTATION
    #region Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // a. Create one StandardShipment.
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir", 1);
            StandardShipment std = new StandardShipment("SH001", "Laptop", 3m, 80m, addr1);

            // b. Create one ExpressShipment.
            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Dokki", 10);
            ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, addr2, 30m);

            // c. Create one InternationalShipment.
            DeliveryAddress addr3 = new DeliveryAddress("Alex", "Corniche", 50);
            InternationalShipment intl = new InternationalShipment("SH003", "Television", 8m, 120m, addr3, "Germany", 100m);

            // d. Add all shipments to the DeliveryCenter.
            DeliveryCenter center = new DeliveryCenter("Delivery Center");
            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(intl);

            // e. Print all shipment details.
            center.PrintAllShipments();

            // f. Print the tracking status of every shipment.
            Console.WriteLine("Tracking Status\n");
            center.PrintTrackingStatuses();
            Console.WriteLine("==========================================\n");

            // g. Print the insurance cost of every shipment.
            Console.WriteLine("Insurance\n");
            DeliveryReport.PrintInsurance(std);
            DeliveryReport.PrintInsurance(exp);
            DeliveryReport.PrintInsurance(intl);
            Console.WriteLine("==========================================\n");

            // h. Store the shipment objects in an ITrackable[] array and print their tracking statuses.
            ITrackable[] trackables = { std, exp, intl };

            //print tracking statuses using the ITrackable interface
            Console.WriteLine("Tracking Statuses from ITrackable Interface\n");
            foreach (ITrackable trackable in trackables)
            {
                string name = trackable is StandardShipment ? "StandardShipment" :
                              trackable is ExpressShipment ? "ExpressShipment" :
                              trackable is InternationalShipment ? "InternationalShipment" 
                              : "Unknown Shipment Type";
                Console.WriteLine($"Tracking Status of {name}: {trackable.GetTrackingStatus()}");
            }


            // i. Store the shipment objects in an IInsurable[] array and print their insurance values.
                IInsurable[] insurables = { std, exp, intl };
            //print insurance values using the IInsurable interface
            Console.WriteLine("Insurance Values from IInsurable Interface\n");
            foreach (IInsurable insurable in insurables)
            {
                string name = insurable is StandardShipment ? "StandardShipment" :
                              insurable is ExpressShipment ? "ExpressShipment" :
                              insurable is InternationalShipment ? "InternationalShipment"
                              : "Unknown Shipment Type";
                Console.WriteLine($"Insurance Value of {name}: {insurable.CalculateInsurance()}");

                Console.WriteLine("Interface Polymorphism Demonstrated Successfully.\n");
            }
        }
    }
    #endregion
    #endregion
}