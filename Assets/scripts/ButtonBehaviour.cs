using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public void Setbutton (string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;

    }

    public GameObject Home;
    public GameObject Search;
    public GameObject Profile;
    public void Setactive()
    {

        // Home.gameObject.SetActive(true);
        // Search.gameObject.SetActive(true);
        // Profile.gameObject.SetActive(true);

        if (Home.activeInHierarchy && !Search.activeInHierarchy && !Profile.activeInHierarchy)
        {
        Home.gameObject.SetActive(true);
        // Search.gameObject.SetActive(false);
        // Profile.gameObject.SetActive(false);  
        } 
         else if (Search.activeInHierarchy && !Home.activeInHierarchy && !Profile.activeInHierarchy)
        {
        Search.gameObject.SetActive(true);
        // Home.gameObject.SetActive(false);
        // Profile.gameObject.SetActive(false);   
        } 
        else if (Profile.activeInHierarchy && !Home.activeInHierarchy && !Profile.activeInHierarchy)
        {
       Profile.gameObject.SetActive(true);
        // Home.gameObject.SetActive(false);
        // Search.gameObject.SetActive(false);   
        }
        
    }

        public void Setinactive()
    {
        Home.gameObject.SetActive(false);
        Search.gameObject.SetActive(false);
        Profile.gameObject.SetActive(false);        

    }
}
