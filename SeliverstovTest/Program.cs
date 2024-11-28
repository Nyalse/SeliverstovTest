using InspectorLib;
string code = String.Empty,
    fullname = String.Empty,
    number = String.Empty,
  newWorker = String.Empty;
char symbol = ' ';
string answer;
bool exit = false;
FunctionInsp functionIns = new FunctionInsp();
string[] functions =
{   "Вывести название",
    "Вывести главного инспектора",
    "Вывести список инспекторов",
    "Сгенерировать госномер",
    "Изменить главного инспектора",
    "Добавить нового сотрудника",
    "Выйти"
};
Console.WriteLine("Добро пожаловать, в программу автоинспекции г. Чита");
Console.WriteLine("Выберите что вы хотите выполнить: ");
for (int i = 0; i < functions.Length; i++)
{
    Console.WriteLine(functions[i]);
}
while (exit == false)
{
    answer = Console.ReadLine();
    if (answer != null)
    {
        if (answer == "Вывести название")
        {
            functionIns.GetCarInspection();
        }
        else if (answer == "Вывести главного инспектора")
        {
            functionIns.GetInspector();

        }
        else if (answer == "Сгенерировать госномер")
        {
            functionIns.GenerateNumber(number, symbol, code);
        }
        else if (answer == "Изменить главного инспектора")
        {
            functionIns.SetInspector(fullname);
        }
        else if (answer == "Добавить нового сотрудника")
        {
            functionIns.AddWorker(newWorker);
        }
        else if (answer == "Вывести список инспекторов")
        {
            functionIns.GetWorker();
        }
        else if (answer == "Выйти")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("К сожалению пока такой функции нет");
        }
    }
    else
    {
        Console.WriteLine("Вы пока ничего не ввели");
    }
}

