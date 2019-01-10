using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScrpt : MonoBehaviour {

    public InfoStatic InfoStatic;
    public GameObject House;
    public GameObject Market;
    public GameObject Port;

    void Start()
    {
        //House = GameObject.Find("House");
        //Market = GameObject.Find("Market");
        //Port = GameObject.Find("Port");
    }

    void Update()
    {
        ShowBuildings();
    }

    public void ShowBuildings()
    {
        if (InfoStatic.housebought == true)
        {
            House.SetActive(true);
        }
        if (InfoStatic.marketbought == true)
        {
            Market.SetActive(true);
        }
        if (InfoStatic.portbought == true)
        {
            Port.SetActive(true);
        }
    }
}
