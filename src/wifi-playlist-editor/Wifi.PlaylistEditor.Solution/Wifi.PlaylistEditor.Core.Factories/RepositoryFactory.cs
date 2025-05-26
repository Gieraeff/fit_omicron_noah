using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Repositories;

namespace Wifi.PlaylistEditor.Core.Factories
{
    public class RepositoryFactory : IPlaylistRepositoryFactory
    {
        private readonly IPlaylistFactory _playlistFactory;
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public RepositoryFactory(IPlaylistFactory playlistFactory,
                                IPlaylistItemFactory playlistItemFactory) 
        { 
            _playlistItemFactory = playlistItemFactory;
            _playlistFactory = playlistFactory;
        }
        public IPlaylistRepository AvailableTypes => throw new NotImplementedException();

        public IPlaylistRepository Create(string filePath)
        {
            IPlaylistRepository repository = null;

            //retrieve the playlist file extension
            var extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case ".m3u":
                    repository = new M3uRepository(_playlistFactory, _playlistItemFactory);
                    break;

                case ".pls":
                    repository = new PlsRepository(_playlistFactory, _playlistItemFactory);
                    break;

                default:
                    repository = null;
                    break;
            }

            return repository;
        }
    }
}
