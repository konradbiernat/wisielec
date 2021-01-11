//Etap 1 stworzenie tablicy słów allWords

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] draw =
                {
                    "  _________",
                    "  |   |   |",
                    "  |   O   |",
                    "  |  /|\\  |",
                    "  |   |   |",
                    "  |  / \\  |",
                    " /|\\     /|\\",
                    "/ | \\   / | \\"
                }; //Stworzenie tablicy błędów gracza draw[]
                string[] allWords =
                {
                    "telefon",
                    "komputer",
                    "rewolwer",
                    "autostrada",
                    "programowanie",
                    "huragan",
                    "kompresja",
                    "kasztan",
                    "helikopter",
                    "kamper",
                    "butelka",
                    "kaskader",
                    "laptop",
                    "komputer",
                    "myszka",
                    "telefon",
                    "pilot",
                    "koniunkcja",
                    "operator",
                    "stolik",
                    "wyrewolwerowany",
                    "pastuch",
                    "owca",
                    "paluszki",
                    "krakersy",
                    "serwis",
                    "mieszkanie",
                    "balon",
                    "obiad",
                    "karygodny",
                    "krokodyl",
                    "autostrada",
                    "policja",
                    "konfident",
                    "bachor",
                    "kataklizm",
                    "wariatka",
                    "kontakt"
                }; //stworzenie tablicy słów allWords[]
                Random rand = new Random(); // zadeklarowanie zmiennej losującej
                string word; // zadeklarowanie zmiennej word
                int allWordsLen = allWords.Length; // zmienna okreslajaca ilosc elementów tablicy słów allWords[]
                int random = rand.Next(allWordsLen); // zmienna okreaslajaca losowa liczbe z zakresu ilosci elementów tablicy słów allWords[]
                word = allWords[random];  // losowanie słowa dla zmiennej word z tablicy słów allWords[]
                int wordLen = word.Length; // zmienna okreslajaca ilosc znaków zmiennej word
                char[] userWord = new char[wordLen]; //tablica wyswietlajaca aktualny stan gry
                for (int i = 0; i < wordLen; i++) //wypelnienie stanu gry samymi kreskami
                {
                    userWord[i] = '-';
                }
                int errCount = draw.Length; // zmienna okreslajaca maksymalna ilosc błędów gracza tj. liczbę elementów tablicy draw[]
                int err = 0; // zmienna określająca bieżącą ilość popełnionych błędów
                char[] errChars = new char[errCount]; // tablica przechowująca podane błędne litery
                bool game = true; // zmienna okreslajaca czy gracz ukończył grę
                for (int i = 0; i < errCount; i++) // Pętla rysująca wisielca z tablicy draw[]
                {
                    Console.WriteLine(draw[i]);
                }
                Console.WriteLine("\nNie daj się powiesić!\n");
                while (game) // pętla wykonująca się dopóki gracz nie ukończy gry
                {
                    for (int i = 0; i < err; i++) // pętla rysująca wisielca w zależności od ilości popełnionych błędów
                    {
                        Console.WriteLine(draw[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine(userWord); // komenda wyswietlająca aktualny stan gry
                    Console.WriteLine();
                    Console.Write("Podane błędne litery: ");
                    Console.Write(errChars); // komenda wyświetlająca podane błędne litery
                    Console.WriteLine("Pozostało prób: {0}", errCount - err); // komenda wyswietlajaca pozostałą ilość prób
                    Console.WriteLine("\nPodaj literę: "); 
                    string s = Console.ReadLine(); // komenda umozliwiajaca wprowadzenie znaków
                    char c;
                    if (s.Length > 0) // warunek ktory sprawdza czy wprowadziliśmy jakąkolwiek wartość
                        c = s.ElementAt(0); // zmienna przypisująca pierwszą literę wprowadzonego ciągu znaków
                    else // jeżeli gracz nie wprowadził żadnej wartości, pętla while(game) rozpocznie się od początku
                        continue;
                    bool charFound = false; // zmienna przechowująca informacje o tym czy wprowadzona litera znajduje się w wylosowanym słowie
                    bool win = false; // zmienna przechowująca dane o tym czy gracz wygrał
                    for (int i = 0; i < wordLen; i++) // pętla śledząca słowo w poszukiwaniu podanej litery
                    {
                        if (c == word.ElementAt(i)) // jeżeli wprowadzona litera znajduje się w słowie...
                        {
                            userWord[i] = c; // ...zastąp kreskę wprowadzoną literą
                            charFound = true; // Litera znajduje się w wylosowanym słowie, więc ustaw charFound na true
                        }
                        
