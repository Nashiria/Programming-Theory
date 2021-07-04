using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leopard : Animal // INHERITANCE
{
    private float speed=2f;
    private void FixedUpdate(){
        Move(speed);
    }
}
