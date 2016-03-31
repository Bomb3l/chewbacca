using UnityEditor;
using UnityEngine;

public class TankMovement 
{
    public CharacterController tankMove;
    public Transform bla;
    public float predkoscPoruszania = 9.0f;
    public float wysokoscSkoku = 7.0f;
    public float aktualnaWysokoscSkoku = 0f;
    public float predkoscBiegania = 7.0f;

    public TankMovement(CharacterController nowy,Transform bla)
    {
        tankMove = nowy;
        this.bla = bla;
    }


    public void klawiatura()
    {
       

        float rochPrzodTyl = Input.GetAxis("Vertical") * predkoscPoruszania;
        float rochLewoPrawo = Input.GetAxis("Horizontal") * predkoscPoruszania;
    //    GameObject model = Resources.Load("tank-t34", typeof(GameObject)) as GameObject;

        if (tankMove.isGrounded && Input.GetButton("Jump"))
        {
            //model.transform.position = new Vector3(20f,6f,315f); 
            aktualnaWysokoscSkoku = wysokoscSkoku;
        }
        else if (!tankMove.isGrounded)
        {
            aktualnaWysokoscSkoku += Physics.gravity.y * Time.deltaTime;
           
        }


        if (Input.GetKeyDown("left shift"))
        {
            predkoscPoruszania += predkoscBiegania;
        }
        else if (Input.GetKeyUp("left shift"))
        {
            predkoscPoruszania -= predkoscBiegania;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            bla.Rotate(0, 1000 * Time.deltaTime, 0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            bla.Rotate(0, 0, 1000 * Time.deltaTime);
        }

        Vector3 ruch = new Vector3(rochLewoPrawo, aktualnaWysokoscSkoku, rochPrzodTyl);
        
        tankMove.Move(ruch * Time.deltaTime);
    }
}