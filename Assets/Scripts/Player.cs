using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject infoText;
    public GameObject diaglogText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            infoText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.K))
            {
                diaglogText.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        infoText.SetActive(false);
        diaglogText.SetActive(false);
    }
}
