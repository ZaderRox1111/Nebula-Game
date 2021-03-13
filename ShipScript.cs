using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public GameObject mod1;
    public GameObject mod2;
    public GameObject mod3;
    public GameObject mod4;

    public GameObject upgradePanel;

    private bool mod1Active, mod2Active, mod3Active, mod4Active;

    // Start is called before the first frame update
    void Start()
    {
        mod1Active = true;
        mod2Active = false;
        mod3Active = false;
        mod4Active = false;

        mod1.SetActive(mod1Active);
        mod2.SetActive(mod2Active);
        mod3.SetActive(mod3Active);
        mod4.SetActive(mod4Active);
    }

   public void UpgradeShip()
   {
        if (mod3Active)
        {
            mod4Active = true;
        }
        else if (mod2Active)
        {
            mod3Active = true;
        }
        else if (mod1Active)
        {
            mod2Active = true;
        }

        mod1.SetActive(mod1Active);
        mod2.SetActive(mod2Active);
        mod3.SetActive(mod3Active);
        mod4.SetActive(mod4Active);

        upgradePanel.SetActive(false);
    }

    public void ConfirmUpgrade()
    {
        upgradePanel.SetActive(true);
    }

}
