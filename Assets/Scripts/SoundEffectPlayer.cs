using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
	public static SoundEffectPlayer sfxPlayerInstance;

	[HideInInspector]
	public AudioSource aud;
	
	public AudioClip[] audioClips;

	void Awake()
    {
    	sfxPlayerInstance = this;   
    	aud = GetComponent<AudioSource>(); 
    }

    // 0 for blop sound
    // 1 for keyboard key sound
    public void PlaySound(int soundNumber){
    	aud.PlayOneShot(audioClips[soundNumber]);
    }
}
