using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projekt_Playlist
{
    public class Playlist
    {
        private string _name;
        private string _autor;
        private List<string> _itemList;


        public string Name
        {
            get{ return _name; }
        }

        public string Autor
        {
            get { return _autor; }
        }

        public void Add(string name, string autor)
        {
            string adder = name;
            adder += autor;
            _itemList.Add(adder);
        }

        public void Remove(string name)
        {
            _itemList.Remove(name);
        }

        public void Clear()
        {

        }
        public void Load()
        {

        }

        public void Save()
        {

        }

    }
}
