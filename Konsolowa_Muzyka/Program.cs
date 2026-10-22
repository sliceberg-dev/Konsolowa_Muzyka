using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Utwor[] utwory = new Utwor[100];

        string[] linie = File.ReadAllLines("Data.txt");
        int i = 0;
        foreach (string linia in linie)
        {
            if (linia == "") { i++; }
            else
            {
                utwory[i] = new Utwor((linie[i*6+0]), (linie[i * 6 + 1]), int.Parse(linie[i * 6 + 2]), int.Parse(linie[i * 6 + 3]), long.Parse(linie[i * 6 + 4]));
            }
        }
        int j = 0;
        // for (int j = 0; j < utwory.Length; j++)
        do
        {
            utwory[j].Wyswietl();
            j++;
        } while (utwory[j] != null);
    }

    class Utwor
    {
        public string artist;
        public string album;
        public int songsNumber;
        public int year;
        public long downloadNumber;

        public Utwor(string artist, string album, int songsNumber, int year, long downloadNumber)
        {
            this.artist = artist;
            this.album = album;
            this.songsNumber = songsNumber;
            this.year = year;
            this.downloadNumber = downloadNumber;
        }
        public void Wyswietl()
        {
            Console.WriteLine(artist);
            Console.WriteLine(album);
            Console.WriteLine(songsNumber);
            Console.WriteLine(year);
            Console.WriteLine(downloadNumber);
            Console.WriteLine();

        }

    }
}