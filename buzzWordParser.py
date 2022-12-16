import requests


#this program will take a link and a list of buzzwords, parse the HTML of the link,
#and return a dictionary of the buzzwords and how many times they occur

print("Enter an html")
url = input()
data = requests.get(url)
html = data.text

print("Enter buzzwords (separated by a space) to parse")
buzzList = input().split(" ")

results = {}

for item in buzzList:
    results[item] = 0
    results[item] = html.count(item) + html.count(item.capitalize())
    
    

print(dict(sorted(results.items(), key=lambda x:x[1], reverse=True)))
