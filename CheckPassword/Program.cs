using System.Security.Cryptography;
using System.Text;

[assembly: ArmDot.Client.ObfuscateControlFlow]
[assembly: ArmDot.Client.VirtualizeCode]

while (true)
{ 
    Console.WriteLine("Enter password (or press Ctrl+C to exit): ");
    var password = Console.ReadLine();
    var passwordBinaryForm = Encoding.UTF8.GetBytes(password);
    var hash = SHA256.Create().ComputeHash(passwordBinaryForm);
    var hashInStringForm = Convert.ToBase64String(hash);

    if ("hzTbLivrxGSCjSfDqNEIDuXEbj1W6IXdPikhanYqTu0=" == hashInStringForm)
        Console.WriteLine($"The password is correct");
    else
        Console.WriteLine($"The password is incorrect");
}
