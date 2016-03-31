using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ekwipunek
{
    private List<IBullet> bullets;
    public IBullet bullet = new StandardBullet();
    private double[] bulletCount = new[] {Double.PositiveInfinity, 0, 0, 0};

    
    public bool wyswietlajEkwipunek = false;

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



    public void narysujEkwipunek()
    {
     

        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;

        for (int y = 0; y < 2; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                Rect slotRect = new Rect(100 + (x * 65), 100 + (y * 65), 60, 60);
                GUI.Box(slotRect,"");
                if (y == 0)
                {
                 
                    GUI.Label(slotRect, (x+1).ToString());
                }
                else
                    GUI.Label(
                        new Rect(slotRect.x + (slotRect.width/2) - 50, slotRect.y + slotRect.height/2 - 10, 100, 20),
                       bulletCount[x].ToString(), centeredStyle);


            }
        }
    }
}
