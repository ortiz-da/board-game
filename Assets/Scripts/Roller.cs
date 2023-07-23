using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Roller : MonoBehaviour
{
    
    public Image dieImage;


    private int _lastRoll = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        dieImage = GameObject.Find("RollResult").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField]
    private Sprite[] diceSprites = new Sprite[6];


    public void Test()
    {
        Debug.Log("TESTING");
    }

    public void Roll() {
    
        _lastRoll = Random.Range(1, 7);
        dieImage.overrideSprite = diceSprites[_lastRoll-1];

    }

    public int getLastRoll()
    {
        return _lastRoll;
    }
}
