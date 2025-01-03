using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Webhotel.Models;

namespace Webhotel.Controllers
{
    public class ReservationController : Controller
    {
        private readonly Database con = new Database();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reservation reservation)
        {
            // Vérifiez si les données du formulaire sont valides
            if (ModelState.IsValid)
            {
                // Ajouter la réservation à la base de données
                con.Reservations.Add(reservation);

                // Enregistrer les modifications dans la base de données
                con.SaveChanges();

                // Rediriger vers la liste des réservations après l'ajout
                return RedirectToAction("Index");
            }

            // Si le modèle n'est pas valide, afficher à nouveau le formulaire avec les erreurs
            return View(reservation);
        }
    }
}
