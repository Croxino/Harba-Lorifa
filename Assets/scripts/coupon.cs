using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class coupon : MonoBehaviour
{

    public InputField code;
    public GameObject start;
    public GameObject popup;
    public GameObject download;

    public GameObject wrongCoup;



    public void callCoupon()
    {
        StartCoroutine(couponCode());
        
    }

    IEnumerator couponCode()
        {

            WWWForm form = new WWWForm();
            form.AddField("score", code.text);
            UnityWebRequest www = UnityWebRequest.Post("http://i373610.hera.fhict.nl/sqlconnect/coode.php", form);
            yield return www.SendWebRequest();


            //Debug.Log(www.error);
        

        if (DBManager.code == code.text)
        {
            //DBManager.code = code.text;
            //DBManager.score = int.Parse(www.downloadHandler.text.Split('\t')[1]);
            Debug.Log("it worked");
            popup.gameObject.SetActive(false);
            download.gameObject.SetActive(false);
            start.gameObject.SetActive(true);

        }
        else
        {
            wrongCoup.gameObject.SetActive(true);
            Debug.Log("incorrect code" + www.error);
        }

    }



}
