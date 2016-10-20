using UnityEngine;
using System.Collections;

public class BallObjectAI : MonoBehaviour
{
	public Vector3 targetPosition;

	// Use this for initialization
	void Start ()
	{
		this.GetComponent<Rigidbody> ().AddForce (new Vector3 (100, 0, 0));
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	}
}
