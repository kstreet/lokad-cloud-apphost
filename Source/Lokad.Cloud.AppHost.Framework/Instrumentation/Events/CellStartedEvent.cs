﻿#region Copyright (c) Lokad 2011
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using System;

namespace Lokad.Cloud.AppHost.Framework.Instrumentation.Events
{
    [Serializable]
    public class CellStartedEvent : IHostEvent
    {
        public CellLifeIdentity Cell { get; private set; }

        public CellStartedEvent(CellLifeIdentity cell)
        {
            Cell = cell;
        }
    }
}