
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
    }
}
