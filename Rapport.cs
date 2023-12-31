using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTicket
{
    class Rapport
    {
        //Rapport sur les réservations d'un utilisateur
        public static List<string> RapportReservationsUtilisateur(Utilisateur utilisateur)
        {
            return utilisateur.HistoriqueReservations
                .Select(b => $"Spectacle ID {b.IDSpectacle}, Statut : {b.StatutReservation}")
                .ToList();
        }
    }
}
