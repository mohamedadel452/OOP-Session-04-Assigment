using System;

namespace OOP04_SmartDelivery
{
    #region CompletedShipment Class
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode) : base(trackingCode) { }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m);

        public override void PrintShipment()
        {
            Console.WriteLine($"Completed Shipment: {TrackingCode}");
        }

        public override string GetTrackingStatus() => "Completed.";
        public override decimal CalculateInsurance() => 0;
    }
    #endregion
}
