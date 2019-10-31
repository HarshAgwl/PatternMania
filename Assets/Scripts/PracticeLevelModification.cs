using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLevelModification : MonoBehaviour
{
	public LevelSelectButtonsGenerator script;
	
    void Start()
    {
        script.LevelButtonClicked(true);
    }
}
