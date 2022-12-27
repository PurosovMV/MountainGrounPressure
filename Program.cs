while(true)
      {
    Console.WriteLine("Введи коэффициент крепости в массиве: ");
      double f = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введи высоту выработки: ");
      double h = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введи пролёт выработки: ");
      double b = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введи плотность грунта: ");
      double p = Convert.ToDouble(Console.ReadLine());
      if ( f < 4)
        {
      double fi = Math.Round((Math.Atan (f) * 180 / Math.PI), 2);
      double bq =  Math.Round((b+2*h*Math.Tan((45-fi/2)* Math.PI / 180)),3);
      double hq =  Math.Round(bq/(2*f), 3);
      double bi = (0.3*(b-5.5)/2)+0.7;
      double gqzn = Math.Round((bi*p*9.81*hq), 3);
      double gqxn = Math.Round((p*9.81*(hq+0.5*h)*Math.Pow(2*Math.Tan(45-fi/2),2)),3);
      Console.WriteLine($"φ - кажущийся угол внутреннего трения = {fi}°");
      Console.WriteLine($"bq - пролет свода обрушения = {bq} м");
      Console.WriteLine($"hq - высота свода обрушения = {hq} м");
      Console.WriteLine($"gqzn - нормативное вертикальное горное давление = {gqzn} кН/м2");
      Console.WriteLine($"gqxn - нормативное горизонтальное горное давление = {gqxn} кН/м2");
          }
             
      else if (f >= 4)
      {
        double hq1 = 1;
        double bi1 = (0.3*(b-5.5)/2)+0.7;
        Console.WriteLine("Укажи степень трещиноватости грунта, где 1 - Очень слаботрещиноватые (Mj < 1,5), 2 - Слаботрещиноватые (1,5 ≤ Mj < 5), 3 - Среднетрещиноватые (5 ≤ Mj < 10), 4 - Сильнотрещиноватые (10 ≤ Mj < 30)");
        int crc = int.Parse(Console.ReadLine());
        Console.WriteLine("Укажи способ разработки грунта, где 1 - Механизированный, 2 - Буровзрывной");
        int metod = int.Parse(Console.ReadLine());
       if (f == 4 && crc == 1 && metod == 1) 
        {
         hq1 = b * 0.2;
         }
        else if (f >= 5 && f <= 9 && crc == 1 && metod == 1)
        {
         hq1 = b * 0.1;
        }
        else if (f == 10 && crc == 1 && metod == 1)
        {
         hq1 = b * 0.05;
        }
        else if (f == 4 && crc == 1 && metod == 2) 
        {
       hq1 = b * 0.2*0.7;
        }
        else if (f >= 5 && f <= 9 && crc == 1 && metod == 2)
        {
         hq1 = b * 0.1*0.7;
          }
        else if (f == 10 && crc == 1 && metod == 2)
        {
         hq1 = b * 0.05*0.7;
          
        }
        else if (f == 4 && crc == 2 && metod == 1) 
        {
         hq1 = b * 0.25;
          }
      else if (f >= 5 && f <= 9 && crc == 2 && metod == 1)
        {
        hq1 = b * 0.2;
          }
      else if (f == 10 && crc == 2 && metod == 1)
        {
        hq1 = b * 0.1;
          }
      else if (f == 4 && crc == 2 && metod == 2) 
        {
        hq1 = b * 0.25*0.7;
        }
      else if (f >= 5 && f <= 9 && crc == 2 && metod == 2)
        {
      hq1 = b * 0.2*0.7;
        }
      else if (f == 10 && crc == 2 && metod == 2)
        {
         hq1 = b * 0.1*0.7;
         }
        else if (f == 4 && crc >=3 && crc <= 5 && metod == 1) 
        {
         hq1 = b * 0.3;
          }
      else if (f >= 5 && f <= 9 && crc >=3 && crc <= 5 && metod == 1)
        {
          hq1 = b * 0.25;
         
        }
      else if (f == 10 && crc >=3 && crc <= 5 && metod == 1)
        {
         hq1 = b * 0.15;
          
        }
      else if (f == 4 && crc >=3 && crc <= 5 && metod == 2) 
        {
         hq1 = b * 0.3*0.7;
        
        }
      else if (f >= 5 && f <= 9 && crc >=3 && crc <= 5 && metod == 2)
        {
          hq1 = b * 0.25*0.7;
         }
      else if (f == 10 && crc >=3 && crc <= 5 && metod == 2)
        {
         hq1 = b * 0.15*0.7;
        }
          Console.WriteLine($"hq1 - глубина нарушенной зоны с учётом способа проходки = {hq1}");
         double gqzn1 = Math.Round((bi1*p*9.81*hq1), 3);
         Console.WriteLine($"gqzn - нормативное вертикальное горное давление = {gqzn1} кН/м2");
        }
        }
