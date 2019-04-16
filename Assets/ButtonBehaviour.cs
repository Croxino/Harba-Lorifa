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

    public GameObject Panel;
    public void Setactive()
    {
        var button = transform.Find("Image").GetComponent<Image>();
        button.enabled = true;
        

        
    }
}
