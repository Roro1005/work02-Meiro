using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GoalText;
    // Start is called before the first frame update
    void Start()
    {
        GoalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" )
        {
            GoalText.SetActive(true);
        }
    }
}
