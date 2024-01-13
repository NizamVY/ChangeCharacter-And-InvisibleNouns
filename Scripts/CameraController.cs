using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public ChangeCharacter ccNumber;
    public int number;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        number = ccNumber.bodiesNumber;
        if (number == 1)
        { 
            gameObject.transform.position = new Vector3(ccNumber.bodies1.transform.position.x, ccNumber.bodies1.transform.position.y,-10);
        }
        else if (number == 2) 
        {
            gameObject.transform.position = new Vector3(ccNumber.bodies2.transform.position.x, ccNumber.bodies1.transform.position.y, -10);
        }
    }
}
