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
        }
    }
}
