Console.Write("Ocjena C: ");
var unos = Console.ReadLine();
var ok = int.TryParse(unos, out int ocjenaC);
if(!ok)
{
    Console.WriteLine("Pogrešan format ocjene.");
    return;
}

Console.Write("Ocjena C++: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCPlus);
if (!ok)
{
    Console.WriteLine("Pogrešan format ocjene.");
    return;
}

Console.Write("Ocjena C#: ");
unos = Console.ReadLine();
ok = int.TryParse(unos, out int ocjenaCSharp);
if (!ok)
{
    Console.WriteLine("Pogrešan format ocjene.");
    return;
}

var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
Console.WriteLine("Prosjek ocjena je {0:N2}", prosjek);

