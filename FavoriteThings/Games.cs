using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Games
    {

        //properties
        public string Title { get; set; }
        public Genre Color { get; set; }


    }

    enum Genre
    {
        RPG,
        FPS,
        RTS,
        MMO
    }
}
