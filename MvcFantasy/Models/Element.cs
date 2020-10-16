using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFantasy.Models {

    public class Element {
        public int id {get; set;}
        public int chance_of_playing_next_round {get; set;}
        public int chance_of_playing_this_round {get; set;}
        public int code {get; set;} 
        public int cost_change_event {get; set;} 
        public int cost_change_event_fall {get; set;} 
        public int cost_change_start {get; set;} 
        public int cost_change_start_fall {get; set;} 
        public int dreamteam_count {get; set;} 
        public int element_type {get; set;} 
        public String ep_next {get; set;} 
        public String ep_this {get; set;} 
        public int event_points {get; set;} 
        public String first_name {get; set;} 
        public String form {get; set;} 
        public Boolean in_dreamteam {get; set;} 
        public String news {get; set;} 
        public DateTime news_added {get; set;} 
        public int now_cost {get; set;} 
        public String photo {get; set;} 
        public String points_per_game {get; set;} 
        public String second_name {get; set;} 
        public String selected_by_percent {get; set;} 
        public Boolean special {get; set;} 
        public String squad_number {get; set;} 
        public String status {get; set;} 
        public int team {get; set;} 
        public int team_code {get; set;} 
        public int total_points {get; set;} 
        public int transfers_in {get; set;} 
        public int transfers_in_event {get; set;} 
        public int transfers_out {get; set;} 
        public int transfers_out_event {get; set;} 
        public String value_form {get; set;} 
        public String value_season {get; set;} 
        public String web_name {get; set;} 
        public int minutes {get; set;} 
        public int goals_scored {get; set;} 
        public int assists {get; set;} 
        public int clean_sheets {get; set;} 
        public int goals_conceded {get; set;} 
        public int own_goals {get; set;} 
        public int penalties_saved {get; set;} 
        public int penalties_missed {get; set;} 
        public int yellow_cards {get; set;} 
        public int red_cards {get; set;} 
        public int saves {get; set;} 
        public int bonus {get; set;} 
        public int bps {get; set;} 
        public String influence {get; set;} 
        public String creativity {get; set;} 
        public String threat {get; set;} 
        public String ict_index {get; set;} 
        public int influence_rank {get; set;} 
        public int influence_rank_type {get; set;} 
        public int creativity_rank {get; set;} 
        public int creativity_rank_type {get; set;} 
        public int threat_rank {get; set;} 
        public int threat_rank_type {get; set;} 
        public int ict_index_rank {get; set;} 
        public int ict_index_rank_type {get; set;} 
        public String corners_and_indirect_freekicks_order {get; set;} 
        public String corners_and_indirect_freekicks_text {get; set;} 
        public String direct_freekicks_order {get; set;} 
        public String direct_freekicks_text {get; set;} 
        public int penalties_order {get; set;}
        public String penalties_text {get; set;}
    }
}