﻿// MIS 3033 002 
// Aug 28, 2023
// abigail pidgeon 113515288

//
DateTime dt1;// complex
dt1 = new DateTime(2023, 8, 21, 10, 30, 00);

Console.WriteLine(dt1.ToString("MMM, dddd. yyyy"));

DateTime dt2;
dt2 = DateTime.Now;
Console.WriteLine(dt2.ToString());

DateTime dt3;
dt3 = new DateTime(2023, 8, 28, 10, 31,56);

TimeSpan ts1;
ts1=dt3- dt1;
Console.WriteLine(ts1.ToString());
Console.WriteLine(ts1.TotalDays);
Console.WriteLine(ts1.TotalHours);
