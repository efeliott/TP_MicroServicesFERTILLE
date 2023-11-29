
using Api.Reservation.Datas.Context;
using Api.Reservation.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Reservation.Datas.Repository
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        /// <summary>
        /// Context
        /// </summary>
        private readonly IApplicationDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilisateurRepository"/> class.
        /// </summary>
        /// <param name="context"></param>
        public UtilisateurRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Cette méthode permet de créer un nouvel utilisateur
        /// </summary>
        /// <param name="utilisateur">Informations du nouvel utilisateur</param>
        /// <returns></returns>
        public async Task<List<Entities.Utilisateur>> CreateUtilisateurAsync(Entities.Utilisateur utilisateur)
        {
            await _context.Utilisateurs.AddAsync(utilisateur);
            await _context.SaveChangesAsync();

            // Création d'une liste contenant uniquement l'utilisateur que vous venez d'ajouter
            List<Entities.Utilisateur> utilisateurs = new List<Entities.Utilisateur> { utilisateur };

            return utilisateurs;
        }

        /// <summary>
        /// Cette méthode permet de recupérer la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        public async Task<List<Entities.Utilisateur>> GetUtilisateurAsync()
        {
            return await _context.Utilisateurs
                .ToListAsync()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Cette méthode permet de recupérer un utilisateur en fonction de son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Entities.Utilisateur> GetUtilisateurByIdAsync(int id)
        {
            return await _context.Utilisateurs
                .FirstOrDefaultAsync(u => u.Id == id)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Méthode qui permet de supprimer un utilisateur en fonction de son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteUtilisateurByIdAsync(int id)
        {
            var utilisateur = await _context.Utilisateurs.FindAsync(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                await _context.SaveChangesAsync();
            }
        }
    }
}
