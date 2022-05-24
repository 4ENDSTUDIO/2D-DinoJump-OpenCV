﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    public float SpeedMultiplier;

    private void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }
    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateSpike", randomWait);
    }
     void generateSpike()
    {
        GameObject spikeIns = Instantiate(spike, transform.position, transform.rotation);

        spikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }    
    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
