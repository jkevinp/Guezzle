using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetScore : MonoBehaviour {

    public string gamemode = "";
    public Text text = null;
	void Start () {
        
        
	}
    void Update()
    {
        if (text != null && gamemode != "")
        {
            int score = 0;
            for (int x = 1; x <= 30; x++)
            {
                score += PlayerPrefs.GetInt(gamemode + "scoreinlevel" + x.ToString());
            }
            text.text = gamemode+ " (" + score + "/90)";
        }
    }
}
