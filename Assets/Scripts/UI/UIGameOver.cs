using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    public TextMeshProUGUI textTemps;
    public TextMeshProUGUI textNbEnnemiTue;
    public TextMeshProUGUI textLevel;

    void Start()
    {
        textTemps.text = "" + GameOverScore.Chronos.ToString("0.00") + "s";
        textNbEnnemiTue.text = "" + GameOverScore.EnnemiTue + " ennemis";
        textLevel.text = "" + GameOverScore.Level;
    }
}
