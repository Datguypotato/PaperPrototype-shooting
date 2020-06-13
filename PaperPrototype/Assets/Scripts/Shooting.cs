using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            // direction is based on character scale
            // that is how they rotate the character
            Vector3 direction = Vector3.zero;

            if (transform.lossyScale.x > 0)
                direction = Vector3.right;
            else
                direction = Vector3.left;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 10f);

            if(hit.collider != null)
            {
                Debug.Log(hit.transform.name);
            }
        }

    }
}
