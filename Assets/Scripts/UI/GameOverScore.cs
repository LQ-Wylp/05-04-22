using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScore : MonoBehaviour
{
    public static int EnnemiTue;
    public static float Chronos;
    public static int Level;

    public void Start()
    {
        GameOverScore.EnnemiTue = 0;
        GameOverScore.Chronos = 0;
        GameOverScore.Level = 0;

    }

}
