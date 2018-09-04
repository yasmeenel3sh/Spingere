using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    Rigidbody rigidMain;
    [SerializeField]
    Rigidbody rigidOther;
    [SerializeField]
    Slider mainSlider;
    [SerializeField]
    Slider otherSlider;
    [SerializeField]
    Button bumpButton;
    [SerializeField]
    Button escapeButton;


    bool inBattle;



    private void FixedUpdate()
    {
        transform.Translate(50 * Vector3.forward * Time.deltaTime);

        if (!inBattle)
        { 
        Vector3 movingPosition = new Vector3(mainSlider.value, 0, 0);
        transform.Translate(movingPosition * Time.deltaTime * 4);
        }



    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody == rigidOther)
        {
            inBattle = true;
            mainSlider.enabled = false;
            Handheld.Vibrate();
            
        }
    }






}
