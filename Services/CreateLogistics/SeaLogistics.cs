//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using LogisticsApp.Models.Transport;

namespace LogisticsApp.Services.CreateLogistics
{
    internal class SeaLogistics : ILogistics
    {
        private ITransport? transport;
        private ITransport CreateTransport()
        {
            return new Ship();
        }

        public void PlanDelivery()
        {
            this.transport = CreateTransport();
            this.transport.Deliver();
        }
    }
}