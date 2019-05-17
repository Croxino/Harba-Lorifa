using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class Login : MonoBehaviour
{   public InputField username;
    public InputField password;
    public GameObject loggedin;
    public GameObject profile;


  
    public void callLogin(){
        StartCoroutine(userLogin());
    }

    IEnumerator userLogin()
    {
            WWWForm form = new WWWForm();
            form.AddField("username", username.text);
            form.AddField("password", password.text);
            

        
        UnityWebRequest www = UnityWebRequest.Post("http://i373610.hera.fhict.nl/sqlconnect/login.php",form);
        yield return www.SendWebRequest();


        if (www.downloadHandler.text[0] == '0')
        {
            DBManager.name = username.text;

            //my php script always returns 0 and adds it at the beginning of any text, thats why we have to strip the 0 for our couponcode to work.
            string replacedString = www.downloadHandler.text.Replace("0", string.Empty);

            DBManager.code = replacedString;



            
            loggedin.gameObject.SetActive(true);
            profile.gameObject.SetActive(false);
            password.text = "";

        }
        else
        {
            Debug.Log("user login failed" + www.error);
        }
    }

    public void logout(){
        DBManager.logOut();
        profile.gameObject.SetActive(true);
        loggedin.gameObject.SetActive(false);
        Debug.Log(DBManager.loggedIn);
    }



    
}