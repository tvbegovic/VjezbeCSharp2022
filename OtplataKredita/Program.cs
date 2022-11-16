void IzracunParametara(double glavnica, double stopa, int brojGodina,
    out double anuitet, out double iznosKamata)
{
    if (glavnica < 0 || stopa < 0 || brojGodina < 0)
        throw new ArgumentException("Parametri moraju biti pozitivni brojevi");
    var r = Kamatnjak(stopa);
    var n = brojGodina * 12;
    anuitet = glavnica * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
    iznosKamata = anuitet * n - glavnica;
}

double Kamatnjak(double stopa)
{
    return (1 + stopa / 100 / 12);
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
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Stopa: ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Broj godina (1-30): ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out int brojGodina);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            if(brojGodina < 1 || brojGodina > 30)
            {
                Console.WriteLine("Broj godina mora biti između 1-30");
                continue;
            }
            IzracunParametara(glavnica, stopa, brojGodina, out double anuitet,
                out double ukupnoKamata);
            Console.WriteLine(
            "Za zadani iznos kredita {0:N2}, godišnju kamatnu stopu {1}% i broj godina otplate {2}" +
            " anuitet je {3:N2} i ukupni iznos kamata je {4:N2}.",
            glavnica, stopa, brojGodina, anuitet, ukupnoKamata);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
    }
} while (nastavi);