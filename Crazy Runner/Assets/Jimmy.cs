using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jimmy : MonoBehaviour
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
        if (PlayerPrefs.GetInt("SelectedCharacter") == 6)

            anim.Play("Jimmy");
        else
            gameObject.SetActive(false);




    }
}
