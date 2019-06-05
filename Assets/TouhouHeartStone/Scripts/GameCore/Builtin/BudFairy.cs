﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouhouHeartstone.Backend.Builtin
{
    public class BudFairy : ServantCardDefine
    {
        public override int id
        {
            get { return 1; }
        }
        public override int cost
        {
            get { return 0; }
        }
        public override int attack
        {
            get { return 1; }
        }
        public override int life
        {
            get { return 1; }
        }
        public override int category
        {
            get { return 2; }
        }
        public override Effect[] getEffects()
        {
            return new Effect[0];
        }
    }
}