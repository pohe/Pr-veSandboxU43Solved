using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Opgave 1 Types and variables 
            //see page 21 i C# noten
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Opgave 1  \n\n");
            Console.WriteLine("-------------------------------------");
            //Erklær en variabel, SongTitle, der kan indeholde en sangtitel
            string songTitle = "Det som ingen selv har set";
            //erklær en variabel, songDurationInSek, der kan indeholde længden af et album i sekunder
            int songDurationInSek = 240;
            //Erklær en variabel, albumDuration, der kan indeholde længden af et album i sekunder
            int albumDuration = 16000;
            //Erklær en variabel, recommeded, der kan anvendes til at registrere om en sang anbefalet
            bool recommended = false;
            //Erklær variabel, songPrice, der kan indeholde prisen på en sang uden moms
            double songPrice = 8.5;

            // Opgave 2 Arithmetic
            // see page 25
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 2  \n\n");
            Console.WriteLine("-------------------------------------");
            //Lav en beregning af hvor mange procent (heltal) sangen udgør af hele albummet og gem resutatet i en variabel, songPercentageOfAlbumInt. Udskriv resultatet
            int songPercentageOfAlbumInt = (songDurationInSek*100)/ albumDuration ;

            //Lav en beregning af hvor mange procent (decimaltal) sangen udgør af hele albummet og gem resutatet i en variabel, songPercentageOfAlbumDouble. Udskriv resultatet med to decimaler

            double songPercentageOfAlbumDouble = (songDurationInSek * 100.0) / albumDuration ;

            Console.WriteLine($"Song percentage of album int {songPercentageOfAlbumInt}");
            Console.WriteLine($"Song percentage of album double {songPercentageOfAlbumDouble:F2}");

            //Beregn momsen på en sang. Gem resultatet i en variabel songTax og skriv den ud med to decimaler
            double songTax = songPrice * 0.25;
            Console.WriteLine($"Song tax {songTax:F2}");

            // Opgave 3
            // logik s.33
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 3  \n\n");
            Console.WriteLine("-------------------------------------");

            // Hvis sangen ikke er anbefalet og den varer mindre end 4 minutter eller at det gælder at sangen udgør under 10 procent af albummet så skal der udskrives, at der er et særligt tilbud "Special offer - reduced price" og prisen reduceres med 20 % 

            if (!recommended && (songDurationInSek < 240) || (songPercentageOfAlbumInt < 10))
            {
                double originalSongPrice = songPrice;
                songPrice = songPrice * 80 / 100;
                Console.WriteLine($"Special offer -- the price is reduced with 20 procent");
                Console.WriteLine($"Original price {originalSongPrice:F2}");
                Console.WriteLine($"Reduced price {songPrice:F2}");
            }

            // Opgave 4
            // Funktioner s. 36 - 38 + 68 -69
            // Lav følgende funktioner i klassen SongCalculation 
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 4  \n\n");
            Console.WriteLine("-------------------------------------");

            // Lav en statc funktion songTax i klassen SongCalculation der kan returnere den beregnede moms
            double theSongTax = SongCalculation.songTax(songPrice);
            Console.WriteLine($"Calculated song tax {theSongTax:F2}");

            // lav en static funktion, SongAmountDiscount. Der skal beregnes den samlede pris på en bestilling af en sang. 
            // Parameterne til funktionen er SongPrice og antal bestillinger
            // Et kald af funktionen kan se således ud.
            // double discount4 = SongCalculation.SongAmountDiscount(songPrice, 4);
            // Hvis der bestillet mere end 5 gives der 5 % rabat
            // Hvis der bestilles mere end 10 gives der 12 % rabat
            // Hvis der bestilles mere 20 gives der 50% rabat
            // Udskriv rabatten efterfølgende efter kald af funktionen med henholdsvis bestillinger på 4, 8, 12 og 30 eksemplarer af sangen
            // Lav to udgaver af funktionen. En der anvender if-sætninger og en der anvender switch

            double discount4 = SongCalculation.SongAmountDiscount(songPrice, 4);
            Console.WriteLine($"Rabat ved bestilling af 4 eksemplarer af sangen som koster {songPrice:F2} er {discount4:F2}");
            double discount8 = SongCalculation.SongAmountDiscount(songPrice, 8);
            Console.WriteLine($"Rabat ved bestilling af 8 eksemplarer af sangen som koster {songPrice:F2} er {discount8:F2}");
            double discount12 = SongCalculation.SongAmountDiscount(songPrice, 12);
            Console.WriteLine($"Rabat ved bestilling af 8 eksemplarer af sangen som koster {songPrice:F2} er {discount12:F2}");
            double discount30 = SongCalculation.SongAmountDiscount(songPrice, 30);
            Console.WriteLine($"Rabat ved bestilling af 30 eksemplarer af sangen som koster {songPrice:F2} er  {discount30:F2}");

            // Opgave 5
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 5  \n\n");
            Console.WriteLine("-------------------------------------");
            // S 48 - 67 i C# noten
            // Færdigør klassen Animal
            // Lav properties for Age, TypeName og Sound (lyd som dyret siger
            // Lav  konstruktør, der initialiserer properties med parametere til at initialisere alle properties
            // Lav en metode der hedder, AllInformation, som returnerer en tekststreng, som indeholder værdierne af alle properties

            // Opgave 6
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 6  \n\n");
            Console.WriteLine("-------------------------------------");
            // Lav et array som kan indeholde 5 objekter af klassen Animal
            Animal[] animals = new Animal[5];
            animals[0] = new Animal(12, "Austailian frog", "Kvæk");
            animals[1] = new Animal(2, "Yellow-lipped sea snake", "TSss");
            animals[2] = new Animal(5, "Gibbon Ape", "Rass");
            animals[3] = new Animal(6, "Orangutang", "Gong gong");
            animals[4] = new Animal(6, "Salmon", "Blob blob");

            // Repetition s.79-84 + datastructures s. 88 - 
            // Lav en forløkke som løber arrayet igennem og beregner den samlede alder
            // den samlede alder skal udskrives
            int sumAge = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] != null)
                    sumAge += animals[i].Age;
            }
            Console.WriteLine($"Samlet age  af animals i arrayet er {sumAge}");

            // Lav en  løkke som løber arrayet igennem bagfra og udskrivet AllInformation om alle dyrene
            Console.WriteLine("Udskrivning af animals arrayet bagfra");
            int j = animals.Length -1;
            while (j >= 0)
            {
                if (animals[j] !=null)
                    Console.WriteLine(animals[j].AllInformation());
                j--;
            }

            // Lav en While løkke som løber arrayet igennem og finder det animal animal objekt, som har den højeste alder
            // Efterfølgende skal den højeste alder udskrives
            int z = 0;
            int maxAge = 0;
            while (z < animals.Length && animals[z] != null)
            {
                if (animals[z].Age > maxAge)
                    maxAge = animals[z].Age;
                z++;
            }
            Console.WriteLine($"Den højeste alder er {maxAge}");

            // Opgave 7
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 7 \n\n");
            Console.WriteLine("-------------------------------------");
            // List s. 93 - 99
            // Lav en datastruktur af typen List,animalList, som kan indeholde objekter af typen Animal
            // Tilføj 5 objekter
            List<Animal> animalList = new List<Animal>()
            {
                new Animal(12, "Austailian frog", "Kvæk"),
                new Animal(2, "Yellow-lipped sea snake", "TSss"),
                new Animal(5, "Gibbon Ape", "Rass"),
                new Animal(6, "Orangutang", "Gong gong"),
                new Animal(6, "Salmon", "Blob blob")
            };

            // Lav en foreach løkke og skriv alle dyrens lyde ud
            foreach (Animal anAnimal in animalList)
            {
                Console.WriteLine(anAnimal.Sound);
            }

            // Fjern det tredje dyr fra listen
            animalList.RemoveAt(2);


            // Dictionary s. 97 -99
            // Lav en datastruktur Dictionary, animalDictionary, som kan gemme dyrene udfra deres lyde
            Dictionary<string, Animal> animalDictionary = new Dictionary<string, Animal>();

            //Tilføj alle dyrene til Dictinary
            //Det antages, at hver art af dyrene har en unik lyd

            animalDictionary.Add(animals[0].Sound, animals[0]);
            animalDictionary.Add(animals[1].Sound, animals[1]);
            animalDictionary.Add(animals[2].Sound, animals[2]);
            animalDictionary.Add(animals[3].Sound, animals[3]);
            animalDictionary.Add(animals[4].Sound, animals[4]);

            // Udskriv alle keys i Dictionariet 
            foreach (string aSound in animalDictionary.Keys ) {
                Console.WriteLine($"Sound {aSound}");
            }

            // Udskriv alle values i Dictionariet. TypeName skal udskrives
            foreach (Animal animal in animalDictionary.Values)
            {
                Console.WriteLine($"Values {animal.TypeName}");
            }

            //Tilføj 3 nye Animals til Listen, animalList, på henholdsvis den første plads, den anden plads og sidste plads i listen
            animalList.Insert(0, new Animal(14, "Elephant", "Grøf Grøf"));
            animalList.Insert(1, new Animal(6, "Mouse", "Snif"));
            animalList.Add(new Animal(3,"Horse", "Prrr"));

            // Iterer (gennemløb) gennem animalList og udskriv de animals, som ikke i forvejen eksisterer i animalDictionary
            // Anvend animalDictionary til at checke om deres lyd eksisterer i forvejen
            // Det antages at lyden er unik

            foreach (Animal anAnimal in animalList  )
            {
                if (!animalDictionary.ContainsKey(anAnimal.Sound))
                {
                    Console.WriteLine($"New animal add {anAnimal.TypeName}");
                }
            }

            // Opgave 8
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n Opgave 8 \n\n");
            Console.WriteLine("-------------------------------------");
            // Arv og polymorfi
            // Lav to subklasser til Animal klassen, Horse og Whale
            // Horse skal have en property, CanTrot. Implementer klassen
            // Whale skal have en property, HaveFlippers. Implementer klassen.
            // Override metoden AllInformation fra Animal klassen i klasserne Horse og Whale. 
            // Tilføj information om HaveFlippers og CanTrot når returnerer information om klassen
            // Lav en ny liste der kan indeholde Animal objekter, listPolymorphism, og tilføj 3 Whale objekter og 2 Horse objekter og 2 Animal Objekter.

            // Gennemløb listen og kald metoden AllInformation og udskriv teksten
            // Udskrives den rigtige information?

            List<Animal> listPolymorphism = new List<Animal>()
            {
                new Whale(45, "BowHead Whale", "Dood Dood", true),
                new Whale(75, "Fin Whale", "Wowood", true),
                new Whale(34, "Blue Whale", "Siiing", true),
                new Horse(12, "American Albino", "Pruhaa", true),
                new Horse(7, "Arabic horse", "Paahuu", true),
                new Animal(2, "Collie dog", "Wuuf"),
                new Animal(4, "Afghan Shepherd", "Aa vuf vuf")
            };

            foreach (Animal polymorfAnimal in listPolymorphism  )     {
                Console.WriteLine(polymorfAnimal.AllInformation());
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}