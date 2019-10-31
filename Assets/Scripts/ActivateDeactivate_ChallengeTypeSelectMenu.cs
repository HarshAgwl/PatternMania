using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivate_ChallengeTypeSelectMenu : MonoBehaviour
{
	// Practice set refers to the zeroth level
	[SerializeField]
	private GameObject practiceSet;
	[SerializeField]
	private GameObject levelSelect;
	[SerializeField]
	private GameObject[] toDeactivate;

    public void Clicked(){
    	SoundEffectPlayer.sfxPlayerInstance.PlaySound(0);
    	if(PlayerPrefs.GetInt(gameObject.name+"_LevelsUnlocked")>0){
    		levelSelect.SetActive(true);
    	}
    	else{
    		practiceSet.SetActive(true);
    	}
    	if(toDeactivate.Length>0){
    		foreach(GameObject obj in toDeactivate){
    			obj.SetActive(false);
    		}
    	}
    }
}
