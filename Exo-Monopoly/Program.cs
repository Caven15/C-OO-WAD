using Exo_Monopoly.Enums;
using Exo_Monopoly.Interfaces;
using Exo_Monopoly.Models;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Demo Sam
            /*  Test de la class De
De.valeurMax = 20;

int[] lances = De.Lancer(5);
foreach (int lance in lances)
{
    Console.WriteLine(lance);
}*/

            /* Test de la class Joueur 

            Joueur j1 = new Joueur() { 
                Nom = "Samuel",
                Pion = Pions.Dino
            };

            Console.WriteLine($"Le premier joueur : {j1.Nom} ; va jouer avec le pion {j1.Pion}.");
            Console.WriteLine($"{j1.Nom} vous êtes en case {j1.Position}, lancer les dés!");
            Console.ReadLine();
            if (j1.Avancer())
            {
                Console.WriteLine("Super un double!");
            }
            Console.WriteLine($"Vous avancer à la case {j1.Position}");*/

            /* Test de la class CasePropriete */

            //Random RNG = new Random();
            //Couleurs[] couleurs = Enum.GetValues<Couleurs>();
            //CasePropriete casePlateau = new CasePropriete("Classe des WAD", couleurs[RNG.Next(couleurs.Length)], 500 );

            //Joueur j1 = new Joueur("Samuel", Pions.Dino);
            //casePlateau.Acheter(j1);

            //Console.WriteLine($"{j1.Nom} avec le pion {j1.Pion} a actuellement {j1.Solde} crédit Monopoly, et possède {j1.Proprietes.Length} propriété(s)");
            //foreach (CasePropriete prop in j1.Proprietes)
            //{
            //    Console.WriteLine($"\t- {prop.Nom} ({prop.Couleur}) à {prop.Proprietaire?.Nom ?? "Disponible"}");
            //}
            #endregion

            #region Demo Alex

            #region Demo_1
            //CasePropriete[] plateau = new CasePropriete[]
            //{
            //    new CasePropriete("Départ", Couleurs.Neutre, 0),
            //    new CasePropriete("Avenue Louise", Couleurs.Bleu, 400)
            //};

            //Jeu monopoly = new Jeu(plateau);

            //try
            //{
            //    // Test ajout normal...
            //    monopoly.AjouterJoueur("Carlos", Pions.Chapeau);
            //    Console.WriteLine("Carlos ajouté au jeu !");

            //    // Test ajout doublon (doit me déclencher une exception)
            //    monopoly.AjouterJoueur("Bob l'éponge", Pions.Chapeau);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Succès du test d'erreur : {ex.Message} ");
            //}
            #endregion


            #endregion

            #region Correctifs - Srucharge

            //Joueur joueur = new Joueur("Toto", Pions.Brouette);
            //CasePropriete caseProp = new CasePropriete("Avenue louise", Couleurs.Bleu, 400);

            //Console.WriteLine("--- État initial ---");
            //Console.WriteLine($"Nom : {joueur.Nom} | Solde : {joueur.Solde} euro.");

            //// Simuler + int
            //joueur = joueur + 200;
            //Console.WriteLine($"Nouveau Solde : {joueur.Solde} euro.");

            //// Simuler CasePropriete  
            //Console.WriteLine($"\n--- Test Achat (j + CasePropriete) ---");
            //CasePropriete[] mesPosession = joueur + caseProp;

            //if (mesPosession.Length > 0)
            //{
            //    Console.WriteLine($"Nom du titre possédé : {mesPosession[0].Nom}");
            //}

            #endregion

            #region Correctif Abstract

            //CasePropriete avenueLouise = new CasePropriete("Avenue Louise", Couleurs.Bleu, 400);

            //Joueur joueur1 = new Joueur("Toto", Pions.Voiture);
            //Joueur joueur2 = new Joueur("Jhon", Pions.Chapeau);

            //Console.WriteLine("--- Arrivée de toto ---");
            //avenueLouise.AjouterVisiteur(joueur1);
            //Console.WriteLine($"Propriétaire : {avenueLouise.Proprietaire?.Nom}");
            //Console.WriteLine($"Solde du joueur 1 : {joueur1.Solde} 🪙");

            //Console.WriteLine("--- Arrivée de Jhon ---");

            //avenueLouise.AjouterVisiteur(joueur2);
            //Console.WriteLine($"Propriétaire : {avenueLouise.Proprietaire?.Nom}");
            //Console.WriteLine($"Solde du joueur 1 : {joueur1.Solde} €");
            #endregion

            #region Correctif Interfaces

            // 1 => Polymorphisme avec IVisiteur
            // On créer une liste d'interface : On ne sait pas ce qu'il y dedans
            // ON sait juste qu'ils ont tous le méthode Activer()

            List<IVisiteur> caseAvisiter = new List<IVisiteur>();

            Joueur jojo = new Joueur("Le Grand Jojo", Pions.Dino);
            Console.WriteLine($"Solde de départ de jojo : {jojo.Solde}");

            CasePropriete AvenueLouise = new CasePropriete("Avenue Louise", Couleurs.Bleu, 400);
            caseAvisiter.Add(AvenueLouise);


            foreach (IVisiteur visiteur in caseAvisiter)
            {
                // On appelle Activer() Sur l'interface, peut importe la classe réelle
                visiteur.Activer(jojo);
             }

            Console.WriteLine("PRopriétaire :" + AvenueLouise.Proprietaire?.Nom);

            // 2 => Polymorphisme avec IPropriétaire
            // On traite la rue uniquement sous l'angle gestion financière
            IProprietaire titreJojo = AvenueLouise;

            Console.WriteLine($"Solde de de jojo après aquisition de L'avenueLouise: {jojo.Solde}");


            titreJojo.Hypothequer();
            Console.WriteLine($"Hypotèqye activé, solde jojo (+50%) {jojo.Solde} €");
            Console.WriteLine($"est hypotéquée ? : {titreJojo.EstHypotequee}");

            titreJojo.Deshypothequer();
            Console.WriteLine($"Hypotèque levée, solde jojo (-60%) {jojo.Solde}");

            #endregion
        }
    }
}
