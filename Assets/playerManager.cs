using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;


public class playerManager : MonoBehaviour
{

    public GameObject ParticleSystem1;
    public GameObject ParticleSystem2;
    public GameObject ParticleSystem3;
    public GameObject ParticleSystem4;
    public GameObject ParticleSystem5;

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        
    if (Input.GetKeyDown(KeyCode.Space)) {
        ParticleSystem1.SetActive(true);
        }
 
    else if (Input.GetKeyUp(KeyCode.Space)) {
        ParticleSystem1.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.A)) {
        ParticleSystem2.SetActive(true);
        }
 
    else if (Input.GetKeyUp(KeyCode.A)) {
        ParticleSystem2.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.S)) {
        ParticleSystem3.SetActive(true);
        }
 
    else if (Input.GetKeyUp(KeyCode.S)) {
        ParticleSystem3.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.D)) {
        ParticleSystem4.SetActive(true);
        }
 
    else if (Input.GetKeyUp(KeyCode.D)) {
        ParticleSystem4.SetActive(false);
    }

    if (Input.GetKeyDown(KeyCode.F)) {
        ParticleSystem5.SetActive(true);
        }
 
    else if (Input.GetKeyUp(KeyCode.F)) {
        ParticleSystem5.SetActive(false);
    }

    }


}
