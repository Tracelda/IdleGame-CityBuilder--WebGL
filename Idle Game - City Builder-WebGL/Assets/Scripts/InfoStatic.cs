using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoStatic
{
    // Score totals
    public static float population;
    public static float populationlimit;
    public static float gold;

    // Upgrades Bought & Amounts
    public static bool housebought;
    public static int houses;
    public static int houseprice;
    public static float housegoldincome;
    public static float housepopincome;

    public static bool marketbought;
    public static int markets;
    public static int marketprice;
    public static float marketgoldincome;
    public static float marketpopincome;

    public static bool minebought;
    public static int mines;
    public static int mineprice;

    // Theme
    public static bool themebought;

    // Date
    

    public static float Population
    {
        get
        {
            return population;
        }
        set
        {
            population = value;
        }
    }

    public static float PopulationLimit
    {
        get
        {
            return populationlimit;
        }
        set
        {
            populationlimit = value;
        }
    }

    public static float Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
        }
    }


    // House ----------------------------------------------------------------------
    public static int HousePrice
    {
        get
        {
            return houseprice;
        }
        set
        {
            houseprice = value;
        }
    }
    
    public static bool HousesBought
    {
        get
        {
            return housebought;
        }
        set
        {
            housebought = value;
        }
    }

    public static int Houses
    {
        get
        {
            return houses;
        }
        set
        {
            houses = value;
        }
    }

    public static float HouseGoldIncome
    {
        get
        {
            return housegoldincome;
        }
        set
        {
            housegoldincome = value;
        }

    }

    public static float HousePopIncome
    {
        get
        {
            return housepopincome;
        }
        set
        {
            housepopincome = value;
        }
    }

    // Market ----------------------------------------------------------------------
    public static bool Marketbought
    {
        get
        {
            return marketbought;
        }
        set
        {
            marketbought = value;
        }
    }

    public static int Markets
    {
        get
        {
            return markets;
        }
        set
        {
            markets = value;
        }

    }

    public static float MarketGoldIncome
    {
        get
        {
            return housegoldincome;
        }
        set
        {
            housegoldincome = value;
        }

    }

    public static float MarketPopIncome
    {
        get
        {
            return housepopincome;
        }
        set
        {
            housepopincome = value;
        }
    }

    public static bool ThemeBought
    {
        get
        {
            return themebought;
        }
        set
        {
            themebought = value;
        }
    }


}
