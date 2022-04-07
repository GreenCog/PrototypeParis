using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Equipe
    {
        private string nom;

        public Equipe(string nom)
        {
            this.nom = nom;
        }

        public string getNom() { 
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }
    }
}
