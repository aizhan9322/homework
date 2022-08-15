//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот деньConsole.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("ВЫХОДНОЙ!!!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Хмм, в неделе 7 дней.");
  }
  else Console.WriteLine("Упс ,это рабочие будни(.");
}

CheckingTheDayOfTheWeek(dayNumber);

