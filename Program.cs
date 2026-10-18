//Zad 1

string imie = "abcd";
char symbol = '#';
int poziom = 3;
int zloto = 45;
double waga = 8.5;
bool mapa = false;

Console.WriteLine("****EKWIPUNEK****");
Console.WriteLine($"Imię (string): {imie}");
Console.WriteLine($"Symbol (char): {symbol}");
Console.WriteLine($"Poziom (int): {poziom}");
Console.WriteLine($"Złoto (int): {zloto}");
Console.WriteLine($"Waga (double): {waga} kg");
Console.WriteLine($"Ma mapę (bool): {mapa}");

//zad 2

int pktPoczatek = 40;
int zlotoPoczatek = 20;
int ileTreningów = 0;

int pktKoniec = pktPoczatek + 25;
pktKoniec *= 2;
int zlotoKoniec = zlotoPoczatek - 8;
zlotoKoniec += 15;

Console.WriteLine($"Na Poczatek doswiadczenia: {pktPoczatek}");
Console.WriteLine($"Na koniec doświadczenia: {pktKoniec}");
Console.WriteLine($"Na poczatek złota: {zlotoPoczatek}");
Console.WriteLine($"Na koniec złota: {zlotoKoniec}");

//zad 3

Console.Write("Racje: ");
decimal racje = decimal.Parse(Console.ReadLine()!);

Console.Write("Ile w drużynie: ");
decimal druzyna = decimal.Parse(Console.ReadLine()!);

Console.Write("Ile dni wyprawy: ");
decimal dniWyprawy = decimal.Parse(Console.ReadLine()!);

decimal ileRacji = racje / druzyna;
decimal ileZostanie = racje % druzyna;
decimal ileDruzyna = racje / dniWyprawy;
decimal ileOsoba = racje / (dniWyprawy * druzyna);

Console.WriteLine($"Racje na osobe: {ileRacji}");
Console.WriteLine($"Ile zostanie: {ileZostanie}");
Console.WriteLine($"Ile dziennie na drużyne: {ileDruzyna}");
Console.WriteLine($"Ile dziennie na osobe {ileOsoba}");
