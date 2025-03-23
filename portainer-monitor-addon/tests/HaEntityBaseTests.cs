namespace HomeAssistant.Addon.PortainerMonitor.Tests;

using HomeAssistant.Addon.PortainerMonitor.Mqtt.HaEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Test for <see cref="HaEntityBase"/>
/// </summary>
[TestClass]
public sealed class HaEntityBaseTests
{
    [TestMethod]
    public void BuildID()
    {
        var checks = new (string input, string expected)[]
                         {
                             ("portainer1_local_something", "portainer1_local_something"),
                             ("portai%ner1/lo.cal_som$thi ng", "portai_ner1_lo_cal_som_thi_ng")
                         };

        foreach (var check in checks)
        {
            var received = HaEntityBase.BuildID(check.input);
            Assert.AreEqual(check.expected, received, $"ID does contain invalid chars, expected `check.expected` but received `{received}`");
        }
    }
}