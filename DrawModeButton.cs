using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawModeButton : MonoBehaviour
{
    public GameObject resistorBandChart;
    public GameObject multimeter;
    public GameObject drawModeScreen;
    public GameObject HUDWeaponModels;

    public GameObject clockButton;
    public GameObject resBandButton;
    public GameObject multimeterButton;

    public bool test;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            multimeter.SetActive(false);
            resistorBandChart.SetActive(false);
            drawModeScreen.SetActive(true);
            HUDWeaponModels.SetActive(false);

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

        var resbandbuttcolor = resBandButton.GetComponent<Image>().color;
        var clockbuttcolor = clockButton.GetComponent<Image>().color;
        var multimeterbuttcolor = multimeterButton.GetComponent<Image>().color;

        resbandbuttcolor = originalbuttoncolor;
        clockbuttcolor = originalbuttoncolor;
        multimeterbuttcolor = originalbuttoncolor;

        resBandButton.GetComponent<Image>().color = resbandbuttcolor;
        clockButton.GetComponent<Image>().color = clockbuttcolor;
        multimeterButton.GetComponent<Image>().color = multimeterbuttcolor;
    }
}