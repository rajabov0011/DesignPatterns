//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using LogisticsApp.Services.CreateLogistics;

internal class Program
{
    private static void Main(string[] args)
    {
        ILogistics roadlogistics = new RoadLogistics();
        roadlogistics.PlanDelivery();
        Console.WriteLine("----------------------------------");
        ILogistics sealogistics = new SeaLogistics();
        sealogistics.PlanDelivery();
        Console.ReadKey();
    }
}