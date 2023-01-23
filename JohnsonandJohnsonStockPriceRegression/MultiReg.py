#this is my forecasting project to predict the Johnson and Johnson stock price using government data and multiple regression model 
import pandas as pd
import numpy as np
from sklearn.linear_model import LinearRegression
from sklearn.metrics import r2_score, mean_squared_error
from sklearn.model_selection import train_test_split

df = pd.read_excel("jandj.xlsx", header=3)
#now we'll read the excel file into a dataframe

#this is where I found my data:
#https://fred.stlouisfed.org/series/CUSR0000SEFW
#https://www.cdc.gov/DataStatistics/
#https://cdan.dot.gov/query
#www.a-mansia.com/obesity-and-diabetes-in-the-world
#https://worldpopulationreview.com/country-rankings/obesity-rates-by-country
#https://fred.stlouisfed.org/series/WPU51110102
#https://www.bls.gov/ppi/

df = df.drop(columns=['Unnamed: 0', 'Unnamed: 15', 'Date'], axis=1)
#there are a few columns we don't need so let's drop them

#let's change some column names to make this regression easier
df = df.rename(columns={"PPI (Medicare Patients: Physician Care)": 'PPI'})
df = df.rename(columns={"Dementia Fatalities2": 'Dementia'})
df = df.rename(columns={"J&J Close lagged by 1": 'lag1'})
df = df.rename(columns={"J&J Close lagged 2": 'lag2'})
df = df.rename(columns={"J&J Close lagged 3": 'lag3'})
df = df.rename(columns={"J&J Close lagged 4": 'lag4'})
df = df.rename(columns={"Obesity Adult Rate of 100": 'Obesity'})
df = df.rename(columns={"Motor Vehicle Crashes (Injury Only)": 'Crashes'})
df = df.rename(columns={"CPI (Urban Consumers - Alcoholic Beverages at Home)": 'CPI'})
df = df.rename(columns={"Alheimer's Deaths2": 'Alzheimers'})

column_names = df.columns
print(column_names)
#These columns will be easier to use 

#now we'll set our independent and dependent variables
y = df[['Close']]
x = df.drop(['Close'], axis=1)

#now that we have split our dependent and independent let's define the training and test sets
x_train, x_test, y_train, y_test = train_test_split(x, y, test_size=0.2)

#now we create the multiple linear regression model
reg = LinearRegression()

#and now we fit our training data to the model
reg.fit(x_train, y_train)

#we'll use the fitted model to make predictions on the test set
y_pred = reg.predict(x_test)

#we will evaluate the performance of the model
mse = mean_squared_error(y_test, y_pred)
r2 = reg.score(x_test, y_test)

#our r-squared value is nearly 0.98, meaning that almost 98% of the variation in the stock price of Johnson and Johnson can be predicted using our cdc data. Not bad!
r2

#time to visualize the results
plt.figure(figsize=(15,10))
plt.scatter(y_test,y_pred)
plt.xlabel('Actual')
plt.ylabel('Predicted')
plt.title('Actual vs Predicted')

