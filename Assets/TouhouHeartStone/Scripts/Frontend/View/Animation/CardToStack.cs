﻿using System;
using UnityEngine;
using IGensoukyo.Utilities;

namespace TouhouHeartstone.Frontend.View.Animation
{
    /// <summary>
    /// 卡到卡堆
    /// </summary>
    public class CardToStack : CardAnimation
    {
        public override string AnimationName => "CardToStack";

        public override void PlayAnimation(object sender, EventArgs args, GenericAction callback)
        {
            var arg = Utilities.CheckType<CardPositionEventArgs>(args);

            var gv = Card.GetComponentInParent<GlobalView>();

            Card.transform.SetSiblingIndex(arg.GroupID);

            Card.GetOrAddComponent<PositionAnimation>().Play(new Vector3[2] {
                    Card.transform.localPosition,
                    gv.CardPositionCalculator.StackPosition
                }, new Vector3[2]
                {
                    Card.transform.localRotation.eulerAngles,
                    Vector3.zero
                }, callback);
        }
    }


    public static class TransformExtension
    {
        public static PositionWithRotation GetLocalPWR(this Transform tr)
        {
            return new PositionWithRotation() { Position = tr.localPosition, Rotation = tr.localRotation.eulerAngles };
        }

        public static PositionWithRotation GlobalToLocal(this Transform tr, PositionWithRotation pwr)
        {
            pwr.Position = tr.parent.InverseTransformPoint(pwr.Position);
            pwr.Rotation = tr.parent.InverseTransformDirection(pwr.Rotation);
            return pwr;
        }
    }
}
