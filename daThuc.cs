using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace baitapthuhanh
{
    public class daThuc
    {
        // attribute
        private int Ia;
        private int Ib;
        private int Ic;
        // properties
        public int a{
            get{ return Ia;}
            set{ Ia= value;}
        }
         public int b{
            get{ return Ib;}
            set{ Ib= value;}
        }
         public int c{
            get{ return Ic;}
            set{ Ic= value;}
        }
        // contrustor

       public daThuc(int a , int b , int c){
        this.a = a;
         this.b = b;
         this.c = c;
       }
       

       // methods
        public void xuat(){
            Console.Write(this.Ia.ToString() + "x^2 +"+ this.Ib.ToString() +"x +" +this.Ic.ToString() );
        } 
        public int kiemTraNghiemPhuongTrinh(daThuc phuongTrinh){
            int nghiem = -1;
            if(delta(phuongTrinh) > 0 ){
                Console.WriteLine("phuong trinh co 2 nghiem phan biet");
                return nghiem = 1;
            }
            else if(delta(phuongTrinh)==0){
               Console.WriteLine("phuong trinh co 1 nghiem duy nhat");
               return nghiem = 1;
            }
           else {
             Console.WriteLine("phuong trinh vo nghiem");
            return nghiem;
           }

        }
        public double delta(daThuc phuongTrinh){
            double delta;
            return Math.Sqrt(delta =(phuongTrinh.b*phuongTrinh.b) - 4*phuongTrinh.a*phuongTrinh.c);
        }
        public void nghiemCuaDaThuc(){
            float delta = this.b * this.b - 4*this.a * this.c;
            float x1,x2;
            if(delta > 0){
                 x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
             else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }

        public daThuc cong2Dathuc(daThuc phuongTrinh1, daThuc phuongTrinh2){
            int a = phuongTrinh1.a + phuongTrinh2.a;
            int c = phuongTrinh1.c + phuongTrinh2.c;
            int b = phuongTrinh1.b + phuongTrinh2.b;
            daThuc phuongTrinhMoi = new daThuc(a,b,c);
            return phuongTrinhMoi;
        }
        public daThuc tru2Dathuc(daThuc phuongTrinh1, daThuc phuongTrinh2){
            int a = phuongTrinh1.a - phuongTrinh2.a;
            int c = phuongTrinh1.c - phuongTrinh2.c;
            int b = phuongTrinh1.b - phuongTrinh2.b;
            daThuc phuongTrinhMoi = new daThuc(a,b,c);
            return phuongTrinhMoi;
        }
        public void dathucBangNhau (daThuc phuongTrinh1, daThuc phuongTrinh2){
            if(phuongTrinh1.a == phuongTrinh2.a && phuongTrinh1.b== phuongTrinh2.b && phuongTrinh1.c == phuongTrinh2.c){
                Console.WriteLine("2 phuong trinh bang nhau");
            }
            else  Console.WriteLine("2 phuong trinh kh bang nhau");
        }
        public void dathuckhacNhau (daThuc phuongTrinh1, daThuc phuongTrinh2){
            if(phuongTrinh1.a != phuongTrinh2.a && phuongTrinh1.b!= phuongTrinh2.b && phuongTrinh1.c != phuongTrinh2.c){
                Console.WriteLine("2 phuong trinh khac nhau");
            }
            else  Console.WriteLine("2 phuong trinh kh khac nhau");
        }
    }
}