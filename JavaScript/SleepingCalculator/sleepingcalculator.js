const getSleepHours = day =>
{
  switch (day)
  {
    case "monday":
    {
      return 8;
      break;
    }
    case "tuesday":
    {
      return 8;
      break;
    }
    case "wednesday":
    {
      return 7;
      break;
    }
    case "thursday":
    {
      return 6;
      break;
    }
    case "friday":
    {
      return 9;
      break;
    }
    case "saturday":
    {
      return 10;
      break;
    }
    case "sunday":
    {
      return 7;
      break;
    }
    default:
    return "Invalid input";
  }
}

const getActualSleepHours = () =>
{
  return getSleepHours("monday") +
  getSleepHours("tuesday") +
  getSleepHours("wednesday") +
  getSleepHours("thursday") +
  getSleepHours("friday") +
  getSleepHours("saturday") +
  getSleepHours("sunday")
}

const getIdealSleepHours = () =>
{
  let idealHours = 8;
  return idealHours * 7;
}

const calculateSleepDebt = () =>
{
  let actualSleepHours = getActualSleepHours();
  let idealSleepHours = getIdealSleepHours();
  if (actualSleepHours === idealSleepHours)
  {
    return `You've reached your sleeping hour goal! Great job`;
  }
  else if (actualSleepHours > idealSleepHours)
  {
    return `You slept ${actualSleepHours - idealSleepHours} hours more than your sleeping hour goal. Keep it up!`;
  }
  else
  {
    return `You sleep ${idealSleepHours - actualSleepHours} hours less than you're suppose to. YOU NEED TO SLEEP MORE!`;
  }
}

console.log(calculateSleepDebt());



