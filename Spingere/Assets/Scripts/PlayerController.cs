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
    


    private void FixedUpdate()
    {
        Vector3 movingPosition = new Vector3(mainSlider.value, 0, 50);
        transform.Translate(50 * Vector3.forward * Time.deltaTime);
        transform.Translate(new Vector3(mainSlider.value, 0, 0) * Time.deltaTime * 4);


    }





    
}
