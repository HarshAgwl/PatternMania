using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class View_or_DeletePlayerPrefs : MonoBehaviour
{
	[SerializeField]
	private bool deletePlayerPrefs = false;
	public int cryptographyLevelsUnlocked = 0;
	public int mathematicsLevelsUnlocked = 0;

    void Start(){
    	StartCoroutine("UpdateValues");
    }

    IEnumerator UpdateValues(){
    	if(deletePlayerPrefs){
    		PlayerPrefs.DeleteAll();
    		Debug.Log("Deleted Player Prefs");
    	}
    	cryptographyLevelsUnlocked = PlayerPrefs.GetInt("Cryptography_LevelsUnlocked");
    	mathematicsLevelsUnlocked = PlayerPrefs.GetInt("Mathematics_LevelsUnlocked");

    	yield return new WaitForSeconds(1f);
    	StartCoroutine("UpdateValues");
    }
    	
}
