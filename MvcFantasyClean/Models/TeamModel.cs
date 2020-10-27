using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFantasyClean.Models {

    public class Team {
        public int TeamId {get; set;}
        public String name {get; set;}
        public String short_name {get; set;}
        public int strength {get; set;} 
        public int strength_overall_home {get; set;} 
        public int strength_overall_away {get; set;} 
        public double strength_attack_home {get; set;} 
        public int strength_attack_away  {get; set;} 
        public double strength_defence_home {get; set;} 
        public int strength_defence_away  {get; set;} 
        public int pulse_id {get; set;}
        public int code {get; set;}
    }
}