using System.Globalization;

namespace UnitConvertion;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        foreach (var unit in Enum.GetValues(typeof(EUnits)))
        {
            EUnits eunit = (EUnits)unit;
            InputUnitsBox.Items.Add(eunit.EnumToString());
            OutputUnitsBox.Items.Add(eunit.EnumToString());
        }
    }

    private void Convert(object sender, EventArgs e)
    {
        if (!double.TryParse(inputValueBox.Text, out double inputValue) ||
            !double.TryParse(ExponentTextBox.Text, out double Exp) ||
            InputUnitsBox.SelectedItem is null ||
            OutputUnitsBox.SelectedItem is null)
        {
            OutputLabel.Text = "Error";
            return;
        }

        Convertor convertor = new Convertor();

        EUnits from = InputUnitsBox.SelectedItem.ToString().ToUnit();
        EUnits to = OutputUnitsBox.SelectedItem.ToString().ToUnit();

        OutputLabel.Text = convertor.From(from)
                                    .To(to)
                                    .Convert(inputValue * Math.Pow(10, Exp))
                                    .ToString("G2", CultureInfo.InvariantCulture);


    }

}
