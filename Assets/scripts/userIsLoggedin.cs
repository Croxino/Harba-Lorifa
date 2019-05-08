using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userIsLoggedin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject accpopup;
        public GameObject couponpopup;

    public GameObject downloadpop;

    public void downloadreq()
    {
        downloadpop.gameObject.SetActive(true);
    }
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
