using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class PuzzlePieceScript : MonoBehaviour
{
   public bool isDoneRandomizing = false;
   public bool isNullPiece = false; 
}
public class QuestionAnswer
{
    public string answer = string.Empty;
    public string trivia = string.Empty;
    public int questionID = 0;
    public string getQuestion(int questionid)
    {
        switch (questionid)
        {
            case 0:
                return "Who is the person in the picture?";
            case 1:
            return "What is the name of the place shown in the picture?";
            case 2:
            return "Where is the landmark located?";
        }
        return "What is shown in the picture?";
    }
    public List<QuestionAnswer> questionanswerBank = new List<QuestionAnswer>();
    public List<string> triviaList = new List<string>();
    public void Load()
    {

        triviaList.Add("Rizal studied Philosophy and Letters at the University of Santo Tomas and Agriculture at the Ateneo Municipal de Manila. He left for Europe on May 5, 1882. He studied Medicine and Philosophy and Letters in Madrid, and finished these courses in 1884 and 1885.");
        triviaList.Add("Emilio Aguinaldo first studied in San Juan de Letran. He joined the revolution in 1896 as a lieutenant under Gen. Baldomero Aguinaldo and rose to the rank of general in a few months. Conducted campaign against Spain until Pact of Biac-na-Bato was signed in December 1897. Among the provisions of the Pact were: [1] Aguinaldo and his men would leave the Philippines [2]the Spanish government would give them an indemnity of P800,000. Spain sent only P400,000, which was used by the General Committee of Hongkong to finance second revolution.");
        triviaList.Add("Andres Bonifacio was born to Santiago Bonifacio and Catalina de Castro, a Spanish mestiza, in a shack in Tondo, Manila on November 30, 1863. He started his early education in the school of Guillermo Osmeña of Cebu. He reached only primary school. At the age of 14, his father and mother died, forcing him to quit his studies and to look after his younger brothers and sisters. As a means of support, he had them help him make wooden canes and paper fans, which he sold in the streets.");
        triviaList.Add("Emilio Jacinto was only 20 when he joined the Katipunan. He was always thinking and prudent, but vehement and furious when he thinks he is right. This quality was admired by Bonifacio.");
        triviaList.Add("Antonio Luna was the fiery-tempered but brilliant military strategist of Gen Aguinaldo. He was the brother of the famous painter Juan Luna. Antonio Luna studied Bachelor of Arts at the Ateneo Municipal de Manila, studied pharmacy at the Univerity of Santo Tomas, but finished it in Barcelona, Spain. He obtained his Doctor of Medicine at the Central University of Madrid, and studied further in France and Belgium.");
        //5
        triviaList.Add("(Tandang Sora)One of our most famous heroine in Philippine history was born in Banilad, Caloocan on January 6, 1812. Melchora Aquino is better known as Tandang Sora, because she was already old when the revolution broke out in 1896. She had very little education, but she had all the qualities of a literate person.");
        triviaList.Add("Marcelo H. del Pilar started school in the College of Mr. Jose Flores. He transferred to the College of San Jose in Manila. He finished law in 1880. Marcelo H. del Pilar was more popularly known as Plaridel. Multi-talented Plaridel played the violin, the piano and the flute. He was good in fencing. He used to sing in serenades and played beautiful pieces on the violin during Flores de Mayo");
        triviaList.Add("Born of a poor family, Apolinario Mabini was always studious. He was always sad and silent and liked to sit alone to meditate. Mabini studied at San Juan de Letran where he got his Bachelor of Arts degree and Professor of Latin. He also finished Law. He was a spokesman of the Congress, and a notary public.");
        triviaList.Add("The famous and beautiful Banaue or Banawe Rice Terraces is considered by Filipinos as the “8th wonder of the world”. This tourist spot is one of the most admired and most visited tourist attractions in the Philippines. This amazing human achievement was built over 2,000 years ago by the Ifugaos using primitive tools only such as stones and woods. This panoramic beauty is a manifestation of engineering skills and intelligence of native Filipinos.");
        triviaList.Add("Bangui Windmills - is a wind farm in Bangui, Ilocos Norte, Philippines. The wind farm uses 20 units of 70-metre (230 ft) high Vestas V82 1.65 MW wind turbines, arranged on a single row stretching along a nine-kilometer shoreline off Bangui Bay, facing the West Philippine Sea.");
        //10
        triviaList.Add("Paoay Church - The Saint Augustine Church (Spanish: Iglesia de San Agustín de Paoay), commonly known as the Paoay Church, is the Roman Catholic church of the municipality of Paoay, Ilocos Norte in the Philippines. Completed in 1710, the church is famous for its distinct architecture highlighted by the enormous buttresses on the sides and back of the building. It is declared as a National Cultural Treasure by the Philippine government in 1973 and a UNESCO World Heritage Site under the collective group of Baroque Churches of the Philippines in 1993.");
        triviaList.Add("Baclaran Church - The National Shrine of Our Mother of Perpetual Help (Filipino: Pambansáng Dambana ng Ina ng Laging Saklolo) also known as Redemptorist Church and colloquially the Baclaran Church, is a prominent Catholic National shrine along Roxas Boulevard in Baclaran, Parañaque, a city within the southern part of Metro Manila, the capital of the Philippines.");
        triviaList.Add("Leyte Landing Memorial  - The Leyte Landing Memorial in Red Beach, Palo, marks the spot where American liberation forces of General Douglas MacArthur landed.The Battle of Leyte in the Pacific campaign of World War II was the invasion and conquest of Leyte in the Philippines by the United States and Australian forces and allied Filipino guerrillas under the command of General Douglas MacArthur and waged against the Imperial Japanese Army in the Philippines led by General Tomoyuki Yamashita from 17 October 1944 to 31 July 1945. The battle launched the Philippines campaign of 1944-45 for the recapture and liberation of the entire Philippine Archipelago and to end almost three years of Japanese occupation.");
        triviaList.Add("Intramuros - In Latin, Intramuros literally “within the walls”, meaning within the wall enclosure of the city. In 1951, Intramuros was declared a National Historical Monument. There 8 entrances in Intramuros. Most famous destination inside is the For Santiago.");
        triviaList.Add("Rizal Park - Kabalyeros de Rizal (Knights of Rizal), honor guards from the Philippine Marines stands 14-hour days watching. It was designed by a Swiss sculptor Richard Kissling and his design is the Motto Stella or “Guiding Star”. Unveiled on 1913 in the 17th Death Anniversary of Dr. Jose P. Rizal. It is almost been a protocol to lay a wreath and to show respect for visiting dignitaries. It is not merely the statue of the national hero, but also a burial site of his remains. Known as Kilometer 0. It serves as the reference point to all places in the Philippines.");

        triviaList.Add("Chocolate Hills - One of many top sights in the actual Philippines, The Chocolate  Hills are unusual geological formations that include at lowest 1, 268 specific mounds scattered during the entire interior on the island regarding Bohol. The virtually symmetrical along with same-sized formations vary from 98 to be able to 164 ft (30 to be able to 50 meters) high and they are covered within the  green lawn.During the actual dry time of year the your lawn turns brown, consequently the label. There is no consensus about how these large mole slopes were created. One concept holds which the Chocolate Hills are classified as the weathered stone formations of a form of marine limestone on top of an impermeable covering of clay surfaces.");
        triviaList.Add("Barasoain Church - Barasoain Church (also known as Our Lady of Mt. Carmel Parish) is a Roman Catholic church built in 1630 in Malolos, Bulacan. It is about 42 kilometers away from Manila. Having earned the title as the Cradle of Democracy in the East, the most important religious building in the Philippines, and the site of the First Philippine Republic, the church is proverbial for its historical importance among Filipinos.");
        triviaList.Add("Corregidor - In January 1958 a detachment of US Marines from Subic Bay set up a small radar station on Corregidor. They were TDY there for about ten weeks, bivouacking in the remains of the hospital. Actor John Wayne, while filming the movie The Barbarian and the Geisha, took a helicopter to Corregidor for a visit. While there, he had lunch with the marines.");
        triviaList.Add("Fort Santiago (Spanish: Fuerte de Santiago Tagalog: Moog ng Santiago) is a citadel first built by Spanish conquistador, Miguel López de Legazpi for the new established city of Manila in the Philippines. The defense fortress is part of the structures of the walled city of Manila referred to as Intramuros (within the walls).");
        triviaList.Add("EDSA Shrine is a small church of the Roman Catholic Archdiocese of Manila located at the intersection of Ortigas Avenue and Epifanio de los Santos Avenue (EDSA) in Barangay Ugong Norte, Quezon City.");
        //5
        triviaList.Add("Malacañang palace is the official residence and principal workplace of the President of the Philippines.");
        triviaList.Add("Magellan's Cross is a Christian cross planted by Portuguese, and Spanish explorers as ordered by Ferdinand Magellan upon arriving in Cebu in the Philippines ");
        triviaList.Add("Lapu-Lapu (fl. 1521) was a ruler of Mactan in the Visayas. The Philippines regards him as the first Filipino hero because he was the first native to resist Spanish colonization through his victory over the explorer Ferdinand Magellan.");
        triviaList.Add("Considered one of the best examples of Hispanic architecture in the Philippines, the home of the Rizal family in Calamba, Laguna, is now preserved as a historical site. The old stone facades remain, as do the Rizal family heirlooms found inside the house. Steeped in the shadows of the past, you can almost see the ghost of a young Jose Rizal wandering around the corridors or peering at visitors from behind doors.");
        triviaList.Add("VIGAN HERITAGE CITY - Vigan was part of our Ilocos to Pangasinan tour. We first explored Laoag, went up north to Pagudpod to enjoy the serene white beach there, then travelled south to Batac to visit Vigan Heritage Village, Ilocos SurMarcos Museum, Vigan, and finally, Pangasinan.Vigan Heritage Village is where Ilocos region’s rich culture and history are crafted in ornate architecture, furniture and detailed ornaments. For this reason, Vigan Heritage Village was considered a UNESCO Heritage Site to preserve the cultural past of the Ilocandia region.");
        //10
        triviaList.Add("BIAK-NA-BATO - Biyak na Bato is a national park.  It was declared so by President Manuel L. Quezon in 1937. History has it that Filipino revolutionaries like Emilio Aguinaldo used the numerous caves of Biak na Bato as refuge when they fought against the spaniards.The caves of Biak na Bato are no ordinary caves.  The caves are beautifully lined with gigantic stalactites and awesome rock formations.  Some are even teeming with wildlife.  And, there are so many caves to explore!  Aside from the dozen or so famous caves, the guides estimate that there are nearly a hundred caves in Biak na Bato.");
        triviaList.Add("FORT SAN PEDRO - Fuerte de San Pedro is a military defence structure, built by Spanish and indigenous Cebuano labourers under the command of Spanish conquistador, Miguel López de Legazpi and the Spanish Government in Cebu. It is located in the area now called Plaza Indepedencia, in the pier area of the city. The smallest, oldest triangular bastion fort in the country was built in 1738 to repel Muslim raiders. In turn, it served as a stronghold for Filipino revolutionaries near the end of the 19th century. This served as the nucleus of the first Spanish settlement in the Philippines.");
        triviaList.Add("PUGAD LAWIN - The Cry of Pugad Lawin (Filipino: Sigáw ng Pugad Lawin), alternately and originally referred to as the Cry of Balintawak (Filipino: Sigáw ng Balíntawák, Spanish: Grito de Balíntawák) was the beginning of the Philippine Revolution against the Spanish Empire.At the close of August 1896, members of the Katipunan secret society (Katipuneros) led by Andrés Bonifacio rose up in revolt somewhere in an area referred to as Kalookan, wider than the jurisdiction of present-day Caloocan City and overlapping into present-day Quezon City. Originally the term `Cry` referred to the first skirmish between the Katipuneros and the Civil Guards (Guardia Civil). Other definitions of the term have been made over the years, but today it is popularly understood to refer to the tearing of community tax certificates (cédulas personales) by the rebels to mark their separation from Spain. This was literally accompanied by patriotic shouts.");
        triviaList.Add("SANTA ISABEL FORT  - Santa Isabel Fort in Palawan This fort was built in the mid to late 17th century by the Augustinian Recollects who replaced the early Jesuit community. In those days, the church and the military travelled hand-in-hand throughout the Philippines, building small chapels and protecting them with large fortified walls and a military regiment. Both the fort's cannon and its chapel remain intact to this day. Santa Isabel Fort is located in the town of Taytay, eight hours by jeepney from Puerto Princesa.");
        triviaList.Add("AGUINALDO SHRINE  - The Aguinaldo Shrine is the national shrine located in Kawit, Cavite in the Republic of the Philippines, where the independence of the Philippines from Spain was declared on June 12, 1898.[4] To commemorate the event, now known as Araw ng Kalayaan or Independence Day, a national holiday, the Philippine flag is raised here by top government officials on June 12th each year. The house is now a museum.");







        string zeroanswers = "Jose Rizal,Emilio Aguinaldo,Andres Bonifacio,Emilio Jacinto,Antonio Luna,Melchora Aquino,Marcelo Del Pilar,Apolinario mabini";
        string[] questionzeroanswers = zeroanswers.Split(',');
        int ctr =0;
        foreach (string s in questionzeroanswers)
        {
            QuestionAnswer qa = new QuestionAnswer();
            qa.answer = s;
            qa.questionID = 0;
            qa.trivia = triviaList[ctr];
            questionanswerBank.Add(qa);
            ctr++;
        }
        string oneanswers = "Banaue Rice Terraces,Bangui Windmills,Paoay Church,Baclaran Church,Leyte Landing Memorial,Intramuros,Rizal Park,Chocolate Hills,Barasoain Church,Corregidor,Fort Santiago,Edsa Shrine,Malacanang,MAGELLAN'S CROSS,LAPU-LAPU MONUMENT,RIZAL'S HOUSE,VIGAN HERITAGE CITY,BIAK-NA-BATO,FORT SAN PEDRO,PUGAD LAWIN MONUMENT,SANTA ISABEL FORT,AGUINALDO SHRINE";
        string[] questiononeanswers = oneanswers.Split(',');
        foreach (string s in questiononeanswers)
        {
            QuestionAnswer qa = new QuestionAnswer();
            qa.answer = s;
            qa.questionID = 1;
            qa.trivia = triviaList[ctr];
            questionanswerBank.Add(qa);
            ctr++;
        }

        Debug.Log(questionanswerBank.Count + " total answer entries");

       
    }
    public List<QuestionAnswer> GetBank()
    {
        return questionanswerBank;
    }


}
public class HardScript : MonoBehaviour {
    QuestionAnswer qa = new QuestionAnswer();
    public GameObject PuzzleHelp = null;
    bool animate = false;
    public GameObject _camera = null; // The Camera used
    Vector3 a, b; //Position of gameobject a and b before switching
    bool isNotRandom = true; //Did we randomize the tile yet?
    GameObject goa, gob; //Gameobject a and b.. Used for switching 2 gameobject aka "Tiles"
    float gameTime = 0; //Total playtime 
    System.Random rng = new System.Random(); //Random number generator. used for random
    public static int level = 1; //The level to load
    Transform[] PuzzlePieces; //Collection of Tiles that will be used in the puzzle
    GameObject nullPiece = null; //The Gameobject that holds the empty tile
    public GUISkin skin = null; //The GUI Skin to use in UI
    public GameObject canvas = null; //Menu canvas

