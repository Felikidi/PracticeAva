using System;

namespace AvaDesktop.Helpers;

public static class Data
{
    public static string GenerateEmail()
    {
        DateTime today = DateTime.Now;
        string time = today.Day.ToString() + today.Hour.ToString() + today.Minute.ToString() + 
                      today.Second.ToString() + today.Millisecond.ToString();
        return $"test{time}@dd.com";
    }
}