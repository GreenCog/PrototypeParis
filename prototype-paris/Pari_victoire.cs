using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Pari_victoire : Pari_match
    {
        private Equipe equipe;

        public Pari_victoire(int id, Match match, Equipe equipe, Utilisateur utilisateur, double montant) : base(id, match, utilisateur, montant)
        {
            this.equipe = equipe;
        }

        public Equipe getEquipe()
        {
            return equipe;
        }

        public void setEquipe(Equipe equipe)
        {
            this.equipe = equipe;
        }
    }
}
