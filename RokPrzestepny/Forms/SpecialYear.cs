using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RokPrzestepny.Forms
{
    public class SpecialYear
    {
        [Display(Name = "Year")]
        [Required, Range(1899, 2023, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Year { get; set; }
        public string Name { get; set; }
        public string LeapYear()
        {
            if (Year%100==0 && Year%400!=0) 
                return "nieprzestepny";
            else
            if (Year%4==0) 
                return "przestepny";
            else
                return "nieprzestepny";
        }

        public bool IsGood()
        {
            if (Year.HasValue==true && Name!=null)
            {
                return true;
            }
            else
                return false;
        }
        


    }
}
