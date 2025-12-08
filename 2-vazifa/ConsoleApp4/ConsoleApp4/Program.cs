Console.WriteLine("Iltimos ismingizni kiriting: ");
string firstName = Console.ReadLine();
Console.WriteLine("Iltimos familyangizni kiriting: ");
string lastName = Console.ReadLine();
Console.WriteLine("Iltimos yashash manzilingizni kiriting: ");
string address = Console.ReadLine();
Console.WriteLine("Iltimos telefon raqamingizni kiriting: ");
string phoneNumber = Console.ReadLine();

Console.WriteLine($"Assalomu alaykum {firstName} {lastName}, tizimga xush kelibsiz.\nSizning bizga ma'lum ma'lumotlaringiz\nIsmingiz: {firstName}\nFamilyangiz: {lastName}\nYashash manzilingiz: {address}\nTelefon raqamingiz: {phoneNumber}");