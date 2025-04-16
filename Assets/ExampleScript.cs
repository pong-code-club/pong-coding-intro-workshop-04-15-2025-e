using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    //declaring variable - telling computer to reserve a box with a specific name for me to store information inside of it
    //primitive data types

    //[accessor keyword] [data type] [identifier]
    public int Lives;
    public float Size;
    public bool IsAlive;
    public string CubeName;

    //compound data types
    public Transform MyTransform;
    public Rigidbody MyRigidbody;
    public Vector3 ExampleVector3;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Inside Start");

        //assign variable value
        Lives = 3;
        Size = 1.5f;
        IsAlive = true;
        CubeName = "Happy Cube";

        //GetComponent gets a specific component through code
        MyTransform = GetComponent<Transform>();
        MyRigidbody = GetComponent<Rigidbody>();

        //change variable on component
        MyRigidbody.mass = 10.5f;

        //calling the Translate function on the Transform component
        MyTransform.Translate(2,0,0);

        ExampleVector3 = new Vector3(10, 11, 12);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Inside Update");

        //calling the Translate function on the Transform component
        //multiple by Time.deltaTime essential mean change per second vs per frame [1 unit per second instead of per frame]
        MyTransform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
