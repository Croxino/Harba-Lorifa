using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string name;
    public static string code;

    public static bool loggedIn {get{ return name != null;}}

    public static bool coupon {get{ return code != null;}}

    public static void logOut()
    {
        name = null;
    }
}
