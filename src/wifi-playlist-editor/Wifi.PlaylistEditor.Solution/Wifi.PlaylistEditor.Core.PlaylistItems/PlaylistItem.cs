using System.IO;
using Id3;

namespace Wifi.PlaylistEditor.Core.PlaylistItems
{
    public class PlaylistItem
    {

        public void setPlaylistMP3Item(IPlaylistItem item)
        {

            string[] musicFiles = Directory.GetFiles(item.Path);
            foreach (string musicFile in musicFiles)
            {
                using (var mp3 = new Mp3(musicFile))
                {
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X);

                }
            }
        }
    }
}
