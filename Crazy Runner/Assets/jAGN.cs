using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jAGN : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 3)

            anim.Play("CrazyNinja");
        else
            gameObject.SetActive(false);




    }
}
