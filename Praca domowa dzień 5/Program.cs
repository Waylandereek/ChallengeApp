
        int number = 4566;
        string numberInString = number.ToString();
        char[] letters = numberInString.ToCharArray();

        int[] ilosc = new int[10];

        for (int i = 0; i < letters.Length; i++)
        {
            ilosc[letters[i] - '0']++;
        }

        for (int i = 0; i < ilosc.Length; i++)
        {
            Console.WriteLine("Cyfra " + i + " występuje " + ilosc[i] + " razy.");
        }

