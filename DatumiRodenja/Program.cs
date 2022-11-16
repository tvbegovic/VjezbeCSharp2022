Console.Write("Datum 1: ");
var unos = Console.ReadLine();
var ok = DateTime.TryParse(unos, out DateTime datum1);
if(!ok)
{
    Console.WriteLine("Datum je u pogrešnom formatu");
    return;
}
Console.Write("Datum 2: ");
unos = Console.ReadLine();
ok = DateTime.TryParse(unos, out DateTime datum2);
if (!ok)
{
    Console.WriteLine("Datum je u pogrešnom formatu");
    return;
}
if(datum1 < datum2)
{
    Console.WriteLine("Osoba 1 je starija od osobe 2 za {0} dana", 
        (datum2 - datum1).TotalDays);
}
else if(datum2 < datum1)
{
    Console.WriteLine("Osoba 2 je starija od osobe 1 za {0} dana", 
        (datum1 - datum2).TotalDays);
}
else
{
    Console.WriteLine("Obje osobe su rođene istog datuma");
}

if(datum1.Month < datum2.Month)
{
    Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
}
else if(datum2.Month < datum1.Month)
{
    Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
}
else
{
    if (datum1.Day < datum2.Day)
    {
        Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
    }
    else if(datum2.Day < datum1.Day)
    {
        Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
    }
    else
    {
        Console.WriteLine("Osobe 1 i 2 slave rođendan istog dana");
    }
}