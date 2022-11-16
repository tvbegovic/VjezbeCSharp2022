double IznosKamata(double glavnica, double stopa)
{
    if (stopa < 0 || stopa > 20)
        throw new ArgumentOutOfRangeException("Stopa je izvan raspona 0-20");
    return glavnica * stopa / 100;
}

var nastavi = true;
do
{
    try
    {
        Console.Write("Glavnica: ");
        var unos = Console.ReadLine();
        if (string.IsNullOrEmpty(unos))
            nastavi = false;
        else
        {
            var ok = double.TryParse(unos, out double glavnica);
            if (!ok)
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

            var kamate = IznosKamata(glavnica, stopa);
            Console.WriteLine("Za glavnicu {0} i kamatnu stopu {1}% kamata je {2:N2}",
                glavnica, stopa, kamate);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Pogreška. Tekst: {0}", ex.Message);
        continue;
    }
} while (nastavi);