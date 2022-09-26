using System;

public class person

{
   public int MyWallet() 
   {
      Random random = new Random();
      int num = random.Next (100000,300000); 
      return num; 
   }
   public int MyCar()
   {
      Random random = new Random();
      int num = random.Next (0,12); 
      return num;
       
   }
   public void information(Programet _program, String _valg)
   {
      switch(_valg)
         {
            case "Wallet":
            {
               Console.WriteLine(_program.getwallet()+ " kr");
               break;
            }
            case "MyCar":
            {
               Console.WriteLine("22");
               //Console.WriteLine(myNumbers.Max(  ));  // returns the largest value
               break;
            }
         }
   }


  
    
}