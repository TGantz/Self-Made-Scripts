﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeButton : MonoBehaviour
{
    public GameObject rightHand;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var redinkon = rightHand.GetComponent<DrawingScript>().redOn = false;
            var orangeinkon = rightHand.GetComponent<DrawingScript>().orangeOn = true;
            var yellowinkon = rightHand.GetComponent<DrawingScript>().yellowOn = false;
            var greeninkon = rightHand.GetComponent<DrawingScript>().greenOn = false;
            var blueinkon = rightHand.GetComponent<DrawingScript>().blueOn = false;
            var purpleinkon = rightHand.GetComponent<DrawingScript>().purpleOn = false;
            var erasermodeon = rightHand.GetComponent<DrawingScript>().eraserOn = false;
        }
    }
}
