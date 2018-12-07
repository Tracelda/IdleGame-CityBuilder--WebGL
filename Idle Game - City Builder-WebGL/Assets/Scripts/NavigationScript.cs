using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//using System;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.IO;

public enum Navigation { mainmenu, shop, game };

public class NavigationScript : MonoBehaviour {

    public Navigation SceneNum;

    //// Save game stuff
    //public bool GameSaveLoaded = false;
    //public float PopulationScore = 0f;
    //public float GoldScore = 0f;
    //public InfoStatic InfoStatic;

    void Start ()
    {

	}
	
	void Update ()
    {
		
	}

    public void ChangeScene()
    {
        switch (SceneNum)
        {
            case Navigation.mainmenu:
                Debug.Log("Switch to main menu");
                SceneManager.LoadScene(0);
                break;

            case Navigation.shop:
                Debug.Log("Switch to shop");
                SceneManager.LoadScene(1);
                break;

            case Navigation.game:
                Debug.Log("Switch to game");
                SceneManager.LoadScene(2);
                break;
        }
    }

    public void SwitchToMainMenu()
    {
        SceneNum = (Navigation)0; // Main Menu
        ChangeScene();
    }

    public void SwitchToShop()
    {
        SceneNum = (Navigation)1; // Shop
        ChangeScene();
    }

    public void SwitchToGame()
    {
        SceneNum = (Navigation)2; // Game
        ChangeScene();
    }

    //public void Save()
    //{
    //    Debug.Log("Attempting save");
    //    BinaryFormatter binaryFormatter = new BinaryFormatter();
    //    // creates a file in the data path /C/users/appdata/....
    //    FileStream DataFile = File.Create(Application.persistentDataPath + "/PlayerData.dat");

    //    // creates new instance of the game data class
    //    GameData data = new GameData();

    //    // populating the new instance with the current ingame values
    //    data.goldscore = InfoStatic.gold;
    //    data.populationscore = InfoStatic.population;
    //    data.populationlimit = InfoStatic.populationlimit;
    //    data.housebought = InfoStatic.housebought;
    //    data.amountohouses = InfoStatic.houses;
    //    data.marketbought = InfoStatic.marketbought;
    //    data.amountomarkets = InfoStatic.markets;
    //    data.minebought = InfoStatic.minebought;
    //    data.amountomines = InfoStatic.mines;
    //    data.themebought = InfoStatic.themebought;

    //    // turns data to binary
    //    binaryFormatter.Serialize(DataFile, data);
    //    DataFile.Close();
    //}

    //public void Load()
    //{
    //    Debug.Log("Attempting load");
    //    // checks to see if data file exists
    //    if (File.Exists(Application.persistentDataPath + "/PlayerData.dat"))
    //    {
    //        Debug.Log("Loading");
    //        BinaryFormatter binaryFormatter = new BinaryFormatter();

    //        // makes a local file with the file in the location and opens it 
    //        FileStream dataFile = File.Open(Application.persistentDataPath + "/PlayerData.dat", FileMode.Open);

    //        //converts the data back from binary
    //        GameData data = (GameData)binaryFormatter.Deserialize(dataFile);
    //        dataFile.Close();

    //        // set the ingame values to values in save file 
    //        InfoStatic.gold = data.goldscore;
    //        InfoStatic.population = data.populationscore;
    //        InfoStatic.populationlimit = data.populationlimit;
    //        InfoStatic.housebought = data.housebought;
    //        InfoStatic.houses = data.amountohouses;
    //        InfoStatic.marketbought = data.marketbought;
    //        InfoStatic.markets = data.amountomarkets;
    //        InfoStatic.minebought = data.minebought;
    //        InfoStatic.mines = data.amountomines;
    //        InfoStatic.themebought = data.themebought;
    //    }
    //    //Reload the scene
    //    SceneManager.LoadScene(0);
    //}
}

//// things we want to save 
//[Serializable]
//class GameData
//{
//    public float goldscore;
//    public float populationscore;
//    public float populationlimit;
//    public bool housebought;
//    public int amountohouses;
//    public bool marketbought;
//    public int amountomarkets;
//    public bool minebought;
//    public int amountomines;
//    public bool themebought;
//}


