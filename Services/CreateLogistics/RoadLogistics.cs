//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using LogisticsApp.Models.Transport;

namespace LogisticsApp.Services.CreateLogistics
{
    internal class RoadLogistics : ILogistics
    {
        private ITransport? transport;
        private ITransport CreateTransport()
        {
            return new Truck();
        }

        public void PlanDelivery()
        {
            this.transport = CreateTransport();
            this.transport.Deliver();
        }
    }
}