using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour {
     int moneyAmount;
       int isItemSold;
    public Text ItemPrice;
    public Text money1;
    public Text money2;
    public Text money3;
    public Text money4; 
    public Text money5;
    public Text money6; 
    public Text money7;
    public Text money8;
    public Text money9;
    public Button buyButton; 

	// Use this for initialization
	 public void Start () {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        PlayerPrefs.Save();

    }


    // Update is called once per frame
    public void Update() {

        money1.text = "Money: " + moneyAmount.ToString() + "$";
        money2.text = "Money: " + moneyAmount.ToString() + "$";
        money3.text = "Money: " + moneyAmount.ToString() + "$";
        money4.text = "Money: " + moneyAmount.ToString() + "$";
        money5.text = "Money: " + moneyAmount.ToString() + "$";
        money6.text = "Money: " + moneyAmount.ToString() + "$";
        money7.text = "Money: " + moneyAmount.ToString() + "$";
        money8.text = "Money: " + moneyAmount.ToString() + "$";
        money9.text = "Money: " + moneyAmount.ToString() + "$";

        isItemSold = PlayerPrefs.GetInt("IsItemSold");

        if (moneyAmount >= 5 && isItemSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;


    }
    public void buyItem()
    {
        moneyAmount -= 5;
        PlayerPrefs.SetInt ("IsItemSold", 1);
        PlayerPrefs.GetInt(ItemPrice.text = "Sold!");
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        SceneManager.LoadScene("CharacterSelect");
    }

    public void resetPlayerPrefts()
    {
        moneyAmount = 0;
        buyButton.gameObject.SetActive(true);
        ItemPrice.text = "Price : 5$";
        PlayerPrefs.DeleteAll();
        
    }
    public void Characters()
    {
        SceneManager.LoadScene("CharacterSelect");
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

}
