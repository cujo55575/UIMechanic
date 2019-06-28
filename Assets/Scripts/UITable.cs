using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UITable : MonoBehaviour
{
    [SerializeField]
    Button[] buttons;
    // Use this for initialization
    void Start()
    {
        buttons[0].onClick.AddListener(turnLeftTheUITable);
        buttons[1].onClick.AddListener(turnRightTheUITable);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void turnLeftTheUITable()
    {
        Debug.Log("This is left");
    }
    void turnRightTheUITable()
    {
        Debug.Log("This is right");
    }

}
