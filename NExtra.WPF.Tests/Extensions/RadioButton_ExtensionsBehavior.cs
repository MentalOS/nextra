using System.Windows.Controls;
using NExtra.Testing;
using NExtra.WPF.Controls;
using NExtra.WPF.Extensions;
using NUnit.Framework;

namespace NExtra.WPF.Tests.Controls.Extensions
{
    [TestFixture]
    public class RadioButton_ExtensionsBehavior
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
                Assert.That(new RadioButton { IsChecked = null }.State(), Is.EqualTo(ThreeState.Undetermined));
                Assert.That(new RadioButton { IsChecked = false }.State(), Is.EqualTo(ThreeState.Unchecked));
                Assert.That(new RadioButton { IsChecked = true }.State(), Is.EqualTo(ThreeState.Checked));
            });
        }
    }
}