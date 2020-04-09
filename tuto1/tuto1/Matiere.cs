using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto1
{
    class Matiere
    {
        int id;
        string libelle;
        double note;

        Etudiant e;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public double Note { get => note; set => note = value; }
        internal Etudiant E { get => e; set => e = value; }
    }
}
