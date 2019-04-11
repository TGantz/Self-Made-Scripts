using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButtonControl : MonoBehaviour
{
    public GameObject rightHand;

    public GameObject redButton;
    public GameObject orangeButton;
    public GameObject yellowButton;
    public GameObject greenButton;
    public GameObject blueButton;
    public GameObject purpleButton;


    private Color originalRed;
    private Color originalOrange;
    private Color originalYellow;
    private Color originalGreen;
    private Color originalBlue;
    private Color originalPurple;



    void Start()
    {
        originalRed = redButton.GetComponent<Image>().color;
        originalOrange = orangeButton.GetComponent<Image>().color;
        originalYellow = yellowButton.GetComponent<Image>().color;
        originalGreen = greenButton.GetComponent<Image>().color;
        originalBlue = blueButton.GetComponent<Image>().color;
        originalPurple = purpleButton.GetComponent<Image>().color;
    }

    void Update()
    {
        var redinkon = rightHand.GetComponent<DrawingScript>().redOn;
        var orangeinkon = rightHand.GetComponent<DrawingScript>().orangeOn;
        var yellowinkon = rightHand.GetComponent<DrawingScript>().yellowOn;
        var greeninkon = rightHand.GetComponent<DrawingScript>().greenOn;
        var blueinkon = rightHand.GetComponent<DrawingScript>().blueOn;
        var purpleinkon = rightHand.GetComponent<DrawingScript>().purpleOn;
        var erasermodeon = rightHand.GetComponent<DrawingScript>().eraserOn;

        if (redinkon == true)
        {
            redButton.GetComponent<Image>().color = new Color32(255, 182, 182, 255);
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
        if(orangeinkon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = new Color32(255, 197, 153, 255);
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
        if(yellowinkon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = new Color32(255, 255, 156, 255);
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
        if (greeninkon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = new Color32(185, 255, 187, 255);
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
        if (blueinkon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = new Color32(185, 187, 255, 255);
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
        if (purpleinkon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = new Color32(235, 206, 255, 255);
        }
        if(erasermodeon == true)
        {
            redButton.GetComponent<Image>().color = originalRed;
            orangeButton.GetComponent<Image>().color = originalOrange;
            yellowButton.GetComponent<Image>().color = originalYellow;
            greenButton.GetComponent<Image>().color = originalGreen;
            blueButton.GetComponent<Image>().color = originalBlue;
            purpleButton.GetComponent<Image>().color = originalPurple;
        }
    }
}
