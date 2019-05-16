using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabreference : MonoBehaviour

{

    public GameObject Sporten;
    public GameObject Zoeken;

    private GameObject gm;
    private gManager GManager;
    // Start is called before the first frame update
    void Awake()
    {
        gm = GameObject.Find("manager");
        GManager = gm.GetComponent<gManager>();


    }

    // void Start() {
    //     Debug.Log(GManager.Zoeken);
    // }


    public void sportenActive()
    {
        if (!GManager.Sporten.activeInHierarchy)
        {
            GManager.Sporten.SetActive(true);
            GManager.Menu.SetActive(false);
        }
    }

        public void zoekenActive()
    {
        if (!GManager.Zoeken.activeInHierarchy)
        {
            GManager.Zoeken.SetActive(true);
            GManager.Menu.SetActive(false);
        }
    }

    
}
