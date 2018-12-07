using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScrpt : MonoBehaviour {

    // Scripts
    public InfoStatic InfoStatic;
    
    // Points
    public GameObject GoldTxt;
    public Text GoldtxtVal;
    public GameObject PopulationTxt;
    public Text PopulationtxtVal;
    public string GoldString;
    public string PopulationString;

    // House
    public string HouseValueString;
    public string HouseAmountString;
    public int HouseValue;
    public GameObject HousePriceTxt;
    public Text HousePriceValue;
    public GameObject HouseAmountTxt;
    public Text HouseAmountValue;

    // Market
    public string MarketValueString;
    public string MarketAmountString;
    public int MarketValue;
    public GameObject MarketPriceTxt;
    public Text MarketPriceValue;
    public GameObject MarketAmountTxt;
    public Text MarketAmountValue;

    // Themes
    public float ThemePrice;

    //Boosters
    public float SmallIncome;
    public float BigIncome;

    void Start ()
    {
        SetPrices();

        // House
        HousePriceTxt = GameObject.Find("HousePriceTxt");
        HousePriceValue = HousePriceTxt.GetComponent<Text>();
        HouseAmountTxt = GameObject.Find("HouseAmountTxt");
        HouseAmountValue = HouseAmountTxt.GetComponent<Text>();

        HouseValueString = HouseValue.ToString(); // Initilises displayed value of house price
        HousePriceValue.text = "Price: " + HouseValueString;

        HouseAmountString = InfoStatic.houses.ToString(); // Initilises Displayed Value of houses bought
        HouseAmountValue.text = "Built: " + HouseAmountString;

        // Market
        MarketPriceTxt = GameObject.Find("MarketPriceTxt");
        MarketPriceValue = MarketPriceTxt.GetComponent<Text>();
        MarketAmountTxt = GameObject.Find("MarketAmountTxt");
        MarketAmountValue = MarketAmountTxt.GetComponent<Text>();

        MarketValueString = MarketValue.ToString(); // Initilises displayed value of market price
        MarketPriceValue.text = "Price: " + MarketValueString;

        MarketAmountString = InfoStatic.markets.ToString(); // Initilises Displayed Value of markets bought
        MarketAmountValue.text = "Built: " + MarketAmountString;

        // Points
        GoldTxt = GameObject.Find("GoldTxt");
        GoldtxtVal = GoldTxt.GetComponent<Text>();
        PopulationTxt = GameObject.Find("PopulationTxt");
        PopulationtxtVal = PopulationTxt.GetComponent<Text>();

        // Themes
        ThemePrice = 100;

        // Boosters
        SmallIncome = 100;
        BigIncome = 1000;
    }
	

	void Update ()
    {
        UpdateText();
	}

    public void SetPrices()
    {
        InfoStatic.houseprice = HouseValue;
        InfoStatic.marketprice = MarketValue;
    }

    public void UpdateText()
    {
        // Points Text
        GoldString = InfoStatic.gold.ToString();
        PopulationString = InfoStatic.population.ToString();
        GoldtxtVal.text = GoldString;
        PopulationtxtVal.text = PopulationString;
        // House Text
        HouseAmountString = InfoStatic.houses.ToString();
        HouseAmountValue.text = "Built: " + HouseAmountString;
        // Market Text
        MarketAmountString = InfoStatic.markets.ToString();
        MarketAmountValue.text = "Built: " + MarketAmountString;
    }

    public void BuyHouse()
    {
        Debug.Log("Click");
        if (InfoStatic.gold >= InfoStatic.houseprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.housebought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First House");
                InfoStatic.housebought = true;
            }

            InfoStatic.gold -= InfoStatic.houseprice; // Updates values to represent a house being bought
            InfoStatic.houses++;
            Debug.Log("Houses: " + InfoStatic.houses);
            Debug.Log("Gold: " + InfoStatic.gold);
            HouseAmountValue.text = "Built: " + HouseAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyMarket()
    {
        Debug.Log("Click");
        Debug.Log("Market Price: " + InfoStatic.marketprice);
        if (InfoStatic.gold >= InfoStatic.marketprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.marketbought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First Market");
                InfoStatic.marketbought = true;
            }

            InfoStatic.gold -= InfoStatic.marketprice; // Updates values to represent a market being bought
            InfoStatic.markets++;
            Debug.Log("Markets: " + InfoStatic.markets);
            Debug.Log("Gold: " + InfoStatic.gold);
            MarketAmountValue.text = "Built: " + MarketAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyHouseX2()
    {
        Debug.Log("Click");
        if (InfoStatic.gold >= InfoStatic.houseprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.housebought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First House");
                InfoStatic.housebought = true;
            }

            InfoStatic.gold -= (InfoStatic.houseprice * 2); // Updates values to represent a house being bought
            InfoStatic.houses += 2;
            Debug.Log("Houses: " + InfoStatic.houses);
            Debug.Log("Gold: " + InfoStatic.gold);
            HouseAmountValue.text = "Built: " + HouseAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyMarketX2()
    {
        Debug.Log("Click");
        Debug.Log("Market Price: " + InfoStatic.marketprice);
        if (InfoStatic.gold >= InfoStatic.marketprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.marketbought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First Market");
                InfoStatic.marketbought = true;
            }

            InfoStatic.gold -= (InfoStatic.marketprice * 2); // Updates values to represent a market being bought
            InfoStatic.markets += 2;
            Debug.Log("Markets: " + InfoStatic.markets);
            Debug.Log("Gold: " + InfoStatic.gold);
            MarketAmountValue.text = "Built: " + MarketAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyHouseX10()
    {
        Debug.Log("Click");
        if (InfoStatic.gold >= InfoStatic.houseprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.housebought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First House");
                InfoStatic.housebought = true;
            }

            InfoStatic.gold -= (InfoStatic.houseprice * 10); // Updates values to represent a house being bought
            InfoStatic.houses += 10;
            Debug.Log("Houses: " + InfoStatic.houses);
            Debug.Log("Gold: " + InfoStatic.gold);
            HouseAmountValue.text = "Built: " + HouseAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyMarketX10()
    {
        Debug.Log("Click");
        Debug.Log("Market Price: " + InfoStatic.marketprice);
        if (InfoStatic.gold >= InfoStatic.marketprice) // Detect if player has enough gold
        {
            Debug.Log("Able To Buy");
            if (InfoStatic.marketbought == false) // Checks if player has bought upgrade before
            {
                Debug.Log("First Market");
                InfoStatic.marketbought = true;
            }

            InfoStatic.gold -= (InfoStatic.marketprice * 10); // Updates values to represent a market being bought
            InfoStatic.markets += 10;
            Debug.Log("Markets: " + InfoStatic.markets);
            Debug.Log("Gold: " + InfoStatic.gold);
            MarketAmountValue.text = "Built: " + MarketAmountString;
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }

    public void BuyThemeOnBtnPress()
    {
        if (InfoStatic.themebought == false)
        {
            InfoStatic.themebought = true;
            InfoStatic.gold -= ThemePrice;
        }
    }

    public void BuySmallBoosterOnBtnPress()
    {
        InfoStatic.gold += SmallIncome;
    }

    public void BuyLargeBoosterOnBtnPress()
    {
        InfoStatic.gold += BigIncome;
    }

}
