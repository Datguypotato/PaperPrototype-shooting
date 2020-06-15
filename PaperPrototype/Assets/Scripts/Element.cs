using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public GameObject fireParticle;

    public GameObject vineObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            StartCoroutine(burnDown());
    }

    IEnumerator burnDown()
    {
        fireParticle.SetActive(true);

        yield return new WaitForSeconds(2);

        fireParticle.SetActive(false);
        vineObject.SetActive(false);
    }
}