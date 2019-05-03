using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net.Mail;


public class registration : MonoBehaviour
{
    public InputField email;
    public InputField password;
    public InputField hPassword;

    public Button submit;
  
    public void callRegister(){
        StartCoroutine(Register());
    }

    IEnumerator Register(){
            WWWForm form = new WWWForm();
            form.AddField("email", email.text);
            form.AddField("password", password.text);

        
        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/register.php",form);
        yield return www;

        if (www.downloadHandler.text == "0")
        {
            Debug.Log("User created succesfully");

        }
        else
        {
            Debug.Log("error" + www.error);
        }
    }
    public void verifyInput()
    {
         if(password.text == hPassword.text)
        {
            //submit.interactable = true;
            submit.interactable = (email.text.Length >= 8 && email.text.Contains("@") || email.text.Contains(".com"));
         }
         else
         {
             submit.interactable = false;
             
         }    
        //Debug.Log(submit.interactable);
    }
}

