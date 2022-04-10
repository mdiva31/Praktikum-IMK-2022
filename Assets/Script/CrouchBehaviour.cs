using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchBehaviour : MonoBehaviour
{
    private CapsuleCollider playerCol;
    private float originalHeight;
    public float reducedHeight;
    
    // Start is called before the first frame update
    void Start()
    {
        playerCol = GetComponent<CapsuleCollider>();
        originalHeight = playerCol.height;
    }

    // Update is called once per frame
    void Update()
    {
        //Crouch;
        if(Input.GetKeyDown(KeyCode.LeftControl))
            Crouch();
        else if(Input.GetKeyUp(KeyCode.LeftControl))
            GoUp();
    }

    void Crouch()
    {
        playerCol.height = reducedHeight;
    }
    
    void GoUp()
    {
        playerCol.height = originalHeight;
    }
}
