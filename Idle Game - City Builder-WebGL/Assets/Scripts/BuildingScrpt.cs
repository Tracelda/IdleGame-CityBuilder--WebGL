using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScrpt : MonoBehaviour {

    public InfoStatic InfoStatic;
    public GameObject House;
    public GameObject Market;

    private void Start()
    {
        House = GameObject.Find("House");
        Market = GameObject.Find("Market");
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
    }
}
