using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]

    public GameObject applePrefab;

    public float   speed = 10f;

    public float   leftAndRightEdge = 24f;

    public float   changeDirChance = 0.2f;

    public float   appleDropDelay = 1f;
   

    void Start() {
        Invoke( "DropApple", 2f );

    }

    void DropApple() {                                        

        GameObject apple = Instantiate<GameObject>( applePrefab ); 

        apple.transform.position = transform.position;  

        Invoke( "DropApple", appleDropDelay ); 
    }

    // Update is called once per frame
    void Update() {
        // Basic Movement
        Vector3 pos = transform.position;  
       
        pos.x += speed * Time.deltaTime; 
        
        pos.x += 1.0f  * 0.04f;
       
        pos.x += 0.04f;                 
        
        transform.position = pos;  
        
        // Changing Direction        

        if ( pos.x < -leftAndRightEdge ) {                    
// a
            speed = Mathf.Abs( speed );   // Move right       
// b
        } else if ( pos.x > leftAndRightEdge ) {              
// c
            speed = -Mathf.Abs( speed );  // Move left  
       
       // } else if ( Random.value < changeDirChance ) { 
          //  speed *= -1;

        }
    }
    void FixedUpdate() {
        
        if ( Random.value < changeDirChance) {

            speed *= -1;
        }
    }
}   
