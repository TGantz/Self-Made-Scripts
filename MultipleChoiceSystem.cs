using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is a script for the multiple choice questions found throughout the game.  It is extremely versatile as it allows for easy modification to the specifics to each question in the inspector.
//Requires no alterations in script for each question.  It is attached to the desired Screen parent object.

public class MultipleChoiceSystem : MonoBehaviour
{
    public Text questionNumberText;                                                             //Text appearing on the cover screen that appears before the question is started.  Will be used to show the question number.

    public Text questionText;                                                                   //Text object in game that will display the chosen question string

    public Text answerA;                                                                        //Child text objects for the onscreen buttons for the question
    public Text answerB;
    public Text answerC;
    public Text answerD;

    public Text questionTimer;                                                                  //Text object that will display the questionTimer integer

    public Text correctIncorrectText;                                                           //Text object on the correct/incorrect screen that appears after the question is complete

    public string questionNumber;

    public string questionOption1;                                                              //Each multiple choice question has 3 randomized options that can appear when the question is initiated.
    public string questionOption1A;                                                             //Answer choices for question option 1
    public string questionOption1B;
    public string questionOption1C;
    public string questionOption1D;

    public string questionOption2;
    public string questionOption2A;                                                             //Answer choices for question option 2
    public string questionOption2B;
    public string questionOption2C;
    public string questionOption2D;

    public string questionOption3;
    public string questionOption3A;                                                             //Answer choices for question option 3
    public string questionOption3B;
    public string questionOption3C;
    public string questionOption3D;

    public string question1CorrectAnswer;                                                       //Correct answer(A, B, C, or D) can be chosen in the inspector for each question option.
    public string question2CorrectAnswer;
    public string question3CorrectAnswer;
    private string correctAnswer;

    private bool correct = false;
    private bool incorrect = false;
    private bool questionComplete = false;

    public float questionTimeLimit;                                                             //Time limit for the player to input an answer
    public bool keyInserted = false;                                                            //Bool controlled by a script on the key slot using a trigger collider to detect if the key is inserted by checking the tag of the object inserted.

    public GameObject questionCanvas;                                                           //Game Objects will be activated when the key is inserted for activation, cover will disappear when "Start Question" is pressed, Correct/Incorrect appear after question is complete
    public GameObject questionCover;
    public GameObject correctIncorrectScreen;

    public GameObject generalScripts;                                                           //Empty object that holds general scripts.  Used to access the health script.

    //Everything inside this function is established when the game starts, including the selected random question and its
    //provided answer choices, correct answers, and screen settings.
    void Start()
    {
        questionCanvas.SetActive(false);                                                                                //Canvas object containing all multiple choice objects will be hidden until the key is placed in the slot
        correctIncorrectScreen.SetActive(false);

        var randomquestion = new string[3] { questionOption1, questionOption2, questionOption3 };                       //Randomize the questions provided in the string boxes on the inspector.
        questionText.text = randomquestion[Random.Range(0, randomquestion.Length)];                                     //Randomly chooses one of 3 questions, inserts chosen text in the question text box in-game
        
        if(questionText.text == questionOption1)
        {
            answerA.text ="A. " + questionOption1A;                                             //If option 1 is chosen as the question, these are the text found in each answer text.
            answerB.text ="B. " + questionOption1B;
            answerC.text ="C. " + questionOption1C;
            answerD.text ="D. " + questionOption1D;
            correctAnswer = question1CorrectAnswer;                                             //Correct answer designated for first option
        }
        if (questionText.text == questionOption2)
        {
            answerA.text = "A. " + questionOption2A;                                            //If option 2 is chosen as the question, these are the text found in each answer text.
            answerB.text = "B. " + questionOption2B;
            answerC.text = "C. " + questionOption2C;
            answerD.text = "D. " + questionOption2D;
            correctAnswer = question2CorrectAnswer;                                             //Correct answer designated for second option
        }
        if (questionText.text == questionOption3)
        {
            answerA.text = "A. " + questionOption3A;                                            //If option 3 is chosen as the question, these are the text found in each answer text.
            answerB.text = "B. " + questionOption3B;
            answerC.text = "C. " + questionOption3C;
            answerD.text = "D. " + questionOption3D;
            correctAnswer = question3CorrectAnswer;                                             //Correct answer designated for third option
        }

        questionNumberText.text = "Question " + questionNumber;
    }

    void Update()
    {
        if(keyInserted == true)                                                                 //Nested if statements used for initializing the question.  If the correct key is inserted, 
        {                                                                                       //and the start question button is pressed, the cover disappears and timer starts, and waits for answer input
            questionCanvas.SetActive(true);
            if(this.gameObject.tag == "Start Question")
            {
                questionCover.SetActive(false);
                QuestionTimer();
            }
        }
    }
    
    //Controls the timer at which the player has to submit an answer
    void QuestionTimer()
    {

        if (questionComplete == false)
        {
            questionTimeLimit -= Time.deltaTime;                                            //Question timer, decreases as a function of time, displayed in the designated timer text box
            int roundedtimelimit = Mathf.RoundToInt(questionTimeLimit);
            questionTimer.text = roundedtimelimit.ToString();
        }
        if(questionComplete == true)                                                        //Locks time after question is complete, which prevents players from changing answers after question completion.
        {
            questionTimeLimit = 0;
        }
        
        if(questionTimeLimit < 0)                                                           //Runs the answer checking function once the time runs out
        {
            AnswerCheck();
        }
    }

    //Answers are input by pressing one of the 4 buttons on the tables in front of the question screens.  Pressing a button changes 
    //the tag of the canvas item to the corresponding letter.  This function will check the tag of the canvas object and see if it matches
    void AnswerCheck()
    {
        bool hitOnce = false;                                                              //Bool used to prevent health changes from happening more than once

        correctIncorrectScreen.SetActive(true);                                            //Activates correct/incorrect screen

        questionComplete = true;

        if (questionCanvas.gameObject.tag == correctAnswer)                                //If/else statements that determine the outcome depending on whether the answer is correct or not
        {
            correctIncorrectText.text = "Correct";
            correct = true;
            if (hitOnce == false)                                                                        //This if statement is used so health is subtracted or added once.  Without it, it would add/subtract to the health once per frame since this function stems from Update function
            {
                HealthControl();
                hitOnce = true;
            }
        }
        else
        {
            correctIncorrectText.text = "Incorrect";
            incorrect = true;
            if (hitOnce == false)
            {
                HealthControl();
                hitOnce = true;
            }
        }
    }

    //Getting the question right provides a health increase, while getting it wrong hits the player for 20 health
    void HealthControl()
    {
        if (correct == true)
        {
            var correctbonus = generalScripts.GetComponent<Health>().playerHealth += 10.0f;
        }
        if (incorrect == true)
        {
            var incorrectpenalty = generalScripts.GetComponent<Health>().playerHealth -= 20.0f;
        }
    }
}
