using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.Events;

public class ToiletUIManager : MonoBehaviour
{
    public Animator washHandAnimator;
    public Animator tolietWaterAnimator;
    public AudioSource audioSource;
    public float timePlayAudio = 5f;

    public void Update()
    {
        timePlayAudio -= Time.deltaTime;
        if (timePlayAudio <= 0)
        {
            timePlayAudio = 100000000;
            audioSource.Play();
        }
    }

    public void OnClickWashHandBtn()
    {
        StartCoroutine(StartWash());

//        StartCoroutine(LisenterAnimFinish(washHandAnimator, "wash_hand_anim",
//            () => { washHandAnimator.SetBool("isWash", false); }));
    }

    private IEnumerator StartWash()
    {
        washHandAnimator.SetBool("isWash", true);
        yield return new WaitForSeconds(2f);
        washHandAnimator.SetBool("isWash", false);
    }

    public void OnClickTioletWaterBtn()
    {
        StartCoroutine(StartWater());
    }

    private IEnumerator StartWater()
    {
        tolietWaterAnimator.SetBool("isWater", true);
        yield return new WaitForSeconds(1f);
        tolietWaterAnimator.SetBool("isWater", false);
    }

    //
    //    IEnumerator LisenterAnimFinish(Animator animator, string animName, UnityAction action)
    //    {
    //        yield return null;
    //        AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0);
    //
    //        if (stateinfo.IsName(animName) && (stateinfo.normalizedTime > 1.0f))
    //        {
    //            action();
    //        }
    //        else
    //        {
    //            StartCoroutine(LisenterAnimFinish(animator, animName, action));
    //        }
    //    }
}