
string filePath = "input.txt";
string[] lines = File.ReadAllLines(filePath);
var timeInfo = lines[0].Split(":");

var times = timeInfo[1].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                       .Select(int.Parse)
                       .ToArray();

var distanceInfo = lines[1].Split(":");
var distance = distanceInfo[1].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)      
                              .ToArray();    // GPT hjälpte mig här med att konvertera till int och array men är det ett sätt att skriva på
                                             // alltså på samma linje med metoderna
int speed = 0;
int works = 0;
int i = 0;
int result = 1;

foreach (int time in times)
{
   int working = time;
   while (working != 0)
   {
     if ((working * speed) <= distance[i]) 
     {
        speed += 1;
        working -= 1;
      }
     else
     {
        works += 1;
        speed += 1;
        working -= 1;
     }
     if (working == 0) { break; }
   }
    i++;
    result *= works;
    speed = 0;
    works = 0;
}
Console.WriteLine(result);

// Denna tog ganska lång tid för mig men mest för att jag inte kunde få distans o tid på samma
// alltså när time är [0] då ta från distance [0] men lyckades med det tillslut.