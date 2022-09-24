using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public Text moneyText;
   public GameObject Hero;
    int isItemSold;
    public static int moneyAmount;
	// Use this for initialization
	void Start () {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isItemSold = PlayerPrefs.GetInt("isItemSold");
        if (isItemSold == 1)
            Hero.SetActive(true);
        else
            Hero.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        moneyText.text = "Money : " + moneyAmount.ToString() + "$";
    }
    public void gotoShop()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("Shop");

    }
}
