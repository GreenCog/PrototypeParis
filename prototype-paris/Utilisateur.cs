using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Utilisateur
    {
        private int id;
        private string nom_utilisateur;

        public Utilisateur(int id, string nom_utilisateur)
        {
            this.id = id;
            this.nom_utilisateur = nom_utilisateur;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getNomUtilisateur()
        {
            return nom_utilisateur;
        }

        public void setNomUtilisateur(string nom)
        {
            this.nom_utilisateur = nom;
        }
    }
}
