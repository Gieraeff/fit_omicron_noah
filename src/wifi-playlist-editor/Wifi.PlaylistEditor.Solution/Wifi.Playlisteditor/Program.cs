using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Core;
using Wifi.PlaylistEditor.Core.Factories;

namespace Wifi.Playlisteditor
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var playlistFactory = new PlaylistFactory();
            var playlistItemFactory = new PlaylistItemFactory();
            var playlistRepositoryFactory = new RepositoryFactory(playlistFactory,
                                                                                        playlistItemFactory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(playlistFactory, playlistItemFactory, playlistRepositoryFactory));
        }
    }
}
