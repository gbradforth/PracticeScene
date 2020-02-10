using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
     private GameObject Player;
     public string myName;
     public int end = -5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Player, I am" + myName + "!");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = transform.position;
        Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        if (!(p.y == end))
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (p.y == end)
        {
            transform.localScale+=scaleChange;
        }
        Debug.Log(transform.position);    
    }
}
