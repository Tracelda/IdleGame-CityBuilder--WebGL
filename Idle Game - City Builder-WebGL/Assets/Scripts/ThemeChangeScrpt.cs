using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeChangeScrpt : MonoBehaviour {

    public InfoStatic InfoStatic;
    public GameObject MountainBG;
    public GameObject FutureBG;
    public bool ThemeChanged;

	// Use this for initialization
	void Start ()
    {
		if (InfoStatic.themebought)
        {
            MountainBG.SetActive(false);
            FutureBG.SetActive(true);
            ThemeChanged = true;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (!ThemeChanged)
        {
            if (InfoStatic.themebought)
            {
                MountainBG.SetActive(false);
                FutureBG.SetActive(true);
                ThemeChanged = true;
            }
        }
	}
}
