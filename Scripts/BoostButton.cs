using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BoostButton : MonoBehaviour, IPointerDownHandler,
    IPointerUpHandler
{
    public Player player;
    public Slider boostSlider;

    bool pressed = false;
    float boostLeft = 10f;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed & boostLeft > 0f)
        {
            player.runSpeed = 60f;
            boostLeft -= Time.deltaTime;
        }
        else
            player.runSpeed = 40f;

        boostSlider.GetComponent<Slider>().value = boostLeft;
    }
}
