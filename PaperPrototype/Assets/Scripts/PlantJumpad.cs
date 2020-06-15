using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantJumpad : MonoBehaviour
{
    public bool activated = false;
    public float jumpForce;

    public void ActivateJumpad()
    {
        // activate if shooter has high enough water energy
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("toched player");
            other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
        }
    }
}
