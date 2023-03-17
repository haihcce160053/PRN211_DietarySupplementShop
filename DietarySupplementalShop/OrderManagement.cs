using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySupplementalShop
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void LoadOrder()
        {
            IOrderListRepository IOderList = new OrderListRepository();
            List<OrderList> orderlist = new List<OrderList>(IOderList.GetOrderList());
            if (orderlist != null)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.Columns.Add("OrderID", "Order ID");
                dataGridView1.Columns.Add("OrderStatusID", "Order status");
                dataGridView1.Columns.Add("Username", "Username");
                dataGridView1.Columns.Add("Address", "Address");
                dataGridView1.Columns.Add("Ordertime", "Order time");
                dataGridView1.Columns.Add("TotalBill", "Total bill");
                dataGridView1.ClearSelection();

                for (int i = 0; i < orderlist.Count; i++)
                {
                    dataGridView1.Rows.Add(orderlist[i].OrderId,
                        orderlist[i].OrderStatusId,
                        orderlist[i].Username,
                        orderlist[i].DeliveryAddress,
                        orderlist[i].OrderTime,
                        orderlist[i].TotalBill);

                    if (orderlist[i].OrderStatusId == "DHD")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (orderlist[i].OrderStatusId == "KLHD")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkOrchid;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].Value != null
               && dataGridView1.SelectedCells[1].Value != null
               && dataGridView1.SelectedCells[2].Value != null
               && dataGridView1.SelectedCells[3].Value != null
               && dataGridView1.SelectedCells[4].Value != null)
                {
                    txtOrderID.Text = dataGridView1.SelectedCells[0].Value.ToString();
                    txtOrderStatusID.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    txtAddress.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    txtOrderTime.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    txtTotalBill.Text = dataGridView1.SelectedCells[4].Value.ToString();
                }
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmOrderCRUD frmProductCRUD = new frmOrderCRUD(txtOrderID.Text, 4);
            frmProductCRUD.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderCRUD frmProductCRUD = new frmOrderCRUD(txtOrderID.Text, 2);
            frmProductCRUD.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
