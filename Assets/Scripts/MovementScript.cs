using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    public int playerNumber;

    // Vi bruger fixed update, s� hastigheden af spilleren ikke afh�nger af hvor mange FPS spillet k�rer med.
    void FixedUpdate()
    {
        //Vi bruger Unitys Input Manager axis "Horizontal" og "Vertical" plus spillerens nr, da vi har oprettet disse axis p� forh�nd.
        float inputX = Input.GetAxisRaw("Horizontal" + playerNumber);
        float inputY = Input.GetAxisRaw("Vertical" + playerNumber);
        movement = new Vector2(inputX, inputY);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}