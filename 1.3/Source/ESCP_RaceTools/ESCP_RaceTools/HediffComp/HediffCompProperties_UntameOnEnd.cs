﻿using System;
using RimWorld;
using Verse;

namespace ESCP_RaceTools
{
    public class HediffCompProperties_UntameOnEnd : HediffCompProperties
    {
        public HediffCompProperties_UntameOnEnd()
        {
            this.compClass = typeof(ESCP_RaceTools.HediffComp_UntameOnEnd);
        }

        public bool untame = true;
    }
}
