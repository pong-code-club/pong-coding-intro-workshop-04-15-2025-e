using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    //making a variable called MyRigidbody whose data type is Rigidbody, so that I can make a reference to the Rigidbody component
    public Rigidbody MyRigidbody;

    public ScoreScript ScoreUIScoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Ball Script Start");

        //Storing the reference to the Rigidbody component in the variable named MyRigidbody
        MyRigidbody = GetComponent<Rigidbody>();

        //setting the useGravity variable in the Rigidbody componet to false
        MyRigidbody.useGravity = false;

        //calling the AddForce function inside the Rigidbody component/class instance
        MyRigidbody.AddForce(300, 300, 0);

        ScoreUIScoreScript = GameObject.Find("ScoreUI").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit something");

        //ScoreUIScoreScript.AddToScore();

        /*if (collision.gameObject.name == "RightWall")
        {
            ScoreUIScoreScript.AddToScore();
        }

        if (collision.gameObject.name == "LeftWall")
        {
            ScoreUIScoreScript.AddToScore();
        }

        if (collision.gameObject.name == "TopWall")
        {
            ScoreUIScoreScript.AddToScore();
        }*/

        if (collision.gameObject.tag == "WALL")
        {
            ScoreUIScoreScript.AddToScore();
        }

        if (collision.gameObject.name == "Lava")
        {
            SceneManager.LoadScene("PongScene");
        }
    }
}
