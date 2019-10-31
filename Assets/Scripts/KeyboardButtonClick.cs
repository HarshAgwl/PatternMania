using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyboardButtonClick : MonoBehaviour
{
    public void AddToUserText(){ 
    	UI_Manager.instance.userText.text += EventSystem.current.currentSelectedGameObject.name;
    	SoundEffectPlayer.sfxPlayerInstance.PlaySound(1);
    }
}
