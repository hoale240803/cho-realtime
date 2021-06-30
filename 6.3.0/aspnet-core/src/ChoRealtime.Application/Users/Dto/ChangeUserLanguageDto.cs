using System.ComponentModel.DataAnnotations;

namespace ChoRealtime.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}