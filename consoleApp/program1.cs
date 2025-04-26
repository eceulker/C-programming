/*
StreamReader sr = File.OpenText("deneme.txt");

var s ="";

Console.WriteLine(sr.ReadLine());
*/
/*
StreamReader sr = File.OpenText("deneme.txt");

var s ="";


while((s = sr.ReadLine()) != null) {
   Console.WriteLine(sr.ReadLine());   
}
*/
//string sonuc = File.ReadAllText("deneme.txt");
/*
string[] sonuc = File.ReadAllLines("deneme.txt");
Console.WriteLine(sonuc[0]);
Console.WriteLine(sonuc[2]);
*/

//dosya okuma
/*
StreamWriter sw = File.CreateText("deneme.txt");
sw.WriteLine("Merhaba");
sw.WriteLine("btk");
sw.WriteLine("AKADEMİ");

sw.Close();// kapatmamız gerekiyor
*/
/*
using (StreamWriter sw = File.CreateText("deneme.txt")){
  sw.WriteLine("Merhaba");
  sw.WriteLine("btk");
  sw.WriteLine("AKADEMİ");
}
//içeriği siler ve bu bilgileri ekler(using)dosya sıfırlanır
using(StreamWriter sw = File.AppendText("deneme.txt")){
  sw.WriteLine("Selam");
  sw.WriteLine("btk");
  sw.WriteLine("AKADEMİ");
}
//bilgiler eklenir
*/
/*
File.WriteAllText("deneme.txt", "merhaba");
File.AppendAllText("deneme.txt", "merhaba");

using(StreamReader sr = File.OpenText("deneme.txt")) {
    var s = "";

    while((s = sr.ReadLine()) != null) {
        Console.WriteLine(s);
    }
}
*/

//Klasörle Çalışma
//Directory.CreateDirectory("temp");
//Directory.CreateDirectory("temp/deneme");
//Directory.CreateDirectory("temp/deneme2");
/*
if(Directory.Exists("temp/deneme2")) {
    Directory.Delete("temp/deneme2");
} else {
    Console.WriteLine("silmek istediğiniz klasör yok");
}
*/

//string path = @"C:\temp";
//string path = "/Users/sadikturan/Desktop/temp/deneme";

//doğrudan ulaşmak istediğimizde 
/*
string path = Directory.GetCurrentDirectory() + "/temp";

Console.WriteLine(path);

Directory.CreateDirectory(path);
*/

/*
string rootPath = Directory.GetCurrentDirectory();

string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly)// AllDirectoryOnly dersek hepsinii
 
foreach(var dir in dirs) {
    Console.WriteLine(dir);
}
*/
/*
string rootPath = Directory.GetCurrentDirectory();
string[] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);//.txt ile filtre ekledik

foreach(var file in files) {
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));
     
     var info = new FileInfo(file);

     Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
}
*/
/*
string rootPath = Directory.GetCurrentDirectory();
string[] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);//.txt ile filtre ekledik

foreach(var file in files) {
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));
     
     var info = new FileInfo(file);

     Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");
}
*/
