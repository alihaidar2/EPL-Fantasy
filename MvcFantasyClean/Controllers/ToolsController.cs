using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFantasyClean.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace MvcFantasyClean.Controllers
{
    public class ToolsController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dataReader;
        SqlConnection con = new SqlConnection();
        List<Player> players = new List<Player>();
        List<Team> teams = new List<Team>();
        private readonly ILogger<HomeController> _logger;

        public ToolsController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = "Data Source=127.0.0.1,1433; database=FantasyDB; User Id=sa; Password=Haidarali2@";
        }

        // this name represents the view Player
        public IActionResult Player()
        {
            FetchPlayerData();
            return View(players);
        }

        private void FetchPlayerData() {
            if (players.Count > 0) {
                players.Clear();
            }
            try {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM [FantasyDB].[dbo].[fpl_players]";
                dataReader = com.ExecuteReader();

                while (dataReader.Read()) {
                    players.Add(
                        // the variable names should match the model variable names
                        new Player() {
                            PlayerId = (int) dataReader["PlayerId"],
                            second_name = dataReader["second_name"].ToString(),
                            team = dataReader["team"].ToString(),
                            position = dataReader["position"].ToString(),
                            cost = (int) dataReader["now_cost"],
                            total_points = (int) dataReader["total_points"],
                            value = (double) dataReader["value"],
                            minutes = (int) dataReader["minutes"],
                            transfers_in = (int) dataReader["transfers_in"],
                            selected_by = (double) dataReader["selected_by"],
                            goals_scored = (int) dataReader["goals_scored"],
                            assists = (int) dataReader["assists"],
                            goals_conceded = (int) dataReader["goals_conceded"],
                            saves = (int) dataReader["saves"]

                        }
                    );
                }
                con.Close();

            }
            catch (System.Exception ex) {
                throw ex;
            }
        }

        public IActionResult Teams() {
            FetchTeamData();
            return View(teams);
        }
        private void FetchTeamData() {
            if (teams.Count > 0) {
                teams.Clear();
            }
            try {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM [FantasyDB].[dbo].[fpl_teams]";
                dataReader = com.ExecuteReader();

                while (dataReader.Read()) {
                    teams.Add(
                        // the variable names should match the model variable names
                        new Team() {
                            TeamId = (int) dataReader["TeamId"],
                            name = dataReader["name"].ToString(),
                            short_name = dataReader["short_name"].ToString(),
                            strength = (int) dataReader["strength"],
                            strength_overall_home = (int) dataReader["strength_overall_home"],
                            strength_overall_away = (int) dataReader["strength_overall_away"],
                            strength_attack_home = (int) dataReader["strength_attack_home"],
                            strength_attack_away = (int) dataReader["strength_attack_away"],
                            strength_defence_home = (int) dataReader["strength_defence_home"],
                            strength_defence_away = (int) dataReader["strength_defence_away"],
                            pulse_id = (int) dataReader["pulse_id"],
                            code = (int) dataReader["code"],
                            
                        }
                    );
                }
                con.Close();

            }
            catch (System.Exception ex) {
                throw ex;
            }
        }

        public IActionResult Fixtures() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
