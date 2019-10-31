using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    void Start()
    {
        if(!PlayerPrefs.HasKey("Cryptography_LevelsUnlocked")){
        	PlayerPrefs.SetInt("Cryptography_LevelsUnlocked",0);
        }
        if(!PlayerPrefs.HasKey("Mathematics_LevelsUnlocked")){
        	PlayerPrefs.SetInt("Mathematics_LevelsUnlocked",0);
        }
    }
}
