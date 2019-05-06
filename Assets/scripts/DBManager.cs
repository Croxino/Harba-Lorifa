using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string name;
    public static int score;

    public static bool loggedIn {get{ return name != null;}}

    public static void logOut()
    {
        name = null;
    }
}
