using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal // INHERITANCE
{
    private float rotateSpeed=5f;
    private float speed=1f;
    private void FixedUpdate(){
        Move(flySpeed,rotateSpeed);
    }
    public float flySpeed // ENCAPSULATION
{
    get { return flySpeed; } 
    set { flySpeed = value; } 
}

}
