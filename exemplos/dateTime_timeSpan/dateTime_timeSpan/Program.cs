using System;
using System.Globalization;

/*
DateTime d1 = DateTime.Now;
Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);
*/

/*
DateTime d1 = new DateTime(2018, 11, 25);
DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
DateTime d4 = DateTime.Today;
DateTime d5 = DateTime.UtcNow;


Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
*/

/*
DateTime d1 = DateTime.Parse("2000-08-15");
DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d3 = DateTime.Parse("15/08/2018");
DateTime d4 = DateTime.Parse("15/08/2018 13:05:58");

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
*/

/*
DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d2 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d1);
Console.WriteLine(d2);
*/

/*
TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);
*/

/*
TimeSpan t1 = TimeSpan.FromDays(1.5);
TimeSpan t2 = TimeSpan.FromHours(1.5);
TimeSpan t3 = TimeSpan.FromMinutes(1.5);
TimeSpan t4 = TimeSpan.FromSeconds(1.5);
TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
TimeSpan t6 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);
Console.WriteLine(t6);
*/