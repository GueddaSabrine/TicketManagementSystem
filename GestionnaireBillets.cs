using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicket
{


    class GestionnaireBillets
    {
        public event Spectacle.ReservationDelegate ReserverBillets;
        public event Spectacle.AnnulationDelegate AnnulerReservations;

        public void EffectuerReservation(int spectacleID, int nombreBillets)
        {
            ReserverBillets?.Invoke(spectacleID, nombreBillets);
            Console.WriteLine($"{nombreBillets} billets réservés pour le spectacle ID {spectacleID}.");
        }

        public void AnnulerReservation(int spectacleID, int nombreBillets)
        {
            AnnulerReservations?.Invoke(spectacleID, nombreBillets);
            Console.WriteLine($"{nombreBillets} réservation(s) annulée(s) pour le spectacle ID {spectacleID}.");
        }
    }
}
