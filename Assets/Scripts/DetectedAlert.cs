using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.Linq;

public class DetectedAlert : MonoBehaviour {
    public Transform PanelScanMarker;
    public Transform PanelMenu;

    // Use this for initialization
    void Start () {
        PanelScanMarker.gameObject.SetActive(true);
        PanelMenu.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();
        if (activeTrackables.Count() > 0)
        {
            PanelScanMarker.gameObject.SetActive(false);
            PanelMenu.gameObject.SetActive(true);
        }

        else
        {
            PanelScanMarker.gameObject.SetActive(true);
            PanelMenu.gameObject.SetActive(false);
        }
    }
}
