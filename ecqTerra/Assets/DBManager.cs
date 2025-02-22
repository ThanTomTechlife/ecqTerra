using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public static class DBManager
{
    public static string username;
    public static string password;
    

    public static bool LoggedIn { get { return username != null; } }

    public static void LogOut()
    {
        username = null;
    }


}
