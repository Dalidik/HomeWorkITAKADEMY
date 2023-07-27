using System.Runtime.CompilerServices;

Transport Mashina1 = new Mashina("Mustang", 200);
Mashina Mashina2 = new Mashina("Lastoczka", 100);
Transport Lodka1 = new Lodka("Titanik", 350);
Lodka Lodka2 = new Lodka("Kosatka", 300);
Person Person1 = new Person("Oleg", 10, Mashina1);

Mashina1.Moving();
Mashina2.Moving();
Lodka1.Moving();
Lodka2.Moving();
Person1.PersonMoving(Mashina1);
Person1.PersonMoving(Lodka1);


Person1.TransportMetod = Mashina2;
Person1.TransportChangeProperty();
Person1.TransportMetod = Lodka2;
Person1.TransportChangeProperty();
