//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace LogisticsApp.Models.Transport
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("The product is delivered by truck.");
        }
    }
}