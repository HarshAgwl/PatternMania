using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
	public Text textComponent;
	private string text;
	private int frontIndex = 0;
	private int lastIndex;
	private int temp;
	[SerializeField]
	private float speed = 3f;

	void Awake(){
		text = textComponent.text;
		lastIndex = text.Length;
	}

	void Start(){
		StartCoroutine("ChangeText");
	}
    
    IEnumerator ChangeText(){
    	if(frontIndex==text.Length){
    		if(GetComponent<ActivateDeactivateUI>()){
    			GetComponent<ActivateDeactivateUI>().Clicked();
    		}
	    	yield break;
	    }
    	if(System.Char.IsLetter(text[frontIndex])){
	    	temp = (int)text[frontIndex];
	    	temp += 13;
	    	if(temp>90){
	    		temp -= 26;
	    	}
	    	text = text.Remove(frontIndex,1);
	    	text = text.Insert(frontIndex,((char)temp).ToString());
	    	textComponent.text = text;
	    	yield return new WaitForSeconds(1f/speed);
	    }
	    frontIndex++;
	    StartCoroutine("ChangeText"); 
    }
}
