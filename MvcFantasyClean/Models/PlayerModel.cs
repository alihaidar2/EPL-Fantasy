using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFantasyClean.Models {

    public class Player {
        public int PlayerId {get; set;}
        public String second_name {get; set;}
        public String team {get; set;}
        public String position {get; set;} 
        public int cost {get; set;} 
        public int total_points {get; set;} 
        public double value {get; set;} 
        public int minutes  {get; set;} 
        public int transfers_in {get; set;} 
        public double selected_by {get; set;} 
        public int goals_scored {get; set;}
        public int assists {get; set;}
        public int goals_conceded {get; set;}
        public int saves {get; set;}
        
    }
}