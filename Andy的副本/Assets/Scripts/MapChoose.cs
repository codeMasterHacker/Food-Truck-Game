using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChoose : MonoBehaviour
{
    public GameObject maincam;
    public GameObject truck;
    public GameObject truckModel;
    public GameObject apFoodTruckPanel, chefsPanel;

    private AudioSource[] AudioPlayer;
    private List<AudioSource> soundList;
    public List<AudioClip> soundClips;

    void Start()
    {
        truckModel = truck.GetComponent<TruckAcquire>().truckChosen;
        truckModel.transform.localScale = new Vector3(5f, 5f, 5f);
        AudioPlayer = GameObject.Find("AudioPlayer").GetComponentsInChildren<AudioSource>();
        soundList = new List<AudioSource>(AudioPlayer);
    }
    public void City()
    {
        //Animation Cam Pos: -293.89, 79.47, -194.2; Rot: 56, -90, 0
        maincam.transform.position = new Vector3(-293.89f, 79.47f, -194.2f);
        maincam.transform.rotation = Quaternion.Euler(56f, -90f, 0);
        truckModel.GetComponent<Animator>().Play("CityAnim");
        StartCoroutine("CityDelay");
    }

    public void Playground() 
    {
        //Animation Cam Pos: 71.61, 19.87, 248.3; Rot: 0, -180, 0
        maincam.transform.position = new Vector3(71.61f, 19.87f, 248.3f);
        maincam.transform.rotation = Quaternion.Euler(0, -180f, 0);
        truckModel.GetComponent<Animator>().Play("PGAnim");
        StartCoroutine("PGDelay");
    }

    public void AmusementPark()
    {
        //Animation Cam Pos: 295.1, 66.3, -176.8; Rot: 21, -90, 0
        maincam.transform.position = new Vector3(295.1f, 66.3f, -176.8f);
        maincam.transform.rotation = Quaternion.Euler(21f, -90f, 0);
        truckModel.GetComponent<Animator>().Play("APAnim");
        StartCoroutine("APDelay");
    }

    IEnumerator CityDelay()
    {
        yield return new WaitForSeconds(5);
        maincam.transform.position = new Vector3(-300f, 3.029f, -180.05f);
        maincam.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        foreach (AudioSource audio in soundList)
        {
            if (audio.clip.name == "Traffic" || audio.clip.name == "Crowd" || audio.clip.name == "car running")
            {
                audio.Play();
            }
        }

        chefsPanel.SetActive(true);
        apFoodTruckPanel.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    IEnumerator PGDelay()
    {
        yield return new WaitForSeconds(5);
        maincam.transform.position = new Vector3(54.582f, 3.029f, 165f);
        maincam.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        foreach (AudioSource audio in soundList)
        {
            Debug.Log(audio.clip.name);
            if (audio.clip.name == "Children Playing" || audio.clip.name == "Wind")
            {
                audio.Play();
            }
        }

        chefsPanel.SetActive(true);
        apFoodTruckPanel.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    IEnumerator APDelay()
    {
        yield return new WaitForSeconds(5);
        maincam.transform.position = new Vector3(155f, 3f, -240f);
        maincam.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        truckModel.transform.position = new Vector3(437.36f, 3.029f, -155.4f);
        foreach (AudioSource audio in soundList)
        {
            Debug.Log(audio.clip.name);
            if (audio.clip.name == "Kingdom" || audio.clip.name == "Crowd")
            {
                audio.Play();
            }
        }

        chefsPanel.SetActive(true);
        apFoodTruckPanel.SetActive(true);
        yield return new WaitForSeconds(3);
    }
}
