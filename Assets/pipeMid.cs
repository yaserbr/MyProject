using Unity.VisualScripting;
using UnityEngine;

public class pipeMid : MonoBehaviour
{
    public LogicManager logic ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer ==3)
        {
            
        logic.addScore(1);
        }
        
        
    }
}
