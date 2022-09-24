using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript1 : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 2)

            anim.Play("Viking");
        else
            gameObject.SetActive(false);




    }
}

