CreateUser("Tom", 37);
CreateUser("b", -4);
CreateUser("", 130);
 
void CreateUser(string name, int age)
{
    User user = new User(name, age);
    // проверяем корректность значения свойства Name
    // если его длина в диапазоне от 3 до 50, то оно корректно
    if (user.Name.Length >= 3 && user.Name.Length <= 50)
        Console.WriteLine($"Name: {user.Name}");
    else
        Console.WriteLine("Incorrect name!");
 
    // проверяем корректность значения свойства Age
    // если оно в диапазоне от 1 до 100, то оно корректно
    if (age >= 1 && age <= 100)
        Console.WriteLine($"Age: {user.Age}\n");
    else
        Console.WriteLine("Incorrect age!\n");
 
}
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
 
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

