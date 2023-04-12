using System;
using Observer.Classes;
using Observer.Interfaces;

ISubject subject = new Subject();

IObserver phoneObserver = new PhoneObserver();
IObserver tabletObserver = new TabletObserver();
IObserver laptopObserver = new LaptopObserver();

subject.Attach(phoneObserver);
subject.Attach(tabletObserver);
subject.Attach(laptopObserver);

subject.State = ObjectState.Phone;
subject.Notify();

subject.State = ObjectState.Tablet;
subject.Notify();

subject.State = ObjectState.Laptop;
subject.Notify();

subject.Detach(phoneObserver);
subject.Notify();


