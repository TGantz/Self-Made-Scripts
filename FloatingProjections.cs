using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingProjections : MonoBehaviour
{
    public float speedMultiplier;

    public float amplitude = 0.5f;
    public float frequency = 1f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        posOffset = transform.position;
    }

    void Update()
    {
        this.gameObject.transform.Rotate(0, speedMultiplier * Time.deltaTime, 0);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}