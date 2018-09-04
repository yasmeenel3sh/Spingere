using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField]
    Transform BluePlayer;
    [SerializeField]
    Transform RedPlayer;


    public float smoothSpeed = 0.125f;
    public Vector3 offset;
	
	void LateUpdate ()
    {
        transform.Translate(50 * new Vector3(transform.position.x,transform.position.y,1) * Time.deltaTime);

    }
}
