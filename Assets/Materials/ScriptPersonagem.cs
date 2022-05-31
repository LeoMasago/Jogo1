using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPersonagem : MonoBehaviour
{
    public Vector3 mov; 

    // Start is called before the first frame update
    void Start()
    {
Debug.Log("inicio");
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
        {
       
            mov.x = 0.0f;
            mov.y = 0.0f;
            mov.z = -0.1f;

            transform.Translate(mov); 
            Debug.Log(" -1 x");

        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            mov.x = 0.0f;
            mov.y = 0.0f;
            mov.z = 0.1f;

            transform.Translate(mov);
             Debug.Log(" 1 x");
        }

         if(Input.GetKey(KeyCode.UpArrow))
        {
            mov.x = 0.0f;
            mov.y = 0.1f;
            mov.z = 0.0f;

            transform.Translate(mov);
             Debug.Log(" 1 y");
        }

    }
}
