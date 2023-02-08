#region FilesPart1

//using System.Text;

//FileStream fs = new("data.txt", FileMode.OpenOrCreate);

//string data = "Elvin\nAzimov";

//if (fs.CanWrite)
//{
//    byte[] buffer = Encoding.UTF8.GetBytes(data);

//    fs.Write(buffer, 0, buffer.Length);
//}

//fs.Close();


#endregion

#region FilesPart2

//FileStream fs = new("data.txt", FileMode.OpenOrCreate);

//StreamWriter sw = new(fs);

//sw.WriteLine("Hello\nWorld");

//sw.Close();
//fs.Close();

//StreamReader sr = new StreamReader(fs);
//Console.WriteLine(sr.ReadToEnd());
//sr.Close();
//fs.Close();

#endregion



#region FilesPart3

//using (FileStream fs = new("data.txt", FileMode.OpenOrCreate))
//{
//    using (StreamWriter sw = new(fs))
//    {
//        sw.WriteLine("Hello\nMaga");
//    }
//}
#endregion

#region FilesPart4

using FileStream fs = new("data.txt", FileMode.OpenOrCreate);
using StreamWriter sw = new(fs);
sw.WriteLine("Hello\nMaga");

#endregion