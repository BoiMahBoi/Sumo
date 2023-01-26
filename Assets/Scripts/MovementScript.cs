using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    public int playerNumber;

    // Vi bruger fixed update, så hastigheden af spilleren ikke afhænger af hvor mange FPS spillet kører med.
    void FixedUpdate()
    {
        //Vi bruger Unitys Input Manager axis "Horizontal" og "Vertical" plus spillerens nr, da vi har oprettet disse axis på forhånd.
        float inputX = Input.GetAxisRaw("Horizontal" + playerNumber);
        float inputY = Input.GetAxisRaw("Vertical" + playerNumber);
        movement = new Vector2(inputX, inputY);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}