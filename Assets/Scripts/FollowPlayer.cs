using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	[SerializeField] private GameObject player;
	private Vector3 offset = new Vector3(0, 7, -10);
	
	// Start is called before the first frame update
	private void Start()
	{

	}

	// Update is called once per frame
	private void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}
