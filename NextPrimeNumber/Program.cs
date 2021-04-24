using System;

namespace NextPrimeNumber
{
	class Program
	{
		static bool isPrime(int liczba)
		{
			if (liczba == 1)
			{
				return false;
			}

			for (int i = 2; i < liczba; i++)
			{
				if (liczba % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			//program myta się o liczbę i wyświetla najbliższą liczbę pierwszą.
			//Dla 8 wynik to 7,
			//Dla 10 wynik to 11,
			//Dla 9 wynik to 11 powiedzmy że jeśli różnica jest taka sama to pokazujesz większą liczbę
			//Napisz do tego testy
			//Program ma działać tak długo, aż podasz komendę stop	
			//Program powinien wyświetlać wynik na konsoli oraz zapisywać do pliku


			Console.WriteLine("podaj jakąś liczbę dodatnią");
			string text = Console.ReadLine();
			int liczba = int.Parse(text);

			//while (!isPrime(liczba))
			//{
			//	liczba++;
			//}
			//Console.WriteLine("Najblizsza liczba pierwsza to " + liczba);
			//	while (!isPrime(liczba))

			//	{

			//		bool pierwsza = isPrime(liczba);
			//		if (pierwsza == false)
			//		{
			//			liczba++;
			//			Console.WriteLine(liczba);
			//			Console.WriteLine("podaj następną liczbę");
			//			text = Console.ReadLine();
			//			liczba = int.Parse(text);
			//		}


			//	}
			//	Console.WriteLine("Najbliższa liczba pierwsza to " + liczba);
			//}

			while (text != "stop")
			{
				bool pierwsza = isPrime(liczba);
						if (pierwsza == false)
						{
							liczba++;
							Console.WriteLine(liczba);
							Console.WriteLine("podaj następną liczbę");
							text = Console.ReadLine();
							liczba = int.Parse(text);
						}
			}
					
		}
	}

}
	

