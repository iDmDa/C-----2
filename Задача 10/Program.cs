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

    Console.Write("Введите трехзначное число (для выхода нажмите 'q'): ");
    string a = Console.ReadLine();

    if(a.ToLower() == "q") System.Environment.Exit(0);

    if(!Int32.TryParse(a, out int a_int)) {
        msg_style("Ошибка! Введено не число!", "error");
        continue;
    };

    if(a.Length != 3) {
        msg_style("Введенное число не является трехзначным", "error");
        continue;
    }

    msg_style($"{a} -> {a[1]}");
    System.Environment.Exit(0);
}


