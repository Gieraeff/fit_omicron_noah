using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Playlist
{
    public class MP3Item
    {
        public string _titel;
        public string _artist;
        public DateTime _duration;
        public Image _image;

        // todo path integration


        public Image Image { get; private set; }

        public DateTime Duration { get; private set; }

        public string Artist { get; private set; }
        public string Titel { get; private set; }
    }
}
