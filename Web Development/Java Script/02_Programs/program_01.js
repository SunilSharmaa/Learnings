let userInput = prompt(`enter any integer number`);

userInputConvert = parseInt(userInput);

if(isNaN(userInputConvert))
{
    alert(`${userInput} is not a integer number`);
}

else 
{
    if(userInputConvert % 2 == 0)
    {
        alert(`${userInput} is Even number`);
    }

    else
    {
        alert(`${userInput} is Odd number`)
    }
}