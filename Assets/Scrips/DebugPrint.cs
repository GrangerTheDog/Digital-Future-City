using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugPrint : MonoBehaviour
{

    public Button TestButton;
    
    // Start is called before the first frame update
    void Start()
    {
        TestButton.onClick.AddListener(print);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public static void print()
    {
        print("Button was pressed!");
    }
}
