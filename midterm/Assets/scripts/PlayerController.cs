using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //movement and rotation speed, adjustable from the game object
    public float mSpeed;
    public float rSpeed;
    float batteryTake;
    public TMP_Text scoreText;
    public TMP_Text batteryText;
    public TMP_Text winText;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //player controls
        float vAxis = Input.GetAxis("Vertical");
        float hAxis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * mSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0, rSpeed * Time.deltaTime * hAxis, 0);
 

    }
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("battery"))
        {
            Destroy(other.gameObject);
            batteryTake = batteryTake + 1;
            batteryText.text = batteryText.ToString() + "Batteries Collected";


        }
        if (batteryTake >= 10)
        {
            winText.text = "Whoopey Winner!";
        }

        
        if (other.CompareTag("bomb"))
        {
            Destroy(other.gameObject);
           
        }
    }

}