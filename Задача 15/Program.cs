#nullable disable

void msg_style (string message, string status = "normal") {
    if(status == "error") {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.Gray;
        return;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.Gray;
}

for(;;) {

    Console.Write("Введите номер дня недели (для выхода нажмите 'q'): ");
    string a = Console.ReadLine();

    if(a.ToLower() == "q") System.Environment.Exit(0);

    if(!Int32.TryParse(a, out int a_int)) {
        msg_style("Ошибка! Введено не число!", "error");
        continue;
    };

    if(a.Length > 1 || a_int < 1 || a_int > 7) {
        msg_style("Такого дня недели не существует", "error");
        continue;
    }

    string result = a_int > 5 ? "да" : "нет";

    msg_style($"{a_int} -> {result}");
    System.Environment.Exit(0);
}