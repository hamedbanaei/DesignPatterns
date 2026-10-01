using CompositePattern;

var root = new Folder("MyComputer")
			.Add(
				new Folder("Documents")
					.Add(new CompositePattern.File("Resume.pdf", 250_000))
					.Add(new CompositePattern.File("Report.docx", 1_200_000))
					.Add(
						new Folder("Projects")
							.Add(
								new CompositePattern.File(
									"Architecture.pdf",
									3_500_000
								)
							)
							.Add(
								new CompositePattern.File(
									"Notes.txt",
									5_000
								)
							)
					)
			)
			.Add(
				new Folder("Pictures")
					.Add(
						new CompositePattern.File(
							"Vacation.jpg",
							8_500_000
						)
					)
					.Add(
						new CompositePattern.File(
							"Hamed Banaei.jpg",
							18_500_000
						)
					)
					.Add(
						new CompositePattern.File(
							"Family.png",
							4_200_000
						)
					)
			)
			.Add(
				new CompositePattern.File(
					"readme.txt",
					1_500
				)
			);

Console.WriteLine("FILE SYSTEM");
Console.WriteLine("====================");

root.Display();

Console.WriteLine();
Console.WriteLine(
	$"=> Total Size: {root.GetSize():N0} bytes"
);