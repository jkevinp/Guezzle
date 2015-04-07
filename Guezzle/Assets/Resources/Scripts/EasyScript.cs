using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EasyCard
{
    public string name = string.Empty;
    public string id = string.Empty;
    public Texture2D image = null;
    public Texture2D backface = null;
    public string backfaceString = string.Empty;
    public bool isShown = false;
    public bool active = true;
    public GUIContent content = null , backcontent = null;
    public void moveContent(){
        this.content = new GUIContent(this.name, this.image, this.id);
        this.content.image.wrapMode = TextureWrapMode.Clamp;
    }
    public void moveBackContent()
    {
        this.backcontent = new GUIContent(this.name, this.backface, this.id);
    }
    public void setTexture()
    {
    }
}
public class EasyLevelRules
{
    public int levelnumber = 0;
    public int maxTries = 50;
    public float totalTime = 0;
    public int maxCards = 5;
    public EasyLevelRules(int l, int m, float t, int c)
    {
        this.levelnumber = l;

        this.maxTries = m;
        this.totalTime = t;

        this.maxCards = c;
    }
    void OnDestoy()
    {
        Resources.UnloadUnusedAssets();
    }
    static System.Random RNG = new System.Random();


    // Rules . 
    public static EasyLevelRules LoadLevels(int x)
    {
        if (x <= 5) //rounds 1~5
        {
            return new EasyLevelRules(x, 100, 100, RNG.Next(4, 6));
        }
        else if (x >= 6 && x <= 10)//rounds 5 to 10
        {
            return new EasyLevelRules(x, 40, 100, RNG.Next(6, 8));
        }
        else if (x >= 11 && x <= 15)//rounds 11 to 15
        {
            return new EasyLevelRules(x, 40, 100, RNG.Next(5, 10));
        }
        else if (x >= 16 && x <= 25) //rounds 16 to 25
        {
            return new EasyLevelRules(x, 30, 100, RNG.Next(10, 15));
        }
        else //roudns to 30
        {
            return new EasyLevelRules(x, 40, 100, RNG.Next(15, 20));
        }
    }
}

public class EasyScript : MonoBehaviour {
    
    public GUISkin generalSkin = null;
    List<EasyCard> cardList = new List<EasyCard>();
    List<EasyCard> selectedCardList = new List<EasyCard>();
    System.Random RNG = new System.Random();
    public bool canSelect = true;
    public static int level = 1;
    private int clicks = 0;
    public int maxClicks = 2;
    EasyLevelRules rules = null;
    GUIStyle customStyle = new GUIStyle();
    public GameObject canvas = null;
    //GameOver VArs
    public GameObject GameOverCanvas = null;
    bool gameOver = false;
    //End
    Vector2 scrollPosition = Vector2.zero;
    bool isHorizontalOpen = false;
    
