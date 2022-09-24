using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killerx : MonoBehaviour
{

    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("SelectedCharacter") == 4)

            anim.Play("KillerX");
        else
            gameObject.SetActive(false);




    }
}


