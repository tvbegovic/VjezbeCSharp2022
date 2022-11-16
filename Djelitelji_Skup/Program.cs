(int suma, int brojDjelitelja) Djelitelji(int broj)
{
    (int suma, int brojDjelitelja) rezultat = (0, 0);
	if (broj < 1 || broj > 1000000)
		throw new ArgumentException("Broj je izvan raspona 1-1.000.000");
	for (int i = 1; i <= broj / 2; i++)
	{
		if(broj % i == 0)
		{
			rezultat.suma += i;
			rezultat.brojDjelitelja++;
		}
	}
	return rezultat;
}

var nastavi = true;
do
{
	try
	{
		Console.Write("Broj (1-1.000.000): ");
		var unos = Console.ReadLine();
		if (string.IsNullOrEmpty(unos))
			nastavi = false;
		else
		{
            var ok = int.TryParse(unos, out int broj);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
			var rezultat = Djelitelji(broj);
			Console.WriteLine("Za zadani broj {0} suma djelitelja je {1:N0} a njihov broj je {2}",
				broj, rezultat.suma, rezultat.brojDjelitelja);
        }
		

	}
	catch (Exception ex)
	{
        Console.WriteLine("Pogreška. Tekst pogreške: {0}", ex.Message);
    }
} while (nastavi);
