using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LedController : MonoBehaviour {

    public Text debugTxt;
    public GameObject buttonPrefabs;
    public GameObject buttonsParent;
    //
    void LoadButtons()
    {
        for (int i = 0; i<64; i++)
        {

             //sinh ra mot nut bam san
            var button = Instantiate(buttonPrefabs);
            button.transform.parent = buttonsParent.transform;
            button.GetComponent<Button>().onClick.AddListener(delegate { readButton(button.GetComponent<Button>()); });
        }
    }

    void readButton(Button button)
    {
        // dung mot bien trong button de xac dinh su toggle
        //Sau do dung ham broadcast to trans data by wifi of blutooth
    }
	// Use this for initialization
	void Start () {
        LoadButtons();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SendBroadcast()
    {
      
    }
}
