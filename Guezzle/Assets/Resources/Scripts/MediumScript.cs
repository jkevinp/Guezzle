using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MediumScript : MonoBehaviour {
    List<MediumQuestions> questions = new List<MediumQuestions>();
    MediumQuestions currentQuestion = null;
    public GUISkin generalSkin = null;
    List<string> answerBank = new List<string>();
    List<string> selectCharacters = new List<string>();
    public Texture2D box;
    System.Random rng = new System.Random();
    float time = 0 , totalTime = 0;
    public GameObject canvas = null;
    //GameOver VArs
    public GameObject GameOverCanvas = null;
    bool gameOver = false;
    //End
    int bw =100, bh = 100; //btm
    public static int level = 1; // The Current Level to Load

    void Start()
    {
	
        if (canvas != null) if (canvas.activeInHierarchy) canvas.SetActive(false);
        if (GameOverCanvas != null) if (GameOverCanvas.activeInHierarchy) GameOverCanvas.SetActive(false);
        var questionList = new List<MediumQuestions>();
        if(questions.Count == 0)questions =  DataTables.LoadQuestions();
        if (level <= 10)
        {
             questionList = questions.FindAll(x => x.difficulty == "e");
             time = 60; //Time Limit
        }
        else if (level >= 11 && level <= 20)
        {
            questionList = questions.FindAll(x => x.difficulty == "m");
            time = 40;//Time Limit
        }
        else if (level >= 21 && level <= 30)
        {
            questionList = questions.FindAll(x => x.difficulty == "h");
            time = 30;//Time Limit
        }
        totalTime = time;
        int i = rng.Next(0, questionList.Count - 1);
        var tempquestion = questionList[i];
        questions.Remove(tempquestion);
        currentQuestion = tempquestion;

        answerBank.Clear();
        selectCharacters.Clear();
        foreach (char c in currentQuestion.randomword)answerBank.Add(c.ToString());
		GlobalFunctions.isLoading = false;
    }
   
    void OnGUI()
    {
		if (GlobalFunctions.isLoading)return;
        if (canvas.activeInHierarchy || GameOverCanvas.activeInHierarchy ||currentQuestion == null) return;
        
        if (generalSkin != null) if (GUI.skin != generalSkin) GUI.skin = generalSkin;
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Use the character pieces to answer the question");
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height * 0.1f), "[" + currentQuestion.id + "]" + currentQuestion.question);
        if (GUILayout.Button("Menu", GUILayout.Width(Screen.width * 0.1f), GUILayout.Height(Screen.height * 0.1f)))
        {
            GlobalFunctions.PlayAudio("press");
            canvas.SetActive(!canvas.activeInHierarchy);
        }
        //this is the image..
        GUI.DrawTexture(new Rect(Screen.width  /4 , Screen.height * 0.1f, Screen.width / 2,
           Screen.height / 2), currentQuestion.images[0]);
        if (!finished)
        {
        GUI.HorizontalScrollbar(new Rect(0, Screen.height * 0.97f, Screen.width, Screen.height * 0.03f), totalTime, time, totalTime, 0);
        GUI.Label(new Rect(0, Screen.height * 0.87f, Screen.width * 0.1f, Screen.height * 0.1f), "Time");

        
            GUILayout.BeginArea(new Rect(0, Screen.height * 0.6f + 10, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            for (int x = 0; x < currentQuestion.answer.Length; x++)
            {
                if (selectCharacters.Count > x)
                {
                    if (GUILayout.Button(selectCharacters[x].ToString(), GUILayout.Width(bw), GUILayout.Height(bh)))
                    {
                        answerBank.Add(selectCharacters[x].ToString());
                        selectCharacters.RemoveAt(x);
                        GlobalFunctions.PlayAudio("dialog_close");
                    }
                }
                else
                {
                    GUILayout.Button("?", GUILayout.Width(bw), GUILayout.Height(bh));
                }
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();

            GUILayout.BeginArea(new Rect(0, Screen.height * 0.6f + bh + 30, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            for (int x = 0; x < answerBank.Count; x++)
            {
                if (GUILayout.Button(answerBank[x].ToString(), GUILayout.Width(bw), GUILayout.Height(bh)))
                {
                    selectCharacters.Add(answerBank[x].ToString());
                    answerBank.RemoveAt(x);
                    GlobalFunctions.PlayAudio("hit");
                }
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        if (finished)
        {
            GUILayout.BeginArea(new Rect(0, Screen.height * 0.6f , Screen.width, Screen.height * 0.4f));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height * 0.2f), "Did you know? " + currentQuestion.trivia);

            
            if (GUI.Button(new Rect(0, Screen.height * 0.4f * 0.5f, bw, bh), "Menu"))
            {
                GlobalFunctions.PlayAudio("Team_Accept_1");
                Save();
                finished = false;
                GlobalFunctions.changeScene("menuscreen");
            }
            if (level <= 29)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - bw / 2, Screen.height * 0.4f * 0.5f, bw, bh), "Next"))
                {
                    GlobalFunctions.PlayAudio("Team_Accept_1");
                    NextLevel();
                    finished = false;
                }
            }
            else
            {
                if (GUI.Button(new Rect(Screen.width / 2 - (bw * 3) / 2, Screen.height * 0.4f * 0.5f, bw * 3, bh), "Game Mode Cleared"))
                {
                    GlobalFunctions.PlayAudio("Team_Accept_1");
                    NextLevel();
                    finished = false;
                }
            }
            if (GUI.Button(new Rect(Screen.width - bw, Screen.height * 0.4f * 0.5f, bw, bh), "Rounds"))
            {
                GlobalFunctions.PlayAudio("Team_Accept_1");
                Save();
                finished = false;
                GlobalFunctions.changeScene("rounds-medium");
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();  
        }
    }
    bool finished = false;
    void FixedUpdate()
    {
        if (!canvas.activeInHierarchy && !GameOverCanvas.activeInHierarchy)
        {
            if (currentQuestion != null)
            {
               if (currentQuestion.answer.Length == selectCharacters.Count)
                {
                    int ctr = 0;
                    foreach (string c in selectCharacters)
                    {
                        if (c != currentQuestion.answer[ctr].ToString()) return;
                        ctr++;
                    }
                    finished = true;
                }
                if (time >= 1 && !finished)
                {
                    time -= Time.fixedDeltaTime;
                }
                else if(time <= 1 && selectCharacters.Count != currentQuestion.answer.Length)
                {
                    GlobalFunctions.PlayAudio("fire");
                    GameOverCanvas.SetActive(true);
                }
            }
        }
    }
    void OnDestoy()
    {
        Resources.UnloadUnusedAssets();
    }
    void NextLevel()
    {   
            GlobalFunctions.PlayAudio("msg");
            Save();
            currentQuestion = null;
            Start();   
    }
    void Save()
    {
        int score = 0;
        if (time >= 50) score = 3;
        else if (time >= 40 && time < 50) score = 2;
        else score = 3;
        PlayerPrefs.SetInt("mediumscoreinlevel" + level.ToString(), score);
        PlayerPrefs.Save();
        if (level <= 29)
        { 
            level++;
            if (level > PlayerPrefs.GetInt("mediummodelevel"))
            {
                PlayerPrefs.SetInt("mediummodelevel", level);
                PlayerPrefs.Save();
                GlobalFunctions.PlayAudio("Team_Accept_1");
            }
        }
        else
        {
            GlobalFunctions.changeScene("rounds-medium");
        }
    }
}
