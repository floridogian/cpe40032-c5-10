using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour // Problem 1: Center the text on the buttons horizontally and vertically.
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManagerX.StartGame(difficulty); // Problem 5: The spawnRate is always way too fast. When you click Easy, the spawnRate should be slower - if you click Hard, the spawnRate should be faster.
    }



}
