using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivateSpecial : MonoBehaviour
{
	public GameObject submitButton;
	public GameObject[] levelSelectMenus;
	public GameObject[] practiceSets;

    public void Clicked(){
    	SoundEffectPlayer.sfxPlayerInstance.PlaySound(0);

    	string challengeType = submitButton.GetComponent<TextAnswerCheck>().challengeType;

    	if(challengeType=="Cryptography"){
    		practiceSets[0].SetActive(false);
    		levelSelectMenus[0].SetActive(true);
    	}
    	else if(challengeType=="Mathematics"){
    		practiceSets[1].SetActive(false);
    		levelSelectMenus[1].SetActive(true);
    	}
    }
}
