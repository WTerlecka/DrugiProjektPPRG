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
Console.WriteLine($"Ma mapę (bool): {mapa}\n");

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
Console.WriteLine($"Na koniec złota: {zlotoKoniec}\n");

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
Console.WriteLine($"Ile dziennie na osobe {ileOsoba}\n");

//zad 4

Console.Write("Ile punktów życia: ");
int pktZycia = int.Parse(Console.ReadLine()!);

Console.Write("Ile mikstur: ");
int lbMikstur = int.Parse(Console.ReadLine()!);

Console.Write("Czy masz klucz: ");
bool klucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy masz mape: ");
bool czyMapa = bool.Parse(Console.ReadLine()!);

bool zyje = pktZycia > 0;
bool maPelneZdrowie = pktZycia == 100;
bool wymagaLeczenia = !maPelneZdrowie;
bool maZaopatrzenie = lbMikstur >= 1;
bool maPrzedmiotNawigacyjny = klucz || czyMapa;
bool gotowyDoWyprawy = zyje && maZaopatrzenie && maPrzedmiotNawigacyjny;

Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Ma pełne zdrowie: {maPelneZdrowie}");
Console.WriteLine($"Wymaga leczenia: {wymagaLeczenia}");
Console.WriteLine($"Ma zaopatrzenie: {maZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mapę: {maPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}\n");

