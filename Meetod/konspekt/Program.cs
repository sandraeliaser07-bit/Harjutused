//1.  tuvasta sisu võrdluses tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("tere kasutaja, mis su nimi on");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("sa ei sisstanud enda mine😭");
}
else if (nimi != "")

{
    Console.WriteLine("tere " + nimi + "🍆");
}
else
{
    Console.WriteLine("tundmatu sisestus");
}
//2- vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust peasastatud ifide abil
/* if (kasutajavanus > 0)
        {
    if (kasutajavanus < 18)

    {
        Console.WriteLine("emerksi ei saa, alakas, poest valja (┬┬﹏┬┬)");
    }
    else
    {
        Console.WriteLine("naudi enda sydamerabandust ^o^");
    }
}
*/
//2.2 mitu tingimust kasutades loogilist tehet "and"

if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("enerksi ei saa, alakas, poest välja marakratt ╰(*°▽°*)╯");
}
else
{
    Console.WriteLine("oled piisavalt vana, et enda vedel sydamerabandust osta");
}

//2.3 mitu vahemiku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"sisesta oma pikkus ka {nimi}");
double kasutajapikkus = double.Parse(Console.ReadLine());
if (kasutajapikkus < 1.00d)
{
    Console.WriteLine("oled midget T_T");

}
else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
{
    Console.WriteLine("naise pikkus noormehe kohta,(┬┬﹏┬┬) " + nimi);
}
else if (kasutajapikkus < 1.50d && kasutajapikkus >= 1.25d)
{
    Console.WriteLine("Aasiapärane pikkus eesti mehe kohta, läheb paremaks aga ikka lyhike ");
}
else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.50d)
{
    Console.WriteLine("Oled juba päris hea pikkusega, alla eesti mehe keskmise aga palju parem");
}
else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)

{
    Console.WriteLine("norm vend oled, päris pikk");
}


int arv1 = 0;
int arv2 = 0;
Console.WriteLine("tere, palun sisestage esimene arv:");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("sisestage teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("missugust tehet soovid teha? kirjuta kas + - / * ^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+" /* tingimus siia*/)

{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-"/* tingimus siia*/)

{
    tehe = arv1 - arv2;

}
if (tehtetüüp == "*"/* tingimus siia*/)

{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "/"/* tingimus siia*/)
{
    tehe = arv1 / arv2;
}
if (tehtetüüp == "^"/* tingimus siia*/)
{
    tehe = (int)Math.Pow(arv1, arv2);
}
Console.WriteLine($"{tehtetüüp} tehte tulemus: {tehe}");





//4 parool, if ja string andmetüüp

Console.WriteLine($"palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("rahuldav parool");

}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("parool on sobimatu, see sinu parool kindlasti ei ole.");

}
else
{
    Console.WriteLine("parool on vale");

}

//5 värvitavus
Console.WriteLine("mis on sinu lemmik värv?");
string favcolour = Console.ReadLine();
if (favcolour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favcolour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favcolour == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favcolour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favcolour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favcolour == "hall")
{
    Console.BackgroundColor = ConsoleColor.Gray;
}
else if (favcolour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favcolour == "tume sinine")
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
}
else if (favcolour == "pruun")
{
    Console.WriteLine("seda värvi pole");
}
else if (favcolour == "lilla")
{
    Console.WriteLine("seda värvi pole");
}
else if (favcolour == "roosa")
{
    Console.WriteLine("seda värvi pole");
}
else if (favcolour == "oranz")
{
    Console.WriteLine("seda värvi pole");
}
else if (favcolour == "helesinine")
{
    Console.WriteLine("seda värvi pole");
}
Console.WriteLine("siin su värv (❁´◡`❁)");
/* Meetodid
meetodid on väljakutsutavad koodijadad. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
meetodid lasevad programmeerijal taaskasutada ome eelnevalt kirjutatud koodi - write once us many times
meetodeid on kahte liiki- ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta midagi, kuid omavad siiski mingit tegevust

Meetodi signatuur:
meetodi signatuu koosneb mitmest kindlalt äramääratud omadusest, nendeks on:
-juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodilejuurde pääseda saab
public- meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub
private- meetod on saadav ainult selles klassis, kus meetod ise asub
protected- meetod on saadaval ainultselles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus sellele klassile
internal- meetod on saadaval ainult selles klassis ja ainult selles failis.
võibolla ka pandud static- meetod kuulub selle klassi juurde
tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta
andmetüüp mida tagastada võibolla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta üldse andmeid
pannakse selle asemel andmetüübiks "void". kui meetodil on tagastustüüp mis on midagi muud kui void
on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb,et just see, on vaja
väljakutseasukota tagastada, ning peale returni on muutuja nimi tagastatava infoga. peale return lauset, ei
teostata mitte ühtegi muud meetodi sisu. return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö

1. tüüpi meetod- ei tagasta midagi
public static void uusmeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static"  ütleb et ta on
selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta ning pärast meetodi omadusi on meetodi nimi uusmeetod
peale mida on sulus, kus parameetreid ei ole
pärast signatuuri on koodiplokk meetodi koodiga {}
console.writeline("tere"); antud juhul metod kuvab konsooli sõnumi

2. tüüpi meetod- tagastab väärtuse
int[] arvutatudarvud = new int[] {3, 67, 420}; töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega "arvutatudarvud"
public static int arvutakokku(int[] arvud)
meetod, mille signatuuris on juurdepääsumodifikaator public, static ütleb et meetod kuulub siia klassi, tagastustüüp int ütleb,
et programmis väljakutseasukohta tagastatakse täisarv, peale seda on meetodi nimi "arvutakokku" ning sulgude vahel ootab meetod täisarvumassiivi
millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on koodiplokk {} tehtava koodiga
int summa = 0; tekitatakse täisarvuandmetüüpi muutuja nimega summa, kuhu esialgu omistatakse arv 0.
foreach (int  i in arvud) foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi

summa += i; ja muutujale summa lisatakse juurde, hetkel käidav element.

return summa; pärast tsükli töö lõppu tagastatakse return käsu abil, muutuja summa sisu.

 */

