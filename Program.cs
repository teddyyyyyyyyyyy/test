// initialize variables
double atBats = 0;
double hits = 0;
int gamesPlayed = 0;
double seasonBattingAverage = 0.0;

// Priming read
Console.WriteLine("Enter the number of hits, -1 to quit");
string userInput = Console.ReadLine();

//Check while condition
while(userInput != "-1"){
    hits = hits + double.Parse(userInput);
    
    Console.WriteLine("Enter the number of at bats");
    atBats = atBats + double.Parse(Console.ReadLine());

    gamesPlayed = gamesPlayed + 1;
    
    //update read

    Console.WriteLine("Enter the number of hits, -1 to quit");
    userInput = Console.ReadLine();
}

seasonBattingAverage = hits/atBats;

Console.WriteLine("You played " + gamesPlayed + " and hit " + seasonBattingAverage + " on the year.");


