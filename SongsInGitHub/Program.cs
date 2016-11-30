using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsInGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;

            string[] song1 = { "Creep", "Radiohead", "192", "rock" };
            string[] song2 = { "Jazzy", "Jonny", "280", "jazz" };
            string[] song3 = { "Morning", "BB-King", "473", "blues" };
            string[] song4 = { "Kazzt", "Bravo", "330", "jazz" };

            string[][] songsList = { song1, song2, song3, song4 };

            for (int i = 0; i < songsList.Length; i++)
            {
                Console.WriteLine("Song " + (i +1));

                for (int j = 0; j < songsList[i].Length; j++)
                {
                    Console.WriteLine("\t" + songsList[i][j].ToString());

                }

                Console.WriteLine();
                Console.WriteLine("____________________");
            }
            Console.WriteLine();
            Console.WriteLine("1. Edit song's name   2. Find longest song   3. Print all song by gender");
            Console.WriteLine();

            int selectionMenu = int.Parse(Console.ReadLine());

            switch(selectionMenu)
            {
                case 1:
                    Console.WriteLine("Wich name would you like to change?");
                    string songName = Console.ReadLine();
                    Console.WriteLine("What is the new name?");
                    string newName = Console.ReadLine();
                    bool doneAction = false;

                    for (int i = 0; i < songsList.Length; i++)
                    {
                        for (int j = 0; j < songsList[i].Length; j++)
                        {
                            if (songsList[i].Contains(songName))
                            {
                                
                                songsList[i][0] = newName;
                                doneAction = true;
                                break;
                                
                            }
                            else
                            {
                               
                                break;
                            }
                            
                        }


                        if (doneAction)
                            break;
                        else
                        {
                            Console.WriteLine("Name does no exist!");
                            break;
                        }

                    }

                    for (int i = 0; i < songsList.Length; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Song " + (i + 1));

                        for (int j = 0; j < songsList[i].Length; j++)
                        {
                            Console.WriteLine("\t" + songsList[i][j].ToString());

                        }

                        Console.WriteLine();
                        Console.WriteLine("____________________");
                    }

                    break;

                case 2:
                    int[] durations = new int[songsList.Length];

                    for (int i = 0; i < songsList.Length; i++)
                    {
                        durations[i] = int.Parse(songsList[i][2]);
                    }
                    int longestSong = durations.Max();
                    int indexLongestSong = Array.IndexOf(durations, longestSong);

                    for (int i = 0; i < durations.Length; i++)
                    {
                        Console.WriteLine("\t" + songsList[indexLongestSong][i].ToString());
                    }
                    break;

                case 3:
                    Console.WriteLine("Wich gender are you looking for?");
                    string gender = Console.ReadLine();

                    for (int i = 0; i < songsList.Length; i++)
                    {
                        for (int j = 0; j < songsList[i].Length; j++)
                        {
                            if (songsList[i].Contains(gender))
                            {
                                Console.WriteLine("\t" + songsList[i][j].ToString());
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("________________");
                    }
                    break;
            }
        }
    }
}
