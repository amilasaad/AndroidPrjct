using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepy : MonoBehaviour
{
    public float movespeed = 2000f;
    public GameObject character;

    private Rigidbody charBD;
    private float screenwidth;
    // Start is called before the first frame update
    void Start()
    {
        screenwidth = Screen.width;
        charBD = character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > screenwidth / 2)
            {
                Run(1.0f);
            }
            else if (Input.GetTouch (i).position.x < screenwidth / 2)
            {
                Run(-1.0f);
            }

            i++;
        }
    }

    void FixedUpdate()
    {
        #if UNITY_EDITOR
        Run(Input.GetAxis("Horizontal"));
        #endif
    }

    private void Run(float horizontalInput)
    {
        charBD.AddForce(new Vector3(horizontalInput * movespeed * Time.deltaTime, 0));
    }
}
