using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MultipleChoiceQuestion1 : MonoBehaviour
{

    public VideoClip videoClip1;
    public VideoClip videoClip2;
    public VideoClip videoClip3;
    private VideoClip chosenclip;
    public VideoClip correct;
    public VideoClip incorrect;

    private VideoPlayer videoPlayer;
    private AudioSource audioSource;

    public GameObject aButton;
    public GameObject bButton;
    public GameObject cButton;
    public GameObject dButton;
    public GameObject buttonTable;  //Button press assigns a tag to the button table, a, b, c, or d depending on the button.  Acts as the answer input.
    public GameObject q1KeyHolder;
    public GameObject q1Key;

    public bool q1KeyInserted = false;
    private bool questionInitiated = false;
    public float questionTimeLimit = 18.0f;

    public bool answerA = false;
    public bool answerB = false;
    public bool answerC = false;
    public bool answerD = false;

    Vector3 q1KeyLocation;
    Vector3 q1KeyHolderLocation;

    public bool q1CorrectAnswer;
    public bool q1IncorrectAnswer;
    private bool instantiateActLightOnce = false;
    private bool instantiateGreenLightOnce = false;
    private bool instantiateRedLightOnce = false;
    public GameObject generatorExplosion;
    public GameObject Screen1;
    public GameObject q1KeyPicture;
    public GameObject q1Light;
    public GameObject lightOff;
    public GameObject greenLight;
    public GameObject redLight;

    public GameObject generalScripts;
    private bool hitOnce = false;

    void Start()
    {

        var randomvideoclip = new VideoClip[3] { videoClip1, videoClip2, videoClip3 };

        chosenclip = randomvideoclip[Random.Range(0, randomvideoclip.Length)];

        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.isLooping = false;
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = chosenclip;
        videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);

    }


    void Update()
    {
        q1KeyLocation = q1Key.transform.position;
        q1KeyHolderLocation = q1KeyHolder.transform.position;

        print(Vector3.Distance(q1KeyHolderLocation, q1KeyLocation));

        if (Vector3.Distance(q1KeyHolderLocation, q1KeyLocation) < .1f)
        {
            q1KeyInserted = true;
            Destroy(q1KeyPicture);
            if (instantiateActLightOnce == false)
            {
                Instantiate(q1Light, lightOff.transform.position, lightOff.transform.rotation);
                instantiateActLightOnce = true;
            }
        }

        if (q1KeyInserted == true)
        {
            if (this.gameObject.tag == "Start Video")
            {
                VideoPlayer vp = GetComponent<VideoPlayer>();
                vp.isLooping = false;
                vp.Play();
                questionInitiated = true;
            }

            if (questionInitiated == true)
            {
                AnswerCheck();
                QuestionTimer();
            }
        }
    }

    void AnswerCheck()
    {

        if(buttonTable.tag == "A")
        {
            answerA = true;
            Destroy(bButton);
            Destroy(cButton);
            Destroy(dButton);
            CorrectIncorrect();
        }

        if(buttonTable.tag == "B")
        {
            answerB = true;
            Destroy(aButton);
            Destroy(cButton);
            Destroy(dButton);
            CorrectIncorrect();
        }

        if (buttonTable.tag == "C")
        {
            answerC = true;
            Destroy(aButton);
            Destroy(bButton);
            Destroy(dButton);
            CorrectIncorrect();
        }

        if (buttonTable.tag == "D")
        {
            answerD = true;
            Destroy(aButton);
            Destroy(bButton);
            Destroy(cButton);
            CorrectIncorrect();
        }


    }

    void CorrectIncorrect()
    {
        VideoPlayer correctincorrect = GetComponent<VideoPlayer>();
        correctincorrect.isLooping = false;

        if (questionInitiated == true)
        {
            if (chosenclip == videoClip1)
            {
                if (answerA == true)
                {
                    q1CorrectAnswer = true;
                    videoPlayer.clip = correct;
                    Destroy(lightOff);
                    if (instantiateGreenLightOnce == false)
                    {
                        Instantiate(greenLight, lightOff.transform.position, lightOff.transform.rotation);
                        instantiateGreenLightOnce = true;
                    }

                    correctincorrect.Play();
                    if (correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }

                }
                else
                {
                    videoPlayer.clip = incorrect;

                    if (hitOnce == false)
                    {
                        IncorrectPenalty();
                        hitOnce = true;
                    }

                    Destroy(lightOff);
                    if (instantiateRedLightOnce == false)
                    {
                        Instantiate(redLight, lightOff.transform.position, lightOff.transform.rotation);
                        instantiateRedLightOnce = true;
                    }

                    correctincorrect.Play();
                    if (correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }
                }
            }

            if (chosenclip == videoClip2)
            {
                if (answerC == true)
                {
                    q1CorrectAnswer = true;
                    videoPlayer.clip = correct;

                    Destroy(lightOff);
               
                    if (instantiateGreenLightOnce == false)
                    {
                        Instantiate(greenLight, lightOff.transform.position, lightOff.transform.rotation);
                        instantiateGreenLightOnce = true;
                    }

                    correctincorrect.Play();
                    if (correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }
                }
                else
                {
                    videoPlayer.clip = incorrect;

                    if (hitOnce == false)
                    {
                        IncorrectPenalty();
                        hitOnce = true;
                    }

                    Destroy(lightOff);

                    correctincorrect.Play();
                    if (correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }
                }
            }
        

            if (chosenclip == videoClip3)
            {
                if (answerB == true)
                {
                    q1CorrectAnswer = true;
                    videoPlayer.clip = correct;
                    Destroy(lightOff);
                    if (instantiateGreenLightOnce == false)
                    {
                        Instantiate(greenLight, lightOff.transform.position, lightOff.transform.rotation);
                        instantiateGreenLightOnce = true;
                    }

                    correctincorrect.Play();
                    if(correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }
                }

                else
                {
                    videoPlayer.clip = incorrect;

                    if (hitOnce == false)
                    {
                        IncorrectPenalty();
                        hitOnce = true;
                    }

                    Destroy(lightOff);

                    correctincorrect.Play();
                    if (correctincorrect.time > 1.0f)
                    {
                        correctincorrect.Pause();
                    }
                }
            }

        }

    }


    void QuestionTimer()
    {
        questionTimeLimit -= Time.deltaTime;

        if (questionTimeLimit <= 0.0f)
        {
            GameOver();
        }
        
        if (q1CorrectAnswer == true)
        {
            questionTimeLimit = 1.0f;
                return;
        }
    }

    void IncorrectPenalty()
    {
        var incorrectpenalty = generalScripts.GetComponent<Health>().playerHealth -= 20.0f;
    }

    void GameOver()
    {
        var explodeonimpact = (GameObject)Instantiate(generatorExplosion, buttonTable.transform.position, buttonTable.transform.rotation);
        Destroy(Screen1);
    }
}
