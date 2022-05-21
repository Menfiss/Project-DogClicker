using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveGame : MonoBehaviour
{
    public Variables V;
    

    public void Start()
    {
        V.DogCoin = PlayerPrefs.GetFloat("DogCoin");
        V.ClickValue = PlayerPrefs.GetInt("ClickValue");
        V.DogCoinCapacity = PlayerPrefs.GetInt("DogCoinCapacity");
        V.BoneCost = PlayerPrefs.GetInt("BoneCost");
        V.CapacityCost = PlayerPrefs.GetInt("CapacityCost");
        V.Mining = PlayerPrefs.GetFloat("Mining");
        V.MinerCost = PlayerPrefs.GetInt("MinerCost");
        V.CollarPercentage = PlayerPrefs.GetFloat("CollarPercentage");
        V.CollarCost = PlayerPrefs.GetInt("CollarCost");
        V.CapacityLevel = PlayerPrefs.GetInt("CapacityLevel");
        V.BoneLevel = PlayerPrefs.GetInt("BoneLevel");
        V.MinerLevel = PlayerPrefs.GetInt("MinerLevel");
        V.CollarLevel = PlayerPrefs.GetInt("CollarLevel");

        //factory
        V.gpu1Cost = PlayerPrefs.GetInt("gpu1Cost");
        V.gpu2Cost = PlayerPrefs.GetInt("gpu2Cost");
        V.previousQuestion = PlayerPrefs.GetInt("previousQuestion");

        //settings
        V.volumeValue  = PlayerPrefs.GetFloat("volumeValue");
        V.IsFullScreen = PlayerPrefs.GetInt("IsFullScreen");
        
    }
    public void Update()
    {
        PlayerPrefs.SetFloat("DogCoin", V.DogCoin);
        PlayerPrefs.SetInt("ClickValue", V.ClickValue);
        PlayerPrefs.SetInt("DogCoinCapacity", V.DogCoinCapacity);
        PlayerPrefs.SetInt("BoneCost", V.BoneCost);
        PlayerPrefs.SetInt("CapacityCost", V.CapacityCost);
        PlayerPrefs.SetFloat("Mining", V.Mining);
        PlayerPrefs.SetInt("MinerCost", V.MinerCost);
        PlayerPrefs.SetFloat("CollarPercentage", V.CollarPercentage);
        PlayerPrefs.SetInt("CollarCost", V.CollarCost);
        PlayerPrefs.SetInt("CapacityLevel", V.CapacityLevel);
        PlayerPrefs.SetInt("BoneLevel", V.BoneLevel);
        PlayerPrefs.SetInt("MinerLevel", V.MinerLevel);
        PlayerPrefs.SetInt("CollarLevel", V.CollarLevel);

        //factory
        PlayerPrefs.SetInt("gpu1Cost", V.gpu1Cost);
        PlayerPrefs.SetInt("gpu2Cost", V.gpu2Cost);

        //settings
        PlayerPrefs.SetFloat("volumeValue", V.volumeValue);
        PlayerPrefs.SetInt("IsFullScreen", V.IsFullScreen);
        
    }
}
