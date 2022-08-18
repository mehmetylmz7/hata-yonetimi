using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş oldugunuz sayı:"+sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata:"+ex.Message.ToString());
              
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
            Console.ReadLine();

            /*condition1 
            bir sayı giriniz:
            5
            girmiş oldugunuz sayı: 5
            işlem tamamlandı */

            /*condition2 
            bir sayı giriniz:
            key                                string bir değer girildiğnden hata vermesi beklenir
            hata:Giriş dizesi doğru biçimde değildi.
            işlem tamamlandı */


            try
            {
                // int a = int.Parse(null);                   // durum1
                //  int a = int.Parse("test");               // durum2
                int a = int.Parse("-20000000000");       // durum3


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş bir deger girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("cok kucuk ya da cok buyuk bır deger gırdınız ");
                Console.WriteLine(ex);

            }

            Console.ReadLine();

            /* durum1
                 boş bir deger girdiniz
                 System.ArgumentNullException: Değer null olamaz.
                 Parametre adı: String
                 konum: System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer & number, NumberFormatInfo info, Boolean parseDecimal)
                 konum: System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
                 konum: System.Int32.Parse(String s)
                 konum: hata_yonetimi.Program.Main(String[] args) C: \Users\ASUS\Desktop\patika C# kursu\hata-yonetimi\Program.cs içinde: satır 46
            */
           
            /* durum2 

            veri tipi uygun değil
            System.FormatException: Giriş dizesi doğru biçimde değildi.
            konum: System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer & number, NumberFormatInfo info, Boolean parseDecimal)
            konum: System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
            konum: System.Int32.Parse(String s)
            konum: hata_yonetimi.Program.Main(String[] args) C: \Users\ASUS\Desktop\patika C# kursu\hata-yonetimi\Program.cs içinde: satır 47
            */


           /* durum3
                cok kucuk ya da cok buyuk bır deger gırdınız
                System.OverflowException: Değer bir Int32 için çok büyük ya da çok küçüktü.
                konum: System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
                konum: System.Int32.Parse(String s)
                konum: hata_yonetimi.Program.Main(String[] args) C: \Users\ASUS\Desktop\patika C# kursu\hata-yonetimi\Program.cs içinde: satır 48
           */
















        }
    }
}
