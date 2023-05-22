using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class AnimationButton : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(1.3f, 0.4f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
