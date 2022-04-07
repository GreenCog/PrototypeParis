using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Pari_match : Pari
    {
        private Match match;

        public Pari_match(int id, Match match, Utilisateur utilisateur, double montant) : base(id, utilisateur, montant)
        {
            this.match = match;
        }

        public Match getMatch()
        {
            return match;
        }

        public void setMatch(Match match)
        {
            this.match = match;
        }
    }
}
