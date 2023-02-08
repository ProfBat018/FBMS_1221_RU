using Lesson3.Model;
using Lesson3.Service;


#region Serialize

//Student Maga = new()
//{
//    Name = "Maga",
//    Surname = "Babayev",
//    Age = 16,
//    Grade = GRADE.FIRST
//};

//Student Ali = new()
//{
//    Name = "Ali",
//    Surname = "Shirinov",
//    Age = 16,
//    Grade = GRADE.FIRST
//};


//Student Lala = new()
//{
//    Name = "Lala",
//    Surname = "Mammadova",
//    Age = 24,
//    Grade = GRADE.FIRST
//};

//Student Laman = new()
//{
//    Name = "Laman",
//    Surname = "Aliyeva",
//    Age = 26,
//    Grade = GRADE.FIRST
//};


//Group firstGroup = new()
//{
//    Students = new() { Maga, Ali, Lala, Laman },
//    Name = "FBMS_1221_RU"
//};


//string? json = SerializeService.Serialize<Group>(firstGroup);
//FileService.WriteToFile(json, "data2.json", FileMode.Open);

#endregion

string? json = FileService.ReadFromFile("data2.json", FileMode.OpenOrCreate);

Group? first = new();

first.AddStudent(new()
{
    Name = "Subhi",
    Surname = "Aliyev",
    Age = 15,
    Grade = GRADE.FIRST
});




