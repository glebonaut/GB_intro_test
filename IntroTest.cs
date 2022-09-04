string [] GetInputArray()
{
    List<string> list = new List<string>();
    Console.WriteLine("Enter any number of strings; Enter an empty string to finish");
    string input;
    do
    {
        input=Console.ReadLine();
        list.Add(input);
    }
    while (!String.IsNullOrEmpty(input));
    if(list.Count>1)list.RemoveAt(list.Count-1); //remove an empty entry in the end
    string[] output = list.ToArray();
    return output;
}

void PrintOutput(string[] input)
{
    string output ="[";
    for (int i=0;i<input.Length;i++) 
    {
        output+=input[i];
        if(i!=input.Length-1)output+=", ";
    }
    output+="]";
    Console.WriteLine(output);
}

void TaskMethod(string [] input)
{
    //string [] input=GetInputArray();
    Console.Write("Input array: ");
    PrintOutput(input);
    int outputLength=0;
    for (int i=0;i<input.Length;i++) 
    {
        if (input[i].Length<4)outputLength++;
    }
    string[] output = new string[outputLength];
    if (outputLength!=0)
    {
        int j=0, 
            i=0;
        while (i<outputLength)
        {
            if (input[j].Length<4)
            {
                output[i]=input[j];
                i++;
            }
            j++;
        }
    }
    Console.Write("Output array: ");
    PrintOutput(output);
}

/*
string[] defaultInput={"123", "1234", "0", "", "12345678"};
TaskMethod(defaultInput);
*/
TaskMethod(GetInputArray());