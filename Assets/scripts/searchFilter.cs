using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class searchFilter : MonoBehaviour
{



public InputField searchbar;
//public InputField input;
public GameObject cardobjects;
public GameObject cardContainer;
public List<GameObject> cardList = new List<GameObject>();
//public GameObject[] cards = new GameObject[0];

    public void search()
    {
        foreach (var card in cardList)
        {
            if (searchbar.text == card.name)
            {
               //var cardinsta =  Instantiate(card, new Vector2(733,460), transform.rotation);
               var cardinsta = Instantiate(card,Vector3.zero, Quaternion.identity, cardContainer.transform);
              // cardinsta.transform.parent = cardContainer.transform;
               cardinsta.SetActive(true);
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




    }


}
