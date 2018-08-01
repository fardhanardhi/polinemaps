using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSelect : MonoBehaviour {

    public GameObject scrollArea;
    private bool isShowing;

    // Use this for initialization
    void Start () {
        isShowing = false;
        scrollArea.gameObject.SetActive(isShowing);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);

                if (hit.transform.name == "Siti")
                {
                    showDetail();
                }
            }
        }

        if (Input.GetKeyDown("escape"))
        {
            showHideDetail();
        }
    }

    public void showHideDetail()
    {
        if (isShowing == false)
        {
            scrollArea.gameObject.SetActive(true);
            isShowing = true;
        }
        else
        {
            scrollArea.gameObject.SetActive(false);
            isShowing = false;
        }
    }

    public void showDetail()
    {
        scrollArea.gameObject.SetActive(true);
        isShowing = true;
    }

    public void hideDetail()
    {
        scrollArea.gameObject.SetActive(false);
        isShowing = false;
    }
}
