using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class agentmove : MonoBehaviour
{

    public float thrust = 1.0f;
    Rigidbody rb;

    void Start()
    // Start is called before the first frame update
    {
    	rb = GetComponent<Rigidbody>();
	
    }

    void Update(){
    	if(Input.GetKey(KeyCode.W)){
		Vector3 move = new Vector3(0, 0, 1) * thrust *Time.deltaTime;
        	rb.MovePosition(transform.position + move);
    	}
	if(Input.GetKey(KeyCode.S)){
		Vector3 move = new Vector3(0, 0, -1) * thrust *Time.deltaTime;
       		rb.MovePosition(transform.position + move);
    	}
	if(Input.GetKey(KeyCode.A)){
		Vector3 move = new Vector3(-1, 0, 0) * thrust *Time.deltaTime;
        	rb.MovePosition(transform.position + move);
    	}
	if(Input.GetKey(KeyCode.D)){
		Vector3 move = new Vector3(1, 0, 0) * thrust *Time.deltaTime;
        	rb.MovePosition(transform.position + move);
    	}

	if(transform.position.y < 0){
		rb.velocity = new Vector3(0f,0f,0f); 
     		rb.angularVelocity = new Vector3(0f,0f,0f);
     		transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
		rb.MovePosition(new Vector3(0,0.5f,0));
	}
    }    

}
