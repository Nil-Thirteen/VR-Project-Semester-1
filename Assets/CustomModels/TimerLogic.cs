using UnityEngine;

public class TimerLogic : MonoBehaviour
{
    public Animation clock1;
    public Animation clock2;

    public Collider switchButton;

    void Start()
    {
        clock1.Play();
        clock2.Stop();
        //switchButton.

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
}
