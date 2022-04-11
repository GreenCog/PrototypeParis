using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    
    public class Pari_score: Pari_match
    {
        private int score;
        private Equipe equipe;
        

        public Pari_score(int id, Match match, Equipe equipe, Utilisateur utilisateur, double montant, int score): base(id, match, utilisateur, montant)
        {
            this.score = score;
            
            this.equipe = equipe;   
            
        }

        public int Score { get => score ; set => score = value;}
        
        public Equipe Equipe { get => equipe ; set => equipe = value;}
        
        

    }
}
