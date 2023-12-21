using System;

Student[] students = new Student[3];
Student anna = new Student("Иванова Анна Иоановна", 2019, "ул.Чкалова", "8900000000", 4, "Наука");
Student roma = new Student("Романов Роман Романович", 2020, "ул.Чкалова", "890000334550", 3, "История");
Student vika = new Student("Котик Виктория Викторовна", 2021, "ул.Чкалова", "8900000000", 2, "Наука");
students[0] = anna;
students[1]=roma;
students[2]=vika;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(students[i].FIO1);

}
Console.WriteLine("Введите название факультета");
string fakult=Console.ReadLine();
for (int i = 0;i < 3; i++)
{
    if (students[i].Faculty == fakult)
    {
        Console.WriteLine(students[i].FIO1);
    }
}
Console.WriteLine("Введите номер курса");
int kur=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
    if (students[i].Well1 > kur)
    {
        Console.WriteLine(students[i].FIO1);
    }
}
class Student
{
    private string FIO;
    private int date;
    private string address;
    private string telephone;
    private int well;
    private string faculty;
    public Student(string FIO, int date, string address, string telephone, int well, string faculty)
    {
        this.FIO = FIO;
        this.date = date;
        this.address = address;
        this.telephone = telephone;
        this.well = well;
        this.faculty = faculty;

    }
    public string FIO1
    {
        get { return FIO; }
        set { FIO = value; }
    }
    public int Date1
    {
        set { date = value; }
    } 
    public string Address1
    {

        get { return address; }
    }
    public string Telephone1
    {
        get { return telephone; }
        set { telephone = value; }
    }
    public int Well1
    {
        get { return well; }
        set { well = value; }
    }
    public string Faculty
    {
        get { return faculty; }
    }
}