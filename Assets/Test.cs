using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public class Boss
    {
        int mp = 53;

        public void MagicAttack(int magicpoint)
        {
            if (mp < magicpoint)
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            else
            {
                this.mp -= magicpoint;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        int[] points = new int[5];

        points[0] = 100;
        points[1] = 200;
        points[2] = 300;
        points[3] = 400;
        points[4] = 500;

        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }

        // 魔法攻撃
        Boss midboss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            midboss.MagicAttack(5);
        }
        midboss.MagicAttack(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
