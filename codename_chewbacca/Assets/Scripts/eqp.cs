using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class eqp 
{
    private List<IBullet> bullets;
    public IBullet bullet = new StandardBullet();
    private double[] bulletCount = new[] {Double.PositiveInfinity, 0, 0, 0};
   
    private bool wyswietlajEkwipunek = false;
 
    public void zmiana () {
        if (Input.GetKeyDown("k"))
        {
            wyswietlajEkwipunek = !wyswietlajEkwipunek;
        }
        if (wyswietlajEkwipunek)
        {
            if (Input.GetKeyDown("1"))
            {
                bullet = new StandardBullet();
            }
            else if (Input.GetKeyDown("2"))
            {
                bullet = new ArmourPiercingBullet();
            }
            else if (Input.GetKeyDown("3"))
            {
                bullet = new FragBullet();
            }
            else if (Input.GetKeyDown("4"))
            {
                bullet = new NuclearBullet();
                }
         }
    }
 
     void OnGUI()
    {
        if (wyswietlajEkwipunek)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Rect slotRect = new Rect(100 + (x * 65), 100 + (y * 65), 60, 60);
                    
                    if (y == 0)
                        GUI.Label(slotRect, (x + 1).ToString());
                    else
                        GUI.Label(slotRect, bulletCount[x].ToString());


                }
            }
        }
    }
 
    public void narysujEkwipunek()
    {
        //int i = 0;
      
    }
}