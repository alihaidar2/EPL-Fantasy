SELECT mf.MatchId, mf.Matchday, Date, HomeTeam, AwayTeam, home_strength - away_strength as difficulty
FROM matches_final mf
JOIN (SELECT MatchId, Matchday, strength as away_strength
		FROM matches_final mf2
		INNER JOIN fpl_teams ON mf2.AwayTeam = fpl_teams.TeamName
		) x ON mf.MatchID = x.MatchID
JOIN (SELECT MatchId, Matchday, strength as home_strength
		FROM matches_final mf3
		INNER JOIN fpl_teams ON mf3.HomeTeam = fpl_teams.TeamName
		) y ON mf.MatchID = y.MatchId
