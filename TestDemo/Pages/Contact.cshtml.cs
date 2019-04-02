using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TestDemo.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        public ContactUsModel ContactUs { get; set; }

        public void OnGet()
        {
            Message = string.Empty;
        }

        public void OnPost()
        {

        }
    }

    public class ContactUsModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "How did you hear about us?")]
        public string Discovery { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "How can we help you?")]
        public string Inquiry { get; set; }
    }
}
