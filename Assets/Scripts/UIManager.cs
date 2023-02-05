using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public TextMeshProUGUI    collectibleText;


    public static UIManager Instance
    {
        get{
            if(_instance == null){
                Debug.Log("UIManager is null");
            }
            return _instance;
        }
    }

    void Awake(){
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCollectiveText(int collectives){
        collectibleText.text = "Memories: "+collectives;
    }
}   
