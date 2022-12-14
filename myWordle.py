import sys
import pyinputplus as pyip
import random

try:
    color = sys.stdout.shell
except AttributeError:
    raise RuntimeError("Use IDLE")

word_list = []
word_file = open("words.txt")
for word in word_file:
    word_list.append(word.strip())

secretWord = random.choice(word_list).upper()
guessNum = 0
remaining = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]
win = False


def runGuess(secretWord, guess):
    position = 0
    for i in guess:
        if i in remaining:
            remaining.remove(i)
        if i == secretWord[position]:
            color.write(i,"STRING")
        elif i in secretWord:
            color.write(i, "KEYWORD")
        else:
            color.write(i, "SYNC")
        position += 1
    if guess == secretWord:
        print('\nCongrats, you guessed the secret word: ' + secretWord)
    print('\nRemaining letters: ' + ''.join(remaining))
    

def fiveLet(word):
    if len(word) != 5:
        raise Exception('Please enter a valid five letter word')
    if not word.isalpha():
        raise Exception('Must be only letters')

while guessNum < 6 and win == False:
    results = ['', '', '', '', '']
    print('Enter your guess: ')
    guess = pyip.inputCustom(fiveLet).upper()
    runGuess(secretWord, guess)
    guessNum = guessNum + 1
print('You lost: The word was ' + secretWord)






    







