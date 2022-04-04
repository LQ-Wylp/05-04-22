using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsSauvegarder : MonoBehaviour
{
    public float CoutByAmelioration = 50;

    public static float HpPlayer = 0;
    public static int NbAmelioration_Hp = 0;
    public float CoefAugmentation_Hp = 0.1f;
    public TextMeshProUGUI textCoutHp;
    public TextMeshProUGUI textCoutHp_info;
    public void Upgrade_Hp()
    {
        if(ArgentDuCompte.Argents > (1+StatsSauvegarder.NbAmelioration_Hp) * 50)
        {
            ArgentDuCompte.Argents -= (1+StatsSauvegarder.NbAmelioration_Hp) * 50;
            StatsSauvegarder.NbAmelioration_Hp ++;
            StatsSauvegarder.HpPlayer = StatsSauvegarder.NbAmelioration_Hp * CoefAugmentation_Hp;
            textCoutHp.text = "" + (1+StatsSauvegarder.NbAmelioration_Hp) * 50;
            textCoutHp_info.text = "Bonus HP : " + StatsSauvegarder.HpPlayer *100 + "%";
        }
    }

    public static float DegatBonus = 0;
    public static int NbAmelioration_Degat = 0;
    public float CoefAugmentation_Degat = 0.1f;
    public TextMeshProUGUI textCoutDegat;
    public TextMeshProUGUI textCoutDegat_info;
    public void Upgrade_Degat()
    {
        if(ArgentDuCompte.Argents > (1+StatsSauvegarder.NbAmelioration_Degat) * 50)
        {
            ArgentDuCompte.Argents -= (1+StatsSauvegarder.NbAmelioration_Degat) * 50;
            StatsSauvegarder.NbAmelioration_Degat ++;
            StatsSauvegarder.DegatBonus = StatsSauvegarder.NbAmelioration_Degat * CoefAugmentation_Degat;
            textCoutDegat.text = "" + (1+StatsSauvegarder.NbAmelioration_Degat) * 50;
            textCoutDegat_info.text = "Bonus Dégat : " + StatsSauvegarder.DegatBonus *100 + "%";
        }
    }

    public static float BonusExp = 0;
    public static int NbAmelioration_Exp = 0;
    public float CoefAugmentation_Exp = 0.1f;
    public TextMeshProUGUI textCoutExp;
    public TextMeshProUGUI textCoutExp_info;
    public void Upgrade_Exp()
    {
        if(ArgentDuCompte.Argents > (1+StatsSauvegarder.NbAmelioration_Exp) * 50)
        {
            ArgentDuCompte.Argents -= (1+StatsSauvegarder.NbAmelioration_Exp) * 50;
            StatsSauvegarder.NbAmelioration_Exp ++;
            StatsSauvegarder.BonusExp = StatsSauvegarder.NbAmelioration_Exp * CoefAugmentation_Exp;
            textCoutExp.text = "" + (1+StatsSauvegarder.NbAmelioration_Exp) * 50;
            textCoutExp_info.text = "Bonus EXP : " + StatsSauvegarder.BonusExp *100 + "%";
        }
    }

    void Start()
    {
        textCoutHp.text = "" + (1+StatsSauvegarder.NbAmelioration_Hp) * 50;
        textCoutHp_info.text = "Bonus HP : " + StatsSauvegarder.HpPlayer *100 + "%";

        textCoutDegat.text = "" + (1+StatsSauvegarder.NbAmelioration_Degat) * 50;
        textCoutDegat_info.text = "Bonus Dégat : " + StatsSauvegarder.DegatBonus *100 + "%";

        textCoutExp.text = "" + (1+StatsSauvegarder.NbAmelioration_Exp) * 50;
        textCoutExp_info.text = "Bonus EXP : " + StatsSauvegarder.BonusExp *100 + "%";
    }
}
