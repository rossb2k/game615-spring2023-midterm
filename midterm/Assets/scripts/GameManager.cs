using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int playerScore = 0;
    int battery;
    public TMP_Text scoreText;
    public TMP_Text batteryText;
    public TMP_Text win;
    public PlayerController player;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        battery = GameObject.FindGameObjectsWithTag("battery").Length;

        batteryText.text = battery.ToString(); //+ pc.score;

        if (GameObject.FindGameObjectsWithTag("battery").Length <= 0)
        {
            win.text = "Whoopy You Win!";
         
        }

    }

    // This function can be called from other scripts. For example, inside of the
    // PlayerController's OnTriggerEnter function. But remember, the PlayerController
    // would need to have a reference to this GameManager object. This is most
    // easily accomplished by creating a 'public GameManager gm;' in PlayerController
    // and dragging and dropping the GameManager object into the inspector.
    public void IncrementScore()
    {
        Debug.Log("Score Up");
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }


    // This keeps track of the enemy's score. 
    public void IncrementEnemyScore()
    {
        playerScore = playerScore - 1;
        scoreText.text = playerScore.ToString();
        Debug.Log("Bomba");
    }
}
