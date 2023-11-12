using UnityEngine;



/*
 This code was taken from devassets.com (changes made)
URL: https://devassets.com
 */




public class PlayerMovement : MonoBehaviour
{

    //Referencing RigidBody component to change aspects
    public Rigidbody rb;

    public float forwardForce = 2000f;//Thanging this value to a variable allows us to change this value in the inspector!!!
    public float sidewaysForce = 500f;//The added "f" is to make Unity happy :)
    public float initialTorqueForce = 10f;//Force values to be used at initial game start
    public float constantTorque = 10f;//For constant torque

    // Start is called before the first frame update
    void Start()
    {
        //This function will run at the start of the game
        //Debug.Log("Hello, World!");//To display a message on the console
         
        //rb.useGravity = false; //Turns off gravity for this specific component

        //rb.AddForce(0, 200, 500);

        rb.AddTorque(Vector3.right * initialTorqueForce, ForceMode.Impulse);
        rb.AddTorque(Vector3.forward * initialTorqueForce, ForceMode.Impulse);




    }

    // Update is called once per frame
    //void Update()

    //Note on FixedUpdate: if a short input (e.g., a command to jump) is required, use regular Update method
    void FixedUpdate()//FixedUpdate is preferable when doing anything related to physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //multiplying by Time.deltaTime means that the higher the framerate, the lower this value will become, therefore evening out the problems that might accompany a higher frame rate
        //rb.AddTorque(Vector3.up * constantTorque, ForceMode.Impulse);//Adds constant rotation

        if ( Input.GetKey("d")) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//ForceMode.VelocityChange immediately changes the velocity independent of mass :)
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


    }
}
