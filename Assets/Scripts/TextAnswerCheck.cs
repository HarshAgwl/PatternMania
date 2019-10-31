using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnswerCheck : MonoBehaviour
{
	public string challengeType;
	[SerializeField]
	public int currentLevelNo;
	public int numberOfTries = 0;
	public string answer;
	public GameObject successScreen;

    public void Check(){
    	numberOfTries++;
    	if(UI_Manager.instance.userText.text==answer){

    		if(numberOfTries==1){
    			PlayerPrefs.SetInt(challengeType+"_"+currentLevelNo.ToString(),3);
    		}
    		else if(numberOfTries<=3){
    			PlayerPrefs.SetInt(challengeType+"_"+currentLevelNo.ToString(),2);	
    		}
    		else{
    			PlayerPrefs.SetInt(challengeType+"_"+currentLevelNo.ToString(),1);
    		}

    		if(currentLevelNo+1>PlayerPrefs.GetInt(challengeType+"_LevelsUnlocked")){
    			PlayerPrefs.SetInt(challengeType+"_LevelsUnlocked", PlayerPrefs.GetInt(challengeType+"_LevelsUnlocked")+1);
    		}

    		ShowSuccessScreen(PlayerPrefs.GetInt(challengeType+"_"+currentLevelNo.ToString()));
    	}
    }

    void ShowSuccessScreen(int numberOfStars){
    	successScreen.SetActive(true);
		foreach(Transform child in successScreen.transform)
		{
		    if(child.tag == "YellowStar" && numberOfStars>0){
		        child.gameObject.SetActive(true);
                numberOfStars--;
		    }
		}
    }
}

