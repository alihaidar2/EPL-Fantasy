from urllib.request import urlopen
import requests
import json
import pandas as pd
import numpy as np

# printing options
# pd.set_option('display.max_rows', 500)
# pd.set_option('display.max_columns', 500)
# pd.set_option('display.width', 1000)

# get data from FPL
url = 'https://fantasy.premierleague.com/api/bootstrap-static/'
r = requests.get(url)
json = r.json()

# put them into dataframes
elements_df = pd.DataFrame(json['elements'])
elements_types_df = pd.DataFrame(json['element_types'])
teams_df = pd.DataFrame(json['teams'])

#reduce the dataframe to values necessary
slim_elements_df = elements_df[['second_name','team','element_type','selected_by_percent','now_cost','minutes','transfers_in','value_season','total_points', 'goals_scored', 'assists', 'goals_conceded', 'saves']]

# clean data
slim_elements_df['position'] = slim_elements_df.element_type.map(elements_types_df.set_index('id').singular_name_short)
slim_elements_df['team'] = slim_elements_df.team.map(teams_df.set_index('id').name)
slim_elements_df['value'] = slim_elements_df.value_season.astype(float)
slim_elements_df['selected_by'] = slim_elements_df.selected_by_percent.astype(float)
slim_elements_df['goals_scored'] = slim_elements_df.goals_scored.astype(int)
slim_elements_df['assists'] = slim_elements_df.assists.astype(int)
slim_elements_df['goals_conceded'] = slim_elements_df.goals_conceded.astype(int)
slim_elements_df['saves'] = slim_elements_df.saves.astype(int)


slim_elements_df = slim_elements_df.drop(columns=['selected_by_percent','value_season','element_type'])
teams_df = teams_df.drop(columns=['draw','form','loss', 'played', 'points', 'position', 'team_division', 'unavailable', 'win'])
teams_df = teams_df.rename(columns={"id" : "TeamId"})

# mean values for each team
team_pivot = slim_elements_df.pivot_table(index='team',values='value',aggfunc=np.mean).reset_index()

# reorder and export to csv
slim_elements_df = slim_elements_df[['second_name', 'team', 'position', 'now_cost', 'total_points', 'value', 'minutes', 'transfers_in', 'selected_by', 'goals_scored', 'assists', 'goals_conceded', 'saves']]
teams_df = teams_df[['TeamId', 'name', 'short_name','strength','strength_overall_home','strength_overall_away','strength_attack_home',	'strength_attack_away',	'strength_defence_home','strength_defence_away','pulse_id', 'code']]
slim_elements_df.to_csv('/Users/alihaidar/Projects/Python/fantasyepl/TryAgain/fpl_players.csv', index=True, index_label="PlayerId")
teams_df.to_csv('/Users/alihaidar/Projects/Python/fantasyepl/TryAgain/fpl_teams.csv', index=False)

matches = pd.read_csv('/Users/alihaidar/Projects/Python/fantasyepl/MvcFantasyClean/matches_final.csv')
matches_sorted = matches.sort_values(['Matchday'])
matches_sorted = matches_sorted.replace(to_replace = ' FC', value = '', regex = True)

teams = [ "Burnley","Manchester United","Manchester City","Aston Villa",
            "Fulham", "Arsenal", "Crystal Palace", "Southampton",
            "Liverpool", "Leeds United", "West Ham United", "Newcastle United",
            "West Bromwich Albion", "Leicester City", "Tottenham Hotspur", "Everton",
            "Sheffield United", "Wolverhampton Wanderers", "Brighton & Hove Albion","Chelsea" ]

## CREATE DATAFRAME AND USE THIS ALGORITHM TO POPULATE IT
## YOU SHOULD JUST HAVE TO CHANGE THE LINES WITH i FOR INITIAL CELL
## THEN PRINT WITH GAMEWEEK CELLS

fpl_fixtures_df = pd.DataFrame(
    columns=["Team", 
        "GW1","GW2","GW3","GW4","GW5","GW6","GW7","GW8","GW9","GW10",
        "GW11","GW12","GW13","GW14","GW15","GW16","GW17","GW18","GW19","GW20",
        "GW21","GW22","GW23","GW24","GW25","GW26","GW27","GW28","GW29","GW30",
        "GW31","GW32","GW33","GW34","GW35","GW36","GW37","GW38"])

# print("Empty Dataframe ", fpl_fixtures_df, sep='\n')

allGames = []
j = 0

## GOES THROUGH TEAMS AND GETS 
for i in teams :
    teamGames = []
    games = matches_sorted[matches_sorted.apply(lambda row: row.str.contains(str(i), case=False).any(), axis=1)]
    print(i)
    teamGames.append(i)
    for index, row in games.iterrows() :
        if row['Home'] == str(i) :
            teamGames.append(row['Away'] + ' (Home) ' + str(row['Date']))
        else :
            teamGames.append(row['Home'] + ' (Away) ' + str(row['Date']))
    j += 1
    print(teamGames, j)
    fpl_fixtures_df.loc[j] = np.array(teamGames)

print(fpl_fixtures_df.head(5))

fpl_fixtures_df.to_csv('/Users/alihaidar/Projects/Python/fantasyepl/TryAgain/fpl_fixtures.csv', index=False)
