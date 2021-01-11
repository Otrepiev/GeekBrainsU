using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy; 
    [SerializeField] private Transform _enemySpawnPlace;
    [SerializeField] private int _spawnDelay;
    [SerializeField] private int _spawnDelayClone;
    
    private void Start()
    {
        var Delay = _spawnDelay;
    }

    private void FixedUpdate()
    {
        if(Time.time >= _spawnDelay)
        {
            Instantiate(_enemy, _enemySpawnPlace.position, _enemySpawnPlace.rotation);
            Repeat();
        }
        
    }

    private void Repeat()
    {
        _spawnDelay += _spawnDelayClone;
        
    }
}