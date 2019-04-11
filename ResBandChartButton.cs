using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResBandChartButton : MonoBehaviour
{
    public GameObject resistorBandChart;
    public GameObject multimeter;
    public GameObject Notepad;
    public GameObject HUDWeaponModels;

    public GameObject clockButton;
    public GameObject multimeterButton;
    public GameObject notepadButton;

    public bool test;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            resistorBandChart.SetActive(true);
            multimeter.SetActive(false);
            Notepad.SetActive(false);
            HUDWeaponModels.SetActive(true);

            PressedButtonColor();
            ResetOtherButtonColors();

            test = true;
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

        var multimeterbuttcolor = multimeterButton.GetComponent<Image>().color;
        var clockbuttcolor = clockButton.GetComponent<Image>().color;
        var notepadbuttcolor = notepadButton.GetComponent<Image>().color;

        multimeterbuttcolor= originalbuttoncolor;
        clockbuttcolor = originalbuttoncolor;
        notepadbuttcolor = originalbuttoncolor;

        multimeterButton.GetComponent<Image>().color = multimeterbuttcolor;
        clockButton.GetComponent<Image>().color = clockbuttcolor;
        notepadButton.GetComponent<Image>().color = notepadbuttcolor;
    }
}
