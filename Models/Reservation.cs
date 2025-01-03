using System.ComponentModel.DataAnnotations;

namespace Webhotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom complet est requis.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        [Phone(ErrorMessage = "Numéro de téléphone invalide.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "L'adresse email est requise.")]
        [EmailAddress(ErrorMessage = "Adresse email invalide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le nombre de jours est requis.")]
        [Range(1, 365, ErrorMessage = "Veuillez entrer un nombre valide de jours.")]
        public int Days { get; set; }

        [Required(ErrorMessage = "Le nombre d'adultes est requis.")]
        [Range(1, 10, ErrorMessage = "Veuillez entrer un nombre valide d'adultes.")]
        public int NoOfAdults { get; set; }
    }
}
