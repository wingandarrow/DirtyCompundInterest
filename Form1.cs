using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirtyCompundInterest
{
  public partial class Form1 : Form
  {
    public double principal;
    public double rate;
    public int periods;
    public int years;
    public double total;

    public Form1()
    {
      InitializeComponent();
      comboBox1.SelectedIndex = 0;
      dataGridView1.Rows.Clear();
    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
      totalBox.Clear();
      dataGridView1.Rows.Clear();
      principal = double.Parse(Principal.Text);
      rate = double.Parse(interestRate.Text)/100;
      periods = int.Parse(periodsPerYear.Text);
      years = int.Parse(yearsBox.Text);

      int permutations = periods * years;
      double tmp = principal;

      double interest = 0;
      if (comboBox1.SelectedIndex == 0)
      {
        interest = rate / periods;
      }
      else
      {
        interest = rate;
      }


      for (int i = permutations; i > 0; i--)
      {
        tmp += Math.Round(tmp * interest,2);
        dataGridView1.Rows.Add(((permutations-i) / periods),permutations - i + 1,tmp);
      }
      totalBox.Text = $"{tmp}";
    }

    
  }
}
