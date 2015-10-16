using UnityEngine;
using System.Collections;

public class TriggerScore : MonoBehaviour {

    public ScoreManager _mng;
    public int AdPoint;
    // Use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            _mng.AddPoint(AdPoint);
            Destroy(this.gameObject);
        }
    }
}
