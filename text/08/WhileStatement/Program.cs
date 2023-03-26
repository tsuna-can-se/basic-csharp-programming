int rand = Random.Shared.Next(0, 5);
while (rand != 0)
{
    Console.WriteLine("乱数は" + rand + "でした。");
    rand = Random.Shared.Next(0, 5);
}

Console.WriteLine("whileを終了します。");
