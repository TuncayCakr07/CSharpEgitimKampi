using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer --> Listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Tuncay Çakıroğlu");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x=1; 
            //    int y=2;
            //    int z=x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Tuncay Çakıroğlu");

            //void CustomerCard(string name,string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + Surname);
            //}

            //CustomerCard("Tuncay","Çakıroğlu");
            //CustomerCard("Tuğçe","Çakıroğlu");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2,int number3)
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Methodlar

            //string CustomerName()
            //{
            //    return "Tuncay Çakıroğlu";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Tuncay";
            //    string surname = "Çakıroğlu";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Methodlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak Rengi Giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Methodlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion


            #region Örnek Uygulama
            string ExamResult (string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if(result>=50)
                {
                    return student+" İsimli Öğrenci Sınavı Geçti"+" Ortalama: "+result;

                }
                else
                {
                    return student + " İsimli Öğrenci Sınavda Başarısız Oldu" + " Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Tuncay", 55, 65, 85));
            Console.WriteLine(ExamResult("Tuğçe", 75, 65, 85));
            Console.WriteLine(ExamResult("Emine", 45, 65, 95));


            #endregion
            Console.Read();
        }
    }
}
