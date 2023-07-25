
A message1 = new A("h");
A message2 = new A("Morning");

try
{
    message1.EmptyMessage();
    message2.LetterWithBrace();

}
catch (NullReferenceException ex)
{
    Console.WriteLine($"ErrorEmpty:{ex.Message}");
}
catch(LetterWithBraceException ex)
{
    Console.WriteLine($"Error:{ex.Message}");
}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error:{ex.Message}");
//}
finally
{
    Console.WriteLine($"Good morning!");
}

    
