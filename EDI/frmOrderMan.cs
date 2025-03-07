using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using System.IO;
using System.Globalization;
using System.Data.Entity;

namespace EDI
{
    public partial class frmOrderMan : Form
    {
        SecureCoreG7Orders db;
        List<Priority> priorities;
        List<Agency> agencies;
        List<Order> orders;
        List<OrdersDetail> ordersDetails;
        OrderInfo orderInfo;
        Order selectedOrder;

        public frmOrderMan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            db = new SecureCoreG7Orders();

            priorities = db.Priorities.ToList();
            agencies = db.Agencies.ToList();
            orders = db.Orders.ToList();
        }
        
        private void ConfigureDataGrid()
        {
            dtgDades.Columns["idOrderDetail"].Visible = false;
            dtgDades.Columns["idOrder"].Visible = false;
            dtgDades.Columns["idPlanet"].Visible = false;
            dtgDades.Columns["idReference"].Visible = false;
            dtgDades.Columns["Planet"].Visible = false;
            dtgDades.Columns["Order"].Visible = false;
            dtgDades.Columns["Reference"].Visible = false;
        }

        private void LoadOrder()
        {
            selectedOrder = orders.Where(o => o.codeOrder == txtOrderCode.Text).FirstOrDefault();
            if(selectedOrder is null) 
            {
                lblError.Text = "The order has not been found.";
                lblError.Visible = true;
                return;
            }

            orderInfo = GetOrderInfoAreaByOrder(selectedOrder.idOrder);

            lblError.Visible = false;

            short idOrder = selectedOrder.idOrder;

            ordersDetails = db.OrdersDetails.Where(OrderDetails => OrderDetails.idOrder == idOrder).ToList(); 

            dtgDades.DataSource = ordersDetails;
            dtgDades.Rows[0].Selected = true;
            ConfigureDataGrid();

            dtgDades.Refresh();

            SetInfo();
            BindDades();
        }

        private void SetInfo()
        {
            cbPriority.DataSource = priorities;
            cbPriority.DisplayMember = "descPriority";
            cbPriority.ValueMember = "idPriority";

            cbAgency.DataSource = agencies;
            cbAgency.DisplayMember = "descAgency";
            cbAgency.ValueMember = "idAgency";

            swtxtDescFactory.Text = selectedOrder.Factory.DescFactory;
            swtxtFactoryCode.Text = selectedOrder.Factory.codeFactory;
            swtxtOrderDate.Text = selectedOrder.dateOrder.ToString();
            swtxtOperationalArea.Text = orderInfo.OperationalArea.DescOperationalArea;
            swtxtDescReference.Text = ordersDetails[0].Reference.descReference;
            swtxtPlanet.Text = ordersDetails[0].Planet.DescPlanet;
            cbAgency.SelectedValue = orderInfo.idAgency;
            cbPriority.SelectedValue = selectedOrder.IdPriority;
        }

        private OrderInfo GetOrderInfoAreaByOrder(short idOrder)
        {
            OrderInfo orderInfo = db.OrderInfoes
                         .Where(oi => oi.idOrder == idOrder)
                         .FirstOrDefault();

            return orderInfo;
        }

        private void BindDades()
        {         
            swtxtQuantity.DataBindings.Clear();
            swtxtQuantity.DataBindings.Add("Text", dtgDades.DataSource, swtxtQuantity.columnName);
            dtpDeliveryDate.DataBindings.Clear();
            dtpDeliveryDate.DataBindings.Add("Value", dtgDades.DataSource, dtpDeliveryDate.Tag.ToString());
        }

        private void ValidateTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(swtxtQuantity.Text))
            {
                lblError.Text = "Quantity can't be null.";
                lblError.Visible = true;
                return;
            }

            if (selectedOrder is null) return;
            selectedOrder.IdPriority = short.Parse(cbPriority.SelectedValue.ToString());
            orderInfo.idAgency = short.Parse(cbAgency.SelectedValue.ToString());
            
            db.SaveChanges();
            LoadData();
        }



        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderMan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void dtgDades_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dtgDades.SelectedRows[0].Index;
                swtxtDescReference.Text = ordersDetails[selectedRowIndex].Reference.descReference;
                swtxtPlanet.Text = ordersDetails[selectedRowIndex].Planet.DescPlanet;
            }
            catch (Exception) { };
            
        }

        private void swtxtQuantity_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int selectedRowIndex = dtgDades.SelectedRows[0].Index;
                ordersDetails[selectedRowIndex].Quantity = short.Parse(swtxtQuantity.Text);
            }
            catch (Exception) { };
        }

        private void dtpDeliveryDate_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int selectedRowIndex = dtgDades.SelectedRows[0].Index;
                ordersDetails[selectedRowIndex].DeliveryDate = dtpDeliveryDate.Value;
            }
            catch(Exception) { };
        }

        private void btnCarregarEdi_Click(object sender, EventArgs e)
        {
            OrderEdi orderEdi = new OrderEdi();
            orderEdi.LoadData();
            orderEdi.LoadEDI();

            LoadData();
        }
    }
}
