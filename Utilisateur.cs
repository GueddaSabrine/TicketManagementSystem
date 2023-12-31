using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicket
{
    public delegate void HistoriqueReservationDelegate(int spectacleID, int nombreBillets, string statut);

    class Utilisateur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public List<Billet> HistoriqueReservations { get; set; }
        // Autres détails de l'utilisateur

        // Délégué pour l'historique des réservations
        public delegate void HistoriqueReservationDelegate(int spectacleID, int nombreBillets, string statut);
        public HistoriqueReservationDelegate AjouterHistorique;

        // Méthode pour ajouter une réservation à l'historique
        public void AjouterReservationHistorique(int spectacleID, int nombreBillets, string statut)
        {
            HistoriqueReservations.Add(new Billet { IDSpectacle = spectacleID, IDUtilisateur = ID, StatutReservation = statut });
            AjouterHistorique?.Invoke(spectacleID, nombreBillets, statut);
        }
    }
}
