using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 30f;
    // public int roteteSpeed;

    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // transform.Rotate(x,y,z); Bu kod ile nesnemizi dondurebiliyoruz.
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }

    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        moveSpeed = slowSpeed;

    }



}
