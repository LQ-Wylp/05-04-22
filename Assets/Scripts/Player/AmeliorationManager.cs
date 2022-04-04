using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeliorationManager : MonoBehaviour
{
    public static AmeliorationManager _AmeliorationManager;

    void Awake()
    {
        if(AmeliorationManager._AmeliorationManager == null)
        {
            _AmeliorationManager = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        // ARME 1
        Arm1_Dommage = Arm1_Dommage_Initial;
        Arm1_Frequence = Arm1_Frequence_Initial;

        _Bullet1.Dammage = Arm1_Dommage;
        _Arme1.FrequenceTir = Arm1_Frequence;

        // ARME 2
        Arm2_Dommage = Arm2_Dommage_Initial;
        Arm2_Frequence = Arm2_Frequence_Initial;

        _Bullet2.Dammage = Arm2_Dommage;
        _Arme2.FrequenceTir = Arm2_Frequence;

        // ARME 3
        Arm3_Dommage = Arm3_Dommage_Initial;
        Arm3_Frequence = Arm3_Frequence_Initial;
        Arm3_Scale = Arm3_Scale_Initial;

        _Bullet3.Dammage = Arm3_Dommage;
        _Arme3.FrequenceTir = Arm3_Frequence;
        _Bullet3.TauxScale = Arm3_Scale;
    }

    [Header("Arme : 1")]
    public Arme_1 _Arme1;
    public Bullet_1 _Bullet1;

    private float Arm1_Dommage;
    public float Arm1_Dommage_Initial = 5;
    public float Arm1_Dommage_Up = 3;
    private int Arm1_Dommage_Nb_Upgrade = 0;

    private float Arm1_Frequence;
    public float Arm1_Frequence_Initial = 0.75f;
    public float Arm1_Frequence_Up = 1.35f;
    private int Arm1_Frequence_Nb_Upgrade = 0;

    public void Upgrade_Arm1_Dommage(){Arm1_Dommage_Nb_Upgrade ++; Arm1_Dommage = Arm1_Dommage_Initial + Arm1_Dommage_Up * Arm1_Dommage_Nb_Upgrade; _Bullet1.Dammage = Arm1_Dommage;}
    public void Upgrade_Arm1_Frequence(){Arm1_Frequence_Nb_Upgrade ++; Arm1_Frequence = Arm1_Frequence_Initial / (Arm1_Frequence_Up * Arm1_Frequence_Nb_Upgrade); _Arme1.FrequenceTir = Arm1_Frequence;}


    [Header("Arme : 2")]
    public Arme_2 _Arme2;
    public Bullet_2 _Bullet2;

    private float Arm2_Dommage = 15;
    public float Arm2_Dommage_Initial = 15;
    public float Arm2_Dommage_Up = 4;
    private int Arm2_Dommage_Nb_Upgrade = 0;
    


    private float Arm2_Frequence;
    public float Arm2_Frequence_Initial = 6;
    public float Arm2_Frequence_Up = 1.2f;
    private int Arm2_Frequence_Nb_Upgrade = 0;

    public void Upgrade_Arm2_Dommage(){Arm2_Dommage_Nb_Upgrade ++; Arm2_Dommage = Arm2_Dommage_Initial + Arm2_Dommage_Up * Arm2_Dommage_Nb_Upgrade; _Bullet2.Dammage = Arm2_Dommage;}
    public void Upgrade_Arm2_Frequence(){Arm2_Frequence_Nb_Upgrade ++; Arm2_Frequence = Arm2_Frequence_Initial / (Arm2_Frequence_Up * Arm2_Frequence_Nb_Upgrade); _Arme2.FrequenceTir = Arm2_Frequence;}


    [Header("Arme : 3")]
    public Arme_3 _Arme3;
    public Bullet_3 _Bullet3;

    private float Arm3_Dommage;
    public float Arm3_Dommage_Initial = 7;
    public float Arm3_Dommage_Up = 2f;
    private int Arm3_Dommage_Nb_Upgrade = 0;
    

    private float Arm3_Frequence;
    public float Arm3_Frequence_Initial = 5;
    public float Arm3_Frequence_Up = 1.3f;
    private int Arm3_Frequence_Nb_Upgrade = 0;

    private float Arm3_Scale = 5;
    public float Arm3_Scale_Initial = 5;
    public float Arm3_Scale_Up = 5;
    private int Arm3_Scale_Nb_Upgrade = 0;

    public void Upgrade_Arm3_Dommage(){Arm3_Dommage_Nb_Upgrade ++; Arm3_Dommage = Arm3_Dommage_Initial + Arm3_Dommage_Up * Arm3_Dommage_Nb_Upgrade; _Bullet3.Dammage = Arm3_Dommage;}
    public void Upgrade_Arm3_Frequence(){Arm3_Frequence_Nb_Upgrade ++; Arm3_Frequence = Arm3_Frequence_Initial / (Arm3_Frequence_Up * Arm3_Frequence_Nb_Upgrade); _Arme3.FrequenceTir = Arm3_Frequence;}
    public void Upgrade_Arm3_Scale(){Arm3_Scale_Nb_Upgrade ++; Arm3_Scale = Arm3_Scale_Initial + Arm3_Scale_Up * Arm3_Scale_Nb_Upgrade; _Bullet3.TauxScale = Arm3_Scale;}

    [Header("Arme : 3")]
    public Arme_4 _Arme4;
    public Bullet_4 _Bullet4;

    private float Arm4_Dommage;
    public float Arm4_Dommage_Initial = 40;
    public float Arm4_Dommage_Up = 5f;
    private int Arm4_Dommage_Nb_Upgrade = 0;
    

    private float Arm4_Frequence;
    public float Arm4_Frequence_Initial = 2.5f;
    public float Arm4_Frequence_Up = 1.3f;
    private int Arm4_Frequence_Nb_Upgrade = 0;

    public void Upgrade_Arm4_Dommage(){Arm4_Dommage_Nb_Upgrade ++; Arm4_Dommage = Arm4_Dommage_Initial + Arm4_Dommage_Up * Arm4_Dommage_Nb_Upgrade; _Bullet4.Dammage = Arm4_Dommage;}
    public void Upgrade_Arm4_Frequence(){Arm4_Frequence_Nb_Upgrade ++; Arm4_Frequence = Arm4_Frequence_Initial / (Arm4_Frequence_Up * Arm4_Frequence_Nb_Upgrade); _Arme4.FrequenceTir = Arm4_Frequence;}
}
