using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    Rigidbody rigidMain;
    [SerializeField]
    public Slider mainSlider;
    [SerializeField]
    public Slider otherSlider;
    // Use this for initialization
    void Start () {
        rigidMain = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
        
        
		
	}


    private void FixedUpdate()
    {
        Vector3 movingPosition = new Vector3(mainSlider.value, 0, 50);
        transform.Translate(50 * Vector3.forward * Time.deltaTime);
        transform.Translate(new Vector3(mainSlider.value, 0, 0) * Time.deltaTime * 4);


    }





    public void OnSliderChanger(float SteeringValue)
    {
      
       // transform.position = new Vector3(SteeringValue, transform.position.y, transform.position.z);
       

    }
}
