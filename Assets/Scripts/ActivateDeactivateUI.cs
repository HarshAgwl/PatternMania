using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivateUI : MonoBehaviour
{
	[SerializeField]
	private GameObject[] toActivate;
	[SerializeField]
	private GameObject[] toDeactivate;

    public void Clicked(){
    	SoundEffectPlayer.sfxPlayerInstance.PlaySound(0);
    	if(toActivate.Length>0){
    		foreach(GameObject obj in toActivate){
    			obj.SetActive(true);
    		}
    	}
    	if(toDeactivate.Length>0){
    		foreach(GameObject obj in toDeactivate){
    			obj.SetActive(false);
    		}
    	}
    }
}
