using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Daterbase.Models;

namespace Daterbase.Data
{
    public class FillingTheDatingPool : System.Data.Entity.DropCreateDatabaseIfModelChanges<TheDaterbase>
    {
        protected override void Seed(TheDaterbase context)
        {
            var daters = new List<DaterProfile>
            {
                new DaterProfile{Username="BeautifulTragity",Age=25,DMinimumAge=18,DMaximumAge=60,Gender=1,DGender=GenderEnum.male,IsEmployed=false,IsStudent=true,DNoScrubs=true,ZipCode=80120,DWillingToTravel=false},
                new DaterProfile{Username="MarshallMusician",Age=41,DMinimumAge=18,DMaximumAge=36,Gender=0,DGender=GenderEnum.male,IsEmployed=true,IsStudent=false,DNoScrubs=false,ZipCode=80222,DWillingToTravel=true},
                new DaterProfile{Username="ArielDancer",Age=25,DMinimumAge=25,DMaximumAge=35,Gender=1,DGender=GenderEnum.open,IsEmployed=true,IsStudent=true,DNoScrubs=true,ZipCode=80025,DWillingToTravel=false},
                new DaterProfile{Username="ByronBeard",Age=33,DMinimumAge=28,DMaximumAge=38,Gender=0,DGender=GenderEnum.female,IsEmployed=true,IsStudent=false,DNoScrubs=false,ZipCode=80222,DWillingToTravel=true},
                new DaterProfile{Username="TaylorFace",Age=28,DMinimumAge=25,DMaximumAge=31,Gender=1,DGender=GenderEnum.female,IsEmployed=true,IsStudent=true,DNoScrubs=true,ZipCode=80222,DWillingToTravel=true},
                new DaterProfile{Username="HipHipHeyyyy",Age=27,DMinimumAge=20,DMaximumAge=30,Gender=0,DGender=GenderEnum.open,IsEmployed=true,IsStudent=false,DNoScrubs=true,ZipCode=80222,DWillingToTravel=false},
                new DaterProfile{Username="AndroJenny",Age=29,DMinimumAge=25,DMaximumAge=45,Gender=1,DGender=GenderEnum.female,IsEmployed=true,IsStudent=false,DNoScrubs=false,ZipCode=80222,DWillingToTravel=true},
                new DaterProfile{Username="Art'sArt'Arty",Age=26,DMinimumAge=19,DMaximumAge=40,Gender=0,DGender=GenderEnum.open,IsEmployed=true,IsStudent=false,DNoScrubs=false,ZipCode=80025,DWillingToTravel=false},
                new DaterProfile{Username="SenatorQuiltbag",Age=22,DMinimumAge=22,DMaximumAge=35,Gender=2,DGender=GenderEnum.male,IsEmployed=false,IsStudent=false,DNoScrubs=true,ZipCode=80222,DWillingToTravel=false},
                new DaterProfile{Username="CoryHasABigCar",Age=36,DMinimumAge=25,DMaximumAge=45,Gender=0,DGender=GenderEnum.open,IsEmployed=false,IsStudent=false,DNoScrubs=true,ZipCode=80224,DWillingToTravel=false},
            };

            daters.ForEach(d => context.DaterProfiles.Add(d));
            context.SaveChanges();
        }
    }
}
