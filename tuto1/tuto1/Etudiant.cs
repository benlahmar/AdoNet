using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuto1
{
    class Etudiant : user
    {
        string code;
        string filiere;

        List<Matiere> notes=new List<Matiere>();

        public Etudiant()
        {
        }

        public string Code { get => code; set => code = value; }
        public string Filiere { get => filiere; set => filiere = value; }
        internal List<Matiere> Notes { get => notes; set => notes = value; }
    }

}
