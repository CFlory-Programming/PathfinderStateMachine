using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewStateDemo : MonoBehaviour
{
    enum States
    {
        left = 0,
        left2,
        left3,
        right,
        right2,
        right3,
        right4,
        right5,
        right6,
        right7,
        right8,
        up,
        down,
        down2,
        down3,
    }
    [SerializeField]
    private float speed;
    States currentState;
    // Start is called before the first frame update
    void Start()
    {
        currentState = States.right;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.zero;
        switch (currentState)
        {
            case States.right:
                pos = new Vector3(-1.27f, 2.815f, 0);
                break;
            case States.down:
                pos = new Vector3(-1.27f, 1.71f, 0);
                break;
            case States.right2:
                pos = new Vector3(3.37f, 1.71f, 0);
                break;
            case States.up:
                pos = new Vector3(3.37f, 2.82f, 0);
                break;
            case States.right3:
                pos = new Vector3(5.61f, 2.82f, 0);
                break;
            case States.down2:
                pos = new Vector3(5.61f, 1.1f, 0);
                break;
            case States.left:
                pos = new Vector3(0.93f, -0.53f, 0);
                break;
            case States.left2:
                pos = new Vector3(-4.85f, 2f, 0);
                break;
            case States.down3:
                pos = new Vector3(-4.85f, -0.71f, 0);
                break;
            case States.right4:
                pos = new Vector3(-1.02f, -1.34f, 0);
                break;
            case States.left3:
                pos = new Vector3(-5.48f, -2.83f, 0);
                break;
            case States.right5:
                pos = new Vector3(-0.19f, -2.83f, 0);
                break;
            case States.right6:
                pos = new Vector3(2.84f, -0.86f, 0);
                break;
            case States.right7:
                pos = new Vector3(4.86f, -2.92f, 0);
                break;
            case States.right8:
                pos = new Vector3(5.91f, -2.92f, 0);
                break;
        }
        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        
        //check if we are at our target
        if (transform.position==pos)
        {
            switch (currentState)
            {
                case States.right:
                    currentState = States.down;
                    break;
                case States.down:
                    currentState = States.right2;
                    break;
                case States.right2:
                    currentState = States.up;
                    break;
                case States.up:
                    currentState = States.right3;
                    break;
                case States.right3:
                    currentState = States.down2;
                    break;
                case States.down2:
                    currentState = States.left;
                    break;
                case States.left:
                    currentState = States.left2;
                    break;
                case States.left2:
                    currentState = States.down3;
                    break;
                case States.down3:
                    currentState = States.right4;
                    break;
                case States.right4:
                    currentState = States.left3;
                    break;
                case States.left3:
                    currentState = States.right5;
                    break;
                case States.right5:
                    currentState = States.right6;
                    break;
                case States.right6:
                    currentState = States.right7;
                    break;
                case States.right7:
                    currentState = States.right8;
                    break;
            }
        }
    }
}