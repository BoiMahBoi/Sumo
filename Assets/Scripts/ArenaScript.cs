using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaScript : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Vi finder objektet i scenen med navnet "GameManager", og f�r GameManager komponentet p� det. Vi bruger s� GameOver metoden p� GameManager scriptet, og bruger nummeret p� spilleren som vi kolliderede med som parameter.
            GameObject.Find("GameManager").GetComponent<GameManager>().GameOver(collision.gameObject.GetComponent<MovementScript>().playerNumber);
        }
    }

}
