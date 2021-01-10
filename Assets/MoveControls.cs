using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveControls : MonoBehaviour
{
    public MyButton rightButton;
    public MyButton leftButton;
    public MyButton downButton;
    public MyButton upButton;

    public MyButton rotateRightButton;
    public MyButton rotateLeftButton;
    public MyButton rotateDownButton;
    public MyButton rotateUpButton;

    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rightButton.buttonPressed)
        {
            mainCamera.transform.Translate(new Vector3(0.1f, 0.0f, 0.0f));
        }
        if (leftButton.buttonPressed)
        {
            mainCamera.transform.Translate(new Vector3(-0.1f, 0.0f, 0.0f));
        }
        if (downButton.buttonPressed)
        {
            mainCamera.transform.Translate(new Vector3(0.0f, -0.1f, 0.0f));
        }
        if (upButton.buttonPressed)
        {
            mainCamera.transform.Translate(new Vector3(0.0f, 0.1f, 0.0f));
        }

        if (rotateRightButton.buttonPressed)
        {
            mainCamera.transform.Rotate(new Vector3(0f, 1f, 0.0f));
        }
        if (rotateLeftButton.buttonPressed)
        {
            mainCamera.transform.Rotate(new Vector3(0f, -1f, 0.0f));
        }
        if (rotateUpButton.buttonPressed)
        {
            mainCamera.transform.Rotate(new Vector3(-1f, 0f, 0.0f));
        }
        if (rotateDownButton.buttonPressed)
        {
            mainCamera.transform.Rotate(new Vector3(1f, 0f, 0.0f));
        }
    }
}
