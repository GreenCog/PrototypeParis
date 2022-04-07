using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Pari
    {
        private int id;
        private Utilisateur parieur;
        private double montant;

        public Pari(int id, Utilisateur parieur, double montant)
        {
            this.id = id;
            this.parieur = parieur;
            this.montant = montant;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public Utilisateur getParieur()
        {
            return parieur;
        }

        public void setParieur(Utilisateur parieur)
        {
            this.parieur = parieur;
        }

        public double getMontant()
        {
            return montant;
        }

        public void setMontant(double montant)
        {
            this.montant = montant;
        }
    }
}
