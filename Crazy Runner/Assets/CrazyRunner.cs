using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyRunner : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 5)

            anim.Play("CrazyRunner");
        else
            gameObject.SetActive(false);




    }
}
