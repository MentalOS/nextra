using System.Windows.Controls;

namespace NExtra.WPF.Controls.Extensions
{
    /// <summary>
    /// Extension methods for System.Windows.Controls.RadioButton.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://www.saidi.se/nextra
    /// </remarks>
    public static class RadioButtonExtensions
    {
        /// <summary>
        /// Get the ThreeState state of a radio button.
        /// </summary>
        /// <param name="radioButton">The radio button of interest.</param>
        /// <returns>The ThreeState state of the radio button.</returns>
        public static ThreeState State(this RadioButton radioButton)
        {
            if (!radioButton.IsChecked.HasValue)
                return ThreeState.Undetermined;
            return radioButton.IsChecked.Value ? ThreeState.Checked : ThreeState.Unchecked;
        }
    }
}