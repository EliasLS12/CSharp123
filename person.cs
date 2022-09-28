using System; 
  
public class person 
{ 
   public List<Car> myCars = new List<Car>();
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
            case "MyWallet": 
            { 
               Console.WriteLine(_program.getwallet()+ " kr"); 
               break; 
            } 
            case "MyCar": 
            { 
               myCars = _program.getcar();
               for(int i = 0; i < myCars.Count; i++)
               {
                  Console.WriteLine(myCars[i].completeCarspec()); 
               }
               
               break; 
            } 
         } 
   } 
 

}