    //constant position variables.
    const float startx = -100; 
    const float starty = 75;
    const float xoffset = 25;
    const float yoffset = 25;
    const int bh = 100;
    const int bw = 100;
    //end
    bool isFinished = false;
    string input = "";
    bool showQuestion = false;
    void Start () {
		GlobalFunctions.isLoading = false;
        if (qa != null)
        {
            if (qa.GetBank().Count == 0)
            {
                qa.Load();
                qa = qa.GetBank()[level -1];
             
            }
        }
        isFinished = false;
        showQuestion = false;
        input = "";
        isNotRandom = true;
        gameTime = 0;

        if (canvas.activeInHierarchy) canvas.SetActive(!canvas.activeInHierarchy); //set the menu canvas to inactive
        isNotRandom = true; // Reset the puzzle random state to not random yet.
        GameObject Puzzle = GameObject.Find("Puzzle");//Find the Puzzle Game object
        PuzzlePieces = Puzzle.GetComponentsInChildren<Transform>(); //Transforms property of each puzzle pieces
        int ctr = 0; //A counter
        Texture2D[] images = Resources.LoadAll<Texture2D>("UI/Images/Hard/Level/" + level.ToString()); //Load all images based on level
        images.OrderBy(x=> x.name);
        Transform[] PuzzlePiecesHelp = PuzzleHelp.GetComponentsInChildren<Transform>();
        foreach (Transform go in PuzzlePiecesHelp)
        {
            if (go.name != "PuzzleHelp")
            {
                if (ctr <= images.Length - 2)
                {
                    go.GetComponentInChildren<Renderer>().material.mainTexture = images[ctr];
                }
                else
                {
                  
                }
                ctr++;
            }
        }

        ctr = 0;

        foreach (Transform go in PuzzlePieces)
        {
            if(go.name != "Puzzle") {
                go.gameObject.AddComponent<PuzzlePieceScript>();
                go.gameObject.GetComponent<PuzzlePieceScript>().isDoneRandomizing = false;
                if (ctr <= images.Length - 2)
                {
                    go.GetComponentInChildren<Renderer>().material.mainTexture = images[ctr];
                }
                else
                {
                    go.gameObject.GetComponent<PuzzlePieceScript>().isNullPiece = true;
                    nullPiece = go.gameObject;
                }
                ctr++;
            }
        }
	}
    //Handles the raycaster of mouse/touch input
    void HandleInput()
    {

        if (Input.GetMouseButtonUp(0)) //If clicked
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) //if the ray hits an puzzle piece
            {
                if (a == Vector3.zero) //if A = is not yet set
                {
                    //If the selected object is not the empty piece and the selected object is within 25 units to null piece
                    if (!hit.transform.gameObject.GetComponent<PuzzlePieceScript>().isNullPiece &&
                        Vector3.Distance(hit.transform.position, nullPiece.transform.position) == 25f)
                    {
                        a = hit.transform.position; //get thep oistion of game object
                        goa = hit.transform.gameObject; //save the selected object to goa
                        goa.GetComponent<Renderer>().material.color = Color.red; //make the selected object color red
                        nullPiece.GetComponent<Renderer>().material.color = Color.red; //Make the empty piece red
                        GlobalFunctions.PlayAudio("press"); //Play a sound
                        b = nullPiece.transform.position; //Set the b position to the empty piece
                        gob = nullPiece; //save the empty piece to b
                    }
                    return; //Return to start
                }
               
            }
        }
    }

    void Randomize()
    {
        if (isNotRandom) // if the puzzle is not yet randomized
        {
            foreach (Transform t in PuzzlePieces) //foreach puzzle piece in the puzzle
            {
                if (t.name != "Puzzle") // if the puzzle piece is not the main puzzle
                {

                    if (!t.GetComponentInChildren<PuzzlePieceScript>().isDoneRandomizing) // if the puzzlepiece is not yet randomize
                    {
                        int rand = rng.Next(0, PuzzlePieces.Length - 1); //select a random piece from the puzzle
                        while (t == PuzzlePieces[rand] || PuzzlePieces[rand].name == "Puzzle") //while the slected random piece is already randomized, select another 
                            rand = rng.Next(0, PuzzlePieces.Length - 1);

                        a = t.transform.position; //save the puzzle piece position to a
                        goa = t.gameObject; //save the puzzle piece to goa
                        b = PuzzlePieces[rand].position; // save the random piece position to b
                        gob = PuzzlePieces[rand].transform.gameObject; //save the random puzzlepiece to gob
                        t.position = b; //switch position of the current piece to random piece
                        gob.transform.position = a; //swtich the random piece positon to current piece
                        a = Vector3.zero; //reset position to x=0. y=0.z=0
                        b = Vector3.zero;//reset position to x=0. y=0.z=0
                        gob = null; //empty the gob
                        goa = null; //empty the goa
                        t.GetComponentInChildren<PuzzlePieceScript>().isDoneRandomizing = true; //set the status of current piece to already randomize
                        PuzzlePieces[rand].GetComponentInChildren<PuzzlePieceScript>().isDoneRandomizing = true; //set the status of random piece to already randomize
                    }
                }
            }
            isNotRandom = false; //when all piece is randomize, set the puzzle to randomized.
            GlobalFunctions.PlayAudio("koto4"); //play  a sound
            gameStarted = true;
        }
    }
    //function to reset the puzzle to its original position
    void Fix()
    {
        int row = 0;
        int col = 0;
        if (showQuestion) return;
        foreach (Transform _transform in PuzzlePieces)
        {
            if (_transform.name != "Puzzle")
            {
                Vector3 correctPosition = new Vector3(startx + (xoffset * col), starty - (yoffset * row), 0);
                _transform.localPosition =correctPosition;
                
                if (col <= 4) col++;
                else
                {
                    col = 0;
                    row++;
                }
            }
        }
        GlobalFunctions.PlayAudio("Team_Accept_3");
    }
    //Function that displays GUI
    void OnGUI()
    {
		if (GlobalFunctions.isLoading)return;
        if (canvas.activeInHierarchy) return; //if the menu canvas is active, dont continue.
        if (skin != null) if (GUI.skin != skin) GUI.skin = skin; // if the skin exists, set the gui skin to skin provided.

        if (!showQuestion && !isFinished)
        {
            if (_camera != null) //Change Camera based on slider value if the camera is not empty
                _camera.transform.position = new Vector3(_camera.transform.position.x,
                    _camera.transform.position.y,
                     GUI.VerticalSlider(new Rect(50, 0, 150, Screen.height * 0.8f), _camera.transform.position.z,
                    -50, -300));
            //code for enabling animation of puzzle piece during switching
            animate = GUI.Toggle(new Rect(Screen.width * 0.9f, 0, Screen.width * 0.1f, 50), animate, "Do animation");
            //code for sort button
            if (GUI.Button(new Rect(Screen.width * 0.9f, Screen.height * 0.1f, Screen.width * 0.1f, Screen.height * 0.1f), "Sort(dev)"))
            {
                Fix(); //On click, fire fix function
            }
            if (GUI.Button(new Rect(Screen.width * 0.5f - Screen.width * 0.05f, Screen.height * 0, Screen.width * 0.1f, Screen.height * 0.1f), "Menu"))
            {
                //when menu button is clicked, set the menu canvas to true and play a sound
                canvas.SetActive(!canvas.activeInHierarchy);
                GlobalFunctions.PlayAudio("press");
            }
        }
        if (showQuestion && !isFinished)
        {
            GUI.Label(new Rect(Screen.width * 0.2f, Screen.height * 0.3f, Screen.width * 0.6f, Screen.height * 0.2f), qa.getQuestion(qa.questionID));
            input = GUI.TextField(new Rect(Screen.width * 0.2f, Screen.height * 0.6f, Screen.width * 0.6f, Screen.height * 0.1f), input);
            string temp = input.ToLower();
            string answer = qa.answer.ToLower();
            if (temp.Equals(answer))
            {
                GlobalFunctions.PlayAudio("Team_Accept_1");
                Save();
                isFinished = true;
                gameStarted = false;
            }
        }
        if (isFinished)
        {
            GUI.Label(new Rect(Screen.width * 0f, Screen.height * 0f, Screen.width, Screen.height * 0.7f), qa.trivia);
            if (GUI.Button(new Rect(0, Screen.height * 0.7f, bw, bh), "Menu"))
            {
                GlobalFunctions.PlayAudio("confirm");
                GlobalFunctions.changeScene("menuscreen");
            }
          //0629bayanDSLWiFi
            if (level  <= 29)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - bw / 2, Screen.height * 0.7f , bw, bh), "Next"))
                {
                    NextLevel();
                }
            }
            else if (level == 30)
            {
                if (GUI.Button(new Rect(Screen.width / 2 - (bw * 3) / 2, Screen.height * 0.7f , bw * 3, bh), "Game Mode Cleared"))
                {
                    GlobalFunctions.PlayAudio("confirm");
                    GlobalFunctions.changeScene("rounds-hard");
                }
            }
            if (GUI.Button(new Rect(Screen.width - bw, Screen.height * 0.7f , bw, bh), "Rounds"))
            {
                GlobalFunctions.PlayAudio("confirm");
                GlobalFunctions.changeScene("rounds-hard");
            }
        }
    }
    void NextLevel()
    {
        GlobalFunctions.PlayAudio("msg");
        if (level <= 29)
        {
            level++;
        }
        Start();
    }
    bool gameStarted = false;
    void Save()
    {
        int score = 3;
        PlayerPrefs.SetInt("hardscoreinlevel" + level.ToString(), score);
        PlayerPrefs.Save();
        if (level +1 > PlayerPrefs.GetInt("hardmodelevel"))
        {
                PlayerPrefs.SetInt("hardmodelevel", level +1 );
                PlayerPrefs.Save();
                GlobalFunctions.PlayAudio("Team_Accept_1");
        }
        
    }
    void Update () {
        if (canvas.activeInHierarchy) return;
        gameTime += Time.fixedDeltaTime;
        if (gameTime >= 4 && gameTime < 5 && isNotRandom)
        {
            Randomize();
        }
        else if(!isNotRandom && gameTime >=5)
        {
            HandleInput();
            moveObjects();
            detectFinish();
        }
	}
    //code to check if the puzzle is correctly sorted
    void detectFinish()
    {
        int row = 0;
        int col = 0;
        if (showQuestion) return;
        foreach (Transform _transform in PuzzlePieces)
        {
            if (_transform.name != "Puzzle")
            {
                Vector3 correctPosition = new Vector3(startx + (xoffset * col), starty - (yoffset * row), 0);
                if (_transform.localPosition != correctPosition) return;
                if (col <= 4) col++;
                else
                {
                    col = 0;
                    row++;
                }
            }
        }
        showQuestion = true;

    }
    //function to switch the selected piece and the empty piece
    void moveObjects()
    {
        if (a != Vector3.zero && b != Vector3.zero && !isNotRandom)
        {
            if (animate && (Vector3.Distance(goa.transform.position, b) > 2 || Vector3.Distance(gob.transform.position, a) > 2))
            {
                goa.transform.position = Vector3.Lerp(goa.transform.position, b, 0.05f);
                gob.transform.position = Vector3.Lerp(gob.transform.position, a, 0.05f);
                return;
            }
            else if ( !animate || Vector3.Distance(goa.transform.position, b) < 3 || Vector3.Distance(gob.transform.position, a) < 3)
            {
                if (goa.transform.position != b) goa.transform.position = b;
                if (gob.transform.position != a) gob.transform.position = a;
                a = Vector3.zero;
                b = Vector3.zero;
                GlobalFunctions.PlayAudio("lock2");
                goa.GetComponent<Renderer>().material.color = Color.white;
                nullPiece.GetComponent<Renderer>().material.color = Color.white;
                goa = null;
                gob = null;
            }
        }
    }
    void OnDestoy()
    {
        Resources.UnloadUnusedAssets();
    }
}
/* else if (a != Vector3.zero && b == Vector3.zero)
                {
                    if (a != hit.transform.position && Vector3.Distance(a, hit.transform.position) <= 25)
                    {
                        if (!goa.GetComponent<PuzzlePieceScript>().isNullPiece && hit.transform.gameObject.GetComponent<PuzzlePieceScript>().isNullPiece)
                        {
                            b = hit.transform.position;
                            gob = hit.transform.gameObject;
                            GlobalFunctions.PlayAudio("hit");
                            gob.GetComponent<Renderer>().material.color = Color.red;
                            Debug.Log("Distance: " + Vector3.Distance(a, b));
                            return;
                        }
                        else if (goa.GetComponent<PuzzlePieceScript>().isNullPiece)
                        {
                            b = hit.transform.position;
                            gob = hit.transform.gameObject;
                            GlobalFunctions.PlayAudio("hit");
                            gob.GetComponent<Renderer>().material.color = Color.red;
                            Debug.Log("Distance: " + Vector3.Distance(a, b));
                        }
                    }
                }*/