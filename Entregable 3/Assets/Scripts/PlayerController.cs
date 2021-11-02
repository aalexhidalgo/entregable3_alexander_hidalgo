using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void Scale(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += 2 * axis;
        }
    }

    public void Rotation(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Scale(KeyCode.W, Vector3.one);
        Rotation(KeyCode.R, new Vector3(45, 0, 45));
    }
}
