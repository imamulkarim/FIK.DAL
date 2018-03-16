using FIK.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Client
{
    public partial class MainFormForm : Form
    {
        FIK.DAL.SQL sqlDal;

        
        
        public MainFormForm()
        {
            InitializeComponent();

            string dbPaht = Application.StartupPath + "\\TestDatabase.mdf";
            string connectionString = string.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={0};database=TestDatabase;Integrated Security=True", dbPaht);
            sqlDal = new FIK.DAL.SQL(connectionString);
            //sqlDal.ExecuteQuery(,)
        }

        private void btnSingleAll_Click(object sender, EventArgs e)
        {
            Student model = new Student();
            model.CPGA = 3.87f;
            model.EnrollDate = DateTime.Now.Date;
            //studentModel.ID = ; auto generate
            model.LastActiveDate = DateTime.Now;
            model.LastPresentTime = new TimeSpan(11, 10, 0);

            Image img = new ImageHelper().GenerateThumbnailImage(@"C:\Users\TonmoyVP\Desktop\GadgetAndGearPOS\GadgetAndGearPOS\images\icon_reports.png");
            model.StudentImage = new ImageHelper().ImageToByte(img);
            model.StudentName = "Mr. Fazle Imamul Karim Tonmoy";
            model.MonthlyTutionFee = 2000;

            string msg = "";
            bool r = sqlDal.Insert<Student>(model, "", "id","", ref msg);

            if (r)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }


        private void btnSingleSelective_Click(object sender, EventArgs e)
        {
            Student model = new Student();
            model.CPGA = 3.87f;
            model.StudentName = "Md. Arman Hossain";

            string msg = "";
            bool r = sqlDal.Insert<Student>(model, "CPGA,StudentName", "id","", ref msg);

            if (r)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string msg = "";
            string query = @"select * from Student";

            DataTable dataTable = sqlDal.Select(query, ref msg);

            dgvStudentData.DataSource = dataTable;

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }

        }

        private void btnUpdateSingleAll_Click(object sender, EventArgs e)
        {
            Student model = new Student();
            model.CPGA = 3.17f;
            model.EnrollDate = DateTime.Now.Date;
            //studentModel.ID = ; auto generate
            model.LastActiveDate = DateTime.Now;
            model.LastPresentTime = new TimeSpan(11, 10, 0);

            Image img = new ImageHelper().GenerateThumbnailImage(@"C:\Users\TonmoyVP\Desktop\GadgetAndGearPOS\GadgetAndGearPOS\images\icon_reports.png");
            model.StudentImage = new ImageHelper().ImageToByte(img);
            model.StudentName = "Md. Fazle Imamul Karim Tonmoy";
            model.MonthlyTutionFee = 2000;
            model.ID = 1;

            string msg = "";
            bool r = sqlDal.Update<Student>(model, "", "id","", ref msg);

            if (r)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnCompositeInsetUpdate_Click(object sender, EventArgs e)
        {

            List<Purchase> listPurchase = new List<Purchase>();

            string maxId = sqlDal.GetMaxId("RcvNo", "000", "Purchase", "R2018");

            {
                Purchase model = new Purchase();
                model.PrdCode = "1001";
                model.Qty = 10;
                //model.ID = ; auto generate
                model.RcvDate = DateTime.Now;
                model.RcvNo = maxId;
                model.TestMoney = 20; 
                model.TestNumeric = 200.5m; 

                listPurchase.Add(model);

                model = new Purchase();
                model.PrdCode = "1002";
                model.Qty = 15;
                //model.ID = ; auto generate

                //model.RcvDate = DateTime.Now; //for null test 
                //model.TestMoney = 0; // for null test
                //model.TestNumeric = 0; // for null test

                model.RcvNo = maxId;
                listPurchase.Add(model);
            }

                Stock model2 = new Stock();
                List<Stock> listStock = new List<Stock>();

            {
                model2 = new Stock();
                model2.PrdCode = "1001";
                model2.RcvQty = 10;
                //model.ID = ; auto generate
                listStock.Add(model2);

                model2 = new Stock();
                model2.PrdCode = "1002";
                model2.RcvQty = 15;
                //model.ID = ; auto generate
                listStock.Add(model2);
            }


            CompositeModel compositeModel = new CompositeModel();
            compositeModel.AddRecordSet<Purchase>(listPurchase, OperationMode.Insert, "Id", "", "","");
            compositeModel.AddRecordSet<Stock>(listStock, OperationMode.InsertOrUpdaet, "", "PrdCode,+RcvQty", "PrdCode","");


            string msg = "";
            bool r = sqlDal.InsertUpdateComposite(compositeModel,  ref msg);

            if (r)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show(msg);
            }


        }

        private void btnLoadStockAndRcv_Click(object sender, EventArgs e)
        {

            string msg = "";
            string query = @"select * from Stock";

            List<Stock> stockList =
            sqlDal.Select<Stock>(query, ref msg);
            dgvStock.DataSource = stockList;

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }

            msg = "";
             query = @"select * from Purchase";

            List<Purchase> PurchaseList =
            sqlDal.Select<Purchase>(query, ref msg);
            dgvPurchase.DataSource = PurchaseList;

            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }





}
