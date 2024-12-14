int n = 3,i;
string s;
Student[] students = new Student[n];

for (i = 0; i < students.Length; i++) {

    Console.WriteLine("\nNew Student Details : ");

    Console.Write("Enter ID   : ");
    s=Console.ReadLine();
    students[i].sId=int.Parse(s);

    Console.Write("Enter Name : ");
    s = Console.ReadLine();
    students[i].name = s;

    Console.Write("Enter Field: ");
    s = Console.ReadLine();
    students[i].field = s;

    Console.Write("Enter Avg  : ");
    s = Console.ReadLine().Trim();
    students[i].avg = float.Parse(s);
}

for (i = 0; i < n; i++) {
    Console.WriteLine();
    Console.WriteLine("SID   : "+students[i].sId);
    Console.WriteLine("Name  : "+students[i].name);
    Console.WriteLine("Field : "+students[i].field);
    Console.WriteLine("Avg   : "+students[i].avg);
    Console.WriteLine();
}
