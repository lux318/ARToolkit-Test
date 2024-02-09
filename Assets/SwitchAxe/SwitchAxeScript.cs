using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAxeScript : MonoBehaviour
{
   public Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bool currentState = anim1.GetBool("Touched");

            anim1.SetBool("Touched", !currentState);
        }
    }
}
