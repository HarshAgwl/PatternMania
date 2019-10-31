using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
	public static UI_Manager instance;
    public Text userText;

    void Awake(){
    	instance = this;
    }
}
