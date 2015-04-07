using UnityEngine;
using System.Collections;

public class RoundsSelectionScript : MonoBehaviour {

    public GUISkin generalSkin = null;
    public string gamemode = string.Empty;
    public string playerprefkey = string.Empty;
    public string sceneTarget = string.Empty;
    Vector2 scrollerPosition = Vector2.zero;
   public GUIStyle lblStyle = null;
    void Start () {
		GlobalFunctions.isLoading = false;
        lblStyle = GlobalFunctions.getLabelStyle();
        GlobalFunctions.SetScrollbar(generalSkin, 0.05f);
	}
    void OnGUI()
    {
		if (GlobalFunctions.isLoading)return;
        if (generalSkin != null)if (GUI.skin != generalSkin) GUI.skin = generalSkin;
        GUI.skin.button.alignment = TextAnchor.MiddleCenter;
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
        int ctr = 0;
        int row = 0;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height * 0.1f), "Select Level", lblStyle);
        scrollerPosition = GUI.BeginScrollView(new Rect(0, Screen.height * 0.1f, Screen.width, Screen.height * 0.8f),
                                scrollerPosition,
                                new Rect(0, 0, Screen.width, Screen.height) , true, true);
        for (int x = 1; x <=30; x++)
        {
            if (x <= PlayerPrefs.GetInt(playerprefkey)){
                string levelstring =  x.ToString();
                
                levelstring = levelstring  +  "\n(" + PlayerPrefs.GetInt(gamemode + "scoreinlevel" + x) + "/3)";
                
                if (GUI.Button(new Rect(Screen.width * 0.8f * 0.2f *ctr, (Screen.height * 0.2f) * row, Screen.width * 0.15f, Screen.height * 0.15f), levelstring ))
                {
                    GlobalFunctions.PlayAudio("press");
                    switch (gamemode)
                    {
                        case "easy":
                            EasyScript.level = x;
                            break;
                        case "medium":
                            MediumScript.level = x;
                        break;
                        case "hard":
                        HardScript.level = x;
                            break;
                    }
                    GlobalFunctions.changeScene(sceneTarget);
                }
            }
            else
            {
                GUI.Label(new Rect(Screen.width * 0.8f * 0.2f * ctr, (Screen.height * 0.2f) * row, Screen.width * 0.15f, Screen.height * 0.15f), x.ToString()); 
            }
            if (ctr < 5) ctr++;
            else
            {
                ctr = 0;
                row++;
            }
        }
     
        GUI.EndScrollView();
        if (GUI.Button(new Rect(0, Screen.height * 0.9f  , Screen.width, Screen.height * 0.1f), "Back To Main Menu", lblStyle))
        {
            GlobalFunctions.changeScene("menuscreen");
        }
    }
}
