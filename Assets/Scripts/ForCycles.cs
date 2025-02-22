
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCycles : MonoBehaviour
{
    public float amount;
    public List<Material> materials = new List<Material>();
    public List<Image> listImages = new List<Image>();
    private void Start()
    {
        SetColorMaterials();
        SetColorImages();
    }

    private void SetColorImages()
    {
        for (int i = 0; i < listImages.Count; i++)
        {
            if (i == 0)
            {
                
                listImages[i].color = Color.yellow;
            }
            else
            {
                listImages[i].color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }



    private void SetColorMaterials()
    {
        for (int index = 0; index < materials.Count; index++)
        {
            if (index % 2 == 0)
            {
                amount += 10;
                Debug.Log(amount);
                materials[index].color = Color.blue;
            }
            else
            {
                amount -= 5;
                Debug.Log(amount);
                materials[index].color = Color.yellow;
            }
        }
    }


    // Update is called once per frame
    private void Update()
    {
        
    }
}
