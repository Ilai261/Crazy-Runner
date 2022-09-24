using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

   void OnTriggerEnter2D (Collider2D col)
    {
        GameControl.moneyAmount += 1; 
        Destroy(gameObject);

    }
}

