using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net.Mail;


public class registration : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField hPassword;

    public Button submit;
  
    public void callRegister(){
        StartCoroutine(Register());
    }

    IEnumerator Register(){
            WWWForm form = new WWWForm();
            form.AddField("username", username.text);
            form.AddField("password", password.text);

        
        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/register.php",form);
        yield return www.SendWebRequest();

        if (www.downloadHandler.text == "0")
        {
            Debug.Log("User created succesfully");

        }
        else
        {
            Debug.Log( "user creation failed" + www.error);
        }
    }
    public void verifyInput()
    {
         if(password.text == hPassword.text)
        {
            //submit.interactable = true;
            submit.interactable = (username.text.Length >= 8 && password.text.Length >= 1 && hPassword.text.Length >= 1 && username.text.Contains("@") && username.text.Contains(".com") || username.text.Contains(".nl") );
         }
         else
         {
             submit.interactable = false;
             
         }    
        //Debug.Log(submit.interactable);
    }
}

