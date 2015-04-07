using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class settings : MonoBehaviour {
    public void UnlockAll()
    {
            PlayerPrefs.SetInt("easymodelevel", 30);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("mediummodelevel", 30);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("hardmodelevel", 30);
            PlayerPrefs.Save();
        
        for (int x = 1; x <= 30; x++)
        {
            
                PlayerPrefs.SetInt("easyscoreinlevel" + x.ToString(), 3);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("mediumscoreinlevel" + x.ToString(), 3);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("hardscoreinlevel" + x.ToString(), 3);
                PlayerPrefs.Save();
        }
    }
    public void ResetAll()
    {
            PlayerPrefs.SetInt("easymodelevel", 1);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("mediummodelevel", 1);
            PlayerPrefs.Save();
            PlayerPrefs.SetInt("hardmodelevel", 1);
            PlayerPrefs.Save();
        for (int x = 1; x <= 30; x++)
        {
                PlayerPrefs.SetInt("easyscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("mediumscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("hardscoreinlevel" + x.ToString(), 0);
                PlayerPrefs.Save();
           
        }
    }
    public void SetVolume(float val)
    {
        AudioListener.volume = val;
    }

}
