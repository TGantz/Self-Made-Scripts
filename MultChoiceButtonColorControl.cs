using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script will control the color of the on screen buttons so the player has a visual of what answer was selected.  They will shift to a brighter color of the default color.
//This is attached to mult. choice canvas of the desired screen.

public class MultChoiceButtonColorControl : MonoBehaviour
{

    public GameObject onScreenAButton;      //Public variable for each of the 4 buttons on the screen
    public GameObject onScreenBButton;
    public GameObject onScreenCButton;
    public GameObject onScreenDButton;

    private Color originalButtonColor;      //The color of the button when not selected
    private Color selectedButtonColor;      //The desired color when the corresponding answer is chosen

    // Start is called before the first frame update
    void Start()
    {
        originalButtonColor = onScreenAButton.GetComponent<Image>().color;      //Attaches color values to each of the variables at start up
        selectedButtonColor = new Color32(255, 182, 182, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.tag == "A")                                                  //If A is selected, the on screen A button will change colors
        {
            onScreenAButton.GetComponent<Image>().color = selectedButtonColor;
            onScreenBButton.GetComponent<Image>().color = originalButtonColor;
            onScreenCButton.GetComponent<Image>().color = originalButtonColor;
            onScreenDButton.GetComponent<Image>().color = originalButtonColor;
        }
        if (this.gameObject.tag == "B")                                                 //If B is selected, the on screen B button will change colors
        {
            onScreenAButton.GetComponent<Image>().color = originalButtonColor;
            onScreenBButton.GetComponent<Image>().color = selectedButtonColor;
            onScreenCButton.GetComponent<Image>().color = originalButtonColor;
            onScreenDButton.GetComponent<Image>().color = originalButtonColor;
        }
        if (this.gameObject.tag == "C")                                                 //"" C "" C Button
        {
            onScreenAButton.GetComponent<Image>().color = originalButtonColor;
            onScreenBButton.GetComponent<Image>().color = originalButtonColor;
            onScreenCButton.GetComponent<Image>().color = selectedButtonColor;
            onScreenDButton.GetComponent<Image>().color = originalButtonColor;
        }
        if (this.gameObject.tag == "D")                                                 //"" D "" D Button
        {
            onScreenAButton.GetComponent<Image>().color = originalButtonColor;
            onScreenBButton.GetComponent<Image>().color = originalButtonColor;
            onScreenCButton.GetComponent<Image>().color = originalButtonColor;
            onScreenDButton.GetComponent<Image>().color = selectedButtonColor;
        }
    }
}
