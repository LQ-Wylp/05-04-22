using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chronos : MonoBehaviour
{
    public TextMeshProUGUI TextChronos;
    public float Timer;
    void Update()
    {
        Timer += Time.deltaTime;
        TextChronos.text = ": " + Timer.ToString("0.00") + "s";
        GameOverScore.Chronos = Timer;
    }
}
