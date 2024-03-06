DateTime now = DateTime.Now;
var dayOfWeek = now.DayOfWeek switch
{
    DayOfWeek.Monday => "月曜日",
    DayOfWeek.Tuesday => "火曜日",
    DayOfWeek.Wednesday => "水曜日",
    DayOfWeek.Thursday => "木曜日",
    DayOfWeek.Friday => "金曜日",
    DayOfWeek.Saturday => "土曜日",
    DayOfWeek.Sunday => "日曜日",
    _ => "Unknown"
};
Console.WriteLine(dayOfWeek);
