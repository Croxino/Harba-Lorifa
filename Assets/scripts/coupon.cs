using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class coupon : MonoBehaviour
{

    public InputField code;

    public void callCoupon()
    {
        StartCoroutine(couponCode());
        
    }

    IEnumerator couponCode()
        {

            WWWForm form = new WWWForm();
            form.AddField("score", code.text);
            UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/coode.php", form);
            yield return www.SendWebRequest();
            Debug.Log(DBManager.code);

            //Debug.Log(www.error);
        

        if (DBManager.code == "HRB")
        {
            //DBManager.code = code.text;
            //DBManager.score = int.Parse(www.downloadHandler.text.Split('\t')[1]);
            Debug.Log("it worked");


        }
        else
        {
            Debug.Log("user login failed" + www.error);
        }
        Debug.Log(DBManager.code);
        Debug.Log(www.error);
        Debug.Log(www.downloadHandler.text);
        Debug.Log(www.downloadHandler.text[0]);
        Debug.Log(DBManager.loggedIn);
    }

}
