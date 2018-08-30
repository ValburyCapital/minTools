using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace minTools
{
    namespace Valbury
    {
        namespace Macquarie
        {
            public static class Constants
            {
                public static string MacFTPLocation = "ftp://files.valburycapital.com/Macquarie Statements/UPLOADS";
                public static string MacFTPLocationSignedInAsMacquarie = "ftp://files.valburycapital.com/UPLOADS";
                public static string MacFTPLocationUser = "macquarie";
                public static string MacFTPLocationPass = "drTwe478y";
            }

            public static class FilenameChecker
            {
                //figure out if a given filename is the standard format of a RawData file
                public static bool isFilenameRawData(string filename)
                {
                    if (filename.Contains("EQUITY") && !(filename.Contains(".pdf")))
                        return true;
                    else if (filename.Contains("_LED") && !(filename.Contains(".pdf")))
                        return true;
                    else if ((filename.Contains("OP ") || filename.Contains("OP_") || filename.Contains("_OP")) && !(filename.Contains(".pdf")))    //CH - client statements got OP and TA in the name too
                        return true;
                    else if ((filename.Contains("TA ") || filename.Contains("TA_") || filename.Contains("_TA")) && !(filename.Contains(".pdf")))
                        return true;
                    else if (filename.Contains("CASH") && !(filename.Contains(".pdf")))
                        return true;
                    else if (filename.Contains("LEDGER") && !(filename.Contains(".pdf")))
                        return true;
                    else if (filename.Contains("EXCHANGE_FEES") && !(filename.Contains(".pdf")))
                        return true;
                    else if (filename.Contains("INTSTMT") && !(filename.Contains(".pdf")))
                        return true;
                    else
                        return false;
                }

                //figure out if a given filename follows the standard format of a client statement
                public static bool isFilenameClientStatement(string filename)
                {
                    //CH - we occasionally receive PDF raw datas 
                    if (filename.Contains(".pdf"))
                        return true;
                    else
                        return false;
                }

                //does a given filename have the date tacked on the end more than once etc
                public static bool isFilenameMalformed(string filename)
                {
                    string pattern1 = "\\d{6} \\d{6}";
                    string pattern2 = "\\d{8} \\d{8}";

                    Match m1 = Regex.Match(filename, pattern1);
                    Match m2 = Regex.Match(filename, pattern2);
                    if (m1.Success || m2.Success)
                        return true;
                    else
                        return false;
                }

                //return the date stated in the filename of a given file, as long as its a valid macquarie style filename
                public static DateTime deriveFilenameDate(string filename)
                {
                    if ((filename == null) && !(filename.Contains(DateTime.Now.AddDays(-1).ToString("yyyyMM") + "d")))
                        throw new ArgumentNullException();

                    string format = "yyyyMMdd";

                    Match m1 = Regex.Match(filename, "\\d{8}");
                    Match m2 = Regex.Match(filename, "\\d{6}");
                    Match m3 = Regex.Match(filename, "\\d{4}");

                    if (m1.Success)
                    {
                        int temp1 = int.Parse(m1.ToString().ElementAt(0) + "" + m1.ToString().ElementAt(1));
                        int temp2 = int.Parse(m1.ToString().ElementAt(2) + "" + m1.ToString().ElementAt(3));
                        if (temp1 == 20 && temp2 == int.Parse(DateTime.Now.ToString("yy")))
                            format = "yyyyMMdd";
                        else
                            format = "ddMMyyyy";
                        return DateTime.ParseExact(m1.ToString(), format, CultureInfo.InvariantCulture);
                    }
                    else if (m2.Success)
                    {
                        int temp1 = int.Parse(m2.ToString().ElementAt(0) + "" + m2.ToString().ElementAt(1));
                        int temp2 = int.Parse(m2.ToString().ElementAt(4) + "" + m2.ToString().ElementAt(5));
                        if (temp1 == int.Parse(DateTime.Now.ToString("yy")) && temp2 == int.Parse(DateTime.Now.ToString("yy")))
                            format = "yyMMdd";
                        else if (temp1 == int.Parse(DateTime.Now.ToString("yy")))
                            format = "yyMMdd";
                        else
                            format = "ddMMyy";
                        return DateTime.ParseExact(m2.ToString(), format, CultureInfo.InvariantCulture);
                    }
                    else if (m3.Success)
                    {
                        format = "MMMM yyyy";
                        return DateTime.ParseExact(m3.ToString().Replace(deriveAccountName(filename), "").Replace("_", ""), format, CultureInfo.InvariantCulture);
                    }
                    else
                        return new DateTime();

                }

                //return the account name from a given rawdata or client statement filename
                public static string deriveAccountName(string filename)
                {
                    string[] months = new string[12] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER" };
                    if ((filename == null) && !(filename.Contains(DateTime.Now.AddDays(-1).ToString("yyyyMM") + "d")))
                        throw new ArgumentNullException();

                    Match m1 = Regex.Match(filename, "\\d{8}");
                    Match m2 = Regex.Match(filename, "\\d{6}");
                    Match m3 = Regex.Match(filename, "\\d{4}");
                    if (m1.Success)
                        return filename.Replace(m1.ToString(), "").Replace(".csv", "").Replace(".pdf", "").Replace("LEDGER", "").Replace("EQUITY", "").Replace("_TA", "").Replace("_OP", "").Replace("TA ", "").Replace("OP ", "").Replace("CASH", "").Replace("LED", "").Replace("_", "").Trim();
                    else if (m2.Success)
                        return filename.Replace(m2.ToString(), "").Replace(".csv", "").Replace(".pdf", "").Replace("LEDGER", "").Replace("EQUITY", "").Replace("_TA", "").Replace("_OP", "").Replace("TA ", "").Replace("OP ", "").Replace("CASH", "").Replace("LED", "").Replace("_", "").Trim();
                    else
                    {
                        string temp = string.Empty;
                        for (int i = 0; i < months.Length; i++)
                        {
                            if (filename.Contains(months[i]))
                            {
                                temp = filename.Replace(m3.ToString(), "").Replace(".pdf", "").Replace(months[i], "").Trim();
                                break;
                            }
                        }
                        return temp;
                    }
                }

                public static int howManyRawDataStatements(List<string> listOfFilenames)
                {
                    int output = 0;
                    foreach (string file in listOfFilenames)
                        if (FilenameChecker.isFilenameRawData(file))
                            ++output;
                    return output;
                }

                public static int howManyRawDataStatements(List<string> listOfFilenames, DateTime forThisStatementDate)
                {
                    int output = 0;
                    foreach (string file in listOfFilenames)
                        if (FilenameChecker.isFilenameRawData(file) &&
                            FilenameChecker.deriveFilenameDate(file).Equals(forThisStatementDate))
                            ++output;
                    return output;
                }

                public static int howManyClientStatements(List<string> listOfFilenames)
                {
                    int output = 0;
                    foreach (string file in listOfFilenames)
                        if (FilenameChecker.isFilenameClientStatement(file))
                            ++output;
                    return output;
                }

                public static int howManyClientStatements(List<string> listOfFilenames, DateTime forThisStatementDate)
                {
                    int output = 0;
                    foreach (string file in listOfFilenames)
                        if (FilenameChecker.isFilenameClientStatement(file))
                        {
                            DateTime fileDate = FilenameChecker.deriveFilenameDate(file);
                            if (forThisStatementDate.Date.Equals(fileDate.Date))
                                output++;
                        }
                    return output;
                }
            }

            public static class BusinessDay
            {
                public enum Format
                {
                    DayMonthYearLong,
                    DayMonthYearShort,
                    MonthDayYearLong,
                    MonthDayYearShort,
                    YearDayMonthLong,
                    YearDayMonthShort,
                    YearMonthDayLong,
                    YearMonthDayShort,
                }
                public static string GetLastBusinessDay(DateTime dt)
                {
                    if (dt.DayOfWeek == DayOfWeek.Monday)
                        return dt.AddDays(-3).ToString("yyyyMMdd");
                    return dt.AddDays(-1).ToString("yyyyMMdd");
                }
                public static DateTime GetLastBusinessDayDateTime(DateTime dt)
                {
                    if (dt.DayOfWeek == DayOfWeek.Monday)
                        return dt.AddDays(-3);
                    return dt.AddDays(-1);
                }
                public static string GetLastBusinessDay(DateTime dt, string format)
                {
                    if (dt.DayOfWeek == DayOfWeek.Monday)
                        return dt.AddDays(-3).ToString(format);
                    return dt.AddDays(-1).ToString(format);
                }
                public static string GetLastBusinessDay(DateTime dt, Format format)
                {
                    if (dt.DayOfWeek == DayOfWeek.Monday)
                    {
                        switch (format)
                        {
                            case Format.DayMonthYearLong:
                                return dt.AddDays(-3).ToString("ddMMyyyy");
                            case Format.DayMonthYearShort:
                                return dt.AddDays(-3).ToString("ddMMyy");
                            case Format.MonthDayYearLong:
                                return dt.AddDays(-3).ToString("MMddyyyy");
                            case Format.MonthDayYearShort:
                                return dt.AddDays(-3).ToString("MMddyy");
                            case Format.YearMonthDayLong:
                                return dt.AddDays(-3).ToString("yyyyMMdd");
                            case Format.YearMonthDayShort:
                                return dt.AddDays(-3).ToString("yyMMdd");
                            case Format.YearDayMonthLong:
                                return dt.AddDays(-3).ToString("yyyyddMM");
                            case Format.YearDayMonthShort:
                                return dt.AddDays(-3).ToString("yyddMM");
                        }
                    }
                    switch (format)
                    {
                        case Format.DayMonthYearLong:
                            return dt.AddDays(-1).ToString("ddMMyyyy");
                        case Format.DayMonthYearShort:
                            return dt.AddDays(-1).ToString("ddMMyy");
                        case Format.MonthDayYearLong:
                            return dt.AddDays(-1).ToString("MMddyyyy");
                        case Format.MonthDayYearShort:
                            return dt.AddDays(-1).ToString("MMddyy");
                        case Format.YearMonthDayLong:
                            return dt.AddDays(-1).ToString("yyyyMMdd");
                        case Format.YearMonthDayShort:
                            return dt.AddDays(-1).ToString("yyMMdd");
                        case Format.YearDayMonthLong:
                            return dt.AddDays(-1).ToString("yyyyddMM");
                        case Format.YearDayMonthShort:
                            return dt.AddDays(-1).ToString("yyddMM");
                        default:
                            throw new ArgumentException();
                    }
                }
            }
        }
    }
}

