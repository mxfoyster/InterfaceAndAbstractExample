using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TargetManager : MonoBehaviour
{

    public List<IMovingTarget> targets;
    public GameObject targetCoinMaster;
    public GameObject targetCubeMaster;
    public GameObject targetSphereMaster;
    private bool moveTargets;
    // Start is called before the first frame update
    void Start()
    {
        moveTargets = false;
        targets = new List<IMovingTarget>();
        GameObject targetCoin = GameObject.Instantiate(targetCoinMaster); //create it
        GameObject targetCube = GameObject.Instantiate(targetCubeMaster); //create it
        GameObject targetSphere = GameObject.Instantiate(targetSphereMaster);
        GameObject targetSphere2 = GameObject.Instantiate(targetSphereMaster);

        var ss = FindObjectsOfType<MonoBehaviour>().OfType<IMovingTarget>();
        foreach (IMovingTarget s in ss)
        {
            targets.Add(s);
        }
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (moveTargets)
            foreach (IMovingTarget target in targets)
            {
                target.move();
            }
        
    }
    public void OnClickMoveButton()
    {
        moveTargets = true;
    }

    public void OnClickStopButton()
    {
        moveTargets = false;
    }

}
