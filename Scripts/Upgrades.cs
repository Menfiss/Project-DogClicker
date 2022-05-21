using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Upgrades : MonoBehaviour
{
    public Variables V;
    
    

    // Bone Upgrade
    public TextMeshProUGUI BoneUpgradeCostText;
    
    // Capacity Upgrade
    public TextMeshProUGUI CapacityUpgradeCostText;

    // Miner Upgrade
    public TextMeshProUGUI MinerUpgradeCostText;

    // Collar Upgrade
    public TextMeshProUGUI CollarUpgradeCostText;

    public TextMeshProUGUI PerClickText;
    public TextMeshProUGUI PerSecondText;

    public TextMeshProUGUI CapacityLevelText;
    public TextMeshProUGUI BoneLevelText;
    public TextMeshProUGUI MinerLevelText;
    public TextMeshProUGUI CollarLevelText;






    public void BoneUpgrade() 
    {
        if(V.DogCoin >= V.BoneCost)
        {
            SoundManagerScript.PlaySound("buy");
            V.ClickValue++;
            V.DogCoin -= V.BoneCost;
            V.BoneCost = (int)Math.Ceiling(V.BoneCost * 1.5);
            V.BoneLevel += 1;
        }
    }

    public void CapacityUpgrade()
    {
        if(V.DogCoin == V.CapacityCost)
        {
            SoundManagerScript.PlaySound("buy");
            V.DogCoin -= V.CapacityCost;
            V.DogCoinCapacity = (int)Math.Ceiling(V.DogCoinCapacity * 1.5);
            V.CapacityCost = V.DogCoinCapacity;
            V.CapacityLevel += 1;
        }
    }

    public void MinerUpgrade()
    {
        if(V.MinerCost <= V.DogCoin)
        {
            SoundManagerScript.PlaySound("buy");
            V.Mining += 1;
            V.DogCoin -= V.MinerCost;
            V.MinerCost *= 10;
            V.MinerLevel += 1;
        }
    }

    public void CollarUpgrade()
    {
        if (V.CollarCost <= V.DogCoin)
        {
            SoundManagerScript.PlaySound("buy");
            V.CollarPercentage += 0.1f;
            V.DogCoin -= V.CollarCost;
            V.CollarCost *= 10;
            V.CollarLevel += 1;
        }
    }
    
    IEnumerator Start()
    {
        while (true)
        {
            V.DogCoin += (V.Mining + (V.Mining * V.CollarPercentage));
            
            yield return new WaitForSeconds(1f);
        }
    }

    void Update()
    {
        BoneUpgradeCostText.text = "Cost:\n" + V.BoneCost.ToString();

        CapacityUpgradeCostText.text = "Cost\n" + V.CapacityCost.ToString();

        MinerUpgradeCostText.text = "Cost\n" + V.MinerCost.ToString();

        CollarUpgradeCostText.text = "Cost\n" + V.CollarCost.ToString();

        PerClickText.text = V.ClickValue.ToString();
        PerSecondText.text = Math.Round(V.Mining + (V.Mining * V.CollarPercentage),2).ToString();

        CapacityLevelText.text = "LvL\n" + V.CapacityLevel.ToString();
        BoneLevelText.text = "LvL\n" + V.BoneLevel.ToString();
        MinerLevelText.text = "LvL\n" + V.MinerLevel.ToString();
        CollarLevelText.text = "LvL\n" + V.CollarLevel.ToString();


    }
}
