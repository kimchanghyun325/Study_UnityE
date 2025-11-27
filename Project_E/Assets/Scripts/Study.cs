using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string say = "";
    private string said = "";
    string newsay = "Hello, World!";
    public char text;
    void Start()
    {
        Debug.Log(this.say);
        Debug.Log(newsay);
        Debug.Log(said);
        Debug.Log(this.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
