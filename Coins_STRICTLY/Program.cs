char [] sequence = new char[70];
for (int i = 0; i < sequence.Length; i++)
{
    sequence[i] = 'X';
}

string userInput = "HTHHHTTH";
sequence = userInput.ToUpper().ToCharArray();

Console.WriteLine(CheckSequence(sequence, 3, 1));
Console.ReadLine();

bool CheckSequence(char[] seq, int length, int numberOfStriclty)
{
    int strictlyHowMuch = 0;
    int currentStrictlyLength = 0;

    for (int i = 0; i < seq.Length -1 ; i++)
    {
        if (seq[i] == seq[i + 1])
        {
            if(currentStrictlyLength < length)
            {
                currentStrictlyLength++;
                continue;
            }
            else if (currentStrictlyLength == length)
            {
                strictlyHowMuch++;
                currentStrictlyLength++;
                continue;
            }
            else if (currentStrictlyLength > length)
            {
                currentStrictlyLength = 1;
                continue;
            }

            //currentStrictlyLength < length ? currentStrictlyLength++;
                                            //: currentStrictlyLength == length ?
                                                                            // {strictlyHowMuch++; currentStrictlyLength++ } : currentLength = 1;
        }
    }
     return strictlyHowMuch == numberOfStriclty;
}
