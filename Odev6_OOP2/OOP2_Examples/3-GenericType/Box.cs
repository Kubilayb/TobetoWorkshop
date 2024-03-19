using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Examples._3_GenericType
{
    public class Box<T>
    {
        public T Content { get; set; }

        public Box(T content)
        {
            Content = content;
        }
        public static void DisplayContent(Box<T> box)
        {
            Console.WriteLine($"İçerik: {box.Content}");
        }
    }

    /*
             Bu kod, Box adında bir generic sınıf tanımlar. 
             <T> yazısı, bu sınıfın generic bir tür parametresi aldığını belirtir. 
             T placeholder, generic türün temsil ettiği türü ifade eder.

             Content adında bir özellik (property) tanımlanmıştır. 
             Bu özellik, T generic türünde bir içerik saklar.

             Ayrıca, Box sınıfı bir kurucu metot (constructor) içerir. 
             Bu kurucu metot, bir Box örneği oluştururken içerik parametresini alır ve Content özelliğine atar.

             Bu sınıf, herhangi bir türdeki bir nesneyi saklamak için kullanılabilir. 
             Örneğin, Box<int> bir tamsayı değerini, Box<string> bir metin değerini saklayabilir.
             Bu sayede, aynı yapıyı farklı türlerdeki verileri saklamak için kullanabilirsiniz. 

     */
}
