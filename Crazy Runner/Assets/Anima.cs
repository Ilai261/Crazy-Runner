using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 1)

            anim.Play("PhilBeef");
        else
            gameObject.SetActive(false);




    }
}
