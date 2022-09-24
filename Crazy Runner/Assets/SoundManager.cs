using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip Jump;
    static AudioSource audioSrc;

    // Use this for initialization
    void Start() {

        Jump = Resources.Load<AudioClip>("Jump");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(Jump);
                    break;

        }




    }


}

