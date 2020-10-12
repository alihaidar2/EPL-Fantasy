from urllib.request import urlopen
import pandas as pd
import numpy as np
import json
# import requests

# extract and clean json_data
request = urlopen("https://fantasy.premierleague.com/api/bootstrap-static/")
json_data = json.loads(request.read())

# create all empty dataframes
df_events = pd.DataFrame(columns={})
df_game_settings = pd.DataFrame(columns={})
df_phases = pd.DataFrame(columns={})
df_teams = pd.DataFrame(columns={})
df_elements = pd.DataFrame(columns={})
df_element_stats = pd.DataFrame(columns={})
df_element_types = pd.DataFrame(columns={})

# create and populate events DF
i = 0
for col in json_data['events'] :
    for j in col :
        df_events.loc[i, j] = str(col[j])
    i=i+1

# create and populate game_settings DF
for col, value in json_data['game_settings'].items():
    df_game_settings.loc[0, col] = str(value)

# create and populate phases DF
i = 0
for col in json_data['phases']:
    for j in col:
        df_phases.loc[i, j] = col[j]
    i = i+1

# create and populate teams DF
i = 0
for col in json_data['teams']:
    for j in col :
        df_teams.loc[i, j] = col[j]
    i=i+1

# create and populate elements DF
i = 0
for col in json_data['elements']:
    for j in col :
        df_elements.loc[i, j] = col[j]
    i=i+1

# create and populate element_stats DF
i = 0
for col in json_data['element_stats']:
    for j in col:
        df_element_stats.loc[i, j] = col[j]
    i=i+1


# create and populate element_types
i = 0
for col in json_data['element_types'] :
    for j in col :
        df_element_types.loc[i, j] = str(col[j])
    i=i+1


# exporting all data frames to csv
df_events.to_csv('csv_files/events.csv')
df_game_settings.to_csv('csv_files/game_settings.csv')
df_phases.to_csv('csv_files/phases.csv')
df_teams.to_csv('csv_files/teams.csv')
df_elements.to_csv('csv_files/elements.csv')
df_element_stats.to_csv('csv_files/element_stats.csv')
df_element_types.to_csv('csv_files/element_types.csv')

# yay tamara is the best