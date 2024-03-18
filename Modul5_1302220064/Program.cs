// See https://aka.ms/new-console-template for more information
using Modul5_1302220064;

public class Program
{
    public static void Main(String[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        double i = float.Parse(Console.ReadLine());
        double j = float.Parse(Console.ReadLine());
        double k = float.Parse(Console.ReadLine());
        penjumlahan.JumlahTigaAngka<double>(i,j,k);

        SimpleDataBase<double> simpleData = new SimpleDataBase<double>();
        simpleData.AddNewData(i);
        simpleData.AddNewData(j);
        simpleData.AddNewData(k);
        simpleData.PrintAllData();

    }
}
