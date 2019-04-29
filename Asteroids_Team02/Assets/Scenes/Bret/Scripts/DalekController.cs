﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DalekController : MonoBehaviour
{
    [SerializeField]
    //Transform player;
    NavMeshAgent dalek;

    void Start()
    {
        dalek = this.GetComponent<NavMeshAgent>();
        
    }

    public void SetDestination(Vector3 target)
    {
        
        dalek.SetDestination(target);
    }
}