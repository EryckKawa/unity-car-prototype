using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float movSpeed = 20;
	[SerializeField] private float turnSpeed;
	private float horizontalInput;
	private float verticalInput;
	// Start is called before the first frame update
	private void Start()
	{

	}

	// Update is called once per frame
	private void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
		//Move the vehicle forward
		transform.Translate(movSpeed * Time.deltaTime * verticalInput * Vector3.forward);
		transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * Vector3.up);
	}
}
