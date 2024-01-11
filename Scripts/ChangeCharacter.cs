using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter: MonoBehaviour
{

    public GameObject bodies1;
    public GameObject bodies2;
    public SpriteRenderer bodies1Renderer;
    public SpriteRenderer bodies2Renderer;

    public int bodiesNumber;
    
    void Start()
    {
        bodies1Renderer = bodies1.GetComponent<SpriteRenderer>();
        bodies2Renderer = bodies2.GetComponent<SpriteRenderer>();

        bodies1.GetComponent<MovementControll>().enabled = true;
        bodies2.GetComponent<MovementControll>().enabled = false;
        bodiesNumber = 1;

        bodies1Renderer.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (bodiesNumber == 1)
            {
                bodies1.GetComponent<MovementControll>().enabled = false;
                bodies2.GetComponent<MovementControll>().enabled = true;
                bodiesNumber = 2;
                bodies1Renderer.color = Color.white;
                bodies2Renderer.color = Color.black;
            }
            else
            {
                bodies1.GetComponent<MovementControll>().enabled = true;
                bodies2.GetComponent<MovementControll>().enabled = false;
                bodiesNumber = 1;
                bodies1Renderer.color = Color.black;
                bodies2Renderer.color = Color.white;
            }
        }
    }
}
