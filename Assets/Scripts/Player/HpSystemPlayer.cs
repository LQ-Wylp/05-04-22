using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpSystemPlayer : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    public Slider _JaugeHP;

    public AudioSource AudioHeal;

    public AudioSource DamageAudio;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth += MaxHealth * StatsSauvegarder.HpPlayer;
        HealthRemaning = MaxHealth;
        _JaugeHP.value = HealthRemaning / MaxHealth;
    }

    public void TakeDammage(float dommage)
    {
        DamageAudio.Play();
        HealthRemaning -= dommage;
        
        if(HealthRemaning <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        _JaugeHP.value = HealthRemaning / MaxHealth;
    }

    public void HealPlayer(float value)
    {
        AudioHeal.Play();
        HealthRemaning += value;
        if(HealthRemaning > MaxHealth)
        {
            HealthRemaning = MaxHealth;
        }
        _JaugeHP.value = HealthRemaning / MaxHealth;
    }
}
