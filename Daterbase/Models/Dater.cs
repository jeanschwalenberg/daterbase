using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Daterbase.Models
{

    public enum GenderEnum { male, female, open };

    public class Dater
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DaterID { get; set; }
        [DisplayName("Name:")]
        public string Username { get; set; }
        public int Age { get; set; }
        public int DMinimumAge { get; set; }
        public int DMaximumAge { get; set; }
        public int Gender { get; set; }
        public GenderEnum DGender { get; set; }
        public bool IsEmployed { get; set; }
        public bool IsStudent { get; set; }
        public bool DNoScrubs { get; set; }             //false = unwilling to date unemployed and out of school
        public int ZipCode { get; set; }
        public bool DWillingToTravel { get; set; }

        public virtual ICollection<Match> Matchs { get; set; }
    }
}

