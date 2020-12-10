using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Player.position, enemy.transform.position) < 50)
        {
            enemy.SetDestination(Player.position);
        } else
        {
            enemy.SetDestination(enemy.transform.position);
        }
        
    }
}
