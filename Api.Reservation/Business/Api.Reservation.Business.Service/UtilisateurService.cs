
using Api.Reservation.Datas.Entities;
using Api.Reservation.Datas.Repository;
using Api.Reservation.Generals.Common;

namespace Api.Reservation.Business.Service
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IReservationRepository _reservationRepository;

        private readonly IUtilisateurRepository _utilisateurRepository;

        private readonly IFlightsApi _flightsApi;

        public UtilisateurService(IReservationRepository reservationRepository, IUtilisateurRepository utilisateurRepository, IFlightsApi flightsApi)
        {
            _reservationRepository = reservationRepository;
            _utilisateurRepository = utilisateurRepository;
            _flightsApi = flightsApi;
        }
        public async Task<Datas.Entities.Utilisateur> CreateUtilisateurAsync(Datas.Entities.Utilisateur utilisateur)
        {
            // Le siège est disponible, procédez à la création de la réservation
            List<Datas.Entities.Utilisateur> utilisateurs = await _utilisateurRepository.CreateUtilisateurAsync(utilisateur)
                .ConfigureAwait(false);

            // Obtenez le premier utilisateur de la liste
            Datas.Entities.Utilisateur utilisateurCree = utilisateurs.FirstOrDefault();

            return utilisateurCree;
        }
    }
}
