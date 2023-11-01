﻿
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


    }
}
