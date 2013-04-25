using System.Windows.Controls;
using NExtra.Testing;
using NExtra.WPF.Controls;
using NExtra.WPF.Extensions;
using NUnit.Framework;

namespace NExtra.WPF.Tests.Extensions
{
    [TestFixture]
    public class CheckBox_ExtensionsBehavior
    {
        CrossThreadTestRunner runner;


        [SetUp]
        public void SetUp()
        {
            runner = new CrossThreadTestRunner();
        }


        [Test]
        public void State_ShouldReturnCorrectValue()
        {
            runner.RunInSTA(delegate
            {
                Assert.That(new CheckBox { IsChecked = null }.State(), Is.EqualTo(ThreeState.Undetermined));
                Assert.That(new CheckBox { IsChecked = false}.State(), Is.EqualTo(ThreeState.Unchecked));
                Assert.That(new CheckBox { IsChecked = true }.State(), Is.EqualTo(ThreeState.Checked));
            });
        }
    }
}