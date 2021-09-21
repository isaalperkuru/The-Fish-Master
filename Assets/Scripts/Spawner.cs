using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Fish fishPrefab;
    [SerializeField] private Fish.FishType[] types;
    void Awake()
    {
        for (int i = 0; i < types.Length; i++)
        {
            int num = 0;
            while(num < types[i].fishCount)
            {
                Fish fish = UnityEngine.Object.Instantiate<Fish>(fishPrefab);
                fish.Type = types[i];
                fish.ResetFish();
                num++;
            }
        }
    }
}
