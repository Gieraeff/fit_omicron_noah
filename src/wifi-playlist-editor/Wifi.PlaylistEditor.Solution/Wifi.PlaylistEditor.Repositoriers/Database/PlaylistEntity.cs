using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Repositoriers.Database
{
    public class PlaylistEntity
    {
        public string Titel  { get; set; }
        public string Author { get; set; }
        public string CreateAt { get; set; }
        public IEnumerable<string> ItemPathList { get; set; }
    }
}