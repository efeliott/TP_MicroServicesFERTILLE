using Api.Reservation.Business.Service;
using Api.Reservation.Datas.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        // TODO
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateursController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }


        // GET api/<UtilisateursController>/5
        [HttpGet]
        public async Task<IActionResult> GetUtilisateurAsync()
        {
            var utilisateur = await _utilisateurService.GetUtilisateurAsync();
            if (utilisateur == null)
            {
                return NotFound();
            }
            return Ok(utilisateur);
        }

        // GET api/utilisateurs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUtilisateurById(int id)
        {
            try
            {
                var utilisateur = await _utilisateurService.GetUtilisateurByIdAsync(id);
                if (utilisateur == null)
                {
                    return NotFound(); // Retourne un code de statut 404 si l'utilisateur n'est pas trouvé
                }

                return Ok(utilisateur); // Retourne un code de statut 200 avec l'utilisateur
            }
            catch (Exception ex)
            {
                // Log l'exception si nécessaire
                return StatusCode(500, "Une erreur interne s'est produite."); // Retourne un code de statut 500 en cas d'exception
            }
        }

        // POST api/<UtilisateursController>
        [HttpPost]
        [ProducesResponseType(typeof(Datas.Entities.Utilisateur), 200)]
        public async Task<IActionResult> CreateUtilisateurAsync([FromBody] Datas.Entities.Utilisateur utilisateur)
        {
            return Ok(await _utilisateurService.CreateUtilisateurAsync(utilisateur));
        }

        // PUT api/<UtilisateursController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UtilisateursController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilisateurByIdAsync(int id)
        {
            try
            {
                await _utilisateurService.DeleteUtilisateurByIdAsync(id);
                return NoContent(); // Retourne un code de statut HTTP 204 No Content
            }
            catch (KeyNotFoundException)
            {
                return NotFound(); // Retourne un code de statut HTTP 404 Not Found
            }
        }
    }
}
