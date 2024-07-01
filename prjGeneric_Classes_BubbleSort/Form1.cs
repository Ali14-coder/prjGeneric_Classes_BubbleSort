namespace prjGeneric_Classes_BubbleSort
{
    public partial class Form1 : Form
    {
        Generic_Results<double> gr; //this is the generic class
        Calculate_Average cs = new Calculate_Average(); //sealed class
        public Form1()
        {
            InitializeComponent();
            gr = new Generic_Results<double>(5);
        }

        private void btnOrderResults_Click(object sender, EventArgs e)
        {
            object results1 = this.txtRes1.Text;
            object results2 = this.txtRes2.Text;
            object results3 = this.txtRes3.Text;
            object results4 = this.txtRes4.Text;
            object results5 = this.txtRes5.Text;

            gr.Push(results1, results2, results3, results4, results5);

            object[] sorted_results = gr.Display_and_Sort();

            this.txtRes1.Text = sorted_results[0].ToString();
            this.txtRes2.Text = sorted_results[1].ToString();
            this.txtRes3.Text = sorted_results[2].ToString();
            this.txtRes4.Text = sorted_results[3].ToString();
            this.txtRes5.Text = sorted_results[4].ToString();

            double dblAVG = cs.determine_avg(sorted_results);
            this.txtAverage.Text = "" +dblAVG + "%";
        }

    }
}
