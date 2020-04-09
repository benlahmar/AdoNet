using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto1
{
    class user
    {
        int id;
        string nom, log, pass, pays, ville;

        public user()
        {
        }

        public user(string nom, string log, string pass, string pays, string ville)
        {
            this.nom = nom;
            this.log = log;
            this.pass = pass;
            this.pays = pays;
            this.ville = ville;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Log { get => log; set => log = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Pays { get => pays; set => pays = value; }
        public string Ville { get => ville; set => ville = value; }
        public int Id { get => id; set => id = value; }
    }
}
