using System;

namespace OOP04_SmartDelivery
{
    #region StandardShipment Class
    public class StandardShipment : Shipment
    {
        #region Constructors
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }
        #endregion

        #region Properties
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5m); }
        }
        #endregion

        #region Methods
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("\n------------------------------------------\n");
        }

        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        #endregion
    }
    #endregion
}
