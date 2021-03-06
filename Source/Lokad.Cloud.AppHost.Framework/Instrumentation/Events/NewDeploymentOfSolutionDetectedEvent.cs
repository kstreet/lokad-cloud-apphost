﻿#region Copyright (c) Lokad 2011-2012
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using System;
using System.Xml.Linq;
using Lokad.Cloud.AppHost.Framework.Definition;

namespace Lokad.Cloud.AppHost.Framework.Instrumentation.Events
{
    [Serializable]
    public class NewDeploymentOfSolutionDetectedEvent : IHostEvent
    {
        public HostEventLevel Level { get { return HostEventLevel.Information; } }
        public HostLifeIdentity Host { get; private set; }
        public SolutionHead Deployment { get; private set; }
        public SolutionDefinition Solution { get; private set; }

        public NewDeploymentOfSolutionDetectedEvent(HostLifeIdentity host, SolutionHead deployment, SolutionDefinition solution)
        {
            Host = host;
            Deployment = deployment;
            Solution = solution;
        }

        public string Describe()
        {
            return string.Format("AppHost: New deployment detected for {0} solution on {1}.",
                Solution.SolutionName, Host.WorkerName);
        }

        public XElement DescribeMeta()
        {
            return new XElement("Meta",
                new XElement("Component", "Lokad.Cloud.AppHost"),
                new XElement("Event", "NewDeploymentOfSolutionDetectedEvent"),
                new XElement("AppHost",
                    new XElement("Host", Host.WorkerName),
                    new XElement("Solution", Solution.SolutionName)));
        }
    }
}
