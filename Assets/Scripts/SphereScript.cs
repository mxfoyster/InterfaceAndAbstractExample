using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour, IMovingTarget
{

    [SerializeField] private GameObject sphere;
    private Vector3 sphereCurrentPosition;
    private float degreeCounter;

    // Start is called before the first frame update
    void Start()
    {
        sphereCurrentPosition = sphere.transform.position;
        degreeCounter = 0;
    }
    
    public void move()
    {
        if (degreeCounter < 360) degreeCounter += 0.05f;
        Vector3 sphereNewPosition = sphereCurrentPosition;
        sphereNewPosition.z += Mathf.Sin(degreeCounter);
        sphereNewPosition.x += Mathf.Cos(degreeCounter);
        sphere.transform.position = (sphereNewPosition);
    }
}
