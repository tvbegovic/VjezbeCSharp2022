Console.Write("Redni broj mjeseca (1-12): ");
var unos = Console.ReadLine();
var ok = int.TryParse(unos, out int redniBroj);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if(redniBroj < 1 || redniBroj > 12)
{
    Console.WriteLine("Broj je izvan raspona 1-12");
    return;
}
int brojDanaUMjesecu;
switch(redniBroj)
{
    case 2:
        if (DateTime.IsLeapYear(DateTime.Now.Year))
            brojDanaUMjesecu = 29;
        else
            brojDanaUMjesecu = 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        brojDanaUMjesecu = 30;
        break;
    default:
        brojDanaUMjesecu = 31;
        break;
}
if(brojDanaUMjesecu == 31)
    Console.WriteLine("{0}. mjesec ima {1} dan", redniBroj, brojDanaUMjesecu);
else
    Console.WriteLine("{0}. mjesec ima {1} dana", redniBroj, brojDanaUMjesecu);