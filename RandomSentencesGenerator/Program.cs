string[] names = { "Peter", "Michell", "Jane", "Steve" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
string[] details = { "near the river", "at home", "in the park" };

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.WriteLine("Hello, this is your first random-generated sentence:");
string input = string.Empty;
while (input == string.Empty)
{
    string rondomName = GetRandom(names);
    string rondomPlace = GetRandom(places);
    string rondomVerb = GetRandom(verbs);
    string rondomNoun = GetRandom(nouns);
    string rondomAdverb = GetRandom(adverbs);
    string rondomDetail = GetRandom(details);

    string whoFromWhere = $"{rondomName} from {rondomPlace}";
    string action = $"{rondomAdverb} {rondomVerb} {rondomNoun}";
    string sentence = $"{whoFromWhere} {action} {rondomDetail}";
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(sentence);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Click [Enter] to generate a new one");
    Console.WriteLine("or enter \"E\" for exit");
    input = Console.ReadLine();
}

string GetRandom(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    return words[randomIndex];
}