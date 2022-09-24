using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewDiePie : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 9)

            anim.Play("PewDiePie");
        else
            gameObject.SetActive(false);




    }
}
