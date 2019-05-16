using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptaccess : MonoBehaviour
{

             

             private GameObject gm;
             private gManager GManager;
             
    // Start is called before the first frame update
        void Awake()
    {

                gm = GameObject.Find("manager");
                GManager = gm.GetComponent<gManager>();
                
                

    }
    void Start()
    {

         GManager.Zoeken.SetActive(true);
    }



}
