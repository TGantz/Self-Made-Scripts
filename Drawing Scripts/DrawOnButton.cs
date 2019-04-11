using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawOnButton : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject drawOffButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            var drawmodeon = rightHand.GetComponent<DrawingScript>().drawModeOn = true;

            PressedButtonColor();
            ResetOtherButtonColors();
        }
    }

    void PressedButtonColor()
    {
        var pressedColor = new Color32(255, 182, 182, 255);

        var thisbuttonColor = this.gameObject.GetComponent<Image>().color;
        thisbuttonColor = pressedColor;
        this.gameObject.GetComponent<Image>().color = thisbuttonColor;
    }

    void ResetOtherButtonColors()
    {
        var originalbuttoncolor = new Color32(96, 9, 9, 255);

        var drawonbuttcolor = drawOffButton.GetComponent<Image>().color; ;

        drawonbuttcolor = originalbuttoncolor;

        drawOffButton.GetComponent<Image>().color = drawonbuttcolor;
    }
}
