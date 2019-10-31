using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackspaceButton : MonoBehaviour
{
    public void RemoveLastCharacter(){ 
    	if(UI_Manager.instance.userText.text.Length>0){
    		UI_Manager.instance.userText.text = UI_Manager.instance.userText.text.Substring(0,UI_Manager.instance.userText.text.Length-1);
    	}
    	SoundEffectPlayer.sfxPlayerInstance.PlaySound(1);
    }
}
