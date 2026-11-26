using UnityEngine;
using System.Collections;

public class TimerLogic : MonoBehaviour
{
    public Animation clock1;
    public Animation clock2;

    public Collider switchButton;

    void Start()
    {
        clock1.Play();
        clock2.Stop();
        //Collider.OnTriggerEnter

    }

    void switchClock()
    {
        if (clock1.isPlaying)
        {
            clock1.Stop();
            clock2.Play();
        }
        else
        {
            clock1.Play();
            clock2.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("A collider has entered the button trigger");
    }
}
