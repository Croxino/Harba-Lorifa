using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchFilter : MonoBehaviour
{



public InputField searchbar;
public GameObject cardobjects;
public GameObject cardContainer;
public List<GameObject> cardList = new List<GameObject>();


    public void search()
    {
        foreach (var card in cardList)
        {
            if (searchbar.text == card.name.ToLower())
            {

               card.SetActive(true);
            }
            else{
                card.SetActive(false);
            }
            if (searchbar.text == "")
            {
                card.SetActive(true);
            }
        }
    }
}




