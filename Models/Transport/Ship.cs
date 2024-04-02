//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace LogisticsApp.Models.Transport
{
    internal class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("The product is shipped by sea.");
        }
    }
}