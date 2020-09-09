using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace add  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            int Number1, Number2;  
            Console.WriteLine("please enter the Number1");  
            Number1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("please enter the Number2");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Sum;
            int Product;
            int div=-999;
            Sum = Number1 + Number2; 
            Product = Number1*Number2;
            if(Number2!=0)
                div = Number1 / Number2;
            Console.WriteLine("Sum of two Numbers:" + Sum.ToString()); 
            Console.WriteLine("Product of two Numbers:" + Product.ToString());
            Console.WriteLine("Division of two Numbers:" + div.ToString());
            Console.ReadLine();  
        }  
    }  
}  