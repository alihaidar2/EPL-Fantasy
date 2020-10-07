import pandas as pd
from datetime import datetime
import re

df = pd.read_csv('/Users/alihaidar/Projects/Python/fantasyepl/eplfixturesdata.txt')

df.rename(columns={'= English Premier League 2020/21' : 'Teams'}, inplace=True)

# regular expressions for cleaning
timeRegEx = r'^(\s*\d{2}\.\d{2}\s*|\s*)'
dateRegEx = r'(\t|\s)*\[(\w*\s)(\w*)\/(\d{1,2})\]' # replace with $3 '\s*\[(\w|\s|\/)*\]\s*' -- 
scoreRegEx = r'\s*(((\d-\d)\s\(\d-\d\))|\s-\s)\s*'

# fix formatting and export to csv
df_fixdate = df.replace(to_replace = dateRegEx, value = r'\1\3 \4', regex = True)
df_notime = df_fixdate.replace(to_replace = timeRegEx, value = '', regex = True)
df_clean = df_notime.replace(to_replace = scoreRegEx, value = ',', regex = True)
df_clean.to_csv('csv_files/eploutput.csv')


# new dataframe with necessary columns (for matchday and date)
df_matchday = pd.DataFrame(columns = ['Matchday', 'Date'])
# iterate to create the rows for matchday and date
for i in range (len(df_clean.index)) :
    if 'Matchday' in df_clean['Teams'].iloc[i] :
        # pulls out only the integer of the Matchday
        day = int(re.search(r'\d+', df_clean['Teams'].iloc[i]).group())
        row = {'Matchday' : day}
    elif ('Sep') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 20'
    elif ('Oct') in df_clean['Teams'].iloc[i]:
        row['Date'] = df_clean['Teams'].iloc[i] + ' 20'
    elif ('Nov') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 20'
    elif ('Dec') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 20'
    elif ('Jan') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 21'
    elif ('Feb') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 21'
    elif ('Mar') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 21'
    elif ('Apr') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 21'
    elif ('May') in df_clean['Teams'].iloc[i] :
        row['Date'] = df_clean['Teams'].iloc[i] + ' 21'
    else :
        df_matchday.loc[i] = row
    
# formatting index and cresating csv with new DataFrame
df_matchday = df_matchday.reset_index(drop = True)
df_matchday.to_csv('csv_files/matchday_out.csv')

# new DataFrame for matches
df_fixtures = pd.DataFrame(columns = ['Match'])
for i in range (len(df_clean.index)) :
    # > 15 : "longer than a date or matchday"
    if len(df_clean['Teams'].iloc[i]) > 15 :
        row = {'Match' : df_clean['Teams'].iloc[i]}
        df_fixtures.loc[i] = row

# fix index formatting and export to csv
df_fixtures = df_fixtures.reset_index(drop = True)
df_fixtures.to_csv('csv_files/fixtures_out.csv')

# merge both on index to create final table and export to csv
df_final = pd.merge(df_matchday, df_fixtures, left_index=True, right_index=True)

# format the date so that it can be imported properly into MS SQL
def format_date(el):
    return datetime.strptime(el, '%b %d %y').strftime('%m-%d-%Y')

df_final['Date'] = df_final['Date'].apply(format_date)


# split match into Hame and Away, drop, then export to csv
df_final[['Home', 'Away']] = df_final.Match.str.split(',', expand=True)
df_final.drop(['Match'], axis=1, inplace=True)
df_final.to_csv('csv_files/matches_final.csv', index_label="MatchID")

print(df_final.columns)


