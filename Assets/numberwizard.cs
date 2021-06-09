using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberwizard : MonoBehaviour
{       int max = 1000;
        int min = 1;
        int guess=500;
    // Start is called before the first frame update
    void Start()
    {
      
        Debug.Log("welcome to my number wizard !");
        Debug.Log("please think of a number and don't say it to anyone");
        Debug.Log("the highest you can pick is "+max);
        Debug.Log("the lowest you can pick is "+min);
        Debug.Log("if your number is higher than 500 press up if lower press down if equal press Y");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up key was pressed ");
            guess = (min + max) / 2;
            Debug.Log("is it higher or lower than"+guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down key was pressed ");
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("is it higher or lower than" + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("we got it ! ");
            Start();

        }
    }
}
