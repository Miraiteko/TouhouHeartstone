﻿using TouhouHeartstone.Frontend.ViewModel;
using TouhouHeartstone.Frontend.View;
using System;

namespace TouhouHeartstone.Frontend.Model
{
    public class CardEventArgs
    {

    }

    /// <summary>
    /// Index改变的事件
    /// </summary>
    public class IndexChangeEventArgs : EventArgs
    {
        public int Index { get; set; }

        /// <summary>
        /// 卡片总数。若不指定则自己看着办
        /// </summary>
        public int Count { get; set; }

        public IndexChangeEventArgs(int index) { Index = index; }
    }

    /// <summary>
    /// 卡片抽出的事件
    /// </summary>
    public class CardDrewEventArgs : EventArgs, ICardEventArgs
    {
        public int CardDID { get; set; }
        public int CardRID { get; set ; }
    }

    /// <summary>
    /// 设置水晶事件
    /// </summary>
    [Obsolete]
    public class SetGemEventArgs : EventArgs, IPlayerEventArgs
    {
        public int PlayerID { get; set; }

        public int MaxGem { get; set; } = -1;

        public int CurrentGem { get; set; } = -1;

        public SetGemEventArgs(int max, int current)
        {
            MaxGem = max;
            CurrentGem = current;
        }
        public SetGemEventArgs() { }
    }

    /// <summary>
    /// 回合结束事件
    /// </summary>
    public class RoundEventArgs : EventArgs, IPlayerEventArgs
    {
        public int PlayerID { get; set; }
        public RoundEventArgs(int playerID)
        {
            PlayerID = playerID;
        }
    }

    /// <summary>
    /// 丢卡事件
    /// </summary>
    [Obsolete]
    public class ThrowCardEventArgs : EventArgs, IPlayerEventArgs
    {
        public int PlayerID { get; set; }

        public CardID[] Cards { get; set; }

        public CardID[] NewCards { get; set; }

        public ThrowCardEventArgs(int playerID, int[] cards)
        {
            PlayerID = playerID;
            Cards = CardID.ToCardIDs(cards);
        }

        public ThrowCardEventArgs(int playerID, int[] defines, int[] runtimes)
        {
            PlayerID = playerID;
            Cards = CardID.ToCardIDs(defines, runtimes);
        }

        public ThrowCardEventArgs(int playerID, CardID[] cards)
        {
            PlayerID = playerID;
            Cards = cards;
        }

        public ThrowCardEventArgs(CardID[] cards)
        {
            Cards = cards;
        }
    }

    /// <summary>
    /// 卡片至手牌
    /// </summary>
    public class CardToStackEventArgs : EventArgs
    {
        public int Index { get; set; }
        public int Count { get; set; }
    }

    /// <summary>
    /// 生成一个随从
    /// </summary>
    public class RetinueSummonEventArgs : EventArgs, IPlayerEventArgs, ICardEventArgs
    {
        public int PlayerID { get; set; }
        public int CardDID { get; set; }
        public int CardRID { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public int Position { get; set; }
    }

    /// <summary>
    /// 预览插入
    /// </summary>
    public class RetinuePreview: EventArgs
    {
        public int Position { get; set; }

        public RetinuePreview(int position)
        {
            Position = position;
        }
    }

    public class OnAttackEventArgs : EventArgs, IPlayerEventArgs, ICardEventArgs
    {
        public int PlayerID { get; set; }
        public int CardDID { get; set; }
        public int CardRID { get; set; }

        public int TargetRID { get; set; }
    }

    [Obsolete("请直接使用RecvAction播放伤害动画")]
    public class OnDamageEventArgs : EventArgs
    {
        public int DamageAmount { get; set; }

        public OnDamageEventArgs(int amount)
        {
            DamageAmount = amount;
        }
    }
}
