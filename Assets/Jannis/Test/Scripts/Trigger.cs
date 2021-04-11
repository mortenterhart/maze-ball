using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    bool onOff = false;

    [SerializeField] GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Enter()
    {
        
        onOff = true;
    }

    public void Exit()
    {
        
        onOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!onOff && door.transform.position.y < 0.745f)
        {
            door.transform.Translate(Vector3.up * Time.deltaTime);

            if (door.transform.position.y > 0.75f)
            {
                //door.transform.position = transform.TransformDirection(-1.7f, 0.75f, -0.375f);
            }
        }
        else if (onOff && door.transform.position.y > 0f)
        {
            door.transform.Translate(Vector3.down * Time.deltaTime);

            //if (door.transform.position.y < 0f) door.transform.position = new Vector3(-1.7f, 0f, -0.375f);
        }
    }
}
