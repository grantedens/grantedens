import pyinputplus as pyip

#response = pyip.inputNum('Enter an odd number: ', blockRegexes=[r'[02468]$'])
def addsUpToTwelve(numbers):
    numbersList = list(numbers)
    for i, digit in enumerate(numbersList):
        numbersList[i] = int(digit)
    if sum(numbersList) != 12:
        raise Exception('Imbecile, this adds to %s.' % (sum(numbersList)))
    return int(numbers)

response = pyip.inputCustom(addsUpToTwelve)
