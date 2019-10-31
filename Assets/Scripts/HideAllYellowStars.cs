using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAllYellowStars : MonoBehaviour
{
	public GameObject successScreen;
	
    public void Clicked(){
    	foreach(Transform child in successScreen.transform)
		{
		    if(child.tag == "YellowStar"){
		        child.gameObject.SetActive(false);
		    }
		}
    }
}
