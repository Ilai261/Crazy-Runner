using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatManAnimation : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 8)

            anim.Play("RatMan");
        else
            gameObject.SetActive(false);




    }
}
