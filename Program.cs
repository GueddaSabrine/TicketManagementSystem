using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTicket
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        ///[STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            /*Console.WriteLine("Démarrage du programme...");

            // Création d'un spectacle
            var spectacle = new Spectacle
            {
                ID = 1,
                Titre = "Spectacle de test",
                Date = DateTime.Now,
                Lieu = "Salle de test",
                PlacesDisponibles = 100
            };

            // Création d'un utilisateur
            var utilisateur = new Utilisateur
            {
                ID = 1,
                Nom = "Utilisateur Test",
                HistoriqueReservations = new List<Billet>()
            };

            // Création d'un gestionnaire de billets
            var gestionnaire = new GestionnaireBillets();

            // Abonnement aux événements de réservation et d'annulation
            spectacle.ReserverBillets += (spectacleID, nombreBillets) => Console.WriteLine($"Événement de réservation pour le spectacle ID {spectacleID}, Nombre de billets : {nombreBillets}");
            spectacle.AnnulerReservations += (spectacleID, nombreBillets) => Console.WriteLine($"Événement d'annulation pour le spectacle ID {spectacleID}, Nombre de billets : {nombreBillets}");

            // Abonnement à l'événement d'ajout d'une réservation à l'historique utilisateur
            utilisateur.AjouterHistorique += (spectacleID, nombreBillets, statut) => Console.WriteLine($"Réservation ajoutée à l'historique : Spectacle ID {spectacleID}, Nombre de billets : {nombreBillets}, Statut : {statut}");

            Console.WriteLine("\nEffectuer une réservation...");

            // Exécution d'une réservation
            gestionnaire.ReserverBillets += (spectacleID, nombreBillets) =>
            {
                spectacle.EffectuerReservation(nombreBillets);
                utilisateur.AjouterReservationHistorique(spectacleID, nombreBillets, "Réservé");
            };

            gestionnaire.EffectuerReservation(spectacle.ID, 5);

            // Affichage du rapport des réservations de l'utilisateur
            var rapportUtilisateur = Rapport.RapportReservationsUtilisateur(utilisateur);
            Console.WriteLine("\nRapport des réservations de l'utilisateur :");
            foreach (var rapport in rapportUtilisateur)
            {
                Console.WriteLine(rapport);
            }

            Console.WriteLine("\nEffectuer une annulation...");

            // Exécution d'une annulation
            gestionnaire.AnnulerReservations += (spectacleID, nombreBillets) =>
            {
                spectacle.AnnulerReservation(nombreBillets);
                utilisateur.AjouterReservationHistorique(spectacleID, nombreBillets, "Annulé");
            };

            gestionnaire.AnnulerReservation(spectacle.ID, 2);

            // Affichage du rapport mis à jour
            rapportUtilisateur = Rapport.RapportReservationsUtilisateur(utilisateur);
            Console.WriteLine("\nRapport des réservations de l'utilisateur (après annulation) :");
            foreach (var rapport in rapportUtilisateur)
            {
                Console.WriteLine(rapport);
            }

            Console.WriteLine("\nFin du programme.");*/


        }
    }
}
