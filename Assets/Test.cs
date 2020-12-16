using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    

    public class Boss
    {
        private int hp = 100;// 体力
        private int power = 25; // 攻撃力
        private int mp = 53;//魔力
        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
            
        }
        

         //魔法攻撃用の関数
        public void Magic(int used_mp)
        {
            if (mp>=used_mp)
            {
                mp -= used_mp;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            
        }

        
    }

    void Start()
    {
        

        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す     
        for (int i=1; i<=11;i++)
        {
            lastboss.Magic(5);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