//string lause = "Tere  hommikust, mul on monster otsas, kas ma võin veel magada?";
//Console.WriteLine("lause pikkus on: " + lause.Length);
//Console.WriteLine("see tekst on capslockis:" + lause.ToUpper());
//Console.WriteLine("see tekst on väiketähtedes:" + lause.ToLower());
//Console.WriteLine("kas lauses on sõna \"magada\"?:" + lause.ToLower().Contains("magada"));
/*
List<string> list = new List<string>() { "auto", "kraav", "kruus" };
string listkoos = "";
foreach (var sõne in list)
{
    listkoos += ("" + sõne.ToUpper() + ",");
}
Console.WriteLine(listkoos);

string eesnimi = "Julius";
string perekonnanimi = "Caesar";
string amet = "Ohver";
string kuuluskeiser = string.Concat(eesnimi, perekonnanimi, amet);
Console.WriteLine(kuuluskeiser);


string kuulukeiser2 = $"{eesnimi}, {perekonnanimi}, {amet}.";
Console.WriteLine($"{eesnimi}, {perekonnanimi}, {amet}.");
Console.WriteLine(kuulukeiser2);
*/
/*
string[] sõnadlauses = lause.Split(' ');
foreach (var sõne in sõnadlauses) ;
{
    Console.WriteLine(sõne);
}
string ükssõna = "kuulilennuteetunneliluuk";
Console.WriteLine(ükssõna[4]);
Console.WriteLine(ükssõna.IndexOf("i"));
*/
//Console.WriteLine("\" ");

//Console.WriteLine(" a\nb ");

//Console.WriteLine("AAAAA");
�/*

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
}
else if (nimi != "")
{
    Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2 - vahemikud
Console.WriteLine(nimi+", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());

//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if (kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
//    }
//    else
//    {
//        Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
//    }
//}

//2.2 mitu tingimust kasutades loogilist tehet "and"
if (kasutajavanus > 0 && kasutajavanus < 18)
{
    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
}
else
{
    Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
}

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled juntsu (Keemstar)");
}
else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaaegu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
}
else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
{
    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
}
else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
{
    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
}
else
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
}

//3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
Console.WriteLine("tere, sisesta esimene liidetav arv");
int arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("tere, sisesta teine liidetav arv");
int arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("sisesta tehemärk: / * + - ^");
string tehtetyyp = Console.ReadLine();

int tulemus = 0;
if (tehtetyyp == "+")
{
    tulemus = arv1 + arv2;
}
if (tehtetyyp == "-")
{
    tulemus = arv1 - arv2;
}
if (tehtetyyp == "*")
{
    tulemus = arv1 * arv2;
}
if (tehtetyyp == "/")
{
    tulemus = arv1 / arv2;
}
if (tehtetyyp == "^")
{
    tulemus = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine(tulemus);

//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
}
else if (password == "saatana" || password == "1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5 värvituvastus värvidele: punane oranz kollane roheline
// helesinine tumesinine lilla roosa pruun must ja valge
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "oranz")
{
    Console.WriteLine("Kahjuks ei ole oranz saadaval");
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
}
else if (favColour == "helesinine")
{
    Console.BackgroundColor = ConsoleColor.Cyan;
}
else if (favColour == "tumesinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "lilla")
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
}
else if (favColour == "roosa")
{
    Console.WriteLine("Kahjuks roosat anda ei ole");
}
else if (favColour == "pruun")
{
    Console.BackgroundColor = ConsoleColor.DarkYellow;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
}
else
{
    Console.WriteLine("ei tea seda värvi");
}
Console.WriteLine("The colour has maybe changed!!!!!");
*/
/* ISESEISEV ÜLESANNE */

//# Kolija kalkulaator - Kirjuta programm mis:
//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//Console.WriteLine("Kas tahad mõõta ära kasti või tünni?");
//string valik = Console.ReadLine();
////#    - olenevalt kasutaja sisestusest küsib ta:
//if (valik == "tünn")
//{

//    //#    - - tünni jaoks:
//    //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//    Console.WriteLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mõõt:");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if(rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }

//    //#    - - - tünni kõrgust
//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());

//    //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//    Console.WriteLine("kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());

//    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on{kogupindala}");
//}
////#    - - kasti jaoks:
//else if(valik == "kast")
//{
//    //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//        Console.WriteLine("Sisesta kasti küljepikkus:");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on{diagonaal}");
//    }
//    //#    - - - - kui on risttahukas siis küsib kasutajalt:
//    else if (kastitüüp == "r")
//    {
//        //#    - - - - - pikima külje pikkust, 
//        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
//        double pikkKülg = double.Parse(Console.ReadLine());

//        //#    - - - - - lühima külje pikkust ja
//        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
//        double lühikekülg = double.Parse(Console.ReadLine());

//        //#    - - - - - kasti kõrgust
//        Console.WriteLine("Mis on sinu kasti kõrgus?:");
//        double kõrgus = double.Parse(Console.ReadLine());

//        //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
//        double V = pikkKülg * lühikekülg * kõrgus;
//        double kogupindala = 2 * ((pikkKülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkKülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkKülg * pikkKülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
//        Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \nDiagonaal aga on{diagonaal}");
//    }

//}

//Console.WriteLine("banana");
//// Console -> adresseritav moodul või objekt (Roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
////    - komakohtadega andmetüüpidel komakoha tähistamine.
//// WriteLine -> adresseritav funktsioon objektist Console
//// () -> sulupaar mis omab endas funktsioonile vajalikku infot
////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
////     - kasutatakse ka matemaatilistes tehetes
//// [] -> tähistab massiive
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
////     - saab ka kasutada teksti sees muutujate kuvamiseks
//    // -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
//// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
//// ; -> iga koodilause lõppeb komakooloniga
//// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)

