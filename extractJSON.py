from urllib.request import urlopen
import pandas as pd
import numpy as np
import json
from datetime import datetime

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

# moves 'id' to the first column
cols_to_order = ['id']
new_columns = cols_to_order + (df_teams.columns.drop(cols_to_order).tolist())
df_teams = df_teams[new_columns]
new_columns = cols_to_order + (df_elements.columns.drop(cols_to_order).tolist())
df_elements = df_elements[new_columns]


# fix boolean type (to int)
df_elements['in_dreamteam'] = (df_elements['in_dreamteam'] == 'TRUE').astype(int)
df_elements['special'] = (df_elements['special'] == 'TRUE').astype(int)
df_game_settings['league_ko_first_instead_of_random'] = (df_game_settings['league_ko_first_instead_of_random'] == 'TRUE').astype(int)
df_game_settings['ui_use_special_shirts'] = (df_game_settings['ui_use_special_shirts'] == 'TRUE').astype(int)
df_game_settings['sys_vice_captain_enabled'] = (df_game_settings['sys_vice_captain_enabled'] == 'TRUE').astype(int)
df_events['finished'] = (df_events['finished'] == 'True').astype(int)
df_events['data_checked'] = (df_events['data_checked'] == 'True').astype(int)
df_events['is_previous'] = (df_events['is_previous']  == 'True').astype(int)
df_events['is_current'] = (df_events['is_current'] == 'True').astype(int)
df_events['is_next'] = (df_events['is_next'] == 'True').astype(int)
df_teams['unavailable'] = (df_teams['unavailable'] == 'True').astype(int)
df_element_types['ui_shirt_specific'] = (df_element_types['ui_shirt_specific'] == 'True').astype(int)

# fix formatting for datetime to work in MS SQL SERVER
def format_date(el):
    return datetime.strptime(el, '%Y-%m-%dT%H:%M:%SZ').strftime('%m-%d-%Y %H:%M:%S')
df_events['deadline_time'] = df_events['deadline_time'].apply(format_date)

# exporting all data frames to csv
df_events.to_csv('csv_files/events.csv', index=False)
df_game_settings.to_csv('csv_files/game_settings.csv', index_label='id')
df_phases.to_csv('csv_files/phases.csv', index=False)
df_teams.to_csv('csv_files/teams.csv', index=False)
df_elements.to_csv('csv_files/elements.csv', index=False)
df_element_stats.to_csv('csv_files/element_stats.csv', index_label='id')
df_element_types.to_csv('csv_files/element_types.csv', index=False)