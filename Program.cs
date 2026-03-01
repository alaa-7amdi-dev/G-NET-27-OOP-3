using G_NET_27_OOP_3.Inheritance;
using System.Runtime.InteropServices.Marshalling;

namespace G_NET_27_OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 
            //A:Composition (Has_A Strong)=>  is a HAS-A relationship where the child can not exists Without parent.
            //B:Association (Use_A)=> connection between two classes ,one class use the other ,but no ownership betwwen them.
            //C:Inheritance (Is_A)=>one class (child) inherits from another (parent).
            //D:Aggregation (Has_A Weak)=> ia a Has-A relationship where the child can exists indpendentiy of the Parent.
            //E:Dependency => class temporarily depends on another to perform an action.

            #endregion

            #region Part 02
            //A: Yes ,A child class can access  a protected field even differenet assemply.
            // No , becouse the outer class inherits a field as private field.

            //B :  protected internal=> can access the field or prop in the same assemply or in different assemply  
            //   as long as it inherits from parent .
            //     private protected=> can access and inherits field in the same assemply only.

            //C:  when applied to the class=> the interitance Chain stops.
            //    when applied to the mathiod => can not change or Override the method inherits.

            // D:  yes can create an abject from sealed class , sealed only prevents inheritance.
            #endregion

            #region Practical Ex

            //Cinema cinema = new Cinema("Metroplicano");
            //cinema.OpenCinema();

            //StandardTicket standardTicket = new StandardTicket("A","Inception",200);
            //VIPTicket vIPTicket = new VIPTicket(true,33,"Avengers",220);
            //IMAXTicket iMAXTicket = new IMAXTicket(false,"Dune",300);

            //cinema.AddTicket(standardTicket);
            //cinema.AddTicket(vIPTicket);
            //cinema.AddTicket(iMAXTicket);

            //Console.WriteLine(standardTicket);
            //Console.WriteLine(vIPTicket);
            //Console.WriteLine(iMAXTicket);

            //cinema.CloseCinema();
            //Console.WriteLine("==========Cinema Closed=======");
            #endregion

            #region Refactor
            //Cinema cinema = new Cinema("Metroplicano");
            //cinema.OpenCinema();
            //StandardTicket standardTicket = new StandardTicket("B4", "Inception", 200);
            //VIPTicket vIP = new VIPTicket(false, 50m, "Avengers", 300);
            //IMAXTicket iMAX = new IMAXTicket(true, "Dune", 250);

            //vIP.SetPrice(200);
            //Console.WriteLine($" Setting Price Directly : {vIP.Price}");
            //vIP.SetPrice(200, 2);
            //Console.WriteLine($"Setting Price With Multiplier : {vIP.Price}");

            //cinema.AddTicket(vIP);
            //cinema.AddTicket(standardTicket);
            //cinema.AddTicket(iMAX);

            //cinema.printAll();

            //Cinema.ProcessTicket(vIP);


            //cinema.CloseCinema();
           


            #endregion
        }
  
    }
}
