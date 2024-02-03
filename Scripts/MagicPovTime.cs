using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicPovTime : MonoBehaviour
{

    public MovementControll lMC;
    public Image healthbarBg;
    public Image healthbar;
    public float visionTime;
    public float visionTimeValue;

    void Start()
    {
        lMC=gameObject.GetComponent<MovementControll>();
        visionTime = visionTimeValue;
    }

    // Update is called once per frame
    void Update()
    {

        if (lMC.enabled)
        {
            healthbarBg.enabled = true;
            healthbar.enabled = true;
            visionTime -= Time.deltaTime;
            healthbar.fillAmount = visionTime / visionTimeValue;
        }
        else
        {
            //visionTime = visionTimeValue;
            if (visionTime <= visionTimeValue)
            {
                visionTime += Time.deltaTime;
                healthbar.fillAmount = visionTime / visionTimeValue;
            }
     }
    }
}
