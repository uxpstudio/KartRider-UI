using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {

	public GameObject CardboardReticle; // Google Cardboard SDK: CardboardReticle / CardboardReticle from CardboardMain Prefab UI folder
	private Vector3 goal;
	private NavMeshAgent agent;
	
	void Start() {
		this.agent = GetComponent<NavMeshAgent>();
		this.goal = new Vector3(0f, 0f, 0f);
	}
	
	//Set navigation destination to the position of the cursor
	//Ex. Call this from an event trigger on the floor object
	public void SetDestinationToCursor() {
		this.goal = CardboardReticle.transform.position;
		MoveToDestination();
	}

	void MoveToDestination(){
		this.agent.destination = goal;
	}
}