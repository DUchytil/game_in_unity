using UnityEngine;

/*
 Following code inspired by Brackeys YouTube channel (changes made)
URL: https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6
 */


public class FollowPlayer : MonoBehaviour
{

    public Transform player;//Referencing Transform component to access player coordinates
    public Vector3 offset; //Vector3 stores three floats. Useful for positional data (x, y, z)

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position); //Displays the coordinates of the player object

        transform.position = player.position + offset; //This takes the camera position and sets it equal to the player position
        //+ offset adds all three respective positional values (x, y, z) (vector addition)



    }
}
