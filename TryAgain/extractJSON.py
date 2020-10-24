from urllib.request import urlopen
import requests
import json
import pandas as pd
import numpy as np

# get data from FPL
url = 'https://fantasy.premierleague.com/api/bootstrap-static/'
r = requests.get(url)
json = r.json()

# put them into dataframes
elements_df = pd.DataFrame(json['elements'])
elements_types_df = pd.DataFrame(json['element_types'])
teams_df = pd.DataFrame(json['teams'])

#reduce the dataframe to values necessary
slim_elements_df = elements_df[['second_name','team','element_type','selected_by_percent','now_cost','minutes','transfers_in','value_season','total_points']]

# clean data
slim_elements_df['position'] = slim_elements_df.element_type.map(elements_types_df.set_index('id').singular_name_short)
slim_elements_df['team'] = slim_elements_df.team.map(teams_df.set_index('id').name)
slim_elements_df['value'] = slim_elements_df.value_season.astype(float)
slim_elements_df['selected_by'] = slim_elements_df.selected_by_percent.astype(float)

slim_elements_df = slim_elements_df.drop(columns=['selected_by_percent','value_season','element_type'])

# mean values for each team
team_pivot = slim_elements_df.pivot_table(index='team',values='value',aggfunc=np.mean).reset_index()

# dataframes for each position: can use them for histograms
fwd_df = slim_elements_df.loc[slim_elements_df.position == 'Forward']
mid_df = slim_elements_df.loc[slim_elements_df.position == 'Midfielder']
def_df = slim_elements_df.loc[slim_elements_df.position == 'Defender']
goal_df = slim_elements_df.loc[slim_elements_df.position == 'Goalkeeper']

# reorder and export to csv
slim_elements_df = slim_elements_df[['second_name', 'team', 'position', 'total_points', 'value', 'minutes', 'transfers_in', 'selected_by']]
slim_elements_df.to_csv('fpl_data.csv', index=True, index_label="PlayerId")
