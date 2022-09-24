using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomyMontana : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 7)

            anim.Play("TomyMontana");
        else
            gameObject.SetActive(false);




    }
}
