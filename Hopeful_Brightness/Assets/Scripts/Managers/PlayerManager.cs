using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.SO;
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public FloatSO playerHealth;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
		{
            Destroy(gameObject);
		}
    }

   
    void Update()
    {
        
    }
}
