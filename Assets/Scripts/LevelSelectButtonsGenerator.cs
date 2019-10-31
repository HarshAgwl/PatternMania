using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelSelectButtonsGenerator : MonoBehaviour
{
	public string challengeType;
	public GameObject levelSelectButtonPrefab;
	public GameObject lockedLevelButtonPrefab;
	public int amount;

    public GameObject alphabetKeyboard;
    public GameObject numeralsKeyboard;

    public Text questionDescription;
    public Text question;
    public GameObject submitButton;

    [System.Serializable]
    public class levelDetails{
        public string questionDescription;
        public string question;
        public string answer;
    }

    public levelDetails[] levelsDetails;

    public levelDetails practiceLevelDetails;

    void OnEnable()
    {
    	GameObject button;
        for(int i=1;i<=amount;i++){
        	if(i<=PlayerPrefs.GetInt(challengeType+"_LevelsUnlocked")){
        		button = Instantiate(levelSelectButtonPrefab, transform.position, Quaternion.identity) as GameObject;
        		int numberOfStars = PlayerPrefs.GetInt(challengeType+"_"+i.ToString(),0);
        		foreach(Transform child in button.transform)
				{
				    if(child.tag == "YellowStar" && numberOfStars>0){
				        child.gameObject.SetActive(true);
		                numberOfStars--;
				    }
				}
        	}
        	else{
        		button = Instantiate(lockedLevelButtonPrefab, transform.position, Quaternion.identity) as GameObject;
        	}
            button.transform.parent = this.transform;
            button.name = i.ToString();
            Text text = button.GetComponentInChildren<Text>();
            text.text = i.ToString();
        }
    }

    void OnDisable(){
        foreach (Transform child in transform) {
             GameObject.Destroy(child.gameObject);
         }
    }

    public void LevelButtonClicked(bool practiceLevel = false){
        int buttonNumber;
        if(practiceLevel==false){
            buttonNumber = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        }
        else
        {
            buttonNumber = 0;
        }
        levelDetails lD;
        if(practiceLevel==false){
            lD = levelsDetails[buttonNumber-1];
        }
        else{
            lD = practiceLevelDetails;
        }
        questionDescription.text = lD.questionDescription;
        question.text = lD.question;

        TextAnswerCheck submitButtonScript = submitButton.GetComponent<TextAnswerCheck>();
        submitButtonScript.answer = lD.answer;
        submitButtonScript.currentLevelNo = buttonNumber;   
        submitButtonScript.numberOfTries = 0;
        submitButtonScript.challengeType = challengeType;
        UI_Manager.instance.userText.text = "";
        if(challengeType=="Cryptography"){
            alphabetKeyboard.SetActive(true);
            numeralsKeyboard.SetActive(false);
        }
        else if(challengeType=="Mathematics"){
            alphabetKeyboard.SetActive(false);
            numeralsKeyboard.SetActive(true);
        }

        GetComponent<ActivateDeactivateUI>().Clicked();
    }
}
