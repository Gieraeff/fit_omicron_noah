using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Core.Factories
{
    public class PlaylistFactory : IPlaylistFactory
    {
        public IPlaylist Create(string title, string author, DateTime createAt)
        {

            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author)) return null;

            return new Playlist(title, author, createAt);
        }
    }
}
