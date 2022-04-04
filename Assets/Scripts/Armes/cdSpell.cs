using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cdSpell : MonoBehaviour
{
    public Image ImgCd;

    public void RefreshVisuel(float cbInitial, float cdEnCours)
    {
        ImgCd.fillAmount = 1 - (cdEnCours / cbInitial);// 1 = gris / 0 = blanc
    }
}
