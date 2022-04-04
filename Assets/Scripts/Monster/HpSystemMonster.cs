using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HpSystemMonster : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    public float BonusHpByUpgradeDifficulte;

    public GameObject Exp;
    public GameObject Aimant;
    public GameObject Heal;


    private bool Afficher;
    public float DurationAffichage;
    private float timer;
    public GameObject Canvas;
    public TextMeshProUGUI textAffichage;
    private string ShowThat;
    

    // Start is called before the first frame update
    void Start()
    {
        HealthRemaning = MaxHealth;
    }

    public void TakeDammage(float dommage)
    {
        HealthRemaning -= dommage + dommage * StatsSauvegarder.DegatBonus;
        ShowDommage(dommage + dommage * StatsSauvegarder.DegatBonus);

        if(HealthRemaning <= 0)
        {
            Instantiate(Exp, transform.position, Quaternion.identity);

            int rand = Random.Range(0,100);
            if(rand == 15)
            {
                Instantiate(Aimant, transform.position, Quaternion.identity);
            }
            if(rand < 2)
            {
                Instantiate(Heal, transform.position, Quaternion.identity);
            }
            ArgentDuCompte.Argents ++;
            GameOverScore.EnnemiTue ++;
            Destroy(gameObject);
        }
    }

    public void BonusDifficulter(int NbAugmentation)
    {
        HealthRemaning += NbAugmentation * BonusHpByUpgradeDifficulte;
        MaxHealth += NbAugmentation * BonusHpByUpgradeDifficulte;
    }

    public void ShowDommage(float Dommage)
    {
        ShowThat = Dommage.ToString("0");
        Afficher = true;
        timer = 0;
    }

    void Update()
    {
        if(Afficher)
        {
            timer += Time.deltaTime;
            Canvas.SetActive(true);
            textAffichage.text = ShowThat;
            if(timer > DurationAffichage)
            {
                timer = 0;
                Afficher = false;
                Canvas.SetActive(false);
            }
        }
    }
}
