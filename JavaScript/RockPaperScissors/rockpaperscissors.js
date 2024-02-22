const getUserChoice = userInput => 
{
  userInput = userInput.toLowerCase();
  
  if (userInput === "rock")
  {
    return userInput;
  }
  else if (userInput === "paper")
  {
    return userInput;
  }
  else if (userInput === "scissors")
  {
    return userInput;
  }
  else if (userInput === "bomb")
  {
    return userInput;
  }
  else
  {
    return "Invalid input!";
  }
}

const getComputerChoice = () => 
{
  let computerChoice = Math.floor(Math.random() * 3);
  switch (computerChoice)
  {
    case 0:
    {
      computerChoice = "rock";
      break;
    }
    case 1:
    {
      computerChoice = "paper";
      break;
    }
    case 2:
    {
      computerChoice = "scissors";
      break;
    }
  }
  return computerChoice;
}

const determineWinner = (userChoice, computerChoice) =>
{
  if (userChoice === computerChoice)
  {
    return "It's a tie!";
  }
  if (userChoice === "rock")
  {
    if (computerChoice === "paper")
    {
      return "Computer won >.<";
    }
    else
    {
      return "Human won ^.^";
    }
  }
  if (userChoice === "paper")
  {
    if (computerChoice === "scissors")
    {
      return "Computer won >.<";
    }
    else
    {
      return "Human won ^.^";
    }
  }
  if (userChoice === "scissors")
  {
    if(computerChoice === "rock")
    {
      return "Computer won >.<";
    }
    else
    {
      return "Human won ^.^";
    }
  }
  if (userChoice === "bomb")
  {
    return "Human won ^.^";
  }
}

function playGame()
{
  let userChoice = getUserChoice("paper");
  let computerChoice = getComputerChoice();
  console.log(`Your choice: ${userChoice}`);
  console.log(`Computer's choice: ${computerChoice}`);
  console.log(determineWinner(userChoice, computerChoice));
}

playGame();


