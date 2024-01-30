using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        door.SetActive(!door.activeInHierarchy);
        if(button!=null)button.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (button == null) door.SetActive(!door.activeInHierarchy);
    }
}
