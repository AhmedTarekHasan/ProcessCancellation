using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Runner : Form
    {
        private Guid m_Process1 = Guid.Parse("6BFB4FE2-E17E-423C-A889-426A0ADF4DF1");
        private Guid m_Process2 = Guid.Parse("97BD55BA-B039-460F-BDC9-34DAD57920C5");
        private Dictionary<Guid, CancellationTokenSource> m_TokensCatalog = new();

        public Runner()
        {
            InitializeComponent();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            var tokenSource = new CancellationTokenSource();
            m_TokensCatalog.Add(m_Process1, tokenSource);
            var cancellationToken = tokenSource.Token;
            TooLongProcess(LstLogs1, cancellationToken);
        }

        private void BtnStop1_Click(object sender, EventArgs e)
        {
            m_TokensCatalog[m_Process1].Cancel();
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            var tokenSource = new CancellationTokenSource();
            m_TokensCatalog.Add(m_Process2, tokenSource);
            var cancellationToken = tokenSource.Token;
            TooLongProcess(LstLogs2, cancellationToken);
        }

        private void BtnStop2_Click(object sender, EventArgs e)
        {
            m_TokensCatalog[m_Process2].Cancel();
        }

        private async Task TooLongProcess(ListBox lstBox, CancellationToken cancellationToken)
        {
            lstBox.Items.Add($"Started at {DateTime.Now}");

            for (var i = 1; i <= 10; i++)
            {
                lstBox.Items.Add($"At iteration #{i}");

                if (cancellationToken.IsCancellationRequested)
                {
                    lstBox.Items.Add($"Cancelled at {DateTime.Now}");
                    break;
                }

                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            if (!cancellationToken.IsCancellationRequested)
            {
                lstBox.Items.Add($"Ended at {DateTime.Now}");
            }
        }
    }
}