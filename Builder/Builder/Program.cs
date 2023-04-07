using Builder;
using Builder.Service.Classes;
using Builder.Service.Interfaces;

IDirector director = new Director();

director.RunBuilder();
director.Builder.GetPc();


// PC newPC = new();
//
// newPC.Add(new Motherboard() {Name = "Asus"});
// newPC.Add(new Processor() {Name = "Intel"});
// newPC.Add(new RAM() {Name = "Crucial"});
//
//
// foreach (var part in newPC)
// {
//     Console.WriteLine(part.Name);
// }
