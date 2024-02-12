using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Player1Controller : MonoBehaviour
{
    private Player thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    public float speed = 1.0f; //NEW CODE

    void Start()
    {
        this.thePlayer = new Player("Cole");
        tm.text = this.thePlayer.getName() + "->" + this.thePlayer.getHP();
    }

    private void Update()
    {
        this.thePlayer.display();
        //NEW CODE**
        //print(Vector3.Distance(this.gameObject.transform.position != this.destinationGO.transform.position));
        if (Vector3.Distance(this.gameObject.transform.position, this.destinationGO.transform.position) > 1.0f)
        {
            this.gameObject.transform.position = Vector3.Slerp(this.gameObject.transform.position, this.destinationGO.transform.position, this.speed * Time.deltaTime);
        }
        //NEW CODE**
    }
}
