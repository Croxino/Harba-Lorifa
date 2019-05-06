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
    public Button submit;

  
    public void callLogin(){
        StartCoroutine(userLogin());
    }

    IEnumerator userLogin()
    {
            WWWForm form = new WWWForm();
            form.AddField("username", username.text);
            form.AddField("password", password.text);

        
        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/login.php",form);
        yield return www.SendWebRequest();

        if (www.downloadHandler.text[0] == '0')
        {
            DBManager.name = username.text;
            //DBManager.score = int.Parse(www.downloadHandler.text.Split('\t')[1]);
            
            loggedin.gameObject.SetActive(true);
            profile.gameObject.SetActive(false);
            password.text = "";

        }
        else
        {
            Debug.Log("user login failed" + www.error);
        }
        Debug.Log(www.error);
        Debug.Log(www.downloadHandler.text);
        Debug.Log(DBManager.loggedIn);
    }

    public void logout(){
        DBManager.logOut();
        profile.gameObject.SetActive(true);
        loggedin.gameObject.SetActive(false);
        Debug.Log(DBManager.loggedIn);
    }

    public void verifyInput()
    {
        //for now the register button only becomes interactible when the requirements match. but preferably it should always be interactable and give a popup notification
        //if anything went wrong, only when everything is correct you should be able to create an account.

            //submit.interactable = true;
            //submit.interactable = (username.text.Length >= 8 && password.text.Length >= 1 && username.text.Contains("@") && username.text.Contains(".com") || username.text.Contains(".nl") );             
          
        //Debug.Log(submit.interactable);
    }

    
}
