using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;

public class Player1Controller : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("onCollision");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Secret Number = " + MySingleton.secretnumber);
        MySingleton.secretnumber = 5;
        EditorSceneManager.LoadScene("Scene2");
    }


    private void Update()
    {
      
    }
}
