using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour {

    public GameObject avatar1, avatar2, avatar3, avatar4, avatar5, avatar6, avatar7, avatar8, avatar9, avatar10, avatar11;

    int whichAvatarIsOn = 1; 
	// Use this for initialization
	private void Start () {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
        avatar3.gameObject.SetActive(false);
        avatar4.gameObject.SetActive(false);
        avatar5.gameObject.SetActive(false);
        avatar6.gameObject.SetActive(false);
        avatar7.gameObject.SetActive(false);
        avatar8.gameObject.SetActive(false);
        avatar9.gameObject.SetActive(false);
        avatar10.gameObject.SetActive(false);
        avatar11.gameObject.SetActive(false);

    }
    public void SwitchAvatar()
    {
        switch (whichAvatarIsOn)
        {

            case 1:
                whichAvatarIsOn = 2;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);

                break;
            case 2:
                whichAvatarIsOn = 3;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(true);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 3:
                whichAvatarIsOn = 4;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(true);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 4:
                whichAvatarIsOn = 5;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false); 
                avatar5.gameObject.SetActive(true);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 5:
                whichAvatarIsOn = 6;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false); 
                avatar6.gameObject.SetActive(true);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 6:
                whichAvatarIsOn = 7;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(true);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 7:
                whichAvatarIsOn = 8;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false); 
                avatar8.gameObject.SetActive(true);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 8:
                whichAvatarIsOn = 9;
             avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(true);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;
            case 9:
                whichAvatarIsOn = 10;
             avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(true);
                avatar11.gameObject.SetActive(false);
                break; 
            case 10:
                whichAvatarIsOn = 11;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(true);
                break;
            case 11:
                whichAvatarIsOn = 1;
                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                avatar3.gameObject.SetActive(false);
                avatar4.gameObject.SetActive(false);
                avatar5.gameObject.SetActive(false);
                avatar6.gameObject.SetActive(false);
                avatar7.gameObject.SetActive(false);
                avatar8.gameObject.SetActive(false);
                avatar9.gameObject.SetActive(false);
                avatar10.gameObject.SetActive(false);
                avatar11.gameObject.SetActive(false);
                break;


        }
        }
    }
	
		
	

