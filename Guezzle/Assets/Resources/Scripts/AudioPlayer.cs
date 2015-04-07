using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
       
    }
   public void PlayFx(string name)
    {
        AudioClip audio = Resources.Load(CONSTANTS.get("SFX") + name) as AudioClip;
        if(audio != null)
        this.GetComponent<AudioSource>().PlayOneShot(audio);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
