using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teeth : MonoBehaviour
{
    public float toothPasteStat;
    public float toothBrusrushStat;
    public float waterStat;

    public MeshRenderer MR;
    public Material originMaterial;
    public Texture clearTexture;

    public GameObject car;
    public Texture carClear;

    public ParticleSystem pSys;
    public ParticleSystem pSys1;

    public Image Finalimage;

    public AudioSource teethSound;



    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
        originMaterial = MR.material;
   
    }

    // Update is called once per frame
    void Update()
    {
        clear();
        GameManager.instance.paste.value  = toothPasteStat;
        GameManager.instance.brush.value = toothBrusrushStat;
        GameManager.instance.water.value = waterStat;
        if(toothPasteStat<=0)
            toothPasteStat= 0;
        if (toothBrusrushStat <= 0)
            toothBrusrushStat = 0;
        if (waterStat <= 0)
            waterStat = 0;
    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButton(0))
        {
            if (GameManager.instance.itemStats == 1)
            {
                toothPasteStat -= Time.deltaTime;
                PlayParticle(pSys);
                PlayParticle(pSys1);
                //teethSound.Play();
                PlayAudio(teethSound);



            }
            else if(GameManager.instance.itemStats == 2)
            {
                if(toothPasteStat <= 0)
                {
                    toothBrusrushStat -= Time.deltaTime;
                   
                }
            }
            else if(GameManager.instance.itemStats == 3)
            {
                if(toothBrusrushStat<=0&&toothPasteStat<=0)
                {
                    waterStat -= Time.deltaTime;
                   
                }
            }
        }
    }

    void clear()
    {
        if(waterStat<=0)
        {
            MR.material.mainTexture = clearTexture;
            car.GetComponent<MeshRenderer>().material.mainTexture = carClear;
            Finalimage.gameObject.SetActive(true);
        }
    }

    void PlayParticle(ParticleSystem particle)
    {
        if (!particle.isPlaying)
        {
            particle.Play();
        }
    }

    void PlayAudio(AudioSource audio)
    {
        if (!audio.isPlaying)
        {
           audio.Play();
        }
    }
}
