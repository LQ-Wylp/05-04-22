using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAmelioration : MonoBehaviour
{
    public List<EmplacementAmelioration> _MesEmplacementsAmeliorations;
    public List<int> _Rands;

    public void LevelUp()
    {
        gameObject.SetActive(true);
        _Rands.Clear();
        for(int i = 0; i < _MesEmplacementsAmeliorations.Count; i++)
        {
            bool accepted = false;
            int rand = 0;
            while(accepted == false)
            {
                accepted = true;
                rand = Random.Range(0, _MesEmplacementsAmeliorations[i]._MesAmeliorations.Count);
                for(int j = 0; j < _Rands.Count; j++)
                {
                    if(rand == _Rands[j])
                    {
                        accepted = false;
                    }
                }
            }
            _Rands.Add(rand);
            _MesEmplacementsAmeliorations[i].Activated(rand);
        }
        Time.timeScale = 0;
    }

    public void CloseAll()
    {
        for(int i = 0; i < _MesEmplacementsAmeliorations.Count; i++)
        {
            _MesEmplacementsAmeliorations[i].CloseThis();
        }
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
