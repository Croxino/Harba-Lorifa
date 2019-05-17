using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;



public class registration : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField hPassword;

    public GameObject loggedin;
    public GameObject profile;

    public Button submit;

    public GameObject regsucc;
    public GameObject regfail;
  
    public void callRegister(){
        StartCoroutine(Register());
    }

     public void callLogin(){
        StartCoroutine(userLogin());
    }

    IEnumerator Register(){
            WWWForm form = new WWWForm();
            form.AddField("username", username.text);
            form.AddField("password", password.text);

        
        UnityWebRequest www = UnityWebRequest.Post("http://i373610.hera.fhict.nl/sqlconnect/register.php",form);
        yield return www.SendWebRequest();

        if (www.downloadHandler.text == "0")
        {

            Debug.Log("User created succesfully");
            regsucc.SetActive(true);

        }
        else
        {
            Debug.Log( "user creation failed" + www.error);
        }
    }
    public void verifyInput()
    {
        //for now the register button only becomes interactible when the requirements match. but preferably it should always be interactable and give a popup notification
        //if anything went wrong, only when everything is correct you should be able to create an account.
         if(password.text == hPassword.text && username.text.Length >= 8 && password.text.Length >= 1 && hPassword.text.Length >= 1 && username.text.Contains("@") && 
            username.text.Contains(".com") || username.text.Contains(".nl"))
        {
            
            callRegister();

         }
         else
         {
             regfail.SetActive(true);
             Debug.Log("failed");
         }    
        //Debug.Log(submit.interactable);
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
        }


