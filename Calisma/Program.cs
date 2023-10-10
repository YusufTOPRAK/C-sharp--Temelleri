using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OPERATÖRLER
            #region OPERATÖRLER
            // MANTIKSAL OPERATÖRLER
            /*#region Mantıksal Operatörler
            Console.WriteLine("-----------&&-----------");
            // Mantıksal Operatörler
            // Şartları değerlendirerek sonuçlar döndüren operatörlerdir.
            #region && ==> ve Tüm şartların yerine getirilmesi gerekir.
            Console.WriteLine($"true - true: {true && true}"); // true
            Console.WriteLine($"true - false: {true && false}"); // false
            Console.WriteLine($"false - false: {false && false}"); // false
            Console.WriteLine($"false - true: {false && true}"); // false
            #endregion

            Console.WriteLine("-----------||-----------");
            #region || ==> veya Şartlardan en az bir tanesinin yerine getirilmesi gerekir.
            Console.WriteLine($"true - true: {true || true}"); // true
            Console.WriteLine($"true - false: {true || false}"); // true
            Console.WriteLine($"false - false: {false || false}"); // false
            Console.WriteLine($"false - true: {false || true}"); // true
            #endregion

            Console.WriteLine("-----------^-----------");
            #region ^ ==> ya da Şartlardan sadece bir tanesinin yerine getirilmesi gerekir.
            Console.WriteLine($"true - true: {true ^ true}"); // false
            Console.WriteLine($"true - false: {true ^ false}"); // true
            Console.WriteLine($"false - false: {false ^ false}"); // false
            Console.WriteLine($"false - true: {false ^ true}"); // true
            #endregion

            Console.ReadLine();
            #endregion*/

            // TERNARY OPERATÖRÜ
            #region Ternary Operatörü
            // Şarta göre değer döndürülmesini sağlayan bir operatördür.
            // koşul ? true durumu : false durumu 

            /*#region
            bool medeniHal = true;
            string mesaj = medeniHal == false ? "Evli" : "Bekar";
            Console.WriteLine(mesaj);
            Console.ReadLine();
            #endregion*/

            /*#region Birden Fazla Koşul
            // Yaşı 25'den küçük olanlara a, 25 olanlara b ve 25'den küçük olanlara c değerini döndüren ternary
            int yas = 27;

            string sonuc = yas < 25 ? "a" : (yas > 25 ? "b" : "c");

            Console.WriteLine(sonuc);
            Console.ReadLine();
            #endregion*/

            /*#region Örenek1
            // Kullanıcı tarafından girilen sayının aşağıdaki koşullara göre sonuçları döndüren kodu yaz.
            // sayi < 3                               == > sayi*5
            // sayi > 3 && sayi < 9                   == > sayi*3
            // sayi >= 9 && sayi % 2 == 0             == > sayi*10
            // sayi % 2 == 1                          == > sayi
            // yukaridaki hiçbir koşulu sağlamıyorsa  ==> -1

            Console.Write("Sayi gir: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi<3 ? sayi*5 : (sayi>3 && sayi<9 ? sayi*3 : (sayi>=9 && sayi%2==0 ? sayi*10 : (sayi%2==1 ? sayi : -1 )));
            Console.WriteLine(sonuc);
            Console.ReadLine();
            #endregion*/

            /*#region Örnek2 
            // Hava durumunu içeren string değerine göre sonuç döndüren kod
            // "Yağmurlu" ==> "Şemsiye al."
            // "Güneşli" ==> "Şapka tak"
            // "Kapalı" ==> "Yağmur yağabilir."

            string havaDurumu = "Yağmurlu";
            string sonuc = havaDurumu == "Yağmurlu" ? "Şemsiye al" : havaDurumu == "Güneşli" ? "Şapka Tak" : "Yağmur yağabilir.";

            Console.WriteLine(sonuc);
            Console.ReadLine();
            #endregion*/

            #endregion

            //CAST OPERATÖRÜ
            #region Cast Operatörü
            // Kullanım Alanları

            /*#region 1) Boxing ==> Unboxing
            object x = 123;
            int x2 = (int)x;
            #endregion*/

            /*#region Bilinçli Tür Dönüşümü
            int a = 5;
            short b = (short)a;
            #endregion*/

            /*#region Char ==> int , int ==> Char (ASCII)
            int ascii = 97;
            char c = (char)ascii;
            Console.WriteLine(c);
            Console.ReadLine();
            #endregion*/

            #endregion

            // SIZEOF OPERATÖRÜ
            /*#region sizeof Operatörü
            // Verilen türün bellekte kaç bytlık yer kapladığını integer olarak döndürür.
            Console.WriteLine($"int: {sizeof(int)}");
            Console.WriteLine($"long: {sizeof(long)}");
            Console.WriteLine($"decimal: {sizeof(decimal)}");
            Console.ReadLine();
            #endregion*/

            // typeof OPERATÖRÜ
            /*#region typeof Operatörü
            // Verilen türü bilgilerini döndürür.
            Type t = typeof(int); // int türüne ait tüm bilgiler t değişkenine atanmıştır.
            Console.WriteLine(t);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsPrimitive);
            Console.ReadLine();
            #endregion*/

            // DEFAULT OPERATÖRÜ
            /*#region Default Operatörü
            // Her tür için tanımlanmış varsayılan değerlere default denir.
            // sayısal   ==> 0
            // bool      ==> false
            // string    ==> null
            // char      ==> \0
            // reference ==> null

            Console.WriteLine(default(int));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(string));
            Console.WriteLine(default(char));
            Console.ReadLine();
            #endregion*/

            // IS OPRERATÖRÜ
            /*#region is Operatörü
            // Boxing olarak tutulan değerin asıl türünü öğrenebilmek/kontrol edebilmek için is opretörü kullanılır.
            object x = false; // Boxing
            Console.WriteLine(x is bool); // true
            Console.WriteLine(x is int); // false
            Console.ReadLine();
            #endregion*/

            // IS NULL OPRERATÖRÜ
            /*#region is null Operatörü
            // Bir değişkenin değerinin null olup olmadığını kontrol eder. Sadece referans tipler nullable olduğu için referans tipler üzerinden kontrol edilebilir.
            string x = null; // true
            string y = ""; // false
            string z = "asdasd"; // false

            Console.WriteLine(x is null);
            Console.WriteLine(y is null);
            Console.WriteLine(z is null);
            Console.ReadLine();
            #endregion*/

            // AS OPERATÖRÜ
            #region as operatörü
            // Cast operatörünün Boxing ==> Unboxing işlemine(aşağıdaki) alternatif olarak kullanılır.
            // object türündeki değerin öz tipi farklı bir tür olarak cast edilmeye çalışılırsa hata verir. as operatörünü kullanarak hata durumunda null değeri döndürülür.
            // as operatörü, primitive türler null değeri alamadığı için sadece referans türlerle(tiplerle) çalışır. 

            // CAST(Boxing ==> Unboxing)
            /*object x = 123;
            int x2 = (int)x;
            Console.WriteLine($"object: {x}");
            Console.WriteLine($"int: {x2}");
            Console.ReadLine();*/

            // as(Boxing ==> Unboxing)
            // HATA VERİR ==> primitive tipteki değerler null değeri alamaz.
            /*object x = 123;
            int x2 = x as int;*/

            // Doğru çalıştırma
            /*object ad = "Ali";
            string ad2 = ad as string;
            Console.WriteLine($"object: {ad}");
            Console.WriteLine($"string: {ad2}");
            Console.ReadLine();*/

            // Sonucun null olarak dönmesi durumu
            // primitive tipler null alamdığı için nullable(?) olarak tanınması lazım.

            /*object ad = "Ali";
            int? ad2 = ad as int?;
            Console.WriteLine($"object: {ad}");
            Console.WriteLine($"string: {ad2}");
            Console.ReadLine();*/

            #endregion


            #region NULL OPERATÖRLERİ
            // NULLABLE OPERATÖRÜ(?)
            /*#region Nullable Operatörü
            // Null değeri alamayan değer türlü(primitive) değişkenlerin null değeri almasını sağlayan operatördür.
            //int x = null; // Hata verir. Çünkü int gibi değer tipli(primitive) değişkenler null değeri alamaz.
            int? x = null;
            Console.WriteLine(x);
            Console.ReadLine();
            #endregion*/

            // NULL COALESCING OPERATÖRÜ(??) - NULL COALESCING ASSIGNMENT OPERATÖRÜ(??=)
            /*#region Null Coalescing
            // Var olan bir değişkenin null olma durumunu kontrol ederek null olduğu belirlendiğinde istenilen işlemin yapılmasını sağlayan operatördür.
            string ad = null;
            Console.WriteLine(ad ?? "Veli");

            // NOT: İstenilen işlem için kullanılacak değişkenin türü ile kontrol edilen değişkenn türü aynı olmalıdır.
            int? x = null;
            //Console.WriteLine(x ?? "Ali"); // Hata verir. Çünkü x sadece int tipi bir değer ile karşılaştırılabilir.
            Console.WriteLine(x ?? 3);       
            Console.ReadLine();
            #endregion*/

            // NULL COALESCING ASSIGNMENT OPERATÖRÜ(??=)
            /*#region Null Coalescing Assignment Operatörü
            // Null Coalescing null olma koşulunu sağladıysa yapılmak istenen işlemle birlikte atama yapar.
            int? id = null;
            Console.WriteLine(id ??= 1);
            Console.ReadLine();
            #endregion*/
            #endregion

            #endregion

            // Switch Case
            #region
            /*#region TANIM
            // Bu yapı sadece bir değerin farklı bir değerle olan eşitlik durumunu kontrol etmek için kullanılır.
            // Switch yapısındaki amaç verilen değerin eşitliğini sağlayan kod bloğunu(case-break) çalıştırmaktır.
            // Eşitlik durumu kontrol edilecek değer switch'e ait alana yazılır.
            // Switch alanına yazılan değerle eşit olunması için aranan diğer değerler case alanına yazılır.
            // Hiçbir case-break bloğunda eşitlik sağlanmıyorsa yapılması istenen iş default-break kod bloğunda tanımlanır.(Zorunlu değildir.)
            // switch alanına yazılan değerin türü ile case alanına yazılan değerin türü aynı olmalıdır. 
            // switch parantezine değişken veya sabit/statik değer yazılabilir fakat case alanına sadece sabit/statik değer yazılabilir, değişken yazılamaz. 

            string ad = "Ali";
            switch (ad) // Parantezin içine eşitliği sorgulanmak istenen değer yazılır.
            {
                case "Kazım":
                    Console.WriteLine("Kazım");
                    break;

                case "Ali":
                    Console.WriteLine("Ali");
                    Console.ReadLine();
                    break;

                case "Kamuran":
                    Console.WriteLine("Kamuran");
                    break;

                default:
                    Console.WriteLine("Hiçbiri değil.");
                    break;
            }


            /*#region When KEYWORD
            // Switch yapısı içinde farklı şartlar da ele alınmak isteniyorsa when kullanılır.
            int satisTutari = 1000;
            switch (satisTutari)
            {
                case 1000 when(3 == 5):

                    break;

                case 1000 when (3 == 3):
                    Console.WriteLine("Çalışılacak alan");
                    Console.ReadLine(); 
                    break;
            }
            #endregion*/

            /*#region goto 
            // Switch yapısın içindeki caselerden herhangi birinin tekrar çalıştırılması isteniyorsa goto kullanılır.
            int i = 10;
            switch (i)
            {
                case 4:
                    Console.WriteLine(i*4);
                    break;

                case 6:
                    Console.WriteLine(i*6);
                    break;

                case 12:
                    goto case 6; // Noktalı virgül ile bitti. break kullanılmaz. Çünkü burada bir yönlendirme yaparak işlem devam ediyor, bitmiyor.

                case 13:
                case 14:
                    goto case 4; // Birden fazla case için goto kullanımı

            }
            #endregion*/

            #region Switch Expressions
            //ESKİ YÖNTEM
            /*#region
            string ad = "";
            int i = 0;
            switch (i)
            {
                case 1:
                    ad = "Hakkı";
                    break;

                case 2:
                    ad = "Kamil";
                    break;

                case 3:
                    ad = "Kazım";
                    break;
            }
            #endregion*/

            // YENİ YÖNTEM
            /*#region
            int i = 0;
            string ad = i switch
            {
                1 => "Hakkı",
                2 => "Kamil",
                3 => "Kazım"
            };
            Console.WriteLine(ad);
            #endregion*/

            // when kullanımı
            /*#region when Kullanımı
            int i = 0;
            string ad = i switch
            {
                1 when 3 == 0 => "Hakkı",
                var x when x == 9 2 => "Kamil",
                3 => "Kazım",
                var x => "Hiçbiri" // default
            };
            Console.WriteLine(ad);
            #endregion*/

            /*#region TUPLE PATTERNS
            // Eşitlik sağlanmak istenen değişken sayısının birden fazla olması.
            #endregion*/


            #endregion
            #endregion

            // IF
            #region
            // Elimizdeki değerin farklı bir değer ile olan eşitlik dahil tüm şartların kontrolünü sağlayan bir yapıdır.

            // Tek başına if kullanımı
            // Tek başına if kullanımı sadece şarta bağlı çalışacak koda odaklanır.

            /*bool medeniHal = true;
            if (medeniHal == true)
            {
                Console.WriteLine("Evli");
            }*/
            //
            /*bool medeniHal = false;
            if (medeniHal) // medeniHal bool olduğu için karşılaştırma(==) kullanılmasına gerek yok. true durumu
            {
                Console.WriteLine("Evli");
            }

            if (!medeniHal) // false durumu
            {
                Console.WriteLine("Evli değil");
            }
            Console.ReadLine();*/

            // if - else
            // if koşulu sağlanmaması durumunda else içerisinde yazılan kod çalışır.
            /*int i = 0;
            if (i<0)
            {
                Console.WriteLine("i değeri pozitif bir sayıdır.");
            }
            else
            {
                Console.WriteLine("i değeri negatif bir sayıdır.");
            }
            Console.ReadLine();
            Console.WriteLine("İşlem bitti.");*/ // Hem if hem de else durumlarında çalışacak kodu if-else bloklarından sonra yazılması doğrudur.(Her ikisine değil) 

            // Birden fazla şart belirtilmek isteniyorsa else if yapısı kullanılır.
            // Birden fazla şartın treu olduğu durumlarda else if yapısını kullanmak sorun yaratabilir.
            // Şartlardan ikisi de aynı aralığı içerdiği için ilk koşulu sağlayan blok çalışacak fakat çalışamayan blok da şarta uygundur.
            // Böyle bir durumda "if-else if" yapısı yerine "if" yapısı kullanılmalı.

            // if - else if yapısı ==> Kullanımı yanlış 
            /*int sayi = int.Parse(Console.ReadLine());
            if (sayi > 100 && sayi <= 200)
            {
                Console.WriteLine("100 ile 200 arasında");
            }
            else if (sayi > 200 && sayi <= 300)
            {
                Console.WriteLine("200 ile 300 arasında");
            }
            else if (sayi > 200 && sayi <= 400)
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            Console.ReadLine();*/

            // if yapısı ==> Kullanımı doğru
            /*int sayi = int.Parse(Console.ReadLine());
            if (sayi > 100 && sayi <= 200)
            {
                Console.WriteLine("100 ile 200 arasında");
            }

            if (sayi > 200 && sayi <= 300)
            {
                Console.WriteLine("200 ile 300 arasında");
            }

            if (sayi > 200 && sayi <= 400)
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            Console.ReadLine();*/

            /// Scopsuz if Kullanımı
            // Tek satırlık işlemlerde kullanılabilir
            /*if (true)
                Console.WriteLine("ABC");*/

            #endregion

            // PATTERN MATCHİNG //
            #region
            // Yapılacak belirli bir iş için kullanılan kod kalıplarıdır. Okunabilirliği(semantik) artrır. ==> PATTERN MATCHİNG
            // TYPE PATTERN //  ==> is operatörünün semantikleştirilmiş halidir.

            // sade hali
            /*object ad = "Ali";
            if (ad is string)
            {
                string ad2 = ad as string;
                Console.WriteLine(ad2);
            }*/

            // type pattern halinde ==> tanımlanan yeni değişken if bloğu için tanımlandı.
            /*object ad = "Ali";
            if (ad is string ad2)
            {
               Console.WriteLine(ad2);
            }*/

            // Oluşturulan yeni değişkenin null olma ihtimalinden dolayı herhangi bir işlem yapılamaz.(tanımlanan if bloğu dışında çünkü if null olup olmadığından haberdar)
            // null bir değişken için yapılabilecek tek işlem ona yeni bir değer atamaktır.
            // Console.WriteLine(ad2); ==> ÇALIŞTIRILAMAZ 


            // CONSTANT PATTERN // ==> Değer(sabit değer) kontrolü için kulllanılan kod kalıbıdır.
            /*int x = 4;
            if (x is 4)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(x is 56); // Farklı bir yol
            Console.ReadLine();*/


            // VAR PATTERN // ==> Var olan değeri var türü ile elde edilmesini sağlar.
            // Tür değişimini run-timeda yapar.
            /*var d = "asdasd"; // Derleme zamanında tür belirlenir.

            object x = "Ali";
            if (x is var a) // run-time zamanında tür belirlenir.
            {

            }*/

            // RECURSIVE PATTERN //
            // switch yapısında kontrol edilen değer olarak referans tipteki değerlerin kullanılmasını sağlar.
            // "case null" özelliğini de barındırır.

            // Type ve Var Pattern //
            // Patternlar if bloğu olmadan da kullanılabilir.
            /*object x = "Ali";
            bool result = x is string ad;
            Console.WriteLine(ad); // null değer alma ihtimalinden dolayı herhangi bir işlem yapılamaz.

            bool result2 = x is var ad2;
            Console.WriteLine(ad2);*/ // run-time da türünü(var) belirleyeceği için işlem yapılır. 
            #endregion

            // HATA TÜRLERİ //
            #region try-catch
            //SYNTAX(DERLEME) HATALARI

            // RUN-TIME HATALARI
            // Çalışma zamanında verilen hatalara denir. Hata sonucu işletim sistemi tarafından programlar durulur.

            // try - catch YAPISI ==> Çalışma zamanında verilen hataların kontrolünü sağlar.
            //Kullanım amaçları:
            // 1- Kullanıcının hataları öğrenmeden işlemin devam etmesi
            // 2- Hatanın nedenini kullanıcıya bildirmek.
            // 3- Oluşan hataya rağmen uygulamanın çalışmasını devam ettirmek.

            // try ==> Çalışma zamanında hata verme ihtimali olan işlemler try içerisine yazılır.
            // catch ==> try bloğu içinde bir hata alındığında akış catch içinde devam eder. Hata olma durumunda olması istenilen durumlar tanımlanır.
            /*try
            {
                Console.WriteLine("Sayı gir: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sayı gir: ");
                int sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Toplam: {sayi1+sayi2}");
                Console.ReadLine();

            }
            catch
            {
                Console.WriteLine("Doğru değer gir.");
                Console.ReadLine();
            }*/
            // NOT: try-catch yapısı maliyetli bir yapı olduğundan sadece hata verme ihtimali olan kodlar yazılır. Gereksiz kullanılmamalı.

            /*Console.WriteLine("Sayı gir: ");
            int sayi1 = 0, sayi2 = 0;
            try 
            {
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sayı gir: ");
                sayi2 = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Doğru değer gir.");

            }
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
            Console.ReadLine();*/

            // HATA PARAMETRELERİ ==> Çalışma zamanındaki hata ile ilgili bilgi veren parametredir. ==> Exception
            // catch kısmında kullanılır.
            /*try
            {
                int s1 = 0, s2=10;
                int a = s2 / s1;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Mesaj: {ex.Message}");      
            }
            Console.ReadLine();*/

            // Exception tüm hataları içerir. Exception dahilinde farklı durumlarda hata parametreleri de vardır. Belirtilen hata parametresi sağlanmıyorsa catch bloğu çalışmaz.
            /*try
            {
                int s1 = 0, s2 = 10;
                int a = s2 / s1;

                int.Parse("asdas"); // catch bloğunda bu hataya karşılık gelen hata parametresi tanımlanmadığı için program çalıştırmayı durdurur.
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Mesaj: {ex.Message}");
            }
            catch (FormatException ex) // FormatException hatasını uygulamak için gerekli catch bloğu
            { 

            }
            catch (Exception ex) // üsteki hiçbir catch bloğu koşulları karşılamazsa burası çalışır.
            { 
            }
            Console.ReadLine();*/

            // try - catch when yapısı ile hata filtreleme //
            /*string x = "c";
            try
            {
                int s1 = 0, s2 = 10;
                int a = s2 / s1;
            }
            // catch when () ==> Hata türü belirtilmeden de kullanılabilir. 
            catch (DivideByZeroException ex) when (x == "a") // ==> when, false ise her türlü çalışmaz.(hata parametresi geçerli olsa dahi)
            {                                                // ==> x == "a" ise çalış     
                Console.WriteLine($"A.Mesaj: {ex.Message}");
            }
            catch (DivideByZeroException ex) when (x == "b") // ==> x == "b" ise çalış
            {
                Console.WriteLine($"B.Mesaj: {ex.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Mesaj: {ex.Message}");
            }
            Console.ReadLine();*/

            #endregion

            // for Döngüsü //
            #region
            // Genellikle ardışık işlemlerde kullanılır.
            // 3 tane parametre alır. Her parametre arasına ";" konur.
            // İlk parametre değer(başlangıç değeri) tanımı, ikinci parametre şart tanımı, üçüncü parametre artış/azalış tanımı şeklindedir.
            // İlk parametre döngünün bir başlangıç noktası olması gerektiğinden dolayı tanımlanır.
            // Şart tanımı genellikle ilk parametre olarak tanımlanan değer üzerinedir. Farklı bir değer üzerin de olabilir.
            // Üçüncü parametre döngünün sonlanması için tanımlanır. Genellikle sonlandırma işlemi başlangıç değeri üzerinden yapılır ama başka değerler üzerinden de yapılabilir.
            //Döngü çalışırken şart true ise yapılması istenilen işlemler(blok içerisinde) gerçekleşir ve 3.parametre artış/azalış işlemini uygular ve tekrar şarta(2.parametre) döner.
            //    Bu durum şart, false olana kadar devam eder. False olduğunda döngüden çıkar.

            //for (int i = 0; i < 10; i++) 
            //{ 
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //ÖRNEK1 ==> 1'den 10(10 dahil) kadar olan sayıları alt alta yazdır.
            //for (int i = 1; i < 10+1; i++)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            //ÖRNEK2 ==> 1 ile 40(dahil) arasındaki çift sayıların toplamını ekrana yazdır.
            //ÇÖZÜM1
            /*int toplam = 0;
            for (int i=1; i <= 40;i++) 
            {
                if (i%2==0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();*/

            //ÇÖZÜM2
            /*int toplam = 0;
            for (int i = 0; i <= 40; i+=2)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadLine();*/

            //ÖRNEK3 ==> Girilen sayının faktöriyelini bul.
            /*Console.WriteLine("Sayı Gir: ");
            int carpım = 1;           
            for (int sayi = int.Parse(Console.ReadLine()); sayi>=1 ;sayi--)
            {
                carpım*=sayi;
            }
            Console.WriteLine(carpım);
            Console.ReadLine();*/

            // FARKLI YOL
            //Console.WriteLine("Sayı Gir: ");
            //int carpım = 1;
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = sayi ; i >= 1  ; i--)
            //{
            //    carpım *= i;
            //}
            //Console.WriteLine(carpım);
            //Console.ReadLine();

            ////////// FOR DÖNGÜSÜ VARYASYONLARI //////////
            //1 ==> Başlangıç değeri dışarıda tanımlanır bu yüzden for döngüsünde tanımlanmasına gerek kalmaz.
            //int i = 0;
            //for (;i<10;i++)
            //{

            //}

            //2 ==> Başlangıç değeri dışarıda tanımlanırsa for içinde ancak bir değer atanarak kullanılabilir. 
            //int i = 0;
            //for (i = 0 ; i<10; i++)
            //{

            //}

            //3 ==> Arttırma işlemi dışarıda for scopu içinde de tanımlanabilir.
            //for (int i = 0; i<10;)
            //{
            //    i++;
            //}

            //4 ==> Şart başlangıç değeri dışında başka bir değer üzerinde de sağlanabilir.
            //string ad = "Ali";
            //for (int i = 0; ad=="Ali";i++)
            //{

            //}

            //int a = 5; 
            //for (int i = 0; a != i*2 ;i++)
            //{

            //}

            //6 ==> Hiçbir parametre belirtilmeden de kullanılabilir. Sonsuz döngüye girer.
            //for (; ; )
            //{
            //    Console.WriteLine("Ali"); // sonsuz kere yazılır.
            //}

            //7 ==> Şart belirtilmedeğinde sonsuz döngüye girer.
            //for (int i = 0; ; i++)
            //{
            //    Console.WriteLine("Ali"); // sonsuz kere yazılır.
            //}

            //8 ==> Birden fazla başlangıç değeri tanımlanabilir, şart ve arttırma işlemlerinde kullanılabilir.
            //for (int i = 0, i2= 1; i>5 && i2<20; i++, i2--)
            //{

            //}
            #endregion

            // while Döngüsü //
            #region
            // Genellikle sonsuz döngü durumları için kullanılır.
            // Şarta bağlı bir döngüdür. Şart true olduğu sürece çalışır.
            // while döngüsü içindeki arttırma/azaltma işlemlerinin sırasına dikkat edilmelidir.

            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // Ekrana 10 kere "Merhaba Dünya" yazdıran program
            //int i = 0;
            //while (i < 10) 
            //{
            //    i++;
            //    Console.WriteLine($"{i}. Merhaba Dünya");
            //}
            //Console.ReadLine();

            // Klavyeden girilen sayının geriye doğru 0' a kadar yazan program
            //Console.WriteLine("Sayı gir: ");
            //int sayi = int.Parse(Console.ReadLine());
            //while (sayi > 0)
            //{
            //    Console.WriteLine(sayi);
            //    sayi--;
            //}
            //Console.ReadLine();

            // 0 ile 100(dahil) arasındaki tek sayıların toplamı
            //1.YOL
            /*int toplam = 0;
            int i = 0;
            while (i <= 100 ) 
            {
                if ( i%2 == 1)
                {
                    toplam += i;
                }
                i++;
            }
            Console.WriteLine(toplam);
            Console.ReadLine();*/

            // 2.YOL
            //int toplam = 0;
            //int i = 1;
            //while (i < 100) 
            //{
            //    toplam += i;
            //    i += 2;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            // Klayveyen girilen sayının faktöriyelini bul.
            /*int sonuc = 1;
            int sayi = int.Parse(Console.ReadLine());        

            while (sayi > 0)
            {
                //sonuc = sonuc * sayi;
                //sonuc *= sayi;
                //sayi--;
                sonuc *= sayi--;
            }

            Console.WriteLine(sonuc);
            Console.ReadLine();*/

            // O anki tarihin saniyesi 5'in katıysa tarihi ekrana yazdıran program
            // Bu uygulama şart while içerisinde kontrol edilmektedir.
            // Program çalıştığı sürece saniye her 5'in katı olduğunda ekrana yazdırılır. 
            /*while (true)
            {
                if (DateTime.Now.Second % 5 == 0)
                    Console.WriteLine(DateTime.Now);

            }
            Console.ReadLine();*/
            #endregion

            // do-while Döngüsü //
            #region
            // Bu döngüde önce yapılacak işlem daha sonrasında şart tanımlanır.
            // Yapılacak işlemler şart true da olsa false da olsa en az bir kez gerçekleşecek.

            /*while (false)
            {
                Console.WriteLine("while");

            }

            do
            {
                Console.WriteLine("do-while");
            } while (false);

            Console.ReadLine();*/
            #endregion

            // Döngüleri Scopsuz Kullanma //
            #region
            // Tek satır ile yapılacak dönü işlemleri scopsuz tanımlanabilir.
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine(i);


            //while (true)
            //    Console.WriteLine("Ali");

            //do
            //    Console.WriteLine("Ali"); 
            //while (true);
            //Console.ReadLine();
            #endregion

            // Döngülerde Sonsuz Döngü //
            #region
            // Bir döngüdeki koşulun sonsuza kadar sağlandığı durumdur.
            // Bir döngüde sonsuz döngü ya istenmeyerek(hata) ya da istendiği için oluşur. 

            // for //
            // Aşağıda sonsuz for döngüsü ve bu döngünün nasıl sonlandırılacağı yazılmıştır.
            // Şartı sağlayan durum bize hep true döndüren bir değer olduğundan bunu döngü içinde false durumuna sokarak döngü kırılabilir.
            /*bool durum = true; 
            for (; durum; ) 
            {
                if (durum)
                {
                    durum =! durum;
                }
            }*/

            // while //
            // for ile aynı mantıkladır.
            /*bool durum = true;
            while (durum)
            {
                if (durum)
                {
                    durum = !true;
                }
            }*/

            #endregion

            // İç İçe Döngüler
            #region
            // Başlangıç değerleri aynı olamaz.
            // Dışarıda tanımlanan dögü her çalıştığında içerideki döngü tüm adımlarını çalıştırır
            //for(; ; )
            //{
            //    for(; ; )
            //    {

            //    }
            //}
            #endregion

            // Keyword//
            #region
            // Derleyici tarafından tanımlanmış belirli bir amaç için kullanılan ve bu kullanımın sınırları olan anahtar kelimelerdir.
            // Operatör ve keyword farkı operatörün belirli bir iş üstlenmesi, keywordun ise kapsamının daha geniş olmasıdır.

            // KONSEPLİ KEYWOEDLER //
            // Kullanımı belli bir konsept barındıran keywordlerdir.
            // namespace, class, while, for, try-catch, do-while, veri tipleri(int, string, boll,.......)

            // KONSEPSİZ KEYWOEDLER //
            // Kullanımı için herhangi bir konsepte ihtiyaç duymayan, tek başına kullanılabilir keywordlerdir.
            // return, break, continue, goto,
            #endregion

            // MANEVRATİK YARDIMCI KODLAR //
            #region
            // Kodu yönlendirmek(döngüyü sonlandırmak/devam ettirmek, metodu sonlandırmak gibi) için kullanılan komutlardır.
            // break, continue, return, goto

            // break //
            //Kullanım yerleri ==> switch-case, döngüler, foreach
            //Döngü içinde kullanılan herhangi bir yapıda(if,try-catch) da kullanılabilir. 
            //Kullanıldığı yapıyı sonlandırır. continue her çalıştığında döngü başa döner.

            //ÖRNEK1: Kullanıcıdan 't' harfi girene kadar sayı girilmesini ve bu sayıların toplamını ekrana yazan program
            /*int toplam = 0;

            while (true)
            {
                Console.WriteLine("Sayı gir: ");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "t")
                {
                    Console.WriteLine(toplam);
                    break;
                }
                else
                {
                    toplam += int.Parse(girilenDeger);
                }
            }
            Console.ReadLine();*/

            //ÖRNEK2: Kullanıcıdan alınan sonsuz adet sayıdan 37 katı girildiğnde sonlanan program.
            /*while (true)
            {
                Console.WriteLine("Sayı gir: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi % 37 ==  0)
                {
                    Console.WriteLine("Bitti");
                    break; 
                }
            }*/

            // continue //
            //Sadece döngülerde kullanılır.
            //Koşul sağlandığında döngünün bitmemesini sağlar.
            //Döngü içinde kullanılan herhangi bir yapıda(if,try-catch) da kullanılabilir. 
            //Örnek ==> 1'den 10'a kadar çift sayıların yazımı (for)
            /*for (int i = 0; i<10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i); // Buranın çalışması için if sağlanması lazım ama sağlanmadığında döngü bitmiyor devam ediyor
            }
            Console.ReadLine();*/

            //ÖRNEK1: Kullanıcının girdiği sonsuz adet sayıdan pozitif olanları çarpan ve "t" girildiğinde sonucu ekrana yazdıran program
            /*int carpim = 1;
            while (true)
            {
                Console.WriteLine("Sayı gir: ");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "t")
                {
                    Console.WriteLine(carpim);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    int sayi = int.Parse(girilenDeger);
                    if (sayi < 0)
                        continue;
                    carpim *= sayi;       
                }
            }*/

            //ÖRNEK2: 1 ile 100 arasında 7'nin katı olmayan sayıları yazdır.
            /*for (int i = 1; i < 100; i++)
            {
                //if (i % 7 != 0)
                //    Console.WriteLine(i); continue kullanılmadan

                if (i % 7 == 0)
                    continue;

                Console.WriteLine(i);
            }
            Console.ReadLine();*/

            // return //
            //Metod içerisinde her yerde kullanılabilir.
            //Kullanım Amacı1: Metodu sonlandırmak
            //Kullanım Amacı2: Geriye değer döndürme
            //return kullanımı sonrası metod sonlanacağı için sonrasındaki komutlar işlenmez.

            //ÖRNEK ==> Kullanıcı "c" tuşuna basana kadar sonsuz döngüde dönen uygulamayı yaz.
            /*while (true)
            {
                if (Console.ReadKey().KeyChar == 'c') // c tuşuna bastığı anda bitmesi istendiği için ReadKey kullanılmıştır.
                {
                    Console.WriteLine("Uygulama sona erdi");
                    return;
                }
                Console.WriteLine("");
                Console.WriteLine("Uygulama Çalışıyor.");
            }*/

            // goto //
            //Kod akışının değiştirilmesini sağlayan bir keyworddür.
            //Metod içerisinde herhangi bir yerde kullanılabilir.
            //İki nokta(:) geri dönülebilecek başlangıç noktasını belirler.
            //Gerekmediği sürece kullanılmamalıdır.

            /*a:
                Console.WriteLine("asd"); // sonsuza kadaar yazdırılır.
                goto a;*/

            //ÖRNEK ==> 1'den yüze kadar sayma
            /*int i = 1;
        x:
            Console.WriteLine(i++);
            if (i < 100)
            goto x;
            Console.ReadLine();*/
            #endregion

            // EKSTRA BİLGİLER //
            #region
            //BİLGİ1 ==> İçi boş sonsuz döngüyü en sade tanımlama
            //while (true) ;
            //for (; ; );
            //do;
            //while (true);

            //BİLGİ2 ==> İçi boş if yapısını en sade tanımlama
            //if (true);
            #endregion
        }
    }
}
