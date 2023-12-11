using CoffeLib;

namespace WinFormProductClient
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new();
        public Form1()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            cbocat.DataSource = Enum.GetValues<Category>();
            bs.DataSource = new List<CoffeResponse>();
            dgvProducts.DataSource = bs;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            btnRefresh.Click += DoClickRefresh;

            btnCreateSubmit.Click += DoClickCreateSubmit;

            bs.PositionChanged += DoProductPositionChanged;

            btnUpdateSubmit.Click += DoClickUpdateSubmit;

            btnDelete.Click += DoClickDelete;

            btnCreateClear.Click += DoClickCreateClear;
        }
        void clear()
        {
            txtcode.Clear();
            txtname.Clear();
            cbocat.SelectedItem = Category.None;
            txtprice.Clear();
        }
        private void DoClickCreateClear(object? sender, EventArgs e)
        {
            txtcode.Clear();
            txtname.Clear();
            cbocat.SelectedItem = Category.None;
            txtprice.Clear();
        }

        private async void DoClickDelete(object? sender, EventArgs e)
        {
            if (bs.Current == null) return;
            if (bs.Current is not CoffeResponse prd) return;
            string endpoint = $"api/coffes/{prd.Id}";
            var result = await Program.RestClient.DeleteAsync<Result<string?>>(endpoint);
            if (result!.Succeded && prd.Id == result!.Data)
            {
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
            clear();
            MessageBox.Show(result!.Message);
        }

        private async void DoClickUpdateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/coffes";
            Category cat = ((Category)cbocat.SelectedItem);
            var req = new CoffeUpdateReq()
            {
                Key = txtcode.Text,
                Name = txtname.Text,
                Category = cat == Category.None ? null : cat.ToString(),
                Price=float.Parse(txtprice.Text),
            };
            var result = await Program.RestClient.PutAsync<CoffeUpdateReq, Result<string?>>(endpoint, req);
            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    endpoint = $"api/coffes/{result!.Data!}";
                    var foundResult = await Program.RestClient.GetAsync<Result<CoffeResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        var found = (bs.DataSource as List<CoffeResponse>)?.FirstOrDefault(b => b.Id == foundResult.Data.Id);
                        if (found != null)
                        {
                            found.Name = foundResult.Data.Name;
                            found.Category = foundResult.Data.Category;
                            bs.ResetBindings(false);
                        }
                    }
                  
                }
            });
            clear();
            MessageBox.Show(result!.Message);
            task.Wait();
        }

        private void DoProductPositionChanged(object? sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                txtcode.Clear();
                txtname.Clear();
                cbocat.SelectedItem = Category.None;
                txtprice.Clear();
            }
        }

        private async void DoClickCreateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/coffes";
            Category cat = ((Category)cbocat.SelectedItem);
            var req = new CoffeCreateReq()
            {
                Code = txtcode.Text,
                Name = txtname.Text,
                Category = cat == Category.None ? null : cat.ToString(),
                Price = float.Parse(txtprice.Text),
            };
            var result = await Program.RestClient.PostAsync<CoffeCreateReq, Result<string?>>(endpoint, req);
            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    endpoint = $"api/coffes/{result!.Data}";
                    var foundResult = await Program.RestClient.GetAsync<Result<CoffeResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        (bs.DataSource as List<CoffeResponse>)?.Add(foundResult.Data);
                        bs.ResetBindings(false);
                    }
                }
            });
            clear();
            MessageBox.Show(result!.Message);
        }

        private async void DoClickRefresh(object? sender, EventArgs e)
        {
            string endpoint = "api/coffes";
            var result = await Program.RestClient.GetAsync<Result<List<CoffeResponse>>>(endpoint);
            if (result!.Succeded == true)
            {
                bs.DataSource = result.Data;
                bs.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {

            if (bs.Current is CoffeResponse prd)
            {
                txtcode.Text = prd.Code.ToString();
                txtname.Text = prd.Name;
                Category cat = Category.None;
                Enum.TryParse<Category>(prd.Category ?? "", out cat);
                cbocat.SelectedItem = cat;
                txtprice.Text = prd.Price.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateSubmit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}