using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public Image cooldown;
    public bool coolingDown;
    public float waitTime = 10.0f;
    public GameObject PanelLoading;
    public GameObject PanelGame;
    
    // Start is called before the first frame update
    void Start()
    {
    

    }
    

    
   
    // Update is called once per frame
    void Update()
    {
        if (coolingDown == true)
        {
            Debug.Log("fill");
            //Reduce fill amount over 30 seconds
            cooldown.fillAmount -= 1.0f / waitTime * Time.deltaTime;
            if(cooldown.fillAmount <= 0f)
            {
                coolingDown = false;
                PanelLoading.SetActive(false);
            }
        }

    }
    


}
