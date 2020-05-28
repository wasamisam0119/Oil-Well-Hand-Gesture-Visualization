using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Space rotationSpace;

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.R))
        transform.Rotate(new Vector3(0,10,0),rotationSpace);
        
    }
}
