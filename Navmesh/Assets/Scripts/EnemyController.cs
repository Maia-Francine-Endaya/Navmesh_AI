using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
  public NavMeshAgent enemy;
  public Transform Player;

  void Update()
  {
    enemy.SetDestination(Player.position);
  }
}
