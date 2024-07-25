let inputCharacter = prompt(`Enter any character`);

switch (inputCharacter.toLowerCase())
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        alert(`${inputCharacter} is a vowel`);
        break;
    
    default:
        alert(`${inputCharacter} is not a vowel`);
}