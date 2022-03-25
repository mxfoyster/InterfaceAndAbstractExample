using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractTargetStuff : MonoBehaviour, IMovingTarget
{
    public Vector3 targetPosition;

    public virtual void Start()
    {
        float x = Random.Range(100f, 200f); // set random pos x
        float z = Random.Range(100f, 200f); //set random pos z
        float y = 1.5f;
        targetPosition.x = x;
        targetPosition.z = z;
        targetPosition.y = y;
    }

    public abstract void move(); 
   
}
