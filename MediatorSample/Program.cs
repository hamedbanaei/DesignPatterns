using MediatorSample;

var room = new ChatRoom();

var kourosh = new Person("Kourosh");
var dariush = new Person("Dariush");

room.Join(kourosh);
room.Join(dariush);

kourosh.Say("hi room");
dariush.Say("oh, hey john");

var bardia = new Person("Bardia");
room.Join(bardia);
bardia.Say("hi everyone!");

kourosh.PrivateMessage("Bardia", "glad you could join us!");
