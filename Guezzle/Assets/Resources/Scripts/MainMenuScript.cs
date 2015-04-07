using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public void GameMode(string name){
        Debug.Log("Changing Screen " + name);
        GlobalFunctions.changeScene(name);
    }
	public void Close(){
		Application.Quit();
	}
    void OnDestoy()
    {
        Resources.UnloadUnusedAssets();
    }
    public void Start()
    {
      
        if (!PlayerPrefs.HasKey("easymodelevel"))
        {
            PlayerPrefs.SetInt("easymodelevel", 1);
            PlayerPrefs.Save();
        }
        if (!PlayerPrefs.HasKey("mediummodelevel"))
        {
            PlayerPrefs.SetInt("mediummodelevel", 1);
            PlayerPrefs.Save();
        }
        if (!PlayerPrefs.HasKey("hardmodelevel"))
        {
            PlayerPrefs.SetInt("hardmodelevel", 1);
            PlayerPrefs.Save();
        }
        for (int x = 1; x < 30; x++)
        {
            if (!PlayerPrefs.HasKey("easyscoreinlevel" + x.ToString()))
            {
                PlayerPrefs.SetInt("easyscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
            }
            if (!PlayerPrefs.HasKey("mediumscoreinlevel" + x.ToString()))
            {
                PlayerPrefs.SetInt("mediumscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
            }
            if (!PlayerPrefs.HasKey("hardscoreinlevel" + x.ToString()))
            {
                PlayerPrefs.SetInt("hardscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
            }
        }
    }
}
