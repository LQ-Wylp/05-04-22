using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class ExpPlayer : MonoBehaviour
{
    public int _Level;
    private float _ExpLevelCurrent;
    public float _NbExpForLevelUp;
    public float _CoefExpByLevel;

    public UnityEvent _LevelUp;

    public TextMeshProUGUI _LevelText;
    public Slider _JaugeExp;

    public AudioSource Xpsound;

    void Start()
    {
        _JaugeExp.value = _ExpLevelCurrent / _NbExpForLevelUp;
        _LevelText.text = "Level : " + _Level;
    }
    public void TakeExp(int exp)
    {
        Xpsound.Play();
        _ExpLevelCurrent += exp + exp * StatsSauvegarder.BonusExp;
        if(_ExpLevelCurrent >= _NbExpForLevelUp)
        {
            GameOverScore.Level ++;
            _ExpLevelCurrent -= _NbExpForLevelUp;
            LevelUp();

            _NbExpForLevelUp *= _CoefExpByLevel;
        }

        _JaugeExp.value = _ExpLevelCurrent / _NbExpForLevelUp;
    }

    public void LevelUp()
    {
        _Level ++;
        _LevelText.text = "Level : " + _Level;
        _LevelUp.Invoke();
    }
}
