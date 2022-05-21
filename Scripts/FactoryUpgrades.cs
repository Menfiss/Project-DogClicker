using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class FactoryUpgrades : MonoBehaviour
{

    public Variables V;
    public SoundManagerScript Sound;

    public GameObject gpu1Panel;
    public GameObject gpu2Panel;
    public GameObject gpu3Panel;
    public GameObject gpu4Panel;

    public GameObject quizPanel;

    public bool IsActiveGpu1 = false;
    public bool IsActiveGpu2 = false;
    public bool IsActiveGpu3 = false;
    public bool IsActiveGpu4 = false;

    public TextMeshProUGUI gpu1CostText;
    public TextMeshProUGUI gpu2CostText;

    void Start()
    {
        gpu1Panel.SetActive(false);
        gpu2Panel.SetActive(false);
        gpu3Panel.SetActive(false);
        gpu4Panel.SetActive(false);

        quizPanel.SetActive(false);
        gpu1CostText.text = "Cost:\n" + V.gpu1Cost.ToString();
    }

    public void gpu1()
    {
        SoundManagerScript.PlaySound("click");
        if (IsActiveGpu1 == false)
        {
            IsActiveGpu1 = true;
            gpu1Panel.SetActive(true);
        }
        else
        {
            IsActiveGpu1 = false;
            gpu1Panel.SetActive(false);
        }
    }
    public void gpu2()
    {
        SoundManagerScript.PlaySound("click");
        if (IsActiveGpu2 == false)
        {
            IsActiveGpu2 = true;
            gpu2Panel.SetActive(true);
        }
        else
        {
            IsActiveGpu2 = false;
            gpu2Panel.SetActive(false);
        }
    }
    public void gpu3()
    {
        SoundManagerScript.PlaySound("click");
        if (IsActiveGpu3 == false)
        {
            IsActiveGpu3 = true;
            gpu3Panel.SetActive(true);
        }
        else
        {
            IsActiveGpu3 = false;
            gpu3Panel.SetActive(false);
        }
    }
    public void gpu4()
    {
        SoundManagerScript.PlaySound("click");
        if (IsActiveGpu4 == false)
        {
            IsActiveGpu4 = true;
            gpu4Panel.SetActive(true);
        }
        else
        {
            IsActiveGpu4 = false;
            gpu4Panel.SetActive(false);
        }
    }

    public void gpu1Buy()
    {

        if (V.gpu1Cost <= V.DogCoin)
        {
            Quiz();
            V.DogCoin -= V.gpu1Cost;
            V.gpu1Cost = (int)Math.Ceiling(V.gpu1Cost * 1.25);
            V.MinerCost -= (int)Math.Ceiling(V.MinerCost * 0.1);
        }
    }

    public void gpu2Buy()
    {
        if (V.gpu2Cost <= V.DogCoin)
        {
            Quiz();
            V.DogCoin -= V.gpu2Cost;
            V.gpu2Cost = (int)Math.Ceiling(V.gpu2Cost * 1.25);
            V.CollarCost -= (int)Math.Ceiling(V.CollarCost * 0.1);
        }
    }
    string[,] quiz = new string[,]
   {
        {"Firewall se používá na ", "Zabezpeèení","Pøenos Dat","Ovìøení uživatele"},
        {"První operaèní systém se jmenoval", "GM-NAA I/O","MS-DOS","OS/360"},
        {"Textové rozhrání má zkratku", "CLI","CL","CMD"},
        {"Mezi vstupní periferní zaøízení patøí", "Skener","Tiskárna","Projektor"},
        {"Mezi výstupní periferní zaøízení patøí", "Projektor","Myš","Trackpoint"},
   };
    System.Random rn = new System.Random();
    public TextMeshProUGUI question;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;
    public int whereIsTheAnswer;
    public bool IsCorrect;
    public void Quiz()
    {
        quizPanel.SetActive(true);
        int index;
       do
        {
            index = rn.Next(0, quiz.GetLength(0));
        } while (index == V.previousQuestion) ;
        V.previousQuestion = index;
        
        int questionIndex1 = rn.Next(1,4);
        int questionIndex2 = rn.Next(1,4);
        int questionIndex3 = rn.Next(1,4);
        while(questionIndex2 == questionIndex1 || questionIndex2 == questionIndex3 || questionIndex1 == questionIndex3)
        {
            questionIndex1 = rn.Next(1, 4);
            questionIndex2 = rn.Next(1, 4);
            questionIndex3 = rn.Next(1, 4);
        }
        question.text = quiz[index, 0];

        answer1.text = quiz[index, questionIndex1];
        answer2.text = quiz[index, questionIndex2];
        answer3.text = quiz[index, questionIndex3];
        if(questionIndex1 == 1)
        {
            whereIsTheAnswer = 1;
        }
        else if(questionIndex2 == 1)
        {
            whereIsTheAnswer = 2;
        }
        else
        {
            whereIsTheAnswer = 3;
        }
    }
    public void Answer1()
    {
        if(whereIsTheAnswer == 1)
        {
            SoundManagerScript.PlaySound("correct");
            IsCorrect = true;
            quizPanel.SetActive(false);
        }
        else
        {
            SoundManagerScript.PlaySound("error");
            IsCorrect = false;
            V.DogCoin = 0;
            quizPanel.SetActive(false);
        }
    }
    public void Answer2()
    {
        if (whereIsTheAnswer == 2)
        {
            SoundManagerScript.PlaySound("correct");
            IsCorrect = true;
            quizPanel.SetActive(false);
        }
        else 
        {
            SoundManagerScript.PlaySound("error");
            IsCorrect = false;
            V.DogCoin = 0;
            quizPanel.SetActive(false);
        }
    }
    public void Answer3()
    {
        if (whereIsTheAnswer == 3)
        {
            SoundManagerScript.PlaySound("correct");
            IsCorrect = true;
            quizPanel.SetActive(false);
        }
        else
        {
            SoundManagerScript.PlaySound("error");
            IsCorrect = false;
            V.DogCoin = 0;
            quizPanel.SetActive(false);
        }
    }

    void Update()
    {
        gpu1CostText.text = "Cost:\n" + V.gpu1Cost.ToString();
        gpu2CostText.text = "Cost:\n" + V.gpu2Cost.ToString();
    }
}
