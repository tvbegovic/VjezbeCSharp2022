double IznosKamata(double glavnica, double stopa)
{
    return glavnica * stopa / 100;
}

var nastavi = true;
do
{
    Console.Write("Glavnica: ");
    var unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = double.TryParse(unos, out double glavnica);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        Console.Write("Stopa (0-20%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        if(stopa < 0 || stopa > 20)
        {
            Console.WriteLine("Stopa je izvan raspona 0-20");
            continue;
        }
        var kamate = IznosKamata(glavnica, stopa);
        Console.WriteLine("Za glavnicu {0} i kamatnu stopu {1}% kamata je {2:N2}",
            glavnica,stopa,kamate);
    }
} while (nastavi);