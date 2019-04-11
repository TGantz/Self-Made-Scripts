using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawOffButton : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject drawOnButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var drawmodeoff = rightHand.GetComponent<DrawingScript>().drawModeOn = false;

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

        var drawonbuttcolor = drawOnButton.GetComponent<Image>().color;;

        drawonbuttcolor = originalbuttoncolor;

        drawOnButton.GetComponent<Image>().color = drawonbuttcolor;
    }
}
