using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luckScript : MonoBehaviour
{
    private Animator animator;
    private bool doorOpen;
    private int counter = 1;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(counter==1)
            {
                luckControll("luck1");
                counter++;
            }else
            if (counter == 2)
            {
                luckControll("luck2");
                counter++;
            }
            else
            if (counter == 3)
            {
                luckControll("luck3");
                counter++;
            }
            else
            if (counter == 4)
            {
                luckControll("luck4");
                counter++;
            }
            else
            if (counter == 5)
            {
                luckControll("luck5");
                counter++;
            }
            else
            if (counter == 6)
            {
                luckControll("luck6");
                counter=1;
            }
        }
    }



    private void luckControll(string v)
    {
        animator.SetTrigger(v);
    }
}
