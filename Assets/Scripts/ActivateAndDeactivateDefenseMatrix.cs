using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDeactivateDefenseMatrix : MonoBehaviour
{
    public GameObject DefenseMatrix;
    public GameObject DefenseMatrixImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            DefenseMatrix.SetActive(true);
            Debug.Log("DefenseMatrix is on!.");
            DefenseMatrixImage.SetActive(true); // defese matrix image
        }
        else
        {
            DefenseMatrix.SetActive(false);

            DefenseMatrixImage.SetActive(false);

            Debug.Log("DefenseMatrix is on!.");
        }
          
    }
}
