using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSelector : MonoBehaviour
{
    public Transform maleGroup;
    public Transform femaleGroup;
    public static int mSelected = 0;
    public static int fSelected = 0;

    public void maleSelected()
    {
        if (maleGroup != null)
        {
            if (mSelected == 0)
            {
                mSelected = 1;
                swapImage(maleGroup.GetChild(1), maleGroup.GetChild(0));

                if (fSelected == 1)
                {
                    fSelected = 0;
                    swapImage(femaleGroup.GetChild(0), femaleGroup.GetChild(1));

                }
            }
        }
    }

    public void femaleSelected()
    {
        if (femaleGroup != null)
        {
            if (fSelected == 0)
            {
                fSelected = 1;
                swapImage(femaleGroup.GetChild(1), femaleGroup.GetChild(0));

                if (mSelected == 1)
                {
                    mSelected = 0;
                    swapImage(maleGroup.GetChild(0), maleGroup.GetChild(1));

                }
            }
        }
    }

    void swapImage(Transform current, Transform next)
    {
        if (current)
        {
            next.gameObject.SetActive(true);
            current.gameObject.SetActive(false);
        }
    }
}
     