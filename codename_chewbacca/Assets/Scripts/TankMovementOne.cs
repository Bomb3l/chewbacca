using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class TankMovementOne {
    public CharacterController tankMove;
    public Transform bla;
    public float predkoscPoruszania = 500.0f;
    public float predkoscrotacji = 70.0f;
    
    

    public TankMovementOne(CharacterController nowy, Transform bla)
    {
        tankMove = nowy;
        this.bla = bla;
    }
	
	// Update is called once per frame
	public void klawiatura () {
       
    //float ruchPrzodTyl = Input.GetAxis("Vertical") * predkoscPoruszania;
	  // float ruchLewoPrawo = Input.GetAxis("Horizontal") * predkoscPoruszania;
       if (Input.GetKey(KeyCode.W))
        bla.transform.Translate(Vector3.forward * predkoscPoruszania*Time.deltaTime);
        if (Input.GetKey("s"))
        bla.transform.Translate(-Vector3.forward * predkoscPoruszania*Time.deltaTime);
        if (Input.GetKey("a"))
        bla.Rotate(-Vector3.up * predkoscrotacji*Time.deltaTime);
        if (Input.GetKey("d"))
        bla.Rotate(Vector3.up * predkoscrotacji*Time.deltaTime);
      
        
       // Vector3 ruch = new Vector3(0, 0, ruchPrzodTyl);

     // tankMove.Move(ruch * Time.deltaTime);
	}

}
