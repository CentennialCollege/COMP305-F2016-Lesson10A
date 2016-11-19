using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (this.player.position);
	}
}
