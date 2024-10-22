string hello = "Hellob";
string world = "World!";

Console.WriteLine(hello.Length);

foreach (char c in hello)
{
    Console.WriteLine(c);

    if (c == 'b')
    {
        Console.WriteLine("Found the character b");
        break;
    }
}

string outstr = String.Concat(hello, world);
Console.WriteLine(outstr);

outstr = String.Join(' ', hello, world);
Console.WriteLine(outstr);

int result = String.Compare(hello, "Hellob");
Console.WriteLine(result);

bool isEqual = hello.Equals("Hellob");
Console.WriteLine(isEqual);

int indexOfB = hello.IndexOf("b");
int lastIndexOfL = hello.LastIndexOf("l");
Console.WriteLine(indexOfB);
Console.WriteLine(lastIndexOfL);


