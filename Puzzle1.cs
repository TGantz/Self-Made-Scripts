using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{

    public GameObject resistor1Placeholder;
    public GameObject resistor2Placeholder;
    public GameObject resistor3Placeholder;
    public GameObject resistor4Placeholder;
    public GameObject resistor5Placeholder;
    public GameObject resistor6Placeholder;
    public GameObject resistor7Placeholder;
    public GameObject resistor8Placeholder;
    public GameObject resistor9Placeholder;
    public GameObject resistor10Placeholder;

    public GameObject resistor10000;
    public GameObject resistor5700;
    public GameObject resistor400;
    public GameObject resistor700;
    public GameObject resistor25000;
    public GameObject resistor1200;
    public GameObject resistor990000;
    public GameObject resistor3000;
    public GameObject resistor60;
    public GameObject resistor4200;
    public GameObject[] resistors;

    public GameObject puzzle1R1;
    public GameObject puzzle1R2;
    public GameObject puzzle1R3;
    public GameObject puzzle1R4;
    public GameObject puzzle1R5;
    public GameObject puzzle1R6;
    public GameObject puzzle1R7;
    public GameObject puzzle1R8;
    public GameObject puzzle1R9;
    public GameObject puzzle1R10;
    public GameObject randomResistorParent;

    private GameObject randR1;
    private GameObject randR2;
    private GameObject randR3;
    private GameObject randR4;
    private GameObject randR5;
    private GameObject randR6;
    private GameObject randR7;
    private GameObject randR8;
    private GameObject randR9;
    private GameObject randR10;

    private float r1Resistance;
    private float r2Resistance;
    private float r3Resistance;
    private float r4Resistance;
    private float r5Resistance;
    private float r6Resistance;
    private float r7Resistance;
    private float r8Resistance;
    private float r9Resistance;
    private float r10Resistance;
    private float totalResistance;

    public bool puzzle1Complete;
    public GameObject puzzle1EnergyShield;

    void Awake()
    {
        resistors[0] = resistor10000;
        resistors[1] = resistor5700;
        resistors[2] = resistor400;
        resistors[3] = resistor700;
        resistors[4] = resistor25000;
        resistors[5] = resistor1200;
        resistors[6] = resistor990000;
        resistors[7] = resistor3000;
        resistors[8] = resistor60;
        resistors[9] = resistor4200;

        RandomizeResistors(resistors);
        ResistorSpawn();

    }


    void Update()
    {
        
        if (randR1 == null)
        {
            r1Resistance = 0.0f;  
        }

        if (randR2 == null)
        {
            r2Resistance = 0.0f;
        }

        if (randR3 == null)
        {
            r3Resistance = 0.0f;
        }

        if (randR4 == null)
        {
            r4Resistance = 0.0f;
        }

        if (randR5 == null)
        {
            r5Resistance = 0.0f;
        }

        if (randR6 == null)
        {
            r6Resistance = 0.0f;
        }

        if (randR7 == null)
        {
            r7Resistance = 0.0f;
        }

        if (randR8 == null)
        {
            r8Resistance = 0.0f;
        }

        if (randR9 == null)
        {
            r9Resistance = 0.0f;
        }

        if (randR10 == null)
        {
            r10Resistance = 0.0f;
        }

        totalResistance = r1Resistance + r2Resistance + r3Resistance + r4Resistance + r5Resistance + r6Resistance + r7Resistance + r8Resistance + r9Resistance + r10Resistance;

        if (randomResistorParent.transform.childCount == 5)
        {
            if(totalResistance == 5360)
            { 
                PuzzleComplete();
            }
        }
    }

    void RandomizeResistors(GameObject[] resistors)
    {
        // Knuth shuffle algorithm
        for (int t = 0; t < resistors.Length; t++)
        {
            var tmp = resistors[t];
            int r = UnityEngine.Random.Range(t, resistors.Length);
            resistors[t] = resistors[r];
            resistors[r] = tmp;
        }
    }


    void ResistorSpawn()
    {
        puzzle1R1 = resistors[0];
        Destroy(resistor1Placeholder);
        randR1 = Instantiate(puzzle1R1, resistor1Placeholder.transform.position, resistor1Placeholder.transform.rotation);
        randR1.transform.parent = randomResistorParent.transform;
        r1Resistance= Single.Parse(randR1.tag);

        puzzle1R2 = resistors[1];
        Destroy(resistor2Placeholder);
        randR2 = Instantiate(puzzle1R2, resistor2Placeholder.transform.position, resistor2Placeholder.transform.rotation);
        randR2.transform.parent = randomResistorParent.transform;
        r2Resistance = Single.Parse(randR2.tag);

        puzzle1R3 = resistors[2];
        Destroy(resistor3Placeholder);
        randR3 = Instantiate(puzzle1R3, resistor3Placeholder.transform.position, resistor3Placeholder.transform.rotation);
        randR3.transform.parent = randomResistorParent.transform;
        r3Resistance = Single.Parse(randR3.tag);

        puzzle1R4 = resistors[3];
        Destroy(resistor4Placeholder);
        randR4 = Instantiate(puzzle1R4, resistor4Placeholder.transform.position, resistor4Placeholder.transform.rotation);
        randR4.transform.parent = randomResistorParent.transform;
        r4Resistance = Single.Parse(randR4.tag);

        puzzle1R5 = resistors[4];
        Destroy(resistor5Placeholder);
        randR5 = Instantiate(puzzle1R5, resistor5Placeholder.transform.position, resistor5Placeholder.transform.rotation);
        randR5.transform.parent = randomResistorParent.transform;
        r5Resistance = Single.Parse(randR5.tag);

        puzzle1R6 = resistors[5];
        Destroy(resistor6Placeholder);
        randR6 = Instantiate(puzzle1R6, resistor6Placeholder.transform.position, resistor6Placeholder.transform.rotation);
        randR6.transform.parent = randomResistorParent.transform;
        r6Resistance = Single.Parse(randR6.tag);

        puzzle1R7 = resistors[6];
        Destroy(resistor7Placeholder);
        randR7 = Instantiate(puzzle1R7, resistor7Placeholder.transform.position, resistor7Placeholder.transform.rotation);
        randR7.transform.parent = randomResistorParent.transform;
        r7Resistance = Single.Parse(randR7.tag);

        puzzle1R8 = resistors[7];
        Destroy(resistor8Placeholder);
        randR8 = Instantiate(puzzle1R8, resistor8Placeholder.transform.position, resistor8Placeholder.transform.rotation);
        randR8.transform.parent = randomResistorParent.transform;
        r8Resistance = Single.Parse(randR8.tag);

        puzzle1R9 = resistors[8];
        Destroy(resistor9Placeholder);
        randR9 = Instantiate(puzzle1R9, resistor9Placeholder.transform.position, resistor9Placeholder.transform.rotation);
        randR9.transform.parent = randomResistorParent.transform;
        r9Resistance = Single.Parse(randR9.tag);

        puzzle1R10 = resistors[9];
        Destroy(resistor10Placeholder);
        randR10 = Instantiate(puzzle1R10, resistor10Placeholder.transform.position, resistor10Placeholder.transform.rotation);
        randR10.transform.parent = randomResistorParent.transform;
        r10Resistance = Single.Parse(randR10.tag);
    }

    void PuzzleComplete()
    {

    }
}
