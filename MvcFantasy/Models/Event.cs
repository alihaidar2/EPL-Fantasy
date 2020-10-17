using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFantasy.Models {

    public class Event {
        public int id {get; set;}
        public String name {get; set;}
        public DateTime deadline_time {get; set;}
        public int average_entry_score {get; set;} 
        public Boolean finished {get; set;} 
        public Boolean data_checked {get; set;} 
        public int highest_scoring_entry {get; set;} 
        public int deadline_time_epoch {get; set;} 
        public int deadline_time_game_offset {get; set;} 
        public int highest_score {get; set;} 
        public Boolean is_previous {get; set;} 
        public Boolean is_current {get; set;} 
        public Boolean is_next {get; set;} 
        public String chip_plays {get; set;} 
        public int most_selected {get; set;} 
        public int most_transferred_in {get; set;} 
        public int top_element {get; set;} 
        public String top_element_info {get; set;} 
        public int transfers_made {get; set;} 
        public int most_captained {get; set;} 
        public int most_vice_Captained {get; set;} 
        
    }
}