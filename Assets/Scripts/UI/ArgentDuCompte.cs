using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArgentDuCompte : MonoBehaviour
{
    public static int Argents;
    public TextMeshProUGUI TextArgent;

    void Update()
    {
        TextArgent.text = ": " + Argents;
    }
}
