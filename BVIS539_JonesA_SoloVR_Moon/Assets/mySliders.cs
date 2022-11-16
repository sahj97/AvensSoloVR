using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNG
{
    public class mySliders : MonoBehaviour
    {


        public Slider mySlider;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(mySlider.SlidePercentage);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
