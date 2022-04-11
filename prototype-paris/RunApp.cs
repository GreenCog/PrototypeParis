using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_paris
{
    public class RunApp
    {
        
        public double montantTotal;
        public double montantGagnants;
        double plateforme;

        public RunApp() { }

        public void Run() {
            montantTotal = 0 ;
            montantGagnants = 0 ;
            plateforme = 0 ;
            


            List<Pari> gagnants = new List<Pari>();
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
            
            Pari_victoire paris_victoire1 = new Pari_victoire(1, match, equipeA, utilisateur1, 200);
            Pari_victoire paris_victoire2 = new Pari_victoire(2, match, equipeA, utilisateur2, 100);
            Pari_victoire paris_victoire3 = new Pari_victoire(3, match, equipeA, utilisateur3, 150);
            Pari_victoire paris_victoire4 = new Pari_victoire(4, match, equipeA, utilisateur4, 320);
            Pari_victoire paris_victoire5 = new Pari_victoire(5, match, equipeA, utilisateur5, 50);
            Pari_victoire paris_victoire6 = new Pari_victoire(6, match, equipeA, utilisateur6, 35);
            Pari_victoire paris_victoire7 = new Pari_victoire(7, match, equipeB, utilisateur7, 550);
            Pari_victoire paris_victoire8 = new Pari_victoire(8, match, equipeB, utilisateur8, 90);
            
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
                    gagnants.Add(p);
                    Console.WriteLine("Gagnant: " + p.getParieur().getNomUtilisateur());
                    montantGagnants += p.getMontant();
                }
            }

            Console.WriteLine("Montant total: " + montantTotal);
            plateforme = (montantTotal- montantGagnants) * 0.1;
            montantTotal -= plateforme;
            Console.WriteLine("Plateforme: " + plateforme);
            Console.WriteLine("Montant total à redistribuer: " + montantTotal);
            montantTotal -= montantGagnants;
            Console.WriteLine("Montant total à répartir: " + montantTotal);

            foreach (Pari_victoire g in gagnants)
            {
                double pourcentageTotalGagnant = g.getMontant() / montantGagnants;
                double a_redistribuer = Math.Round((montantTotal * pourcentageTotalGagnant), 2);

                Console.WriteLine("Gagnant: " + g.getParieur().getNomUtilisateur() + " a parier: " + g.getMontant() + " gagne : " + a_redistribuer); 
            }
        }
        public void RunScore()
        {
             montantTotal = 0 ;
            montantGagnants = 0 ;
            plateforme = 0 ;
            


            List<Pari> gagnants = new List<Pari>();

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

            //perdant
            Pari_score pari_score1 = new Pari_score(1,match, equipeA,utilisateur1, 50 , 1);
            Pari_score pari_score2 = new Pari_score(2,match, equipeA,utilisateur1, 100 , 2);
            Pari_score pari_score3 = new Pari_score(3,match, equipeB,utilisateur1, 50 , 3);
            Pari_score pari_score4 = new Pari_score(4,match, equipeB,utilisateur1, 20 , 1);

            //gagnant 

            Pari_score pari_score5 = new Pari_score(5,match, equipeA,utilisateur1, 200 , 3);
            Pari_score pari_score6 = new Pari_score(6,match, equipeA,utilisateur1, 50 , 3);
            Pari_score pari_score7 = new Pari_score(7,match, equipeB,utilisateur1, 50 , 2);
            Pari_score pari_score8 = new Pari_score(8,match, equipeB,utilisateur1, 50 , 2);

            List<Pari> paris = new List<Pari>();
            paris.Add(pari_score1);
            paris.Add(pari_score2);
            paris.Add(pari_score3);
            paris.Add(pari_score4);
            paris.Add(pari_score5);
            paris.Add(pari_score6);
            paris.Add(pari_score7);
            paris.Add(pari_score8);

            foreach (Pari_score p in paris)
            {
                montantTotal += p.getMontant();

                if (p.Equipe.getNom() == "EquipeA") {
                    if (p.Score == p.getMatch().Getscore_equipeA())
                    {
                        gagnants.Add(p);
                        Console.WriteLine("Gagnant: " + p.getParieur().getNomUtilisateur());
                        montantGagnants += p.getMontant();
                    }
                   
                }
                else
                {
                    if (p.Score == p.getMatch().Getscore_equipeB())
                    {
                        gagnants.Add(p);
                        Console.WriteLine("Gagnant: " + p.getParieur().getNomUtilisateur());
                        montantGagnants += p.getMontant();
                    }
                }
            }

            Console.WriteLine("Montant total: " + montantTotal);
            plateforme = (montantTotal-montantGagnants )* 0.1;
            montantTotal -= plateforme;
            Console.WriteLine("Plateforme: " + plateforme);
            Console.WriteLine("Montant total à redistribuer: " + montantTotal);
            montantTotal -= montantGagnants;
            Console.WriteLine("Montant total à répartir: " + montantTotal);

            foreach (Pari_score g in gagnants)
            {
                double pourcentageTotalGagnant = g.getMontant() / montantGagnants;
                double a_redistribuer = Math.Round((montantTotal * pourcentageTotalGagnant), 2);

                Console.WriteLine("Gagnant: " + g.getParieur().getNomUtilisateur() + " a parier: " + g.getMontant() + " gagne : " + a_redistribuer); 
            }

        }
    }
}
