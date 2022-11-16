double Zarada(int brojSati, double cijenaSata = 40, double porez = 0.2)
{
    if (brojSati < 0)
        throw new ArgumentException("Broj sati mora biti pozitivan");
    return brojSati * cijenaSata * (1 - porez);
}

var nastavi = true;
do
{
	try
	{
		Console.Write("Broj sati: ");
		var unos = Console.ReadLine();
		if (string.IsNullOrEmpty(unos))
			nastavi = false;
		else
		{
			var ok = int.TryParse(unos, out int brojSati);
			if(!ok)
			{
				Console.WriteLine("Pogrešan format");
				continue;
			}
			Console.Write("Cijena sata: ");
			unos = Console.ReadLine();
			ok = double.TryParse(unos, out double cijenaSata);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Porez: ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double porez);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
			Console.WriteLine("Ukupna zarada za broj sati {0}, cijenu sata {1} i porez {2}" +
				" je {3}", brojSati, cijenaSata, porez, 
				Zarada(brojSati, cijenaSata, porez));
			Console.WriteLine("Ukupna zarada za broj sati {0}, cijenu sata {1} i default porez " +
				" je {2}", brojSati, cijenaSata, Zarada(brojSati, cijenaSata));
			Console.WriteLine("Ukupna zarada za broj sati {0}, defaultnu cijenu sata i porez " +
				" {1} je {2}", brojSati, porez, Zarada(brojSati,porez: porez));
			Console.WriteLine("Ukupna zarada za broj sati {0}, defaultnu cijenu i porez je {1}",
				brojSati, Zarada(brojSati));

        }
	}
	catch (Exception ex)
	{
		Console.WriteLine("Pogreška. Tekst pogreške: {0}", ex.Message);
	}
} while (nastavi);
