using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public Transform PaddleTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Paddle Script Start");

        PaddleTransform = GetComponent<Transform>();

        //PaddleTransform.Translate(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //PaddleTransform.Translate(3 * Time.deltaTime, 0, 0);

        //if you are holding down the RightArrow key, run the code inside the if statement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PaddleTransform.Translate(3 * Time.deltaTime, 0, 0);
        }

        //if you are holding down the RightArrow key, run the code inside the if statement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PaddleTransform.Translate(-3 * Time.deltaTime, 0, 0);
        }
    }
}
