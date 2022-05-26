using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI TextOutput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate(); // ABSTRACTION
    }
    protected void Rotate()
    {
        transform.Rotate(1*Time.deltaTime, 2 * Time.deltaTime, 3 * Time.deltaTime);
    } 
    public virtual void PrintText()
    {
        TextOutput.text = "test";
    }
    protected void OnMouseDown()
    {
        PrintText();
    }
}
