using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Heisenberg : MonoBehaviour
{
    int moneyAmount;
    int isItemSold;
    public Text moneyAmountText;
    public Text ItemPrice;

    public Button buyButton;

    // Use this for initialization
    public void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

    }


    // Update is called once per frame
    public void Update()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

        isItemSold = PlayerPrefs.GetInt("isItemSold");

        if (moneyAmount >= 5 && isItemSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;


    }
    public void buyItem()
    {
        moneyAmount -= 5;
        PlayerPrefs.SetInt("IsItemSold", 1);
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
