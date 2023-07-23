using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private TurnScript _turnScript;

    private Roller _roller;
    // Start is called before the first frame update
    void Start()
    {
        _turnScript = GameObject.Find("TurnManager").GetComponent<TurnScript>();
        _roller = GameObject.Find("Roller").GetComponent<Roller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move() {
        Debug.Log("MOVE");
        GetComponent<Rigidbody>().AddForce(_roller.getLastRoll(),_roller.getLastRoll() , _roller.getLastRoll(), ForceMode.Impulse);

        if (_turnScript.getPlayerTurn() == 1)
        {
        }
    }
}
