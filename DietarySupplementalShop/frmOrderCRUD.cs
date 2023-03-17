using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class frmOrderCRUD : Form
    {
        private string id;
        private int CRUDStatus;

        public frmOrderCRUD(string id, int CRUDStatus)
        {
            InitializeComponent();
            this.id = id;
            this.CRUDStatus = CRUDStatus;
        }

        private void frmOrderCRUD_Load(object sender, EventArgs e)
        {
            //Update
            if (CRUDStatus == 2)
            {
                GetOrderInformation();
                btnProcess.Text = "Update product";
                this.Text = "Update product information";
            }

            //View
            if (CRUDStatus == 4)
            {
                GetOrderInformation();
                btnProcess.Hide();
                this.Text = "View order information";
            }
        }

        private void GetOrderInformation()
        {
            IOrderListRepository IOrderList = new OrderListRepository();
            IOrderDetailRepository IOrderDetail = new OrderDetailRepository();
            OrderList orderlist = IOrderList.GetOrderListByID(id);
            List<OrderDetail> orderdetail = IOrderDetail.GetOrderDetailByID(id).ToList();

            if (orderlist != null && orderdetail != null)
            {
                txtOrderID.Text = orderlist.OrderId;
                cbOrderStatus.SelectedIndex = cbOrderStatus.FindStringExact(orderlist.OrderStatusId);
                for (int i = 0; i < orderdetail.Count; i++)
                {
                    txtProductID.Text = txtProductID.Text + orderdetail[i].ProductId + " | ";
                }
                txtUsername.Text = orderlist.Username;
                txtAddress.Text = orderlist.DeliveryAddress;
                dateTimeOrder.Value = orderlist.OrderTime;
                int TotalQuantity = 0;
                for (int i = 0; i < orderdetail.Count; i++)
                {
                    TotalQuantity = TotalQuantity + orderdetail[i].Quantity;
                    txtQuantity.Text = txtQuantity.Text + orderdetail[i].ProductId + " x" + orderdetail[i].Quantity.ToString() + " | ";
                }
                txtTotalBill.Text = orderlist.TotalBill.ToString();
                txtProductID.Text = txtProductID.Text.Remove(txtProductID.Text.Length - 2, 1);
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 2, 1);
                txtTotalQuantity.Text = TotalQuantity.ToString();
            }
        }

        private void UpdateOrderInformation()
        {
            IOrderListRepository IOrderList = new OrderListRepository();
            OrderList orderlist = IOrderList.GetOrderListByID(id);

            orderlist.OrderStatusId = cbOrderStatus.Text.ToString();
            orderlist.DeliveryAddress = txtAddress.Text;
            orderlist.OrderTime = dateTimeOrder.Value;

            if (IOrderList.UpdateOrderList(orderlist) == true)
            {
                MessageBox.Show("Update product for " + orderlist.OrderId + " successful");
            }
            else
            {
                MessageBox.Show("Update account for " + orderlist.OrderId + " failed");
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Update
            if(CRUDStatus == 2)
            {
                UpdateOrderInformation();
                this.Close();
            }
        }
    }
}
