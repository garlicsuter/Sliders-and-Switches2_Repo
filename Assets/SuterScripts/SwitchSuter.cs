using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSuter : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject cannonBall;
    public float power = 10f;
    public SliderSuter sliderSuter;
 

    public void SwitchEnabled()
    {
        Debug.Log("Switch is ON");
        StartCoroutine("FireAtWill");
    }

    public void SwitchDisabled()
    {
        Debug.Log("Switch is OFF");
    }

    IEnumerator FireAtWill()
    {
        Debug.Log("started FireAtWill Coroutine");

        for (int i = 10; i > 0; i--)
        {
            power = sliderSuter.roundedPower;
            var newBall = Instantiate(cannonBall, spawnPoint.transform.position, Quaternion.identity);
            newBall.GetComponent<Rigidbody>().AddForce(transform.forward * 1000 * power);
            yield return new WaitForSeconds(0.5f);
           //yield return null;
        }

        
        
    }
}
