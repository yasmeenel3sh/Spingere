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

    private int tapCounter;
    public bool inBattle;

    private void Start()
    {
        inBattle = false;
        tapCounter = 0;
        bumpButton.gameObject.SetActive(false);
        bumpButton.onClick.AddListener(countTappings);
        escapeButton.gameObject.SetActive(false);
        escapeButton.onClick.AddListener(endBattle);

    }

    private void Update()
    {
        Movement();
        if(inBattle)
        Debug.Log(this.gameObject.tag + " " + this.tapCounter);
    }
     

    void Movement()
    {
        transform.Translate(50f * Vector3.forward * Time.deltaTime);


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

            // mainSlider.enabled = false;
            mainSlider.gameObject.SetActive(false);
            bumpButton.gameObject.SetActive(true);
            escapeButton.gameObject.SetActive(true);

            Handheld.Vibrate();
            
        }
    }
    
    public void Push()
    {
        if (inBattle)
        {

        }
    }
    void countTappings()
    {
        if (inBattle)
        {
            this.tapCounter++;
        }
        
    }
    public int getTappings()
    {
        return this.tapCounter;
    }
    public void resetTappings()
    {
        this.tapCounter = 0;
    }

    void endBattle()
    {
        this.inBattle = false;
        this.tapCounter = 0;
        mainSlider.gameObject.SetActive(true);
        bumpButton.gameObject.SetActive(false);
        escapeButton.gameObject.SetActive(false);
    }



}
