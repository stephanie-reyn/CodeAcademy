let raceNumber = Math.floor(Math.random() * 1000);

let earlyRegistered = false;
let runnerAge = 18;

if (runnerAge > 18 && earlyRegistered)
{
  raceNumber += 1000;
  console.log(`Your race is at 9:30 am, Runner ${raceNumber}!`);
}
else if (runnerAge > 18 && !earlyRegistered)
{
  console.log(`Your race is at 11:00 am, Runner ${raceNumber}!`);
}
else if (runnerAge < 18)
{
  console.log(`Your race is at 12:30 pm, Runner ${raceNumber}!`);
}
else 
{
  console.log(`Please console the registration desk, Runner ${raceNumber}!`);
}


