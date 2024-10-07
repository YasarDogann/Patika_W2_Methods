# Patika Week2 Method Alıştırma Uygulaması
Merhaba,
Bu proje C# ile Method çeşitleri kullanarak alıştırma için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.

## Not
program.cs klasöründe tek sayfada 4 soruyu bilerek yazdım yapılarını tek sayfada görebilmek adına. Karışıklık olmamasına adına aşağıda ayrı olarak eklenmiştir.

## 🚀 1. Soru Kod
```csharp
  //1.Geriye Değer Döndürmeyen Bir void metot.
public static void Song()
{
    Console.WriteLine("Mutlu Son Olmasın Mutlu Sonsuz Olsun");
}

 static void Main(string[] args)
 {
     //1.SORU
     Song();

     Console.Read();
}
```

## 🚀 2. Soru Kod
```csharp
  //2.Geriye Tamsayı Döndüren Bir metot
public static int Number()
{
    Random rand = new Random();
    int num = rand.Next(1,100);
    Console.WriteLine("Üretilen sayı: "+num);

    return num % 2;
}

 static void Main(string[] args)
 {
     //2. SORU
     int result = Number();
     Console.WriteLine(result);
     Console.Read();
}
```

## 🚀 3. Soru Kod
```csharp
//3.Parametre Alan ve Geriye Değer Döndüren Bir Metot
public static int Carp(int num1, int num2)
{
    return num1*num2;
}

 static void Main(string[] args)
 {
     //3.SORU
int result_carp = Carp(5, 2);
Console.WriteLine("iki sayının çarpımı: "+result_carp);
     Console.Read();
}
```

## 🚀 4. Soru Kod
```csharp
//4.Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
public static void Message(string name, string surname)
{
    Console.WriteLine("Hoşgeldiniz {0} {1}", name, surname);
}

 static void Main(string[] args)
 {
     //3.SORU
//4.SORU
Message("Mauro","Icardi");
     Console.Read();
}

