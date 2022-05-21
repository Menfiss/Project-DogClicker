using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class DogCoinClick : MonoBehaviour
{
    public Variables V;
    System.Random rn = new System.Random();

    public GameObject DogCoin;
    public GameObject CloneDogCoin;
    List<GameObject> DogCoinList = new List<GameObject>();
    public Transform canvas;

    
    // DogCoin Click
    public TextMeshProUGUI DogeCoinValueText;
    //
    
    public void IncreaseValue()// DogCoin Click
    {
        SoundManagerScript.PlaySound("click");
        SpawnObject();
        if (V.DogCoin < V.DogCoinCapacity) V.DogCoin += V.ClickValue;
    }

    void Update()
    {
        if(V.DogCoin > V.DogCoinCapacity) V.DogCoin = V.DogCoinCapacity;
        DogeCoinValueText.text = Math.Round(V.DogCoin, 2).ToString() + "/" + V.DogCoinCapacity.ToString();

        if (DogCoin != null)
            for (int i = 0; i < DogCoinList.Count; i++)
                if (DogCoinList[i].transform.position.y > 30)
                {
                    DogCoinList[i].transform.Translate(0, -1, 0);
                }
                else
                {
                    Destroy(DogCoinList[i]);
                    DogCoinList.RemoveAt(0);
                }
    }
    void SpawnObject()
    {
        Vector3 RandomPosition = new Vector3(rn.Next(25, 1900), 1100, 10);
        CloneDogCoin = Instantiate(DogCoin, RandomPosition, Quaternion.identity, canvas);
        CloneDogCoin.transform.SetAsLastSibling();
        DogCoinList.Add(CloneDogCoin);
    }
}
