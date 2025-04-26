/*Soru1
var toplam  = 0;

for(var i=1; i<= 100; i++ ) {
    toplam += i;
   
}
 Console.WriteLine(toplam);


 var toplam  = 0;

for(var i=1; i<= 100; i++ ) {
   if (i % 2 == 1){
    toplam += i;
   } 
   
}
 Console.WriteLine(toplam);
*/

//Soru2
/*
Console.Write("baslangic: ");
var baslangic = Convert.ToInt32(Console.ReadLine());

Console.Write("bitis: ");
var bitis = Convert.ToInt32(Console.ReadLine());

Console.Write("artıs: ");
var artis = Convert.ToInt32(Console.ReadLine());

var toplam = 0;
for(var i = baslangic; i < bitis; i = i + artis) {
    toplam += i;
}
Console.WriteLine(toplam);
*/
//Soru3
/*
string[] isimler = {"ali","mehmet","can","mert","emre"};

for(var i = 0; i < isimler.Length; i++){
    Console.WriteLine(isimler[i]);
}
*/
//Soru4
/*
int[] sayilar = {1,3,4,34,41,56,89,100};

for(var i = 0; i < sayilar.Length; i++){
    if(sayilar[i] % 3 == 0) {
        Console.WriteLine(sayilar[i]);
    }
}
*/
//Soru5
/*
var i = 0;
while(i<10){
    Console.WriteLine(i);
    i++;
}
*/
/*
string[] isimler = {"ali","mehmet","can"};

var i = 0;
while(i < isimler.Length) {
    Console.WriteLine(isimler[i]);
    i++;
}
*/
/*
var secim = "e";
var sayac = 1;
var toplam = 0;

while(secim == "e") {
    Console.Write($"{sayac}. sayı ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.Write("devam etmek istiyor musun? (e/h)");
    secim = Console.ReadLine();

    sayac++;
}
Console.WriteLine($"{sayac-1} adet sayısının ttoplamı: {toplam}");
*/
//SoruTahmin(Soru6)
/*
var rnd = (new Random());
int tutulan = rnd.Next(1,100);
int hak = 3;

while(hak > 0) {
    Console.WriteLine(tutulan);

    Console.Write("sayi: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if(sayi == tutulan) {
        Console.WriteLine("tebrikler bildiniz");
        break;
    }
    else {
        if(hak == 0) {
            Console.WriteLine("oyun bitti");
            break;
        }
        if(tutulan > sayi) {
            Console.WriteLine("yukarı");
        }
        else {
            Console.WriteLine("asagı");
        }
    }
}
*/
//Do-While(7)
/*
int i =1;
do {
    Console.WriteLine(i);
    i++;

}while(i < 10);
*/
/*
Console.Write("adet: ");
int adet =Convert.ToInt32(Console.ReadLine());

string[] urunler = new string(adet);

int i = 0;

do {
    Console.Write("ürün adı: ");
    urunler[i] = Console.ReadLine() ?? "";

    i++;
}while(adet != i);

Console.WriteLine("urunler listeleniyor...");

for(var a = 0; a < urunler.Length; a++) {
    Console.WriteLine(urunler[a]);
}
*/
//foreach(8)

//string ad = "Can";
/*
for(var i = 0; i < ad.Length; i++) {
    Console.WriteLine(ad[i]);
}
*/
/*
foreach(var harf in ad) {
    Console.WriteLine(harf);
}

int[] sayilar = [10,20,30,40];

foreach(var sayi in sayilar) {
    Console.WriteLine(sayi);
}
*/
