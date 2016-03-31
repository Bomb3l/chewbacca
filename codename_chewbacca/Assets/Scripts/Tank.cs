using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {
     CharacterController tankRuch;
     Transform bla;
     TankMovementOne ruch;
     Ekwipunek nowy = new Ekwipunek();
  

	void Start () {
        tankRuch = GetComponent<CharacterController>();
	    bla = GetComponent<Transform>();
        ruch = new TankMovementOne(tankRuch,bla);
    
	}

	void Update () {
       ruch.klawiatura();
        nowy.zmiana();
  
        nowy.bullet.fire();
        
	}
    void OnGUI()
    {
        if (nowy.wyswietlajEkwipunek)
        {
            nowy.narysujEkwipunek();
        }
    }
}
