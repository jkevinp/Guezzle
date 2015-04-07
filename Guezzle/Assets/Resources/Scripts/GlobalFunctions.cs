using UnityEngine;
using System.Collections;

public  class GlobalFunctions : MonoBehaviour {
	public static bool isLoading = false;
    public static void changeScene(string name)
    {
		isLoading = true;
        var loadingpanel = GameObject.FindGameObjectWithTag("LoadingPanel");
        if (loadingpanel == null)
        {
            GameObject g = new GameObject();
            g = Resources.Load("Prefab/Loading") as GameObject;
            var camera = GameObject.FindGameObjectWithTag("MainCamera");
            if (camera != null && g!= null) Instantiate(g);
        }
        Application.LoadLevel(name);
    }
   

    public  static void changeScene(int index)
    {
        Application.LoadLevel(index);
    }
    public static void PlayAudio(string name)
    {
        GameObject g = GameObject.FindGameObjectWithTag("MainCamera");
        AudioPlayer p = g.GetComponent<AudioPlayer>();
        p.PlayFx(name);
    }
    public static void SetScrollbar(GUISkin skin , float param)
    {
        skin.verticalScrollbar.fixedWidth = Screen.width * param;
        skin.verticalScrollbarThumb.fixedWidth = Screen.width * param;
    }
    public static GUIStyle getMenuButtonStyle(){
        GUIStyle customStyle = new GUIStyle();
        customStyle.normal.background = Resources.Load(CONSTANTS.get("BTN") + "btn_rounds_0") as Texture2D;
        customStyle.hover.background = Resources.Load(CONSTANTS.get("BTN") + "btn_rounds_hover") as Texture2D; ;
        customStyle.active.background = Resources.Load(CONSTANTS.get("BTN") + "btn_rounds_active") as Texture2D; ;
        customStyle.font = Resources.Load("UI/Font/SAOUITT-Bold") as Font;
        customStyle.fontSize = 20;
        customStyle.normal.textColor = Color.white;
        customStyle.hover.textColor = Color.yellow;
        customStyle.active.textColor = Color.red;
        customStyle.alignment = TextAnchor.MiddleCenter;
        return customStyle;
        
    }
    public static GUIStyle getLabelStyle()
    {
        GUIStyle customStyle = new GUIStyle();
        customStyle.normal.background = Resources.Load(CONSTANTS.get("LBL") + "Label") as Texture2D;
        customStyle.hover.background = Resources.Load(CONSTANTS.get("LBL") + "Label") as Texture2D; ;
        customStyle.active.background = Resources.Load(CONSTANTS.get("LBL") + "Label") as Texture2D; ;
        customStyle.font = Resources.Load("UI/Font/SAOUITT-Bold") as Font;
        customStyle.fontSize = 30;
        customStyle.normal.textColor = Color.white;
        customStyle.hover.textColor = Color.yellow;
        customStyle.active.textColor = Color.red;
        customStyle.alignment = TextAnchor.MiddleCenter;
        return customStyle;

    }
    public static void ToggleMenu()
    {
        
    }
}
