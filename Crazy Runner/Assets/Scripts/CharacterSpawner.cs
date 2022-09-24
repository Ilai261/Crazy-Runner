using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{

    public  GameObject[] players;


    void Start()
    {

        if (PlayerPrefs.GetInt("SelectedCharacter") == 0)
        {
            Instantiate(players[(0)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 1)
        {
            Instantiate(players[(1)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 2)
        {
            Instantiate(players[(2)], Vector2.zero, Quaternion.identity);
        }


        if (PlayerPrefs.GetInt("SelectedCharacter") == 3)
        {
            Instantiate(players[(3)], Vector2.zero, Quaternion.identity);
        }


        if (PlayerPrefs.GetInt("SelectedCharacter") == 4)
        {
            Instantiate(players[(4)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 5)
        {
            Instantiate(players[(5)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 6)
        {
            Instantiate(players[(6)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 7)
        {
            Instantiate(players[(7)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 8)
        {
            Instantiate(players[(8)], Vector2.zero, Quaternion.identity);
        }

        if (PlayerPrefs.GetInt("SelectedCharacter") == 9)
        {
            Instantiate(players[(9)], Vector2.zero, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("SelectedCharacter") == 10)
        {
            Instantiate(players[(10)], Vector2.zero, Quaternion.identity);
        }
    }
}