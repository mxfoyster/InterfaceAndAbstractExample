using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour, IMovingTarget
{
    [SerializeField] private GameObject cube;
    private Vector3 cubeCurrentPosition;
    private float degreeCounter;
    // Start is called before the first frame update
    void Start()
    {
        cubeCurrentPosition = cube.transform.position;
        degreeCounter = 0;
    }

 
    public void move()
    {
        if (degreeCounter < 360) degreeCounter += 0.05f;
        Vector3 cubeNewPosition = cubeCurrentPosition;
        cubeNewPosition.y += Mathf.Sin(degreeCounter);        
        cube.transform.position=(cubeNewPosition);
    }
}
