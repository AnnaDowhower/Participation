using System;
using System.IO;

namespace Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following line is line 0
            //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
            //    0             1             2           3           4       5       6      7       8        9

            string[] lines = File.ReadAllLines("sales_data_sample.csv");    //type file > click lightbulb > choose using system.IO
            //"string[]" could also be "var"

            double sum03 = 0, sum04 = 0, sum05 = 0;
            double[] sumMonths = new double[13];

            sumMonths[1] = 0;
            sumMonths[2] = 0;
            sumMonths[3] = 0;
            sumMonths[4] = 0;
            sumMonths[5] = 0;
            sumMonths[6] = 0;
            sumMonths[7] = 0;
            sumMonths[8] = 0;
            sumMonths[9] = 0;
            sumMonths[10] = 0;
            sumMonths[11] = 0;
            sumMonths[12] = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string currentLineOfFile = lines[i];
                string[] pieces = currentLineOfFile.Split(",");

                string status = pieces[6];
                double sales = Convert.ToDouble(pieces[4]);
                int month = Convert.ToInt32(pieces[8]), year = Convert.ToInt32(pieces[9]);
                
                if (status == "Shipped")
                {
                    sumMonths[month] += sales;
                    
                    switch (year)
                    {
                        case 2003:
                            sum03 += sales;
                            break;

                        case 2004:
                            sum04 += sales;
                            break;

                        case 2005:
                            sum05 += sales;
                            break;
                    }
                }

         
            }
            //end of for

            Console.WriteLine($"The total sales for 2003 is {sum03.ToString("C")}");
            Console.WriteLine($"The total sales for 2004 is {sum04.ToString("C")}");
            Console.WriteLine($"The total sales for 2005 is {sum05.ToString("C")}");

            for (int i = 1; i < sumMonths.Length; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"The sum for all January's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"The sum for all February's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"The sum for all March's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"The sum for all April's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"The sum for all May's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"The sum for all June's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"The sum for all July's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"The sum for all August's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"The sum for all September's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"The sum for all October's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"The sum for all November's is {sumMonths[i].ToString("C")}");
                }
                else
                {
                    Console.WriteLine($"The sum for all December's is {sumMonths[i].ToString("C")}");
                }
            }
        }
    }
}
