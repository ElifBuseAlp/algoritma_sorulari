//--------------algoritma soruları----------

/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
*/
/*
Console.WriteLine("Lütfen Bir pozitif sayı giriniz: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Dizi elemanlarını giriniz: ");

int[] dizi = new int[n];

for(int i = 0;i < n;i++) // array elemanlarını aldık
{
     dizi[i]= Convert.ToInt32( Console.ReadLine());
}

methodlar ornek = new methodlar();

Console.WriteLine("Dizideki çift elemanlar: ");

for (int i = 0; i < n; i++)
{    
    if(ornek.isEven(dizi[i]))
    Console.WriteLine(dizi[i]);
}
*/

/*
Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


Console.WriteLine("Lütfen iki adet pozitif sayı giriniz: ");

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen "+ n +" Elemanlı Dizi elemanlarını giriniz: ");

int[] dizi = new int[n];

for(int i = 0;i < n;i++) // array elemanlarını aldık
{
     dizi[i]= Convert.ToInt32( Console.ReadLine());
}

methodlar ornek = new methodlar();

for (int i = 0; i < n; i++)
{    
    if(ornek.Bolunebilir(dizi[i], m))
        Console.WriteLine(dizi[i]);
}
*/
/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


Console.WriteLine("Lütfen Bir pozitif sayı giriniz: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen "+ n +" adet kelime giriniz: ");

string[] dizi = new string[n];

for(int i = 0 ;i < n; i++) // array elemanlarını aldık
{
     dizi[i]=  Console.ReadLine();
}

  for (int i = n-1; i >= 0; i--) ////methodsuz çalışan kod
        {
            Console.WriteLine(dizi[i]);    
        }
*/

/*
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
Çözüm: harf sayısını boşlukları silip stringi array e atayıp item adetine bakarak yapabiliriz.
*/

Console.WriteLine("Lütfen Cümlenizi Yazın: ");

string metin  = Console.ReadLine();

string[] n = metin.Split(' ');

foreach (var item in n)
{
    Console.WriteLine(item);
}

int a  =  n.GetLength(0); //arrayde kaç eleman olduğunu bulur

Console.WriteLine(" bu arrayde " + a + " kelime mevcuttur.");

Console.WriteLine(metin.RemoveWhiteSpaces());

string metin2 = metin.RemoveWhiteSpaces();  //metindeki boşlukları silip metin2'ye atadım

//metin2 yi arraya dönüştürmem gerek veya string in içerdiği karakteri bulan bir method bulmalıyım

int z = metin2.Length;  //stringin kaç karakter içeridğini bulur.

Console.WriteLine("Bu cümle " + z + " adet karakter içeriyor");






Console.ReadLine();











Console.ReadLine();

 class methodlar //yeni class oluşturdum
{
    public bool isEven ( int a)
    {
        return a %2 == 0;
    }
        public bool Bolunebilir ( int a, int b)
    {
        return a % b == 0;
    }
    public void sondanBasaYazdirma (string[] dizi , int n) //kullanamadım
    {
        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine(dizi[i]);   
        }
    }
 
}

public static class extensions 
{
   public static string RemoveWhiteSpaces(this string param)// metindeki boşlukları siler
    {
        string[] dizi = param.Split(" ");  //bu stringi boşluklara göre ayır ve bir diziye at
        return string.Join("",dizi); // diziyi boşluksuz olarak birleştirir, istenen char eklenebilir ilk parametreye
    }
    
    }