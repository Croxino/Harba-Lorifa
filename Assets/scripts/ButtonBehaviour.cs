using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{

    public GameObject Home;
    public GameObject Search;
    public GameObject Profile;
    public GameObject Harba;
    public GameObject Menu;
    public GameObject loggedIn;
    public void SetHome()
    {
        if (!Home.activeInHierarchy)
        {
            Home.gameObject.SetActive(true);
            Search.gameObject.SetActive(false);
            Profile.gameObject.SetActive(false);
        }

    }


        public void SetSearch()
    {
        if (!Search.activeInHierarchy)
        {
            Search.gameObject.SetActive(true);
            Home.gameObject.SetActive(false);
            Profile.gameObject.SetActive(false);
        }

                if (loggedIn.activeInHierarchy && DBManager.loggedIn == true)
        {
            loggedIn.gameObject.SetActive(false);
            Home.gameObject.SetActive(false);
            Search.gameObject.SetActive(true);
            Profile.gameObject.SetActive(false);
        } 

    }


        public void SetProfile()
    {
        if (!Profile.activeInHierarchy)
        {
            Profile.gameObject.SetActive(true);
            Home.gameObject.SetActive(false);
            Search.gameObject.SetActive(false);
        }     

        if (!loggedIn.activeInHierarchy && DBManager.loggedIn == true)
        {
            loggedIn.gameObject.SetActive(true);
            Home.gameObject.SetActive(false);
            Search.gameObject.SetActive(false);
            Profile.gameObject.SetActive(false);
        }     
    }


        public void viewCards()
    {
        if (!Harba.activeInHierarchy)
        {
            Harba.gameObject.SetActive(true);
            Menu.gameObject.SetActive(false);
            Search.gameObject.SetActive(false);
        }        
    }
    //     public void Setinactive()
    // {

    //     Home.gameObject.SetActive(false);
    //     Search.gameObject.SetActive(false);
    //     Profile.gameObject.SetActive(false);        

    // }
}
