using System.ComponentModel.DataAnnotations;

namespace CV_Abp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}