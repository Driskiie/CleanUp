using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class CeilingFan : MonoBehaviour
{

    public GameObject CeilingFanBlades;
    public float accleration = 10f;
    public float deaccleration = -50f;
    public float currentSpeed= 0;
    public float maxSpeed;
    private bool isOn = false;


    void Update()
    {
        if (isOn)
        {
            currentSpeed += accleration * Time.deltaTime;
            if (currentSpeed > maxSpeed)
            {


                currentSpeed = maxSpeed;
            }
        }
        else
        {




            currentSpeed -= deaccleration * Time.deltaTime;
            if (currentSpeed < 0)
            {

                currentSpeed = 0;

            }


        }

        CeilingFanBlades.transform.Rotate(Vector3.up, currentSpeed * Time.deltaTime);
    }

   public void toggleFan()
    {

        isOn = !isOn;


    }


}
