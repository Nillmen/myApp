using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so thu nhat: ");
        double SoThuNhat = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        double SoThuHai = Convert.ToDouble(Console.ReadLine());

        if (SoThuHai != 0)
        {
            double KetQua = SoThuNhat / SoThuHai;
            Console.WriteLine("Ket qua cua {0} chia cho {1} la: {2}", SoThuNhat, SoThuHai, KetQua);
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}
