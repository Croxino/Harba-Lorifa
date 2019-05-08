using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string name;
    public static string code;

    public static bool loggedIn {get{ return name != null;}}

    public static string coupon {get{ return code;}}

    public static void logOut()
    {
        name = null;
    }
}
