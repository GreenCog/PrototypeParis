using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class Match
    {
        private int id;

        public int Getid()
        {
            return id;
        }

        public void Setid(int value)
        {
            id = value;
        }

        private List<Equipe> equipes;

        public List<Equipe> Getequipes()
        {
            return equipes;
        }

        public void Setequipes(List<Equipe> value)
        {
            equipes = value;
        }

        private int score_equipeA;

        public int Getscore_equipeA()
        {
            return score_equipeA;
        }

        public void Setscore_equipeA(int value)
        {
            score_equipeA = value;
        }

        private int score_equipeB;

        public int Getscore_equipeB()
        {
            return score_equipeB;
        }

        public void Setscore_equipeB(int value)
        {
            score_equipeB = value;
        }

        public Match(int id, List<Equipe> equipes, int score_equipeA, int score_equipeB)
        {
            this.Setid(id);
            this.Setequipes(equipes);
            this.Setscore_equipeA(score_equipeA);
            this.Setscore_equipeB(score_equipeB);
        }
    }
}
