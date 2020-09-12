using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Transform endTrigger;

    bool ReachEnd()
    {
        return endTrigger.position.z - player.position.z < 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (ReachEnd() == false)
            scoreText.text = (endTrigger.position.z - player.position.z).ToString("0");
    }
}
