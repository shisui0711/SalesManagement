namespace QLCHWF;

public static class DateTimeHelper
{
    public static DateTime GetStartThisWeek()
    {
        DateTime today = DateTime.Today;

        DateTime firstDayOfWeek = today.AddDays(-(int)today.DayOfWeek);
        if (today.DayOfWeek == DayOfWeek.Sunday)
        {
            firstDayOfWeek = firstDayOfWeek.AddDays(-7);
        }

        return firstDayOfWeek;
    }

    public static DateTime GetEndThisWeek()
    {
        DateTime today = DateTime.Today;

        DateTime firstDayOfWeek = today.AddDays(-(int)today.DayOfWeek);
        DateTime lastDayOfWeek = firstDayOfWeek.AddDays(6);
        if (today.DayOfWeek == DayOfWeek.Sunday)
        {
            lastDayOfWeek = DateTime.Today;
        }
        return lastDayOfWeek;
    }
    public static DateTime GetStartLastWeek()
    {
        return GetStartThisWeek().AddDays(-7);
    }

    public static DateTime GetEndLastWeek()
    {
        return GetEndThisWeek().AddDays(-7);
    }

}