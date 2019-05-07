using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userIsLoggedin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject accpopup;
        public GameObject couponpopup;

    public void loggedIn (){
        if (DBManager.loggedIn == false)
        {
            accpopup.gameObject.SetActive(true);
        }else
        {
            couponpopup.gameObject.SetActive(true);
        }
    }
}
