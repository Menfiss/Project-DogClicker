using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class ResetProgression : MonoBehaviour
{
    public Variables V;

    public void ResetProgress()
    {
        SoundManagerScript.PlaySound("click");

        V.DogCoin = 0;
        V.ClickValue = 1;
        V.DogCoinCapacity = 10;
        V.CapacityCost = 10;
        V.CapacityLevel = 0;
        V.BoneCost = 10;
        V.BoneLevel = 0;
        V.Mining = 0;
        V.MinerCost = 20;
        V.MinerLevel = 0;
        V.CollarPercentage = 0;
        V.CollarCost = 100;
        V.CollarLevel = 0;
        V.gpu1Cost = 1000;
        V.gpu2Cost = 2500;
        



    }
}
