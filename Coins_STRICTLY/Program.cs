char [] sequence = new char[70];
for (int i = 0; i < sequence.Length; i++)
{
    sequence[i] = 'X';
}

string userInput = "HHHTTHHHHHTT";
sequence = userInput.ToUpper().ToCharArray();


