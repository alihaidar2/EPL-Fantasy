﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcFantasy.Models;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace MvcFantasy.Controllers
{
    public class HomeController : Controller
    {

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Element> elements = new List<Element>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = "Data Source=127.0.0.1,1433; database=FantasyEplDB; User Id=sa; Password=Haidarali2@";
        }

        public IActionResult Index()
        {
            FetchData();
            return View(elements);
        }

        private void FetchData() {
            if (elements.Count > 0) {
                elements.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT * FROM [FantasyEplDB].[dbo].[elements] INNER JOIN element_types ON elements.element_type = element_types.id ORDER by goals_scored DESC";
                dr = com.ExecuteReader();

                // just adds the data to each element
                // THIS IS NOT what displays 
                while (dr.Read()) {
                    elements.Add(
                        new Element() {
                            id = (int) dr["id"],
                            element_type = (int) dr["element_type"],
                            first_name = dr["first_name"].ToString(),
                            second_name = dr["second_name"].ToString(),
                            form = dr["form"].ToString(),
                            in_dreamteam = (bool) dr["in_dreamteam"],
                            news = dr["news"].ToString(),
                            now_cost = (int) dr["now_cost"],
                            points_per_game = dr["points_per_game"].ToString(),
                            selected_by_percent = dr["selected_by_percent"].ToString(),
                            team = (int) dr["team"],
                            total_points = (int) dr["total_points"],
                            transfers_in = (int) dr["transfers_in"],
                            transfers_out = (int) dr["transfers_out"],
                            minutes = (int) dr["minutes"],
                            goals_scored = (int) dr["goals_scored"],
                            assists = (int) dr["assists"],
                            clean_sheets = (int) dr["clean_sheets"],
                            goals_conceded = (int) dr["goals_conceded"],
                            own_goals = (int) dr["own_goals"],
                            penalties_saved = (int) dr["penalties_saved"],
                            penalties_missed = (int) dr["penalties_missed"],
                            yellow_cards = (int) dr["yellow_cards"],
                            red_cards = (int) dr["red_cards"],
                            saves = (int) dr["saves"],
                            bonus = (int) dr["bonus"],
                            bps = (int) dr["bps"],
                            influence = dr["influence"].ToString(),
                            creativity = dr["creativity"].ToString(),
                            threat = dr["threat"].ToString(),
                            ict_index = dr["ict_index"].ToString()
                        }
                    );
                } 
                con.Close();
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
