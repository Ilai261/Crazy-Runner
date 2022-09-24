using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Shop1 : MonoBehaviour {
    public Text moneyText;
    public GameObject Hero;
    int isItemSold;
    public static int moneyAmount; 
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
       
    }
	
}
