using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
// INHERITANCE
{
    private string m_Name = "Capsule";
    public string Name
    // ENCAPSULATION
    {
        get { return m_Name; }
        set
        {
            if(value.Length > 10)
            {
                Debug.Log("Shape name too long");
            }
            else
            {
                m_Name = value;
            }
        }
    }
    public override void PrintText()
    // POLYMORPHISM
    {
        TextOutput.text = m_Name + " was clicked";
    }
}