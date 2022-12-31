import pandas as pd
import numpy as np

data_df = pd.read_excel("energy.xlsx")
#get energy data into dataframe

x=data_df.drop(['PE'],axis=1).values
y=data_df['PE'].values
#separate into independent variables(x) and dependent variable(y)

from sklearn.model_selection import train_test_split
#split into training and test sets
x_train,x_test,y_train,y_test=train_test_split(x,y,test_size=0.33, random_state=0)

from sklearn.linear_model import LinearRegression
ml=LinearRegression()
ml.fit(x_train,y_train)

y_pred=ml.predict(x_test)
print(y_pred)

ml.predict([[14.96,41.76,1024.07,73.17]])

from sklearn.metrics import r2_score
r2_score(y_test,y_pred)

#visualize results
import matplotlib.pyplot as plt
plt.figure(figsize=(15,10))
plt.scatter(y_test,y_pred)
plt.xlabel('Actual')
plt.ylabel('Predicted')
plt.title('Actual vs Predicted')

#observe actual vs predicted rows
pred_y_df=pd.DataFrame({'Actual Value':y_test,'Predicted value':y_pred, 'Difference': y_test-y_pred})
pred_y_df[0:20]
