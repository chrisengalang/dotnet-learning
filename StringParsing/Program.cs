
using System.Globalization;

string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "4000.00";

int targetNum = 0;

try {
    targetNum = int.Parse(numStr1);
    Console.WriteLine(targetNum);
    
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    Console.WriteLine(targetNum);
    
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);
    
    targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    Console.WriteLine($"{bool.Parse("True")}");
    
    Console.WriteLine($"{float.Parse("1.235"):F2}");
    
    bool succeeded = Int32.TryParse("500", out targetNum);
    
    Console.WriteLine(succeeded);
    Console.WriteLine(targetNum);

} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
