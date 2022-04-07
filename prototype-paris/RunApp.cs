using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class RunApp
    {
        private double montantTotal;
        private double montantGagnants;
        private double plateforme;
        public List<Utilisateur> gagnants = new List<Utilisateur>();
        public RunApp() { }

        public void Run() {
            Equipe equipeA = new Equipe("EquipeA");
            Equipe equipeB = new Equipe("EquipeB");

            List<Equipe> equipeList = new List<Equipe>();
            equipeList.Add(equipeA);
            equipeList.Add(equipeB);
            
            Match match = new Match(1, equipeList, 3, 2);
            
            Utilisateur utilisateur1 = new Utilisateur(1, "Tom");
            Utilisateur utilisateur2 = new Utilisateur(2, "Bob");
            Utilisateur utilisateur3 = new Utilisateur(3, "John");
            Utilisateur utilisateur4 = new Utilisateur(4, "Tanguy");
            Utilisateur utilisateur5 = new Utilisateur(5, "Dany");
            Utilisateur utilisateur6 = new Utilisateur(6, "Michael");
            Utilisateur utilisateur7 = new Utilisateur(7, "Mateo");
            Utilisateur utilisateur8 = new Utilisateur(8, "Daniel");
            
            Pari_victoire paris_victoire1 = new Pari_victoire(1, match, equipeA, utilisateur1, 100);
            Pari_victoire paris_victoire2 = new Pari_victoire(2, match, equipeA, utilisateur2, 100);
            Pari_victoire paris_victoire3 = new Pari_victoire(3, match, equipeA, utilisateur3, 100);
            Pari_victoire paris_victoire4 = new Pari_victoire(4, match, equipeA, utilisateur4, 100);
            Pari_victoire paris_victoire5 = new Pari_victoire(5, match, equipeA, utilisateur5, 100);
            Pari_victoire paris_victoire6 = new Pari_victoire(6, match, equipeA, utilisateur6, 100);
            Pari_victoire paris_victoire7 = new Pari_victoire(7, match, equipeB, utilisateur7, 100);
            Pari_victoire paris_victoire8 = new Pari_victoire(8, match, equipeB, utilisateur8, 100);
            
            List<Pari> paris = new List<Pari>();
            paris.Add(paris_victoire1);
            paris.Add(paris_victoire2);
            paris.Add(paris_victoire3);
            paris.Add(paris_victoire4);
            paris.Add(paris_victoire5);
            paris.Add(paris_victoire6);
            paris.Add(paris_victoire7);
            paris.Add(paris_victoire8);

            foreach (Pari_victoire p in paris)
            {
                montantTotal += p.getMontant();

                if (p.getMatch().Getscore_equipeA() > p.getMatch().Getscore_equipeB() && p.getEquipe().getNom() == p.getMatch().Getequipes()[0].getNom()) {
                    gagnants.Add(p.getParieur());
                    Console.WriteLine("Gagnant: " + p.getParieur().getNomUtilisateur());
                }
            }

            Console.WriteLine("Montant total: " + montantTotal);
            plateforme = montantTotal * 0.1;
            montantTotal -= plateforme;
            Console.WriteLine("Plateforme: " + plateforme);
            Console.WriteLine("Montant total redistribué: " + montantTotal);
        }
    }
}
