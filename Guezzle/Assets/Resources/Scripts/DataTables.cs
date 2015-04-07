using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

//Serves as Database of the game.
public static class  DataTables {
    public static List<MediumQuestions> LoadQuestions()
    {
        List<MediumQuestions> questions = new List<MediumQuestions>();
        MediumQuestions q = new MediumQuestions();
        q.id = 1;
        q.question = "Who is the person in the picture?";
        q.answer = "Jose Rizal";
        q.trivia = "Jose Rizal is the National Hero of the Philippines.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 2;
        q.question = "What is the Name of the Flower?";
        q.answer = "Sampaguita";
        q.trivia = "Sampaguita is the national flower of the Philippines. It is know for its fragnance.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 3;
        q.question = "What is National Tree of the Philippines?";
        q.answer = "narra";
        q.trivia = "Sampaguita is the national Tree of the Philippines, as well as the provincial tree of Chonburi and Phuket in Thailand..";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 4;
        q.question = "Where can you find Baclayon Church?";
        q.answer = "bohol";
        q.trivia = " The Baclayon Church in Bohol was built using coral stones and egg white! It is considered one of the oldest church in the Philippines.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 5;
        q.question = "The Lone Star State of the United States.";
        q.answer = "texas";
        q.trivia = "Texas, U.S.A. was once referred to as “Nuevas Filipinas” or “New Philippines";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 6;
        q.question = "The name of unique vehicle of the Philippines?";
        q.answer = "jeepney";
        q.trivia = "The exotic jeepney is a post-war creation inspired by the GI jeeps that the American soldiers brought to the country in the 1940s. ";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        //Puerto Princesa 
        q = new MediumQuestions();
        q.id = 7;
        q.question = "The national park is located in _______ Princesa, Philippines.";
        q.answer = "Puerto";
        q.trivia = "The world’s longest underground river system accessible to man can be found at the St. Paul National Park.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 8;
        q.question = "The National Animal of the Philippines?";
        q.answer = "carabao";
        q.trivia = "The carabao or kalabaw in Filipino is a tamed type of water buffalo. Its life span is 18 to 20 years and the female carabao can deliver one calf each year.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 9;
        q.question = "The National fish of the Philippines?";
        q.answer = "milkfish";
        q.trivia = " It is a naturally strong fish since it is capable in adapting and thrives even in the limited, unusual environment of the fishpond.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 10;
        q.question = "The dance shown in the picture is called?";
        q.answer = "tinikling";
        q.trivia = "The tinikling name came from birds locally known as Tikling.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 11;
        q.question = "The fruit shown in the picture is called?";
        q.answer = "mango";
        q.trivia = " Philippine mango is an ideal dessert served in many ways and has been known as the “Fruit of the Gods”.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 12;
        q.question = "A city in the Philippines located at Central Visayas.";
        q.answer = "cebu";
        q.trivia = "Cebu is the oldest Philippine city.";
        q.SetEasy();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 13;
        q.question = "The Ruins can be found in _______  Occidental.";
        q.answer = "Negros";
        q.trivia = "Negros Occidental has the most cities among Philippine provinces.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 14;
        q.question = "The popular toy is called?";
        q.answer = "yoyo";
        q.trivia = "The popular toy, the yoyo, was invented by 16th century hunters in the Philippines.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 15;
        q.question = "What is shown in the picture?";
        q.answer = "bakya";
        q.trivia = "The bakya industry prospered during the 1930s when the Filipinos began exporting these to the other countries.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 16;
        q.question = "What is shown in the picture?";
        q.answer = "sorbetes";
        q.trivia = "This sweet treat was concocted in the early 1920's, a time where a single centavo could buy you almost anything.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 17;
        q.question = "What is shown in the picture?";
        q.answer = "kalesa";
        q.trivia = "The Ilustrados, the rich Filipinos who had their own businesses, used the kalesa not only for traveling but as a means a means of transporting their goods as well.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 18;
        q.question = "The ball is used in what game?";
        q.answer = "Basketball";
        q.trivia = "The Philippine Basketball Association is Asia's premier and the world's second oldest professional league.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 19;
        q.question = "One of the Four Metropolitan cities of the Philippines";
        q.answer = "Caloocan";
        q.trivia = "Caloocan (often spelled as Kalookan) is the third most populous city in the Philippines.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 20;
        q.question = "One of the Four Metropolitan cities of the Philippines";
        q.answer = "Manila";
        q.trivia = "Rizal Park is located in Manila City. The flagpole located in Rizal Park, is where the starts of 0 kilometer reading in measuring all distances from Manila. ";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 21;
        q.question = "One of the Four Metropolitan cities of the Philippines";
        q.answer = "Quezon";
        q.trivia = "Quezon City is the second biggest city in the Philippines.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 22;
        q.question = "One of the Four Metropolitan cities of the Philippines";
        q.answer = "Pasay";
        q.trivia = "The name of the city of Pasay, they say, came from the wail of a brokenhearted swain.";
        q.SetMedium();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 23;
        q.question = "The Flying Lemur is called ___ in Mindanao.";
        q.answer = "kagwang";
        q.trivia = "Kagwang doesn't have wings but it can glide across 100 meters of space in a single leap.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 24;
        q.question = "World's Smallest Hoofed Mammal";
        q.answer = "pilandok";
        q.trivia = " Locally known as Pilandok (Tragalus nigricans), this ruminant stands only about 40 centimeters at the shoulder level. ";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 25;
        q.question = "An animal that can be found in Palawan.";
        q.answer = "bearcat";
        q.trivia = "Palawan bearcat is neither a bear nor a cat. It weighs 9 to 14 kilograms and lives up to 20 years.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 26;
        q.question = "The Deer can be found in North Palawan Province.";
        q.answer = "Calamian";
        q.trivia = "Calamian Islands, north of Palawan province, keep a species of deer that cannot be found elsewhere.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 27;
        q.question = "This place is believed to be the Kampo de Kastila";
        q.answer = "Compostela";
        q.trivia = "Compostela Valley is known to be laden with gold, thus earning the monicker “Golden Valley of Mindanao”";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 28;
        q.question = "A  Strait Located in Brgy. Cabalawan, Tacloban City, between the islands of Leyte and Samar";
        q.answer = "San Juanico";
        q.trivia = "San Juanico Strait - said to be the narrowest yet the most navigable strait in the world";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 29;
        q.question = "What is the most famous among the Philippine volcanoes because of its almost perfect cone-shape?";
        q.answer = "Mayon";
        q.trivia = "It is the most active among the Philippine volcanoes having erupted over 40 times in 4 centuries according to recorded history which dates back as far as 1616 as its first recorded eruption.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 30;
        q.question = "Which Philippine volcano is considered to have recorded the second largest volcanic eruption in the world in the 20th century?";
        q.answer = "Mt.Pinatubo";
        q.trivia = " Mount Pinatubo is located in the province of Zambales. When this volcano exploded in June 1991 some towns in Zambales and Tarlac were buried in lahar (volcanic ash) and it greatly affected agricultural farmlands in the Philippines. The largest of the 20th century occurred in June 1912 when Novarupta erupted in Alaska.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);


        q = new MediumQuestions();
        q.id = 31;
        q.question = "Considered the world's smallest active volcano, what is the name of this volcano which can be found in the Philippines?";
        q.answer = "Mt.taal";
        q.trivia = "Mt. Taal. Pandak, unano and bansot are not volcanoes rather these terms refers only to one meaning which is dwarf. Mt. Taal is a very beautiful volcano located in Taal Lake in the province of Batangas.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

        q = new MediumQuestions();
        q.id = 32;
        q.question = "Another active volcano, it was named after a Visayan supreme god whose name means One who is the ruler of time?";
        q.answer = "Mt.Kanlaon";
        q.trivia = "Mt. Kanlaon is located in the island of Negros and it is also famous for hikers who at the same time are nature lovers because of its natural beauty and richness in fauna and flora. Sadly, in August 1996 a mountaineering group was injured (3 killed) when Mt Kanlaon suddenly erupted without any warning spewing forth ash and stones.";
        q.SetHard();
        q.randomize();
        q.AddTexture(q.answer);
        questions.Add(q);

            
        return questions;
    }
}
public class MediumQuestions
{
    public int id = 0;
    public string question = string.Empty;
    public string answer = string.Empty;
    public string trivia = string.Empty;
    public string randomword = string.Empty;
    public string imagename = string.Empty;
    public List<Texture2D> images = new List<Texture2D>();
    public string difficulty = "e";

    public void AddTexture(string imagename)
    {
        this.images.Add(Resources.Load(CONSTANTS.get("QUESTION_IMG") + imagename) as Texture2D);
    }
    public void randomize()
    {
        System.Random num = new System.Random();
        // Create new string from the reordered char array
        this.randomword = new string(this.answer.ToCharArray().
            OrderBy(s => (num.Next(2) % 2) == 0).ToArray());

        this.randomword = this.randomword.ToUpper();
        this.answer = this.answer.ToUpper();
    }
    public void SetHard(){
        this.difficulty = "h";
    }
    public void SetEasy()
    {
        this.difficulty = "e";
    }
    public void SetMedium()
    {
        this.difficulty = "m";
    }
}