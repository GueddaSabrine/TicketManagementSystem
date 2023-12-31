using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicket
{
    public delegate void ReservationDelegate(int spectacleID, int nombreBillets);
    public delegate void AnnulationDelegate(int spectacleID, int nombreBillets);

    class Spectacle
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public int PlacesDisponibles { get; set; }

        // Délégué pour gérer la réservation de billets
        public delegate void ReservationDelegate(int spectacleID, int nombreBillets);
        public ReservationDelegate ReserverBillets;

        // Délégué pour gérer l'annulation de réservations
        public delegate void AnnulationDelegate(int spectacleID, int nombreBillets);
        public AnnulationDelegate AnnulerReservations;

        // Méthode pour effectuer la réservation
        public void EffectuerReservation(int nombreBillets)
        {
            if (PlacesDisponibles >= nombreBillets)
            {
                PlacesDisponibles -= nombreBillets;
                ReserverBillets?.Invoke(ID, nombreBillets);
                Console.WriteLine($"{nombreBillets} billets réservés pour le spectacle '{Titre}'.");
            }
            else
            {
                Console.WriteLine("Nombre de places insuffisant pour effectuer la réservation.");
            }
        }

        // Méthode pour annuler la réservation
        public void AnnulerReservation(int nombreBillets)
        {
            PlacesDisponibles += nombreBillets;
            AnnulerReservations?.Invoke(ID, nombreBillets);
            Console.WriteLine($"{nombreBillets} réservation(s) annulée(s) pour le spectacle '{Titre}'.");
        }

    }
}
