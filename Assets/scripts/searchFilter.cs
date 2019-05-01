using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchFilter : MonoBehaviour
{

string filter;

public InputField searchbar;
//public InputField input;
public GameObject cardobjects;
public List<GameObject> cardList = new List<GameObject>();
//public GameObject[] cards = new GameObject[0];

    public void search(string filter)
    {
        foreach (var card in cardList)
        {
            if (searchbar.text == card.name)
            {
                Instantiate(card);
            }

        }
        // filter = searchbar.text;


        // if (searchbar.text == filter)
        // {
        //     cards = GameObject.FindGameObjectsWithTag(filter);
        //     for (int i = 0; i < cards.Length; i++)
        //     {

        //         cards[i].SetActive(true);

        //     }
            
        // }
        Debug.Log(searchbar.text);
        Debug.Log("list: " + cardobjects);
        Debug.Log("list: " + filter);



    }


}
