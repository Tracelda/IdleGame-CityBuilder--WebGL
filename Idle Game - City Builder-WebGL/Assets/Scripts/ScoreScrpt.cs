using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScrpt : MonoBehaviour {

    public InfoStatic InfoStatic;
    public BuildingScrpt BuildingScrpt;

    // Text
    public GameObject GoldAmount;
    public Text GoldAmountTxt;
    public GameObject PopulationAmount;
    public Text PopulationAmountTxt;
    public GameObject PopulationLimAmount;
    public Text PopulationLimAmountTxt;

    public float Timer;
    public float TimerTarget;

    // Points stuff
    public float HouseGoldIncome;
    public float HousePopulationIncome;

    public float MarketGoldIncome;
    public float MarketPopulationIncome;

    public float PortGoldIncome;
    public float PortPopulationIncome;

    public float GoldIncome;
    public float PopulationIncome;

    public float GoldPerSecond;
    public float PopulationPerSecond;

    public string GoldString;
    public string PopulationString;
    public string PopulationLimString;

    public float BasePopulationLimit;
    public float HousePopulationModifier;

    public float LeftOverHouseGold;
    public float LeftOverMarketGold;
    public float LeftOverPortGold;

    public float LeftOverHousePopulation;
    public float LeftOverMarketPopulation;
    public float LeftOverPortPopulation;

    public bool NotEnoughPopulation;

    public AudioManagerScrpt AudioManagerScrpt;

    void Start ()
    {
        GoldAmount = GameObject.Find("GoldAmount");
        GoldAmountTxt = GoldAmount.GetComponent<Text>();

        PopulationAmount = GameObject.Find("PopulationAmount");
        PopulationAmountTxt = PopulationAmount.GetComponent<Text>();

        PopulationLimAmount = GameObject.Find("PopulationLimAmount");
        PopulationLimAmountTxt = PopulationLimAmount.GetComponent<Text>();

        BuildingScrpt.ShowBuildings(); // Check which buildings have been bought 
        SetIncomes();
        
    }
	
	void Update ()
    {
        UpdatePoints();
    }

    public void UpdateGoldOnBtn() // Adds one to gold score when button is pressed
    {
            InfoStatic.gold++;
            GoldString = InfoStatic.gold.ToString();
            GoldAmountTxt.text = GoldString;
            AudioManagerScrpt.PlaySound("hort-click-snap-perc", .2f);
    }

    public void UpdatePopulationOnBtn() // Adds one to population score when button is pressed
    {

        if (InfoStatic.population < InfoStatic.populationlimit)
        {
            InfoStatic.population++;
            PopulationString = InfoStatic.population.ToString();
            PopulationAmountTxt.text = PopulationString;
            AudioManagerScrpt.PlaySound("hort-click-snap-perc", .2f);
        }
        // else { Debug.Log("Max population reached"); }
    }

    public void AddGold() // adds gold incomes together and adds total to gold score
    {
        if( InfoStatic.population > 0)
        {
            GoldPerSecond += (InfoStatic.population / 10);
            GoldIncome += Mathf.Floor(GoldPerSecond);
            //InfoStatic.gold += GoldIncome;
            GoldPerSecond = 0;
            // Debug.Log("Gold Income from base pop: " + GoldIncome);
            //GoldIncome = 0;
        }


        if (InfoStatic.housebought == true)
        {
            //Debug.Log("Points From House");
            GoldPerSecond += (LeftOverHouseGold + (InfoStatic.housegoldincome * InfoStatic.houses));
            if(GoldPerSecond >=1)
            {
                //GoldIncome = 0;
                //Debug.Log("Gold Per Second Higher Than 1");
                GoldIncome += Mathf.Floor(GoldPerSecond);
                LeftOverHouseGold = (GoldPerSecond - Mathf.Floor(GoldPerSecond));
                // Debug.Log("Gold Income: " + GoldIncome);
                //InfoStatic.gold += GoldIncome;
                GoldPerSecond = 0;
            }
        }
        if (InfoStatic.marketbought == true)
        {
            //Debug.Log("Points From Market");
            GoldPerSecond += (LeftOverMarketGold + (InfoStatic.marketgoldincome * InfoStatic.markets));
            if (GoldPerSecond >= 1)
            {
                //GoldIncome = 0;
                //Debug.Log("Gold Per Second Higher Than 1");
                GoldIncome += Mathf.Floor(GoldPerSecond);
                LeftOverMarketGold = (GoldPerSecond - Mathf.Floor(GoldPerSecond));
                // Debug.Log("Gold Income: " + GoldIncome);
                //InfoStatic.gold += GoldIncome;
                GoldPerSecond = 0;
            }
        }
        if (InfoStatic.portbought == true)
        {
            //Debug.Log("Points From Port");
            GoldPerSecond += (LeftOverPortGold + (InfoStatic.portgoldincome * InfoStatic.ports));
            if (GoldPerSecond >= 1)
            {
                //GoldIncome = 0;
                //Debug.Log("Gold Per Second Higher Than 1");
                GoldIncome += Mathf.Floor(GoldPerSecond);
                LeftOverPortGold = (GoldPerSecond - Mathf.Floor(GoldPerSecond));
                // Debug.Log("Gold Income: " + GoldIncome);
                //InfoStatic.gold += GoldIncome;
                GoldPerSecond = 0;
            }
        }
        InfoStatic.gold += GoldIncome;
        GoldIncome = 0;
    }

    public void AddPopulation() // adds population incomes together and adds total to population score
    {
        // Debug.Log("Not enough population");
        if (InfoStatic.housebought == true)
        {
            PopulationPerSecond += (LeftOverHousePopulation + (InfoStatic.housepopincome * InfoStatic.houses));
            //Debug.Log("Pop per second: " + PopulationPerSecond);
            if (PopulationPerSecond >= 1)
            {
                // PopulationIncome = 0;
                //Debug.Log("Pop Per Second Higher Than 1");
                PopulationIncome += Mathf.Floor(PopulationPerSecond);
                LeftOverHousePopulation = PopulationPerSecond - Mathf.Floor(PopulationPerSecond);
                //Debug.Log("Population Income: " + PopulationIncome);
                //InfoStatic.population += PopulationIncome;
                PopulationPerSecond = 0;
            }
        }
        if (InfoStatic.marketbought == true)
        {
            PopulationPerSecond += (LeftOverMarketPopulation + (InfoStatic.marketpopincome * InfoStatic.markets));
            //Debug.Log("Pop per second: " + PopulationPerSecond);
            if (PopulationPerSecond >= 1)
            {
                // PopulationIncome = 0;
                //Debug.Log("Pop Per Second Higher Than 1");
                PopulationIncome += Mathf.Floor(PopulationPerSecond);
                LeftOverMarketPopulation = (PopulationPerSecond - Mathf.Floor(PopulationPerSecond));
                //Debug.Log("Population Income: " + PopulationIncome);
                //InfoStatic.population += PopulationIncome;
                PopulationPerSecond = 0;
            }
        }
        if (InfoStatic.portbought == true)
        {
            PopulationPerSecond += (LeftOverPortPopulation + (InfoStatic.portpopincome * InfoStatic.ports));
            //Debug.Log("Pop per second: " + PopulationPerSecond);
            if (PopulationPerSecond >= 1)
            {
                // PopulationIncome = 0;
                //Debug.Log("Pop Per Second Higher Than 1");
                PopulationIncome += Mathf.Floor(PopulationPerSecond);
                LeftOverPortPopulation = (PopulationPerSecond - Mathf.Floor(PopulationPerSecond));
                //Debug.Log("Population Income: " + PopulationIncome);
                //InfoStatic.population += PopulationIncome;
                PopulationPerSecond = 0;
            }
        }

        InfoStatic.population += PopulationIncome;
        PopulationIncome = 0;


        if (!CheckPopulationLimit())
        {
            InfoStatic.population = InfoStatic.populationlimit;
        }
    }

    public void UpdatePoints()
    {
        if (Timer < TimerTarget)
        {
            Timer += Time.deltaTime;
        }
        else if (Timer >= TimerTarget)
        {
            AddGold();
            CheckPopulationLimit();
            if (CheckPopulationLimit())
            {
                Debug.Log("Adding population");
                AddPopulation();
            }
            UpdateValues();
            //Debug.Log("Update Values");
            Timer = 0;
            ChangePopulationLimit();
            //PopulationIncome = 0;
            //GoldIncome = 0;
        }
    }

    public void UpdateValues() // updates the values of text boxes
    {
        //Debug.Log("Gold:" + InfoStatic.gold);
        //Debug.Log("Population:" + InfoStatic.population);
        PopulationString = InfoStatic.population.ToString();
        PopulationAmountTxt.text = PopulationString;
        GoldString = InfoStatic.gold.ToString();
        GoldAmountTxt.text = GoldString;
        PopulationLimString = InfoStatic.populationlimit.ToString();
        PopulationLimAmountTxt.text = PopulationLimString;
    }

    public void SetIncomes() // Sets up the income valuses of upgrades
    {
        InfoStatic.housegoldincome = HouseGoldIncome;
        InfoStatic.housepopincome = HousePopulationIncome;
        InfoStatic.marketgoldincome = MarketGoldIncome;
        InfoStatic.marketpopincome = MarketPopulationIncome;
        InfoStatic.portgoldincome = PortGoldIncome;
        InfoStatic.portpopincome = PortPopulationIncome;
    }

    public void ChangePopulationLimit()
    {
        InfoStatic.populationlimit = BasePopulationLimit + (InfoStatic.houses * HousePopulationModifier);
    }

    public bool CheckPopulationLimit()
    {
        if (InfoStatic.population < InfoStatic.populationlimit)
        {
            // Debug.Log("Not enough population");
            NotEnoughPopulation = true;
        }
        else
        {
            // Debug.Log("Max population reached");
            NotEnoughPopulation = false;
        }
        return NotEnoughPopulation;
    }
}