    void Start () {
		GlobalFunctions.isLoading = false;
        if (canvas != null) if (canvas.activeInHierarchy) canvas.SetActive(false);
        if (GameOverCanvas != null) if (GameOverCanvas.activeInHierarchy) GameOverCanvas.SetActive(false);
        customStyle = GlobalFunctions.getMenuButtonStyle();
        rules =  EasyLevelRules.LoadLevels(level);
        cardList.Clear();
        canSelect = true;
        clicks = 0;
        for (int x = rules.maxCards; x > 0; x--)
        {
            string cardToUse = "card" + RNG.Next(1, CONSTANTS.TOTAL_CARD_NUMBERS).ToString();
            //To Avoid Repeated Images
            while (cardList.FindAll(find => find.name == cardToUse).Count != 0) cardToUse = "card" + RNG.Next(1, CONSTANTS.TOTAL_CARD_NUMBERS).ToString();
            
            EasyCard firstCard = new EasyCard();
            firstCard.id = x.ToString();
            firstCard.name = cardToUse;
            firstCard.backface = Resources.Load(CONSTANTS.get("CARD_IMG") + "cardback") as Texture2D;
            firstCard.image = Resources.Load(CONSTANTS.get("CARD_IMG") + cardToUse) as Texture2D;
            firstCard.moveBackContent();
            firstCard.moveContent();
            firstCard.setTexture();
            addCardRandomly(firstCard);
            
            EasyCard secondCard = new EasyCard();
            secondCard.id = x.ToString();
            secondCard.name = cardToUse;
            secondCard.backface = Resources.Load(CONSTANTS.get("CARD_IMG") + "cardback") as Texture2D;
            secondCard.image = Resources.Load(CONSTANTS.get("CARD_IMG") + cardToUse) as Texture2D;
            secondCard.moveBackContent();
            secondCard.moveContent();
            addCardRandomly(secondCard);
        }
	}
    //Adds The Card Given to the Deck of cards randomly
    public void addCardRandomly(EasyCard card)
    {
        if (cardList.Count > 0)
        {
            int max = cardList.Count; //Set the max number for the randomization
            int min = 0; //The min number for the randomization
            int index = RNG.Next(min, max); //Randomize a number that will be the index of the card in the deck
            cardList.Insert(index, card);//Insert the card in the deck with index given
        }else{
            cardList.Add(card);
        }
    }
    void OnGUI()
    {
		if (GlobalFunctions.isLoading)return;
        if (rules != null && !canvas.activeInHierarchy && !GameOverCanvas.activeInHierarchy)
        {
            if (generalSkin != null) if (GUI.skin != generalSkin) GUI.skin = generalSkin;
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal(GUILayout.Height(Screen.height* 0.1f));
                GUILayout.Label("Flips Left:" + rules.maxTries, GUILayout.Width(Screen.width * 0.3f), GUILayout.Height(Screen.height * 0.1f));
                GUILayout.Label("Level:" + rules.levelnumber, GUILayout.Width(Screen.width * 0.3f), GUILayout.Height(Screen.height * 0.1f));
                GUILayout.Label("Time:" + rules.totalTime.ToString("0.00"), GUILayout.Width(Screen.width * 0.3f), GUILayout.Height(Screen.height * 0.1f));
               
                
                if (GUILayout.Button("Menu", customStyle, GUILayout.Width(Screen.width * 0.1f), GUILayout.Height(Screen.height * 0.1f)))
                {
                    GlobalFunctions.PlayAudio("press");
                    canvas.SetActive(!canvas.activeInHierarchy);
                }

            GUILayout.EndHorizontal();
            GlobalFunctions.SetScrollbar(GUI.skin, 0.04f);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Height(Screen.height * 0.9f), GUILayout.Width(Screen.width));
            int ctr = 0;
            foreach (EasyCard card in cardList){
                if (ctr == 0){
                    GUILayout.BeginHorizontal();
                    isHorizontalOpen = true;
                }
                GUIContent content = card.content;
                if (!card.isShown && card.active){
                    name = card.backfaceString;
                    content = card.backcontent;
                }
                //cards
                if (GUILayout.Button(content, GUILayout.Width((Screen.width) * 0.19f), GUILayout.Height((Screen.height * 0.8f) * 0.4f + 30)) && card.active && !card.isShown && canSelect && clicks < maxClicks)
                {
                    selectedCardList.Add(card);
                    card.isShown = true;
                    clicks++;
                    rules.maxTries--;
                    GlobalFunctions.PlayAudio("lock2");
                    if (clicks == maxClicks)
                    {
                        canSelect = false;
                        StartCoroutine(WaitAndPrint(0.4f));
                    }
                }

                if (ctr == 4)
                {
                    if (isHorizontalOpen)
                    {
                        GUILayout.EndHorizontal();
                        isHorizontalOpen = !isHorizontalOpen;
                        ctr = 0;
                    }

                }
                else
                {
                    ctr++;
                }
            }
            if (isHorizontalOpen)
            {
                GUILayout.EndHorizontal();
                isHorizontalOpen = !isHorizontalOpen;
            }
            GUILayout.EndScrollView();
            GUILayout.EndArea();
        }
        else
        {
            Debug.Log("Error Occured! Rules is null");
        }
	}
    //checks if the selected cards are the samee/match
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime); //wait for waittime seconds
        foreach (EasyCard card in cardList){
            if (selectedCardList.FindAll(x => x.name == card.name).Count == maxClicks){
                card.isShown = true;
                card.active = false;
                GlobalFunctions.PlayAudio("Team_Accept_3");
            }
            else{
                if (card.active) card.isShown = false;
            }
        }
        selectedCardList.Clear();

        //Checks if the level is done.
        int cleared = cardList.FindAll(x => x.active == false).Count;
        if (rules.maxTries > 0){
            canSelect = true;
            clicks = 0;
        }
        else if (rules.maxTries == 0 && (cleared / maxClicks) == rules.maxCards)
        {
            NextLevel();
        }
        else
        {
            GameOver();
        }
    }
    void GameOver()
    {
        GameOverCanvas.SetActive(!GameOverCanvas.activeInHierarchy);
        GlobalFunctions.PlayAudio("fire");
    }
    void NextLevel()
    {
        int score = 0;
        if (rules.maxTries > 30)
        {
            score += 1;
        }
        if (rules.totalTime >= 30)
        {
            score += 1;
        }
        if ((rules.totalTime >= 30) && rules.maxTries > 30)
        {
            score += 1;
        }
        PlayerPrefs.SetInt("easyscoreinlevel" + level.ToString(), score);
        PlayerPrefs.Save();
        if (level <= 29)
        {
            level++;
            //unlock next level
            if (level > PlayerPrefs.GetInt("easymodelevel"))
            {
                PlayerPrefs.SetInt("easymodelevel", level);
                PlayerPrefs.Save();
            }
            GlobalFunctions.PlayAudio("Team_Accept_1");
            Start();
        }
        else
        {
            GlobalFunctions.changeScene("rounds-easy");
        }
    }
    void FixedUpdate()
    {
        if (!canvas.activeInHierarchy && !GameOverCanvas.activeInHierarchy && rules != null)
        {
            if (rules.totalTime > 0)rules.totalTime -= Time.deltaTime;
            else GameOver();
            
            int cleared = cardList.FindAll(x => x.active == false).Count;
            if ((cleared / maxClicks) == rules.maxCards)
            {
                NextLevel();
            }
        }
    }
}
