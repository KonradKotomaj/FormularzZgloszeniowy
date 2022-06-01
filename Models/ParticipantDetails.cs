using System.ComponentModel.DataAnnotations;

namespace ApplicationFormular.Models
{
    public class ParticipantDetails
    {
        [Required(ErrorMessage ="Proszę wpisać Imię i Nazwisko.")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage ="Proszę wpisać adres email.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Proszę wpisać numer telefonu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Proszę wybrać dzień")]
        public string DateChoice { get; set; }

        [Required(ErrorMessage ="Proszę potwierdzić uczestnictwo")]
        public bool? WillParticipate { get; set; }
        

        
    }
}
