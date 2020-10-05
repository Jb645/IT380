using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.Reflection;
using System.Collections.Concurrent;

public class CanvasUIFunctions : MonoBehaviour
{   [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public TMP_Text introText;
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public Color backgroundColor;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;//where in sequence
    Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void InitializeIntro() //for repeated code
    {
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "\n\n\n\n\n\n Welcome to Animated Anatomy for Artist! \n\n" +
            "Learn how muscles work interactably as you see them contract and stretch, and remember to take the quizzes for further understanding!";
        introImage.SetActive(true);
        backButton.SetActive(false);
    }

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                InitializeIntro();
                break;
            case "02TutorialScene":
                break;
            case "03Level01Scene":
                break;
        }
    }
    public void IntroSequenceNext() //increases intro sequence
    {
        introSequence++;
        SetIntroSequence();
        
    }
    public void IntroSequenceBack() //decreases intro sequence
    {
        introSequence--;
        SetIntroSequence();
    }

    void SetIntroSequence() //sets the intro sequence
    {
        switch (introSequence)
        {
            case 0:
                InitializeIntro();
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "Overview:\n\n" +
                                    "Title: Animated Anatomy for Artists\n" +
                                    "Platform: WebGL\n" +
                                    "Subject: Biology\n" +
                                    "Sub Subject: Anatomy\n" +
                                    "Main Focus:  human muscular system\n" +
                                    "Learning Level: high school - university\n";
                break;
            case 2:
 
                introText.text = "Proposed EdTech Solution:\n\n" +
                    "A software that is able to animate the motion of the human body on the muscle level will allow users to breach that gap between the flat muscle that you see in textbooks and how it appears on real life. With the help of specialized animators, students will be allowed to see the human body in different positions and how their muscles move at speeds of their convenience, while also being to highlight muscle groups and their names for easier study. With a nice bonus of interactive quizzes to remember the forms of certain muscles will allow artists breach through that annoying art block.";
                break;
            case 3:

                
                introText.text = "Competing Software Review:\n\n" +
                    "•	3d Anatomy for the Artists : A free access app for android  where  you can interact with the skeletal system and drawing galleries, very useful for artists that want to learn more about the skeletal(free) and muscular system(purchasable) also allows for rotation and zooms with a very interactive model.However it doesn’t have any posing abilities or animations to check through. \n" +
                    "•	Mara3d for Human Anatomy: It’s a phone application downloadable through Amazon that shows several Anatomy figures from the skin to the muscles so that artists are able to look around the 3d model and see its parts, however it also does not have posable features or any animation you are only able to look around it.\n" +
                    "•	anatomylearning: Includes both an app and a WebGL browser version that you are able to go into different parts of the body both from skin to muscles to organs to bones. Each different muscle or bone is highlighted and you must navigate to the part you need like if you need to know the cranium click on the picture of the bones and select the one talking about the cranium. Apart from that on the model each part is labeled and includes quizzes so you can test your knowledge. This one is more scientific but its pretty helpful due to the quizzes and how simple is to maneuver.";
                break;
            case 4:

                introText.text = "Competing Software Suggested Improvements:\n\n" +
                    "•	Interactivity: Movement and flesh interaction with animations will allow an easier understating for users as they learn at their own speed And more explanations on body areas. In addition to the highlight that this helps further. Add a VR version where you are able to interact more thoroughly which is not on any of the other software. \n" +
                    "•	Simplify UI: Decrease the number of things on the UI that detract from the model such barrages of links.\n" +
                    "•	Gamify it: add small quizzes for remembering the places of muscles in addition to their shape, will allow a much easier learning experience for students.\n" +
                    "•	Further learning: Ultimately anatomy is needed to learn how clothes work around someone’s body so adding sketches of how clothing works around certain parts of the body may also be useful for students.";
                break;
            case 5:

                introText.text = "Stakeholders & Users:\n\n" +
                    "Art Teachers\n" +
                    "Art Students: high school and university students";
                break;
            case 6:
                introText.text = "Persona:\n\n" +
                    "Name: Thomas\n" +
                    "Age: 17 years old\n" +
                    "Location: New Mexico USA\n" +
                    "Personal Notes:\n" +
                    "•	Does not like to live his house and is introverted \n" +
                    "•	Likes to stay at home and play videogames\n" +
                    "Student Notes:\n" +
                    "•	Doesn’t learn well from books and needs a visual stimulus to learn\n" +
                    "•	Is an art student\n" +
                    "•	Wants to draw people buts does not know where to start\n" +
                    "•	Prefers doing thigs by himself\n" +
                    "•	Likes to tinker with things";
                break;
            case 7:
                introText.text = "Persona Justification:\n\n" +
                    "After researching the Area with the most art students was New Mexico USA, in addition to studies and many Art students stating that they all have a tendency of being introverted I chose those as a location an part of the personal notes, furthermore . Furthermore, for someone to want to learn art one of the basic components its both passion and understanding of human anatomy, although you may need some part art knowledge before knowing how to draw people the essentials like how to shade; as such my group of people I want to talk about are those that want to learn art specifically how to draw humans but don’t know anything about anatomy. Furthermore, as artist must learn from reference and practice through visualization these are also points that have to be address on the students notes (prefers learning through visual media and likes to tinker with things)";
                break;
            case 8:

                introText.text = "Problem Scenario:\n\n" +
                    "Thomas has always been curious despite not liking talking much to people he appreciates portraits of people that he has seen in social media and wants to try learning art. However, he is unable to make sense of the books he has bought for anatomy as they are both too complicated to read and too flat to imagine how the muscles affect the skin of a person. After all he wants to know how to draw a human not a singular pose that the image shows him. \n" +
                    "He wants to be able to move the images to change them and see how they react, or even see how muscles are supposed to stretch and contract as a person moves. And not being able to get out of this block is frustrating him as none of his portraits look correct. And the Worst part his teacher said that tomorrow they will learn Anatomy presumably from books he thinks.";
                break;
            case 9:

                nextButton.SetActive(true);
                introText.text = "Activity Scenario:\n\n" +
                    "The next day, Thomas’s teacher explains that they will start to learn Anatomy starting with the muscles, as he begins to grow more anxious at the thought of all those seemingly random bulges the teacher states they will be using an 3d interactive program to show the movement of the muscles. As the teacher shares the link to the website and instructs the class which part of the body they will be interacting with today. Thomas clicks on the link and goes through the intro and realize that this module will be different from the others as he realizes he is not only be able to see the movement of the muscles but is able to interact with them.\n" +
                    "After Thomas has been playing with the simulation for a week he learns how the shapes of the muscles of the arm are formed and how they work with each other, he also learns their names and where they are attached to and is even able to ace the quizzes which asks him to name the of the muscles in the arm by their shape and where they are attach to. He now knows how the arm works and how it changes when it contracts and extends on different positions. Thomas is now able to understand how muscles affect the skin of a person and due to its interactive nature and his curiosity to tinker with things he is now able to draw them in almost any position. Lastly, he is now ready to learn a different part of the body and see how it interacts with the whole.";
                break;
            case 10:

                nextButton.SetActive(false);
                introText.text = "Problem Statement:\n\n" +
                    "Thomas is frustrated by his inability to draw humans, and he is introverted he prefers to do things by himself and tinker with them and books do not allow that with their still images. He needs a way to understand the human body through interactive means that show him how things work bit by bit, as all of it it’s a jumbled mess. He soon later learns from his teacher about a 3d interact simulation where is he able to tinker and learn about the muscles of the human body, which are even animated and quizzed for his convenience in learning, he soon learn how the arm works and moves in different positions and prepares to learn the rest of the human body.";
                break;
        }
    }


}