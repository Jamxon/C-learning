string question1 = "C# da interface ning asosiy maqsadi nima?";
string answer1a = "Ma’lumot saqlash";
string answer1b = "Ob’ekt uchun shablon berish";
string answer1c = "Xotirani boshqarish";
string answer1d = "Exceptionlarni ushlash";
string question2 = "Quyidagi kodda qaysi OOP prinsipi ishlatilgan?\nclass Animal { public virtual void Speak() {} }\nclass Dog : Animal { public override void Speak() {} }\n";
string answer2a = "Abstraction";
string answer2b = "Encapsulation";
string answer2c = "Polymorphism";
string answer2d = "Inheritance";
string question3 = "C# da List<int> bilan IEnumerable<int> o‘rtasidagi asosiy farq nimada?";
string answer3a = "List faqat o‘qish uchun";
string answer3b = "IEnumerable faqat iteratsiya uchun";
string answer3c = "IEnumerable massiv";
string answer3d = "List faqat reference type";
string question4 = "ASP.NET Core’da Dependency Injection qayerda ro‘yxatdan o‘tadi?";
string answer4a = "Program.cs";
string answer4b = "Controllerda";
string answer4c = "appsettings.json";
string answer4d = "Route konfiguratsiyasida";
string question5 = "LINQ da Where() nima qiladi?";
string answer5a = "Ma’lumot qo‘shadi";
string answer5b = "Ma’lumotni o‘chiradi";
string answer5c = "Filtrlash";
string answer5d = "Tartiblash";
string question6 = "Quyidagi kodda natija nima bo‘ladi?\nint x = 5;\nint y = x;\ny = 10;\nConsole.WriteLine(x);\n";
int answer6a = 10;
int answer6b = 5;
string answer6c = "Error";
string answer6d = "Null";
string question7 = "C# da async/await ning asosiy vazifasi nima?";
string answer7a = "Kodni tezlashtirish";
string answer7b = "Multithreadingni oddiylashtirish";
string answer7c = "Xotirani kamaytirish";
string answer7d = "Ma’lumotni shifrlash";
string question8 = "ASP.NET Core’da API uchun Model validation qayerda ishga tushadi?";
string answer8a = "Controller chaqilgandan keyin";
string answer8b = "Controllerga kirishdan oldin";
string answer8c = "Logger ichida";
string answer8d = "Database save vaqtida";
string question9 = "Entity Framework Core’da DbSet nima?";
string answer9a = "Controller turi";
string answer9b = "Migrationlar ro‘yxati";
string answer9c = "Jadvalni ifodalovchi kolleksiya";
string answer9d = "Middleware turi";
string question10 = "Quyidagi kod nima qaytaradi?\nvar data = new int[] { 2, 4, 6, 8 };\nvar result = data.First(x => x > 5);\n";
int answer10a = 4;
int answer10b = 6;
int answer10c = 8;
string answer10d = "Exception";
string trueMessage = "✔️ To'g'ri javob!\n";
string falseMessage = "❌ Noto'g'ri. Yana urinib ko'ramiz\n";
int trueAnswerCount = 0;
int falseAnswerCount = 0;
Console.WriteLine("✅ C# bo‘yicha 10 ta test savoli\n");
Console.WriteLine($"1) {question1}\na) {answer1a}\nb) {answer1b}\nc) {answer1c}\nd) {answer1d}\n");
string userAnswer1 = Console.ReadLine();
if (userAnswer1.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"2) {question2}\na) {answer2a}\nb) {answer2b}\nc) {answer2c}\nd) {answer2d}\n");
string userAnswer2 = Console.ReadLine();
if (userAnswer2.ToLower() == "c")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"3) {question3}\na) {answer3a}\nb) {answer3b}\nc) {answer3c}\nd) {answer3d}\n");
string userAnswer3 = Console.ReadLine();
if (userAnswer3.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"4) {question4}\na) {answer4a}\nb) {answer4b}\nc) {answer4c}\nd) {answer4d}\n");
string userAnswer4 = Console.ReadLine();
if (userAnswer4.ToLower() == "a")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"5) {question5}\na) {answer5a}\nb) {answer5b}\nc) {answer5c}\nd) {answer5d}\n");
string userAnswer5 = Console.ReadLine();
if (userAnswer5.ToLower() == "c")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"6) {question6}\na) {answer6a}\nb) {answer6b}\nc) {answer6c}\nd) {answer6d}\n");
string userAnswer6 = Console.ReadLine();
if (userAnswer6.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"7) {question7}\na) {answer7a}\nb) {answer7b}\nc) {answer7c}\nd) {answer7d}\n");
string userAnswer7 = Console.ReadLine();
if (userAnswer7.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"8) {question8}\na) {answer8a}\nb) {answer8b}\nc) {answer8c}\nd) {answer8d}\n");
string userAnswer8 = Console.ReadLine();
if (userAnswer8.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"9) {question9}\na) {answer9a}\nb) {answer9b}\nc) {answer9c}\nd) {answer9d}\n");
string userAnswer9 = Console.ReadLine();
if (userAnswer9.ToLower() == "c")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}
Console.WriteLine($"10) {question10}\na) {answer10a}\nb) {answer10b}\nc) {answer10c}\nd) {answer10d}\n");
string userAnswer10 = Console.ReadLine();
if (userAnswer10.ToLower() == "b")
{
    Console.WriteLine(trueMessage);
    trueAnswerCount++;
}
else
{
    Console.WriteLine(falseMessage);
    falseAnswerCount++;
}

Console.WriteLine("Sizning to'g'ri javoblaringiz soni: " + trueAnswerCount);
Console.WriteLine("Sizning noto'g'ri javoblaringiz soni: " + falseAnswerCount);