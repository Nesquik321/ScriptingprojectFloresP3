using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int experience;

    // Start is called before the first frame update
    public int Experience
    {
        get
        {
            return experience;
        }

        set
        {
            experience = value;
        }
    }

    // Update is called once per frame
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}
