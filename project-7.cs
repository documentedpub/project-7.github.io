var message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
