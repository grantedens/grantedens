const NUM_OF_LETTERS = 150;
const FALLING_RATE = 30;
const SPEED_RANGE = 15;
const FONT_SIZE_RANGE = 10;
const OPACITY_RANGE = 1;

let windowHeight;
let windowWidth;
let letters = [];

function setup() {
  windowHeight = window.innerHeight;
  windowWidth = window.innerWidth;
  for (let i = 0; i < NUM_OF_LETTERS; i++) {
    const newLetter = createNewLetter();
    letters.push(newLetter);
  }
}

function draw() {
  for (let i = 0; i < letters.length; i++) {
    const letter = letters[i];
    letter.y += letter.speed;
    if (letter.y > windowHeight + 50) {
      letter.y = -50;
      letter.x = Math.floor(Math.random() * windowWidth);
      letter.opacity = Math.random() * OPACITY_RANGE + 0.1;
      letter.fontSize = Math.random() * FONT_SIZE_RANGE + 5;
      letter.element.style.opacity = letter.opacity;
      letter.element.style.fontSize = `${letter.fontSize}px`;
    }
    letter.element.style.transform = `translate(${letter.x}px, ${letter.y}px)`;
  }
}

function createNewLetter() {
  const newLetter = {};
  newLetter.speed = Math.random() * SPEED_RANGE + 1;
  newLetter.fontSize = Math.random() * FONT_SIZE_RANGE + 5;
  newLetter.opacity = Math.random() * OPACITY_RANGE + 0.1;
  newLetter.element = document.createElement("div");
  newLetter.element.innerHTML = "*";
  newLetter.element.classList.add("matrix-letter");
  newLetter.element.style.fontSize = `${newLetter.fontSize}px`;
  newLetter.element.style.opacity = newLetter.opacity;
  newLetter.x = Math.floor(Math.random() * windowWidth);
  newLetter.y = Math.floor(Math.random() * windowHeight);
  document.body.appendChild(newLetter.element);
  return newLetter;
}

setup();
setInterval(draw, FALLING_RATE);
