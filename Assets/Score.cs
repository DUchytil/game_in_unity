using UnityEngine;
using UnityEngine.UI; //Allows us to access UI components
using TMPro;


/*
 Following code inspired by Brackeys YouTube channel (changes made)
URL: https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6
 */

public class Score : MonoBehaviour
{


    public Transform player;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);//How many units we've moved on the z-axis
        scoreText.text = player.position.z.ToString("0");//Displays UI text with current z position (score)
    }
}
