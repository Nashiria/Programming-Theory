using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    private float distanceX=0;
    private bool isFlipped=false;
    public void Move(float speed,float rotateSpeed=0f)// POLYMORPHISM
    {
         if(rotateSpeed==0f){
        RectTransform rectTransform=gameObject.GetComponent<RectTransform>();
        if(distanceX<100f && !isFlipped){
            rectTransform.Translate(speed*Vector3.right,gameObject.transform);
            distanceX+=speed*Vector3.right.magnitude;
            }
        else if(distanceX<100f && isFlipped){
            rectTransform.Translate(speed*Vector3.left,gameObject.transform);
            distanceX+=speed*Vector3.right.magnitude;
            }
        else{isFlipped=!isFlipped;distanceX=0f;Flip();}}
       else{
  RectTransform rectTransform=gameObject.GetComponent<RectTransform>();
        rectTransform.Translate(speed*Vector3.right,rectTransform.transform);
        rectTransform.Rotate(rotateSpeed*Vector3.forward);
       }
        
        }

        
    public void Flip(){// ABSTRACTION
        RectTransform rectTransform=gameObject.GetComponent<RectTransform>();
      rectTransform.localScale=new Vector3(-rectTransform.localScale.x,rectTransform.localScale.y,rectTransform.localScale.z);
    }
}
