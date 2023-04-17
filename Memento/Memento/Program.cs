// Паттерн Memento 
/*
Паттерн Memento (Хранитель) предоставляет возможность сохранять и 
восстанавливать внутреннее состояние объекта, не раскрывая подробностей его реализации.

Паттерн Memento используется, когда:
- необходимо сохранить и восстановить внутреннее состояние объекта, чтобы позднее 
  восстановить его в это состояние.
*/


using System;
using Memento;


// Клиентский код.  
Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.State = "On";
caretaker.AddSnapshot(originator.Save());
originator.State = "Off";
caretaker.AddSnapshot(originator.Save());
originator.State = "ON";
caretaker.AddSnapshot(originator.Save());

originator.Restore(caretaker);
