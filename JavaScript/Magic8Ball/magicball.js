let userName = 'Stephanie';
userName ? console.log(`Hello, ${userName}!`) : console.log('Hello!');

let userQuestion = 'Are you happy';
console.log(`${userQuestion} ${userName}?`);

let randomNumber = Math.floor(Math.random() * 8);
let eightBall = '';

switch (randomNumber)
{
  case 0:
  eightBall = "Outlook not so hot, try reheating your coffee instead.";
  break;

  case 1:
  eightBall = "My source say no, but they also thought pineapple on pizza was a bad idea.";
  break;

  case 2:
  eightBall = "Signs point to yes, but also to the fact that cats secretly rule the world.";
  break;

  case 3:
  eightBall = "Don't count on it, but counting sheep might help you sleep.";
  break;

  case 4:
  eightBall = "Very doubtful, but hey, stranger things have happened in a parallel universe.";
  break;

  case 5: 
  eightBall = "Ask again later, preferably after a dance-off with your pet.";
  break;

  case 6:
  eightBall = "Yes, definitely, unless your question involves beating a computer at chess.";
  break;

  case 7:
  eightBall = "Reply hazy, ask again when your Wi-Fi connection is stronger.";
  break;
}

console.log(eightBall);

