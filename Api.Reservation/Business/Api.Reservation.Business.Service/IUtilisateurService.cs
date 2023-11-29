using Api.Reservation.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Reservation.Business.Service
{
    public interface IUtilisateurService
    {
        Task<Datas.Entities.Utilisateur> CreateUtilisateurAsync(Datas.Entities.Utilisateur utilisateur);

        Task<List<Datas.Entities.Utilisateur>> GetUtilisateurAsync();

        Task<Datas.Entities.Utilisateur> GetUtilisateurByIdAsync(int id);

        Task DeleteUtilisateurByIdAsync(int id);
    }
}
