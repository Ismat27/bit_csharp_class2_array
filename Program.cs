var studentNames = new string[] {
    "Mobola Makay", "Tomi Olaoye", "Suleiman Ozigis", "Uchenna Doe", "Temmy Orekunrin",
    "Ismail Adegbite", "Victor Emetole", "Kayode Emmanuel", "Tolu Obasun", "Uche Ijomanta"
};

List<int> studentAges = new List<int>();

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    studentAges.Add(random.Next(18, 27));
}

string isStudent18Present = studentAges.Contains(18)? "Yes" : "No";
Console.WriteLine($"Is there a student whose age is 18? {isStudent18Present}");

Console.WriteLine("Student Ages");
foreach (var studentAge in studentAges) 
    Console.WriteLine(studentAge);

Console.WriteLine("\nStudent Names");
foreach (var studentName in studentNames)
{
    Console.WriteLine(studentName);
}
