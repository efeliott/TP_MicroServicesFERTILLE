
using Api.Reservation.Datas.Entities;
using Api.Reservation.Datas.Repository;
using Api.Reservation.Generals.Common;
using Microsoft.EntityFrameworkCore;


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

        /// <summary>
        /// Méthode qui permet de créer un utilisateur de manière asynchrone
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <returns></returns>
        public async Task<Datas.Entities.Utilisateur> CreateUtilisateurAsync(Datas.Entities.Utilisateur utilisateur)
        {
            // Le siège est disponible, procédez à la création de la réservation
            List<Datas.Entities.Utilisateur> utilisateurs = await _utilisateurRepository.CreateUtilisateurAsync(utilisateur)
                .ConfigureAwait(false);

            // Obtenez le premier utilisateur de la liste
            Datas.Entities.Utilisateur utilisateurCree = utilisateurs.FirstOrDefault();

            return utilisateurCree;
        }

        /// <summary>
        /// Méthode qui retourne la liste de tous les utilisateurs
        /// </summary>
        /// <returns></returns>
        public async Task<List<Datas.Entities.Utilisateur>> GetUtilisateurAsync()
        {
            return await _utilisateurRepository.GetUtilisateurAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Méthode qui retourne un utilisateur en fonction de l'id renseigné
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Datas.Entities.Utilisateur> GetUtilisateurByIdAsync(int id)
        {
            // Appelle la méthode du repository et retourne le résultat.
            return await _utilisateurRepository.GetUtilisateurByIdAsync(id)
                .ConfigureAwait(false);
        }

        public async Task DeleteUtilisateurByIdAsync(int id)
        {
            await _utilisateurRepository.DeleteUtilisateurByIdAsync(id);
        }
    }
}
