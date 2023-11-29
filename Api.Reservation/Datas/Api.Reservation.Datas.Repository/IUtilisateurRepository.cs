
using Api.Reservation.Datas.Entities;

namespace Api.Reservation.Datas.Repository
{
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Cette méthode permet de créer un nouveel utilisateur
        /// </summary>
        /// <param name="utilisateur">Les informations du nouvel utilisateur</param>
        /// <returns></returns>
        Task<List<Entities.Utilisateur>> CreateUtilisateurAsync(Entities.Utilisateur utilisateur);

        /// <summary>
        /// Cette méthode permet de visionner tous les utilisateurs
        /// </summary>
        /// <returns></returns>
        Task<List<Entities.Utilisateur>> GetUtilisateurAsync();

        /// <summary>
        /// Cette méthode permet de visionner un utilisateur par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Entities.Utilisateur> GetUtilisateurByIdAsync(int id);

        /// <summary>
        /// Cette méthode permet de supprimer un utilisateur selon son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteUtilisateurByIdAsync(int id);
    }
}
