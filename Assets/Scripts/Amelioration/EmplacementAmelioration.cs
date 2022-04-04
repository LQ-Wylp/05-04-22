using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmplacementAmelioration : MonoBehaviour
{
    public List<GameObject> _MesAmeliorations;

    public void Activated(int rand)
    {
        _MesAmeliorations[rand].SetActive(true);
    }

    public void CloseThis()
    {
        for(int i = 0; i < _MesAmeliorations.Count; i++)
        {
            _MesAmeliorations[i].SetActive(false);
        }
    }
}
