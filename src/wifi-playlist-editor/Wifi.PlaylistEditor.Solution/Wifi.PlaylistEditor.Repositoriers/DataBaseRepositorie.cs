using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Core;
using Wifi.PlaylistEditor.Repositoriers.Database;

namespace Wifi.PlaylistEditor.Repositoriers
{
    public class DataBaseRepositorie
    {
        private IDataBaseDriver<PlaylistEntity> _dataBaseDriver;
        private IPlaylistItemFactory _playlsitItemFactory;
        public  DataBaseRepositorie(IDataBaseDriver<PlaylistEntity> dataBaseDriver, IPlaylistItemFactory playlistItemFactory)
        {
            _dataBaseDriver = dataBaseDriver;
            _playlsitItemFactory = playlistItemFactory;
        }

        //public DataBaseRepositorie()
        //{
        //    //app.config file setting ? 
        //    var connection = "mongodb://admin:password@localhost:27017";

        //    //todo: get rid of instance generation parts
        //    _dataBaseDriver = new MongoDBDriver<PlaylistEntity>(connection, "playlist-db", "playlist-collection");
        //    //_playlsitItemFactory = new IPlaylistItemFactory();
        //}

        public async Task<IEnumerable<string>> LoadAllPlaylistTitles()
        {
            var playlist = await _dataBaseDriver.GetAllAsync();

            return playlist.Select(x => x.Titel);
        }

        public async Task<bool> SaveAsync(IPlaylist playlistToSave)
        {
            if (playlistToSave == null)
            {
                return false;
            }

            //is the title unique ? 
            var allPlaylistEntries = await _dataBaseDriver.GetAllAsync();
            var existingPlaylist = allPlaylistEntries.FirstOrDefault(x => x.Titel == playlistToSave.Name);
            if (existingPlaylist != null)
            {
                return false;
            }

            //convert domain => entity

            var entity = playlistToSave.ToEntity();

            await _dataBaseDriver.CreateAsync(entity);
            return true;
        }

        public async Task<IPlaylist> Load(string playlistTitel)
        {

            var allPlaylistEntries = await _dataBaseDriver.GetAllAsync();
            var entity = allPlaylistEntries.FirstOrDefault(x => x.Titel == playlistTitel);

            if (entity == null)
            {
                return null;
            }

            //convert entity => domain
            return entity.ToDomain(_playlsitItemFactory);
        }
    }
}
