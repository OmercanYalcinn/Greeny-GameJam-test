using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int greenPoint;
    public Text greenScore;

    void Start()
    {
        greenScore = GetComponent<Text>();
        greenPoint = 0;
    }

    

}
