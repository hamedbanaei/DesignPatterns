// ********** ********** ********** ********** **********
// Learn01: Base example
// ********** ********** ********** ********** **********

using Learn01;

Person P1 = new Person("Hamed Banaei", 43);
P1.ShowInfo();

Person P2 = new Person();

P2.Age = P1.Age;
P2.FullName = P1.FullName;

P2.ShowInfo();

P2.Age = 30;
P2.ShowInfo();
P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn01: Base example
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn02: Copy constructor
// ********** ********** ********** ********** **********

//using Learn02;

//Person P1 = new Person("Hamed Banaei", 43);
//P1.ShowInfo();

//Person P2 = new Person(P1);
//P2.ShowInfo();

//P2.Age = 30;
//P2.ShowInfo();
//P1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn02: Copy constructor
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn03: Copy method
// ********** ********** ********** ********** **********

//using Learn03;

//Person P1 = new Person("Hamed Banaei", 43);
//P1.ShowInfo();

//Person P2 = new Person(P1);
//P2.ShowInfo();

//Person P3 = P1.Copy();
//P3.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn03: Copy method
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn04: MemberwiseClone without implementing standards.
// ********** ********** ********** ********** **********

//using Learn04;

//Person P1 = new Person("Hamed Banaei", 43);
//P1.ShowInfo();

//Person P2 = P1.Copy();
//P2.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn04: MemberwiseClone without implementing standards.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn05: MemberwiseClone with implementing ICloneable interface.
// ********** ********** ********** ********** **********

//using Learn05;

//Person P1 = new Person("Hamed Banaei", 43);
//P1.ShowInfo();

//Person P2 = P1.Copy();
//P2.ShowInfo();

//Person P3 = (Person)P1.Clone();
//P3.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn05: MemberwiseClone with implementing ICloneable interface.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn06: Person & Factory Classic sample, factory implements ICloneable interface.
// ********** ********** ********** ********** **********

//using Learn06;

//Person P1 = new Person("Hamed Banaei", 43);
//Factory F1 = new Factory("Iran Khodro", P1);

//Factory F2 = F1.Copy();

//F2.Name = "Pars Khodro";
//F2.Manager.Age = 30;

//F2.ShowInfo();
//F1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn06: Person & Factory Classic sample, factory implements ICloneable interface.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn07: Person & Factory Classic sample, both factory and person implement ICloneable interface.
// ********** ********** ********** ********** **********

//using Learn07;

//Person P1 = new Person("Hamed Banaei", 43);
//Factory F1 = new Factory("Iran Khodro", P1);

//Factory F2 = F1.DeepCopy();

//F2.Name = "Pars Khodro";
//F2.Manager.Age = 30;

//F2.ShowInfo();
//F1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn07: Person & Factory Classic sample, both factory and person implement ICloneable interface.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn08: Implementing IPrototype interface.
// ********** ********** ********** ********** **********

//using Learn08;

//Person P1 = new Person("Hamed Banaei", 43);
//Factory F1 = new Factory("Iran Khodro", P1);

//Factory F2 = (Factory)F1.DeepCopy();

//F2.Name = "Pars Khodro";
//F2.Manager.Age = 30;

//F2.ShowInfo();
//F1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn08: Implementing IPrototype interface.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn09: Implementing IPrototype<T> interface.
// ********** ********** ********** ********** **********

//using Learn09;

//Person P1 = new Person("Hamed Banaei", 43);
//Factory F1 = new Factory("Iran Khodro", P1);

//Factory F2 = F1.DeepCopy();

//F2.Name = "Pars Khodro";
//F2.Manager.Age = 30;

//F2.ShowInfo();
//F1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn09: Implementing IPrototype<T> interface.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn10: Binary Serialization. (Obsolete)
// ********** ********** ********** ********** **********

//// Note: Take a look at project file.
//using Learn10;

//System.Collections.ArrayList oPeople1 =
//				new System.Collections.ArrayList();

//oPeople1.Add(new Person("Hamed Banaei", 43));
//oPeople1.Add(new Person("Navid Sourani", 35));
//oPeople1.Add(new Person("Mehdi Sharifi", 45));

//System.IO.FileStream oStream = null;

//try
//{
//	oStream =
//		new System.IO.FileStream
//		(
//			@"TEST.BIN",
//			System.IO.FileMode.Create,
//			System.IO.FileAccess.Write
//		);

