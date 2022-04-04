using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Monster;
    public List<Transform> SpawnPosition;
    public float IntervalSpawn;
    public int NbSpawnByInterval;
    private float Timer;

    public float TimeToMakeStronger = 5;
    public float CoefAugmentation = 1.1f;
    private float TimerStronger;
    public int NbAugmentation = 0;

    public int LimiteDeMonstre;
    public List<GameObject> AllMonsters;

    void Start()
    {
        Timer = IntervalSpawn;
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > IntervalSpawn)
        {
            Spawn();
            Timer = 0;
        }

        TimerStronger += Time.deltaTime;
        if(TimerStronger > TimeToMakeStronger)
        {
            IntervalSpawn /= CoefAugmentation;
            TimerStronger = 0;
            NbAugmentation++;
        }

    }

    public void Spawn()
    {
        for(int i = 0; i < AllMonsters.Count; i++)
        {
            if(AllMonsters[i] == null)
            {
                AllMonsters.Remove(AllMonsters[i]);
                i--;
            }
        }

        if(LimiteDeMonstre > AllMonsters.Count)
        {
            List<Transform> CopiePosition = new List<Transform>(SpawnPosition);

            for(int i = 0 ; i < NbSpawnByInterval; i++)
            {
                int rand = Random.Range(0, CopiePosition.Count);
                Transform PosSpawn = CopiePosition[rand];
                CopiePosition.RemoveAt(rand);

                
                int randMonster = Random.Range(0, Monster.Count); 
                GameObject InstantiateThis = Monster[randMonster];
                GameObject LastInstance = Instantiate(InstantiateThis, PosSpawn.position, Quaternion.identity);
                LastInstance.GetComponent<HpSystemMonster>().BonusDifficulter(NbAugmentation);

                AllMonsters.Add(LastInstance);
            }
        }

    }
}
