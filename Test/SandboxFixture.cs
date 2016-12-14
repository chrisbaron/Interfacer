﻿using System.Diagnostics;
using System.Dynamic;
using Interfacer;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class SandboxFixture
    {
        [Interfacer(WrappedObjectType.Instance, typeof(Process))]
        public interface IProcess
        {
            ProcessStartInfo StartInfo { get; }
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            InterfacerFactory.Initialize(GetType().Assembly);
        }

        [Test]
        public void Test()
        {
            var process = InterfacerFactory.Create<IProcess>();
            var info = process.StartInfo;
            Assert.That(info, Is.Not.Null);
        }
    }
}