//int muutuja = 3;
//// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud lihtandmetüübid:
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1; // täisarv
        decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
        float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
        double d = 4.01d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
        char c1 = 'a'; // üksainus täht või tähemärk
        string s = "tekst"; // inimloetaval kujul tekst
        var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
        var y = 123;
        const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only
        //void - void on andmetüüp, mida muutujatele anda ei saa. void on andmetüüp, mida kasutatakse meetodite jms
        //signatuurides, et näidata tagastatava andmetüübi puudumist. Tegemist on - sõna otseses mõttes - mitte millegagi.

        //võimalikud komposiitandmetüübid:
        // 1. massiiv:
        // [] -> Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
        //       Massiive saab olla ükskõik millist lihtandmetüüpi massiive.
        //       Massiivi tekitamisel tuleb ära öelda kui pikk või suur see massiiv on
        //       Massiiv saab olla koostatud ka teistest massiividest.
        //
        // Esimene tekitusviis:
        int[] arvuMassiiv = new int[3]; // andemtüüp int väljendab et tegu on täisarvutüüpoi andmega ja kantsulud väljendavad et tegu ühtlasi
                                        // ka massiiviga. nimeks on "arvuMassiiv" ja võrdusmärgiga, on esimene tekitusmoodus öelda et tegu on
                                        // uue massiiviga kasutades kaitsud sõna "new", ja sellele järgneb massiivi pikkuse sätestus "int[3]"
                                        // see tähendab et siin massiivis on 3 elementi, mis on täisarvud.
                                        // Teine tekitusviis:
        int[] arvuMassiiv2 = [1, 2, 3];   // teine massiivi tekitusviis, kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe sisse
                                          // järjendi pikkus tuletatakse elementide arvust
                                          // -- massiivi sisemised meetodid:
        int hasthismany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
                                              // elementi järjendis parasjagu on

        // 2. loend:
        // List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
        //            Täiendava andmetüübikirjeldusega "List" mille järel noolsulgudesse asetatakse mis tüüpi andmed loendis on.
        //            Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde
        //            lisada, ehk tema pikkus ei ole fikseeritud.
        //            Sarnaselt massiiviga, saab loend omada endas, teisi loendeid.
        //
        // Esimene tekitusviis:
        List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, List noolsulgude vahel on loendis
                                                  //olevate andmete andmetüüp. muutuja nimeks on "arvuNimekiri". Omistame sellesse muutujasse 
                                                  //kaitstud sõna "new" abil uue tühja täisarvuloendi sätestusega "List<int>()". 
                                                  // Teine tekitusviis:
        List<int> arvuNimekiri2 = new List<int>() { 1, 2, 3 }; //teine loendi tekitusviis, muutuja instantsieerimine võrdusmärgi ees on sama nagu
                                                               //esimesel, juurde tuleb ainult võrdusamärgi taga olevale sätestusele loogelised
                                                               //sulud koos juba sinna asetatud elementidega. Enam ei ole tegu tühja nimekirjaga,
                                                               //vaid loendiga kus on kolm elementi.
                                                               // Kolmas tekitusviis:
        List<int> arvuNimekiri3 = new List<int>(3); //kolmas loendi tekitusviis kus muutuja instantsieerimine jääb samaks, aga, tavaliste sulgude
                                                    //vahel, sarnaselt massiiviga, saame anda loendile esialgse suuruse. Loend ise ei oma veel
                                                    //andmeid, aga loendis on kolm tühja elementi. Nimelt, on sätestusel, peale andmetüüpi
                                                    //kirjeldavaid noolsulge, paar tavalisi sulge, mille sisse saab parameetrina panna loendi
                                                    //pikkuse. ()
                                                    // -- Loendi sisemised meetodid:
        arvuNimekiri3.Add(67); // Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisada, on Add meetodi
                               // sulgude vahel. Elementi saab lisada otse (antud juhul "67") või muutujana - näiteks ...Add(arv);
        int loendiPikkus = arvuNimekiri3.Count(); // Loendi meetod "Count()" loeb kokku mitu elementi järjendis on, meetod tagastab täisarvu 
                                                  //mis vastab elementide kogusele.
        bool kasSeeArvOn = arvuNimekiri3.Contains(3); // Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude vahel
                                                      // olevale parameetrile, tagastab kas true või false - on leitud või ei ole. Tegemist on
                                                      // põhimõtteliselt foreach tsükliga, mis otsib kindlat parameetrid, töödeldes läbi, kogu
                                                      // loendi.
        arvuNimekiri3.Remove(4); // Loendi meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulgude
                                 //vahel on parameetriks eemaldatava elemendi asukohajärjekorranumber.

        ////põhilised matemaatilised tehted
        //int liitmine = 1 + 1; // liitmine, kaks arvu kokku
        //int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
        //int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
        //int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
        //double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
        //double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

        /* Matemaatilised tehted moodulist math */

        Math.Round(d); //Moodulist "Math" kutsutakse punkti abil esile meetod "Round". Sulgude vahel on ümardatav arv.
                       //Round ümardab sulgude vahel olevas muutujas asetseva arvu, vastavalt komakohtade parameetrile.
                       //Vaikeväärtusena, lähima täisarvuni. 0-4 on allapoole, 5-9 on ülespoole.
        double newpi = Math.PI; //Moodulist "Math" kutsutakse punkti abil esile kaitstud väärtus, PI mis väljendab matemaatilist
                                //pi-d ning saab kasutada kui tavaline arv.
        double astendus = Math.Pow(2, 2); //Moodulist "Math" kutsutakse punkti abil esile meetod "Pow" (power). Sulgude vahel on
                                          //Kaks parameetrit, esimene on neist Astendatav ja teine astendaja. antud jugul oleks
                                          //vastuseks 16.


        //int arv = 0; // sobib
        //string sõne = "abc"; //sobib
        //string string = "abc"; //ei sobi

        // muutuja nimeks ei sobi järgnevad sõnad:
        //abstract, as, base, bool, break, byte, case,
        //catch, char, checked, class, const, continue, decimal,
        //default, delegate, do, double, else, enum, event,
        //explicit, extern, false, finally, fixed, float, for
        //foreach, goto, if, implicit, in, int,
        //interface, internal, is, lock, long, namespace, new,
        //null, object, operator, out, override, params,
        //private, protected, public, readonly, ref, return, sbyte,
        //sealed, short, sizeof, stackalloc, static, string, struct,
        //switch, this, throw, true, try, typeof, uint,
        //ulong, unchecked, unsafe, ushort, using, virtual, void,
        //volatile, while.

        ////Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
        Console.WriteLine("tere, sisesta esimene liidetav arv");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        int arv1 = int.Parse(Console.ReadLine());
        // instantsieerime muutuja "arv1", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
        // mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
        // asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
        Console.WriteLine("tere, sisesta teine liidetav arv");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        int arv2 = int.Parse(Console.ReadLine());
        // instantsieerime muutuja "arv2", ning ütleme et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
        // mille saame kasutajalt Console.Readline() abil (kasutame moodulist "Console" realugemisfunktsiooni), ning teisendame int andmetüübis
        // asuva funktsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõpumärgiga ; .
        Console.WriteLine("sisesta tehemärk: / * + - ^");
        //Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
        // mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
        string tehtetyyp = Console.ReadLine();
        // tekitame muutuja "tehtetyyp", mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle
        // konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. lause lõppeb lauselõpumärgiga ; ..

        int tulemus = 0;
        // instantsieerime muutuja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0. Lause lõpp lõpeb lauselõpumärgiga
        if (tehtetyyp == "+")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "+"
        {
            tulemus = arv1 + arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus liites kokku
        // muutuja arv1 ja muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "-")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "-"
        {
            tulemus = arv1 - arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus lahutades
        // muutujast arv1 muutuja arv2. Lause lõppeb lauselõpumärgiga sulgude sees.  
        if (tehtetyyp == "*")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "*"
        {
            tulemus = arv1 * arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus korrutades
        // muutuja arv1 ja muutuja arv2 sisu omavahel kokku. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "/")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "/"
        {
            tulemus = arv1 / arv2;
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus jagades
        // muutuja arv1 muutujaga arv2. Lause lõppeb lauselõpumärgiga sulgude sees.
        if (tehtetyyp == "^")
        // teeme tingimuslause if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõne "^"
        {
            tulemus = (int)Math.Pow(arv1, arv2);
        }
        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida, kus muutujasse tulemus omistatakse nüüd väärtus kasutades
        // moodulist "Math" punkti abil funktsiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
        // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Lause lõppeb lauselõpumärgiga sulgude sees.

        Console.WriteLine(tulemus);
        // Adresseerime moodulit "Console", ning kasutame sealt funktsiooni "WriteLine" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus.
        // lause lõppeb lauselõpumärgiga.


        Console.WriteLine("Sisesta ostusumma");
        double ostusumma = double.Parse(Console.ReadLine());
        if (ostusumma > 100)
        {
            Console.WriteLine("Saad 20% allahindlust!");
        }
        else if (ostusumma < 101 && ostusumma > 50)
        {
            Console.WriteLine("saad10%allahindlust");
        }
        else if (ostusumma < 51 && ostusumma > 20)
        {
            Console.WriteLine("Saad 5% allahindlust");
        }
        else if (ostusumma < 21)
        {
            Console.WriteLine("Allahindlust ei saa :C");
        }
        else if (ostusumma < 1)
        {
            Console.WriteLine("Sisestatud vigane arv");
        }

        //string kasutajaNimi = "";
        //do
        //{
        //    Console.WriteLine("Palun sisesta oma kasutajanimi");
        //    kasutajaNimi = Console.ReadLine();
        //}
        //while (kasutajaNimi != "user1");
        //if (kasutajaNimi == "user1")
        //{
        //    int ruuduSuurus = 0;

        //    do
        //    {
        //        Console.WriteLine("Kui suurt ruutu tahad?");
        //        ruuduSuurus = int.Parse(Console.ReadLine());
        //    } while (ruuduSuurus < 0 && ruuduSuurus > 20);
        //    char reaKujund = '▓';
        //    string üksRida = "";
        //    int tsükliMuutuja = ruuduSuurus;
        //    do
        //    {
        //        üksRida += "_" + reaKujund;
        //        tsükliMuutuja -= 1;
        //    } while (tsükliMuutuja != 0);
        //    tsükliMuutuja = ruuduSuurus;
        //    do
        //    {
        //        Console.WriteLine(üksRida);
        //        tsükliMuutuja -= 1;

        //    } while (tsükliMuutuja != 0);
        //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
        //}

        /* tingimuslause osad */
        if (true) { } //kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb
                      //koodiplokk tingimuse täitumisel teostatava koodiga
        else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                           //on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
                           //ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood
        else { } //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas if või else if, ning mille koodi-
                 //ploki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

        int option = 3; // -------
        switch (option) //"switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada.
                        //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
                        //ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
        {               //pärast lülitusvalikut tuleb koodiplokk
            case 1:     //koodiploki sees on erinevad juhtumid. juhtumit kontrollitakse kaitstud sõna "case" abil. Antud juhul
                        //kontrollitakse, kas muutujas on väärtus 1, millele järgneb koolon ":"
                        //peale koolonit kirjeldatakse tehtav tegevus
                break;  //ja kui tegevus on täidetud, väljutakse kogu switch tegevusest kaitstud sõna "break"iga. Peale "break"i
                        //on lauselõpumärk ";"
            case 2:
                break;
            case 3:
                break;
            //juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt, ja üks mida tehakse igal muul juhul.
            default:    //kaitstud sõna "default" avab juhtumi kui muutujas ei ole mitte ühtegi muud "case" juhtumi tingimust.
                break;  //Ka default lüppeb sõnaga "break;"
        }

        /* Sõne tööriistad jm tekstiga seotud */
        string alfa = "a\nb";    // \n -> tekitab ühe sõne sisse reamurde, sõne kus on üks "\n" omab kahte rida
        string beta = $"a {alfa} b"; // $  -> lubab kasutada muutujaid loogeliste sulgude vahel otse teksti sees

        /* Loogilised tehted */
        // && -> "and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
        //      mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
        // || -> "or" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui
        //      vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
        // !  -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
        //       puhul tagastab false, ja vastupidi - tulemus mis muidu tagastaks false, hüüumärgi puhul tagastab true.

        /* Võrdlusoperaatorid */
        // == -> on võrdne. Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt Võrdusmärkide teisel pool oleva
        //       objektiga. ei ole sama nagu üks võrdusmärk. üks võrdusmärk omistab, kaks võrdleb.
        // != -> ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
        //       Võrdlusoperaator on kombinatsioon "on võrdne" operaatorist, ja loogilisest tehtest "not".
        // >  -> on suurem kui. Märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt.
        // <  -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
        // >= -> on suurem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
        //       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
        // <= -> on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem
        //       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

        /* Omistusoperaatorid ja kiirtehted */
        int arv = 1;// =  -> üksik võrdusmärk omistab muutujale väärtuse.
        arv += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                    //       asendab tehet "arv = arv + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest ("=")
        arv -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse.
                    //       asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest ("=")
        arv *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva
                    //       arvu kordi. asendab tehet "arv = arv * 2". on kombinatsioon matemaatilisest tehtest "*" ja omistamisest ("=")
        arv /= 2;   // *= -> võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                    //       arvu osadeks. asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest
                    //       ("=")
        arv++;      // ++ -> on spetsiifiliselt ühe juurde liitmiseks lühivariant.
        arv--;      // -- -> on spetsiifiliselt ühe maha lahutamiseks lühivariant.

        /* Tsüklid */

        // 1. do-while
        int dw = 0;
        do // "do" on kaitstud sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi
        {
            dw++;
        } while (dw != 5); //niikaua kuni while järel olevate sulgude vahel olev tingimus on täidetud.

        // 2. while
        int i = 1; //tsüklimuutuja mis kontrollib "while" tsükli tööd
        while (i < 5) //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab tihtipeale välist tsüklimuutujat
                      //antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle
                      //muutuja olekut. Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükli töö lõppeb.
        {
            //koodiplokk kus midagi tehakse
            i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde
        }

        // 3. for
        int kogus = 6; //muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
        for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks
                                        // vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja "int k = 0;", teine parameeter on
                                        // tingimuslause mis kontrollib tingimuse täitumist "k < kogus;" ning kolmas inkrementeerib tekitatud
                                        // muutujat "k++;". pane tähele et iga sulgude vahel oleva osa järel on lauselõpumärk. Tsükli tööd
                                        // kontrolliv tingimuslause koosneb kolmest reast, mitte ühest, nagu while, või do-while puhul.
        {                               // koodiplokk kus tehakse mingi tegevus
            Console.WriteLine(k);       // antud juhul on tegevuseks muutuja "k" arvu väljakuvamine
        }

        // 4. foreach
        int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
        foreach (var arvInLoend in arvuLoend) // kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse
                                              // ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev
                                              // kaitstud sõna "in" väljendab et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend
                                              // muutuja hoiab endas just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat
                                              // tsüklimuutujat ega tingimust, tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib
                                              // iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja tsüklimuutujat, kuna talle on
                                              // sisse ehitatud vaikimisi elemndi järjestuse jälgimine. Niipalju kui andmeid on, ongi see,
                                              // mitu korda tsükkel käivitatakse.
        {                                     // {} koodiplokk kus tehakse mingi tegevus
            Console.WriteLine(arvInLoend);    // antud juhul kuvatakse välja ajutine muutuja, mille sees on loendi element. 
        }

        /* Castimine */

        // Castimine on viis, kuidas ühest andmetüübist teist saada. Castimist on kahte eri liiki, automaatne ja manuaalne.
        // Automaatne castmine toimub siis, kui teisendatakse väiksemast andmetüübist, suuremasse.
        // Manuaalne castimine toimub siis, kui tahetakse saada suuremast andmetüübist väiksemat.
        // Castitakse nii, et teisendatava muutuja ette, pannakse sulud koos soovitud andmetüübiga.

        double newData1 = 2.22d; //tekitame, või on olemas, suure mahuga andmed muutujas newData1. Tegu on double andmetega.
        float data1Float = (float)newData1; //"(float)" teisendab double tüüpi andmed float tüüpi andmeteks.
        long data1Long = (long)newData1; //"(long)" teisendab double tüüpi andmed long tüüpi andmeteks.
        int data1Int = (int)newData1; //"(int)" teisendab double tüüpi andmed int tüüpi andmeteks.
        char data1Char = (char)newData1;//"(char)" teisendab double tüüpi andmed char tüüpi andmeteks.

    }
    /* meetodid */

    // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
    // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
    // Meetodeid on kahte liiki - ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta
    // midagi, kuid omavad siiski mingit tegevust.

    // Meetodi signatuur:
    // Meetodi signatuur koosneb mitmest kindalt äramääratud omadusest, nendeks on:
    // - Juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
    //   public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub.
    //   private - meetod on saadav ainult selles klassis, kus meetod ise asub.
    //   protected - meetod on saadav ainult selles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus
    //               sellele klassile.
    //   internal - meetod on saadav ainult selles klassis ja ainult selles failis.
    // - Võib olla ka pandud static - meetod kuulub selle klassi juurde
    // - Tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta.
    //   Andmetüüp mida tagastada võib olla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta
    //   üldse andmeid, pannakse selle asemel andmetüübiks "void". Kui meetodil on tagastustüüp mis on midagi muud kui
    //   void, on meetodi sees, iga toimiva koodisuuna lõpus, kaitstud sõna "return", return ütleb, et just see, on vaja
    //   väljakutseasukohta tagastada, ning peale returni on muutuja nimi tagastatava infoga. Peale return lauset, ei
    //   teostata mitte ühtegi muud meetodi sisu. Return toimib ka kui breakina, lõpetades siis aktiivse meetodi töö.

    // 1. tüüpi meetod - ei tagasta midagi
    public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et
                                   //ta on selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta
                                   //ning pärast meetodi omadusi on meetodi nimi "UusMeetod" peale mida on sulud, kus
                                   //parameetreid ei ole. 
    {                              //pärast signatuuri on koodiplokk meetodi koodiga {}
        Console.WriteLine("Tere"); //Antud juhul meetod kuvab konsooli sõnumi.
    }
    // 2. tüüpi meetod - tagastab väärtuse
    int[] arvutatavadArvud = new int[] { 3, 67, 420 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                       //"arvutatavadArvud.
    public static int ArvutaKokku(int[] arvud) //Meetod, mille signatuuris on juurdepääsumodifikaator public, static
                                               //ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
                                               //programmis väljakutseasukohta tagastatakse täisarv, peale seda on
                                               //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumassiivi
                                               //millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on
                                               //koodiplokk {} tehtava koodiga.
    {
        int summa = 0; //Tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.
        foreach (int i in arvud) //foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi
        {
            summa += i; //ja muutujale summa lisatakse juurde, hetkel käidav element.
        }
        return summa; //pärast tsükli töö lõppu tagastakse "return" käsu abil, muutuja summa sisu.
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        /*
        int käimasolevaasta = 2025;

        //float pikkus = 2.5f;

        string sõnum = "teie vanus on";

        //bool miskion = false;


        int olenniivana = 19;


        int tehteTulemus = käimasolevaasta + olenniivana;

        //Console.WriteLine(tehteTulemus + sõnum);
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("oioioioioioioioiooio");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        // Console.WriteLine("tehteTulemus + sõnum");
        */

        //int liidetavarv1 = 0;


        //int liidetavarv2 = 0;


        //Console.WriteLine("tere, palun sisesta esimene liidetav");

        //liidetavarv1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("tere, palun sisesta esimene liidetav");

        //liidetavarv2  = int.Parse(Console.ReadLine());

        //int liitmine = liidetavarv1 + liidetavarv2;

        //Console.WriteLine($"tehte tulemus:{liitmine} ");
        //Console.WriteLine("tehte tulemus: " + liitmine);


        //int lahutatavarv1 = 0;

        //int lahutatavarv2 = 0;


        //Console.WriteLine("tere, palun sisesta esimene liidetav");

        //lahutatavarv1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("tere, palun sisesta esimene liidetav");

        //lahutatavarv2 = int.Parse(Console.ReadLine());

        //int lahutamine = lahutatavarv1 - lahutatavarv2;


        //Console.WriteLine($"tehte tulemus:{lahutamine} ");
        //Console.WriteLine("tehte tulemus: " + lahutamine);

        //int korrutavarv1 = 0;
        //int korrutavarv2 = 0;
        //Console.WriteLine("Tere, palun lisa esimene korrutav");
        //korrutavarv1 = int.Parse(Console.ReadLine());


        //int korrutav1 = 0;


        //int korrutav2 = 0;


        //Console.WriteLine("tere, palun sisesta esimene korrutav");

        //korrutav1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("tere, palun sisesta teine korrutav");

        //korrutav2  = int.Parse(Console.ReadLine());

        //int korrutamine = korrutav1 * korrutav2;

        //Console.WriteLine($"tehte tulemus:{korrutamine} ");
        //Console.WriteLine("tehte tulemus: " + korrutamine);


        //int jagatav1 = 0;


        //int jagatav2 = 0;


        //Console.WriteLine("tere, palun sisesta esimene jagatav");

        //jagatav1 = int.Parse(Console.ReadLine());

        //Console.WriteLine("tere, palun sisesta esimene jagatav");

        //jagatav2  = int.Parse(Console.ReadLine());

        //int jagamine = liidetavarv1 / liidetavarv2;

        //Console.WriteLine($"tehte tulemus:{jagamine} ");
        //Console.WriteLine("tehte tulemus: " + jagamine);


        int arv1 = 0;
        int arv2 = 0;
        Console.WriteLine("tere, palun sisestage esimene arv:");
        arv1 = int.Parse(Console.ReadLine());
        Console.WriteLine("sisestage teine arv: ");
        arv2 = int.Parse(Console.ReadLine());
        Console.WriteLine("missugust tehet soovid teha? kirjuta kas + - / * ^");
        string tehtetüüp = Console.ReadLine();
        int tehe = 0;

        if (tehtetüüp == "+" /* tingimus siia*/)

        {
            tehe = arv1 + arv2;
        }
        if (tehtetüüp == "-"/* tingimus siia*/)

        {
            tehe = arv1 - arv2;

        }
        if (tehtetüüp == "*"/* tingimus siia*/)

        {
            tehe = arv1 * arv2;
        }
        if (tehtetüüp == "/"/* tingimus siia*/)
        {
            tehe = arv1 / arv2;
        }
        if (tehtetüüp == "^"/* tingimus siia*/)
        {
            tehe = (int)Math.Pow(arv1, arv2);
        }
        Console.WriteLine($"{tehtetüüp} tehte tulemus: {tehe}");








    }
} 
}
string nimi = "";
do
{
    Console.WriteLine("mis on teie nimi");
    nimi = Console.ReadLine();

    if (nimi != "Daaniel")
    {
        Console.WriteLine("Isik pole registreerunud.");
    }

} while (nimi != "Daaniel");
string parool = "";
do
{
    Console.WriteLine("mis on teie parool");
    parool = Console.ReadLine();

    if (parool != "Redbull")
    {
        Console.WriteLine("Vale parool!");
    }

} while (parool != "Redbull");

string[] loomad = new string[3];
int i = 0;
while (i < 3)
{
    Console.Write("mis on teie lemmikloom ");
    loomad[i] = Console.ReadLine();
    i++;
}
int valik = 0;

while (valik < 1 || valik > 3)
{
    Console.WriteLine("Vali k6ige lemmikuim nendest (1, 2, 3):");
    valik = int.Parse(Console.ReadLine());

    if (valik < 1 || valik > 3)
    {
        Console.WriteLine("nope, vale");
    }
    Console.WriteLine("Sinu lemmikloom on: " + loomad[valik]);
}
Console.WriteLine("Kas su tuba on kolmnurk, ristkülik,ring");
string valik = Console.ReadLine();
double tulemus = 0;



if (valik == "ring")
{
    Console.WriteLine(" sisestage oma toa raadius");
    double raadius = double.Parse(Console.ReadLine());
    tulemus = Math.PI * Math.Pow(raadius, 2);
    Console.WriteLine("Su toa pindala on" + tulemus);
}

else if (valik == "kolmnurk")
{
    Console.WriteLine(" sisestage oma toa esimene külg");
    double a_külg = double.Parse(Console.ReadLine());
    Console.WriteLine(" sisestage oma toa teine külg");
    double b_külg = double.Parse(Console.ReadLine());
    Console.WriteLine(" sisestage oma toa kolmas külg");
    double c_külg = double.Parse(Console.ReadLine());
    tulemus = (a_külg + b_külg + c_külg) / 2;
    Console.WriteLine("Su toa pindala on" + tulemus);
}
else if (valik == "ristkülik")
{
    Console.WriteLine(" sisestage oma toa pikkus");
    double pikkus = double.Parse(Console.ReadLine());
    Console.WriteLine(" sisestage oma toa laius");
    double laius = double.Parse(Console.ReadLine());
    tulemus = laius * pikkus;
    Console.WriteLine("Su toa pindala on" + tulemus);
}
Console.WriteLine("Sisesta ostusumma");
double ostusumma = double.Parse(Console.ReadLine());
if (ostusumma > 100)
//Adresseerimine modulit "console", punkti abil ütleme et kasutame sealt funkstsiooni "writeline" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale sõnum Sisesta ostusumma
// lause lõppeb lauselõpumärgiga
//taga olevate suhlude vahel; antud rida lõppeb lauselõpumärgiga
//{} -> koodiplokk, tavaliselt pärast tingimust või funktisiooni kirjeldust.
//Console.ReadLine-Loeb kasutaja sisestatud teksti (numbri).
//double.Parse-Muudab sisestatud teksti komakohaga arvuks, et saaks matemaatiliselt arvutada
//double ostusumma =-Loob muutuja nimega ostusumma, kuhu salvestatakse kasutaja sisestatud arv.
//ka omakorda jutumärkide vahel. Jutumärgid tähistavad sõnet.
{
    Console.WriteLine("Saad 20% allahindlust!");
    // peale tingimust on koodiplokk, mis {} loogiliste sulgude vahel.
    // Koodiplokk sisaldab ühte rida, kus kasutame Console.WriteLine funktsiooni, et kuvada kasutajale sõnum "Saad 20% allahindlust!"
    // Funktsioon Console.WriteLine kuulub Console moodulisse, mille kaudu saame teksti ekraanile printida.
    // //if-kontrollib, kas mingi tingimus on tõene,
    //Kui on, siis teeb selle sees oleva käsu.
}
else if (ostusumma < 101 && ostusumma > 50)
// teeme tingimuslause else if, mis kontrollib järgmist summakategooriat, kui eelmine if ei olnud tõene
// Kas muutuja ostusumma on suurem kui 50 aga kindlasti väiksem või võrdne 100-ga, kuna eelmine if ei käivitunud
//Märk && tähendab "ja" – mõlemad tingimused peavad kehtima

{
    Console.WriteLine("Saad 10% allahinflust");
    // Koodiplokk {} sees kuvab sõnumi ekraanile, et klient saab 10% allahindlust
    //Adresseerimine modulit "console", punkti abil ütleme et kasutame sealt funkstsiooni "writeline" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale sõnum "Saad 10% allahindlust"
    // lause lõppeb lauselõpumärgiga
    //taga olevate suhlude vahel; antud rida lõppeb lauselõpumärgiga
    //lause "Saad 10% allahindlust" jutumärkide vahel. Jutumärgid tähistavad sõnet
}
else if (ostusumma < 51 && ostusumma > 20)
// teeme tingimuslause else if, mis kontrollib summat 20 ja 51 vahel
//Märk && tähendab "ja" – mõlemad tingimused peavad kehtima
//ostusumma algne hind või kogusumma enne allahindlust.

{
    Console.WriteLine("Saad 5% allahindlust");
    // Kuvame sõnumi ekraanile 5% allahindluse kohta
    //Adresseerimine modulit "console", punkti abil ütleme et kasutame sealt funkstsiooni "writeline" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale sõnum "Saad 5% allahindlust"
    // lause lõppeb lauselõpumärgiga
}
else if (ostusumma < 21)
// teeme tingimuslause else if ning sulgude vahele kirjutame tingimuseks kontrolli,
// kas muutuja ostusumma väärtus on väiksem kui 21
// < tähendab "väiksem kui"
{
    Console.WriteLine("Allahindlust ei saa :(");
}
// peale tingimust on koodiplokk, mis {} loogiliste sulgude vahel.
// Koodiplokk sisaldab ühte rida, kus kasutame Console.WriteLine funktsiooni, et kuvada kasutajale sõnum "Saad sõnumi allahindlust ei saa :(!"
// Funktsioon Console.WriteLine kuulub Console moodulisse, mille kaudu saame teksti ekraanile printida.
else if (ostusumma < 1)
// else if on tingimuslause, mis käivitub ainult siis,
// kui eelmine if või else if tingimus ei olnud tõene
// kui see tingimus on tõene, käivitatakse koodiplokk {}

{
    Console.WriteLine("Susestatud vigane arv");
    //Console –käsureale, kuhu programm saab teksti väljastada.
    //Writeline-see on funktsioon, mis väljastab ekraanile teksti ja liigub uuele reale.
    //Kui ükski eelnevatest ostusumma kontrolli tingimustest ei kehti, tähendab see  et kasutaja sisestas vale arvu ja programm ei tööta
    //ka omakorda jutumärkide vahel. Jutumärgid tähistavad sõnet.

    namespace meetoditetöö
{
    internal class Program
    {
        static void Main(string[] args)

    //    {
    //        Console.WriteLine("Tere kasutaja, mis on teie nimi?");
    //        string filepath = "C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\meetoditetöö\\nimi.txt";
    //        string nimi = Console.ReadLine();
    //        File.WriteAllText(filepath, nimi);
    //        Console.WriteLine("Nimi");
    //        DisplayThisFile();
    //        FindWord("henri");
    //    }
    //    public static void FindWord(string FindThisWord)
    //    {
    //        using (StreamReader readFile = new StreamReader("C: \Users\opilane\Source\Repos\harjutused Henri Hunt\meetoditetöö\nimi.txt") )
    //        {
    //            int lnr = 0;
    //            while (readFile.EndOfStream == false)
    //            {
    //                string line = readFile.ReadLine();
    //                lnr++;

//                if (line.Contains(FindThisWord) == true)
//                {
//                    string v = Console.ReadLine(FindThisWord + " leiti reast " + lnr);
//                }
//            }
//            readFile.Close();
//        }
//    }
//    private static void DisplayThisFile()
//    {
//        string line = "";
//        try
//        {
//            using (
//                StreamReader readThisThing = new StreamReader
//            ("C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\meetoditetöö\\nimi.txt"))
//            {
//                int LineCount = 0;
//                while (readThisThing.EndOfStream == false)
//                {
//                    LineCount++;
//                    line = readThisThing.ReadLine();
//                    int pikkus = line.Length;
//                    Console.WriteLine(LineCount + " " + line + " . Reapikkus on" + pikkus);
//                }
//                readThisThing.Close();
//            }
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine("Ei saa lugeda sellepärast et:" + e.Message);
//            throw;
//        }
//    }

//}
//{
//    Console.WriteLine("Tere");
//    int[] arvutatavadArvud = new int[] { 2, 3, 4 };
//}
//public static int ArvutaKokku(int[] arvud)
//{
//    int summa = 0;
//    foreach (int i in arvud)
//    {
//        summa += i;
//    }
//    return summa;
//Console.WriteLine("Tere kasutaja, mis on sinu nimi?");
//string nimi = "";
//nimi += Console.ReadLine();
//if (nimi != "Nipitiri") 
//{
//    Console.WriteLine("Sa pole Nipitiri, ootan ainult Nipitirit.");
//}

//Console.WriteLine("Tere kasutaja, kas sulle meeldivad tulbid?");
//string tulbid = "";
//tulbid = Console.ReadLine();
//if (tulbid != "jah")
//{
//    Console.WriteLine("Mulle ka :) ");
//}
//else 
//{
//    Console.WriteLine("Sorri mees ma ei saa sinust aru :( ");
//}

//Console.WriteLine("Tere kasutaja, mitu tundi sa sel nädalal mängisid?");
//int mängutunnid = 0;
//mängutunnid = int.Parse(Console.ReadLine());
//if (mängutunnid == 0)
//{
//    Console.WriteLine("Kahju, et sul pole aega mängida.");
//}
//else if (mängutunnid < 10 && mängutunnid > 0)
//{
//    Console.WriteLine("Mõõdukas mängur oled");
//}
//else if (mängutunnid < 20 && mängutunnid > 10)
//{
//    Console.WriteLine("Natuke paljuks läheb, kodutööd kannatavad");
//}
//else if (mängutunnid < 40 && mängutunnid > 20)
//{
//    Console.WriteLine("Liiga palju mängid, kas kooli üldse jõuad?");
//}
//else if (mängutunnid < 40)
//{
//    Console.WriteLine("Siin peaks juba psühholoog sekkuma");
//}

//int jalgpalliMäng = 0;
//Console.WriteLine("Mis su viimase mängu tulemus on?");
//jalgpalliMäng = int.Parse(Console.ReadLine());
//switch (jalgpalliMäng)
//{
//    case 0:
//        Console.WriteLine("Pudrujalg oled v?");
//        break;
//    case 1:
//        Console.WriteLine("Täitsa okei");
//        break;
//    case 2:
//        Console.WriteLine("Nu see juba parem");
//        break;
//    case 3:
//        Console.WriteLine("Wow, Messi");
//        break;
//    case 4:
//        Console.WriteLine("Ei tunne sellist numbrit");
//        break;
//}









//string kasutajaNimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajaNimi = Console.ReadLine();
//} while (kasutajaNimi != "Mihkel");
//if (kasutajaNimi == "Mihkel")
//{

//}


//int parool = 0;
//Console.WriteLine("Palun sisestage parool");
//parool = int.Parse(Console.ReadLine());
//while (parool > 1000 && parool < 9999)
//{
//    Console.WriteLine("Sinu parool sobib");
//}
//if (parool < 1000 && parool > 9999)
//{
//    Console.WriteLine("Vale parool! Parool peab olma neljakohaline arv");
//}


//int puuviljad = 5;
//for (int i = 0; i < puuviljad; i++)
//{
//    Console.WriteLine(i);
//}





//int[] arvuLoend = { 1, 2, 3, 4, 5 };
//foreach (var arvInLoend in arvuLoend)
//{
//    Console.WriteLine(arvInLoend);
//}
//namespace Meetodid
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string Tere = "";
//            while (Tere == "")
//            {
//                Console.WriteLine("Tere");
//                Tere = Console.ReadLine();
//            }
//        }
//    }
//}

//Console.WriteLine("Tere");
//Console.WriteLine("Palun kirjuta 5 arvutavat arvu");
//int[] arvutatavadArvud = new int[] { 2, 3, 4 };

//     static int ArvutaKokku(int[] arvud)
//{
//    int summa = 0;
//    foreach (int i in arvud)
//    {
//        summa += i;
//    }
//    return summa;
//}

//namespace Meetodid
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double komakohagaarv = 9.45d;
//            Console.WriteLine((int)komakohagaarv);
//            int roundedarv = (int)Math.Round(komakohagaarv);
//            Console.WriteLine(roundedarv);


//            int arv = 35;
//            string arvtekstina = arv.ToString();
//            Console.WriteLine(arvtekstina);
//            Console.WriteLine(arv);
//            double arvdouble = 279346559d;
//            int arvint = 0;
//            arvint = (int)arvdouble;
//            double uusdouble = arvint;
//        }
//    }
//}
meetodid



