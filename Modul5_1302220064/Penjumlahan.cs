using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302220064
{
    public class Penjumlahan { 
    
        
    public void JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic i = input1;
            dynamic j = input2;
            dynamic k = input3; 
            dynamic hasil = i + j + k;
            Console.WriteLine(hasil);
        }
    
    }
}
