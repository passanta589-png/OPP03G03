using System.Timers;

namespace OPP03G03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01
            //a) Overloading بيكون في نفس الكلاس بنفس الاسم بس بباراميترز مختلفة. أما Overriding فبيكون بين كلاس أساسي وكلاس فرعي لنفس الميثود باستخدام override
            //b)Static binding بيحصل وقت الـ Compile-time(في الـ Overloading).أما Dynamic binding بيحصل وقت الـ Run-time بناءً على نوع الكائن الفعلي في الـ Overriding
            #endregion
            #region 02
            //a)منع أي كلاس تاني إنه يورث من الكلاس ده(Stop inheritance)

            //b)الـ Sealed class بيمنع وراثة الكلاس بالكامل.الـ Sealed method بيسمح بوراثة الكلاس عادي، بس بيمنع الكلاسات الفرعية إنها تعمل Override للميثود دي

            //c)لا، لأن كلمة sealed بتمنع أي تعديل أو Override عليها في الكلاسات الوراثي
            #endregion

            //#region 10
            //Driver driver = new Driver("Ahmed Mohamed");
            //Deliverycenter deliveryCenter = new Deliverycenter();
            //deliveryCenter.driver = driver;

            //StandardShipment standardShipment = new StandardShipment("SH001", "Laptop", 3, 80, 95);
            //ExpressShipment expressShipment = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            //InternationalShipment internationalShipment = new InternationalShipment("SH003", "Television", 5, 120, "Germany", 100);

            //deliveryCenter.PrintAllShipments();
            //deliveryCenter.AddShipment(standardShipment);
            //deliveryCenter.AddShipment(expressShipment);
            //deliveryCenter.AddShipment(internationalShipment);

            //deliveryCenter.PrintAllShipments();

            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);

            //Console.WriteLine("Updating shipment status...");
            //Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");
            //standardShipment.updateWeight(5m);
            //Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");
            //standardShipment.updateWeight(5.5m);
            //Console.WriteLine($"Updated Weight After Packing : {standardShipment.Weight} KG");

            //Shipment[] shipments = { standardShipment, expressShipment, internationalShipment };
            //Console.WriteLine("Printing Using Shipment[]...");

            #endregion
        }
    }
}
