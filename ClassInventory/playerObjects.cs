using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassInventory
{
    internal class playerObjects
    {
        public string name, team, position;
        public int age;
        public playerObjects(string _name, string _team, string _position, int _age)
        {
            name = _name;
            team = _team;
            position = _position;
            age = _age;

        }
    }
}
