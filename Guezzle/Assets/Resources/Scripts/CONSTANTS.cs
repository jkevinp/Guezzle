using UnityEngine;
using System.Collections;

using System.Collections.Generic;
public static class CONSTANTS  {
    private static Dictionary<string, string> strings = new Dictionary<string, string>();
    public static int TOTAL_CARD_NUMBERS = 40;
    public static int MAX_ROUNDS = 30;
    public static void init(){
        strings.Add("SFX", "Audio/SFX/");
        strings.Add("BGM", "Audio/BGM/");
        strings.Add("CARD_IMG", "UI/Images/Easy/");
        strings.Add("QUESTION_IMG", "UI/Images/Medium/");
        strings.Add("BTN", "UI/Buttons/");
        strings.Add("LBL", "UI/Label/");
    }
    public static void add()
    {

    }
    public static string get(string key)
    {
        if (strings.Count == 0) CONSTANTS.init();
        if (strings.ContainsKey(key))
        {
            return strings[key];
        }
        return string.Empty;
    }
}
