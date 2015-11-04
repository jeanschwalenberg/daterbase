using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daterbase.Models
{
    public enum Volatile
    {
        //TODO some sort of crude compatibility ranking
    }

    public class Match
    {
        //TODO need userID or some way to second DaterID
        public int DaterID { get; set; }
        public int MatchID { get; set; }

        public virtual Dater Dater { get; set; }


    }
}