//	System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oBinaryFormatter =
//		new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

//	oBinaryFormatter.Serialize(oStream, oPeople1);
//}
//catch (System.Exception ex)
//{
//	System.Console.WriteLine(ex.Message);
//}
//finally
//{
//	if (oStream != null)
//	{
//		//oStream.Close();
//		oStream.Dispose();
//		oStream = null;
//	}
//}

//System.Collections.ArrayList oPeople2 = null;

//try
//{
//	oStream =
//		new System.IO.FileStream
//			(
//				@"TEST.BIN",
//				System.IO.FileMode.Open,
//				System.IO.FileAccess.Read
//			);

//	System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oBinaryFormatter =
//		new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

//	object obj = oBinaryFormatter.Deserialize(oStream);

//	System.Console.WriteLine(obj.ToString() + "\n\r\n\r");
//	oPeople2 = (System.Collections.ArrayList)obj;

//	foreach (Person oPerson in oPeople2)
//	{
//		oPerson.ShowInfo();
//	}
//}
//catch (System.Exception ex)
//{
//	System.Console.WriteLine(ex.Message);
//}
//finally
//{
//	if (oStream != null)
//	{
//		//oStream.Close();
//		oStream.Dispose();
//		oStream = null;
//	}
//}

// ********** ********** ********** ********** **********
// / Learn10: Binary Serialization. (Obsolete)
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn11: XML Serialization.
// ********** ********** ********** ********** **********

//using Learn11;

//System.Collections.ArrayList oPeople1 =
//				new System.Collections.ArrayList();

//oPeople1.Add(new Person("Hamed Banaei", 43));
//oPeople1.Add(new Person("Navid Sourani", 35));
//oPeople1.Add(new Person("Mehdi Sharifi", 45));

//System.IO.FileStream oStream =
//	new System.IO.FileStream
//		(
//			@"TEST.XML",
//			System.IO.FileMode.Create,
//			System.IO.FileAccess.Write
//		);

//// Note: Person class must have Default Constructor!
//System.Xml.Serialization.XmlSerializer oXmlSerializer =
//	new System.Xml.Serialization.XmlSerializer
//		(
//			typeof(System.Collections.ArrayList),
//			new System.Type[] { typeof(Person) }
//		);

//oXmlSerializer.Serialize(oStream, oPeople1);
//oStream.Close();

//System.Collections.ArrayList oPeople2 = null;

//oStream =
//	new System.IO.FileStream
//		(
//			@"TEST.XML",
//			System.IO.FileMode.Open,
//			System.IO.FileAccess.Read
//		);

//object obj = oXmlSerializer.Deserialize(oStream);
//oStream.Close();

//oPeople2 = (System.Collections.ArrayList)obj;

//System.Console.WriteLine(obj.ToString() + "\n\r\n\r");

//foreach (Person oPerson in oPeople2)
//{
//	oPerson.ShowInfo();
//}

// ********** ********** ********** ********** **********
// / Learn11: XML Serialization.
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn12: Serialization + IPrototype
// ********** ********** ********** ********** **********

//using Learn12;

//Person P1 = new Person("Hamed Banaei", 43);
//Factory F1 = new Factory("Iran Khodro", P1);

//Factory F2 = F1.DeepCopy();

//F2.Name = "Pars Khodro";
//F2.Manager.Age = 30;

//F2.ShowInfo();
//F1.ShowInfo();

// ********** ********** ********** ********** **********
// / Learn12: Serialization + IPrototype
// ********** ********** ********** ********** **********






// ********** ********** ********** ********** **********
// Learn13: Byte Serialization with Json
// ********** ********** ********** ********** **********

//using Learn13;

//List<Person> oPeople1 = new List<Person>();

//oPeople1.Add(new Person("Hamed Banaei", 43));
//oPeople1.Add(new Person("Navid Sourani", 35));
//oPeople1.Add(new Person("Mehdi Sharifi", 45));

//var serializedData =
//	System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(oPeople1);

//// Note: Person class must have Default Constructor!

//List<Person> oPeople2 =
//	System.Text.Json.JsonSerializer.Deserialize<List<Person>>(serializedData);


//foreach (Person oPerson in oPeople2)
//{
//	oPerson.ShowInfo();
//}

// ********** ********** ********** ********** **********
// / Learn13: Json Serialization
// ********** ********** ********** ********** **********