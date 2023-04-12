using Decorator.Classes;
using System;
using System.Globalization;

//
// Message message = new Message();
//
// message.Send();


LetterMessage message1 = new(new Message()); 
EmailMessage message2 = new(new Message()); 

message1.Send();


MessageDecorator decorator = message2;
decorator.Send();