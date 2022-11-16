Console.Write("Unesite redni broj mjeseca (1-12): ");
var unos = Console.ReadLine();
var ok = int.TryParse(unos, out int redniBroj);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if( redniBroj < 1 || redniBroj > 12 )
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
if(redniBroj >= 1 && redniBroj <= 3)
{
    Console.WriteLine("1. kvartal");
}
else if(redniBroj >= 4 && redniBroj <= 6)
{
    Console.WriteLine("2. kvartal");
}
else
{
    Console.WriteLine("Ostalo");
}
