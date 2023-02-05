using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private static Player _instance;

    [SerializeField] private int _memories;


    public static Player Instance
    {
        get{
            if(_instance == null){
                Debug.Log("Player is null");
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

    void Update(){
        UIManager.Instance.UpdateCollectiveText(_memories);
    }

    public void AddMemory(){
        _memories++;
    }
}
