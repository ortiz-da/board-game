using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{

    private int numPlayers = 2;
    private int playerTurn = 1;

    private int numTurnsPlayed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextTurn()
    {
        if (playerTurn >= numPlayers)
        {
            playerTurn = 1;
        }
        else
        {
            playerTurn++;
        }
    }

    public int getPlayerTurn()
    {
        return playerTurn;
    }
    
}
