int n = 3;
Student[] students = new Student[n];

students[0].sId = 402100012;
students[0].name = "Ali";
students[0].field = "com";
students[0].avg = (float)16.50;

students[1].sId = 402100020;
students[1].name = "Hatam";
students[1].field = "com";
students[1].avg = (float)17.10;


students[2].sId = 402100031;
students[2].name = "Zaman";
students[2].field = "Psy";
students[2].avg = (float)19.75;

for (int i = 0; i < n; i++) {
    Console.WriteLine("SID   : "+students[i].sId);
    Console.WriteLine("Name  : "+students[i].name);
    Console.WriteLine("Field : "+students[i].field);
    Console.WriteLine("Avg   : "+students[i].avg);
    Console.WriteLine();
}