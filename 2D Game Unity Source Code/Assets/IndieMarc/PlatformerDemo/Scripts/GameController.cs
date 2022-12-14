using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public int actived_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        tmp.text = "Actived 0/4 Levels";
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Actived " + actived_count.ToString() + "/4 Levels";
    }
}
