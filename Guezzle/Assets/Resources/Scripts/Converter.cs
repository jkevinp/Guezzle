using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
public class Converter : MonoBehaviour {
    List<UnityEngine.Texture2D> tlist = new List<UnityEngine.Texture2D>();
        
    void Start () {
     
        Object[] list = Resources.LoadAll("UI/Images/Convert" );
        for (int i = 0;i < list.Length; i++ )
        {
            Debug.Log(list[i].name);
            tlist.Add(Resources.Load("UI/Images/Convert/" + list[i].name) as UnityEngine.Texture2D);
          
        }
      foreach(Texture2D t in tlist)Debug.Log(t.name);
	}
    float index = 0;
    void OnGUI()
    {
        var w = Screen.width;
        var ww = Screen.height;
      
        if(GUI.Button(new Rect(0,0,Screen.width, Screen.height ), "")){
            StartCoroutine(SaveResize());
            x++;
            index++;
        }
        GUI.DrawTexture(new Rect(0, 0, w, ww), tlist[(int)index]);

       

    }
    float x = 1;
    IEnumerator SaveResize()
    {
            yield return new WaitForEndOfFrame();
            var w = Screen.width;
            var ww = Screen.height;
            var tex = new Texture2D(w, ww);
            tex.ReadPixels(new Rect(0, 0, w, ww), 0, 0);
            tex.Apply();
            byte[] newPicture = tex.EncodeToPNG();
            var file = File.Open(Application.dataPath + "/Resources/UI/Images/Output/card" + x.ToString() + ".png", FileMode.Create);
            var binary = new BinaryWriter(file);
            binary.Write(newPicture);
            file.Close();
    }
    string lastname = "";
}
