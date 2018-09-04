using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    [SerializeField]
    private PlayerController _bluePlayer;
    [SerializeField]
    private PlayerController _redPlayer;
    private float timerLimit = 1f;
    private float timer = 0;
	// Use this for initialization
	void Start () {
        //gets the playercontroller script from players
        _bluePlayer = GameObject.Find("BluePlayer").GetComponent<PlayerController>();
        _redPlayer = GameObject.Find("RedPlayer").GetComponent<PlayerController>();

	}
	
	// Update is called once per frame
	void Update () {
        Engage();
		
	}
    void Engage()
    {
        if (_bluePlayer.inBattle && _redPlayer.inBattle)
        {
            

            if (timer < timerLimit)
            {
                timer += Time.deltaTime;
            }
            else
            {
                int bluePlayerTappings = this._bluePlayer.getTappings();
                int redPlayerTappings = this._redPlayer.getTappings();
                if (bluePlayerTappings > redPlayerTappings)
                {
                    _bluePlayer.Push();
                }
                else if(redPlayerTappings > bluePlayerTappings)
                {
                    _redPlayer.Push();
                }
                _redPlayer.resetTappings();
                _bluePlayer.resetTappings();
                timer = 0;
            }
        }
    }
}
