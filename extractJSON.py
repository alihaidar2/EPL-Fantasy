from urllib.request import urlopen
import pandas as pd
import numpy as np
import json
# import requests

# extract and clean json_data
request = urlopen("https://fantasy.premierleague.com/api/bootstrap-static/")
json_data = json.loads(request.read())

# beautifying it makes it one long string
# json_data = json.dumps(json_data, indent=2)

df = pd.DataFrame(columns={})


# use 2 variables since if you use 1 it will return an array
# col is the name of the attribute
# value is the value of the attribute

df_game_settings = pd.DataFrame(columns={})

# creates columns for dataframe
# populates dataframe but with strigs for the array
for col, value in json_data['game_settings'].items():
    df_game_settings.loc[0, col] = str(value)

df_game_settings.to_csv('csv_files/game_settings.csv')



#
# json_data['game_settings'][col] prints values
# 

# for col, y in json_data.items() :
#     df_game_settings[col] = col
#     print(df_game_settings)
#     # print(json_data[col])


