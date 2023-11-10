/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:   The Program reads in the amount of seconds and outputs the
 *                 amount of time in days, hours, minutes and seconds. 
 *------------------------------------------------------------------------------
*/

using System;
namespace TimeCalculator
{
  class Program
  {
    public static void Main()
    {
      long secInput,              //  input seconds
           sec, min, hour, day;    //  int to calculate

      string secText,              //  output text
           minText,              //    for singular/
           hourText,             //               /plural
           dayText,              //                  differentiation

           outText;              //  variable to change conjunction 

      Console.Clear();
      Console.Write("\n Umrechner von Sekunden in Tage, Stunden, Minuten und Sekunden\n");
      Console.Write("===============================================================\n");
      Console.Write(" Gesamtsekunden [int]:\n    ");
      secInput = Convert.ToInt64(Console.ReadLine());

      sec  = secInput % 60;
      min  = secInput / 60;
      hour = min / 60;
      min  = min % 60;
      day  = hour / 24;
      hour = hour % 24;

      minText  = (min == 1)  ? "Minute" : "Minuten";
      hourText = (hour == 1) ? "Stunde" : "Stunden";
      dayText  = (day == 1)  ?    "Tag" : "Tage";

      Console.WriteLine("---------------------------------------------------------------");
      if (sec != 1 || min >= 1 || hour >= 1 || day >= 1)
      {
        secText = (sec == 1) ? "Sekunde" : "Sekunden";
        outText = (sec == 1) ?   "bleibt" : "bleiben";

        if (day >= 1)
        {
          Console.Write($"{secInput} {secText} sind:\n" +
            $"    {day} {dayText}, {hour} {hourText}, {min} {minText} und {sec} {secText}");
        }
        else if (hour >= 1)
        {
          Console.Write($"{secInput} {secText} sind:\n " +
            $"   {hour} {hourText}, {min} {minText} und {sec} {secText}");
        }
        else if (min >= 1)
        {
          Console.Write($"{secInput} {secText} sind:\n " +
            $"   {min} {minText} und {sec} {secText}");
        }
        else
        {
          Console.Write($"{secInput} {secText} {outText} {sec} {secText}");
        }
      }
      else
      {
        secText = "Sekunde";
        outText = "bleibt";
        Console.Write($"{secInput} {secText} {outText} {sec} {secText}");
      }
      Console.Write("\n===============================================================\n");
      Console.Write("\n Weiter mit beliebiger Taste ...\n");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
