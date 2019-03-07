using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Games
    {

        //properties
        public string Title { get; set; }
        public Genres Genre { get; set; }

        public Games(string title, Genres genre)
        {
            Title = title;
            Genre = genre;
        }

        public void Start()
        {
            Console.WriteLine($"{Title} started up, it is a {Genre}");
            Console.ReadLine();
        }

        public void Play()
        {
            Console.WriteLine("Played the game");
        }


    }

    enum Genres
    {
        RPG,
        FPS,
        RTS,
        MMO
    }
}
