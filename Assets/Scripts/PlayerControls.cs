using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    [SerializeField] float controlSpeed = 28f;

    void Update()
    {
        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        // Change horizontal position
        float xOffSet = xThrow * Time.deltaTime * controlSpeed;
        float newXPos = transform.localPosition.x + xOffSet;

        // Change vertical position
        float yOffSet = yThrow * Time.deltaTime * controlSpeed;
        float newYPos = transform.localPosition.y + yOffSet;

        transform.localPosition = new Vector3(newXPos, newYPos, transform.localPosition.z);
    }

}
