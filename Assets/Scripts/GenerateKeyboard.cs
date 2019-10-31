using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class GenerateKeyboard : MonoBehaviour
{
	public string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public GameObject buttonPrefab;

    void Awake()
    {
        foreach(char character in characters){
        	GameObject button = Instantiate(buttonPrefab, transform.position, Quaternion.identity) as GameObject;
            button.transform.parent = this.transform;
            button.name = character.ToString();
            Text text = button.GetComponentInChildren<Text>();
            text.text = character.ToString();
        }
    }
}
