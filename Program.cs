using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitapthuhanh // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
          daThuc phuongTrinh =  new daThuc(1,4,1);
          phuongTrinh.xuat();
          phuongTrinh.kiemTraNghiemPhuongTrinh(phuongTrinh);
          // delta
          Console.WriteLine(phuongTrinh.delta(phuongTrinh));
          // in cac nghiem cua phuong trinh 
          phuongTrinh.nghiemCuaDaThuc();

          Console.ReadLine();
        }
    }
}