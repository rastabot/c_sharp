using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MyPLINQWin
{
    public partial class frmMain : Form
    {
        // Cancelation token
        private CancellationTokenSource cancelToken =
            new CancellationTokenSource();

        public frmMain()
        {
            InitializeComponent();
        }

        private void ProcessData()
        {
            int[] myNumArr = Enumerable.Range(1, 2000000).ToArray();
            int[] divideByThree = null;

            try
            {
                divideByThree = (from num in myNumArr.AsParallel().
                                 WithCancellation(cancelToken.Token)
                                 .WithDegreeOfParallelism(2)
                                 where num % 3 == 0
                                 orderby num descending
                                 select num).ToArray();
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExcecute_Click(object sender, EventArgs e)
        {
            // ProcessData();
            Task.Factory.StartNew(() => {
                Thread.Sleep(500);
                ProcessData();
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
            MessageBox.Show("I am here");
            // closing the current form 
            this.Close();
            // closing the application
            // Application.Exit();
            
        }
    }
}
