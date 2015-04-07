using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class splashScript : MonoBehaviour {
    public Camera camera = null;
    float color = 0 ,textcolor = 1;
    float time = -1;
    public GameObject canvas = null;
    public Text text = null;
	void Start () {
        if (canvas != null) if (canvas.activeInHierarchy) canvas.SetActive(false);
	}
    bool hasDoneShowingup = false;
	
	// Update is called once per frame
	void Update () {
        if (color >= 0 && color <= 1 && !hasDoneShowingup)
        {
            color += Time.deltaTime;
            textcolor -= Time.deltaTime;
            camera.backgroundColor = new Color(color, color, color, color);
        }
        else
        {
            if (time >= 0)
            {
                time -= Time.fixedDeltaTime;
                if (time >= 0 && time <= 3)
                {
                    textcolor += Time.deltaTime;
                    color -= Time.deltaTime;
                }
                camera.backgroundColor = new Color(color, color, color, color);
            }
            else
            {
                if (color <= 0) GlobalFunctions.changeScene("menuscreen");
            }
            if (canvas != null) 
                if (!canvas.activeInHierarchy)
                {
                    hasDoneShowingup = true;
                    canvas.SetActive(true);
                    GlobalFunctions.PlayAudio("confirm");
                    time = 5;
                }
        }
        if (text != null) text.color = new Color(textcolor, textcolor, textcolor);
        
	}
}
