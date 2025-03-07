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
        Order selectedOrder = new Order();

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
            dtgDades.Columns["codeReference"].HeaderText = "Code";
            dtgDades.Columns["descReference"].HeaderText = "Desccription";
            dtgDades.Columns["idPriority"].Visible = false;
            dtgDades.Columns["descPlanet"].Visible = false;
            dtgDades.Columns["dateOrder"].Visible = false;
            dtgDades.Columns["idAgency"].Visible = false;
            dtgDades.Columns["CodeAgency"].Visible = false;
            dtgDades.Columns["DescAgency"].Visible = false;
            dtgDades.Columns["codeFactory"].Visible = false;
            dtgDades.Columns["DescFactory"].Visible = false;
            dtgDades.Columns["CodeOperationalArea"].Visible = false;
            dtgDades.Columns["DescOperationalArea"].Visible = false;
        }

        private void LoadOrder()
        {
            selectedOrder = orders.Where(o => o.codeOrder == txtOrderCode.Text).FirstOrDefault();
            if(selectedOrder is null) 
            {
                lblError.Text = "The order has not been found.";
                lblError.Visible = true;
                ClearBindings();
                return;
            }

            orderInfo = GetOrderInfoAreaByOrder(selectedOrder.idOrder);

            lblError.Visible = false;

            short idOrder = GetOrderIdByCode(txtOrderCode.Text);

            Agency agency = GetAgencyByOrder(idOrder);
            OperationalArea operationalArea = GetOperationalAreaByOrder(idOrder);

            var singleOrderDetails = db.OrdersDetails
                              .Where(OrderDetails => OrderDetails.idOrder == idOrder)
                              .Select(OrderDetails => new
                              {
                                  OrderDetails.idOrderDetail,
                                  OrderDetails.Reference.codeReference,
                                  OrderDetails.Reference.descReference,
                                  OrderDetails.Quantity,
                                  OrderDetails.DeliveryDate,
                                  OrderDetails.Order.IdPriority,
                                  OrderDetails.Planet.DescPlanet,
                                  OrderDetails.Order.dateOrder,
                                  OrderDetails.Order.Factory.codeFactory,
                                  OrderDetails.Order.Factory.DescFactory,
                                  agency.idAgency,
                                  agency.CodeAgency,
                                  agency.DescAgency,
                                  operationalArea.CodeOperationalArea,
                                  operationalArea.DescOperationalArea

                              }).ToList();

            dtgDades.DataSource = singleOrderDetails;
            ConfigureDataGrid();

            dtgDades.Refresh();

            cbPriority.DataSource = priorities;
            cbPriority.DisplayMember = "descPriority";
            cbPriority.ValueMember = "idPriority";

            cbAgency.DataSource = agencies;
            cbAgency.DisplayMember = "descAgency";
            cbAgency.ValueMember = "idAgency";

            //BindDades();
        }

        private short GetOrderIdByCode(string codeOrder)
        {
            var order = db.Orders
                          .Where(o => o.codeOrder == codeOrder)
                          .Select(o => o.idOrder)
                          .FirstOrDefault();

            return order;
        }

        private Agency GetAgencyByOrder(short idOrder)
        {
            Agency agency = db.OrderInfoes
                         .Where(oi => oi.idOrder == idOrder)
                         .Select(oi => oi.Agency)
                         .FirstOrDefault();

            return agency;
        }

        private OperationalArea GetOperationalAreaByOrder(short idOrder)
        {
            OperationalArea operationalArea = db.OrderInfoes
                         .Where(oi => oi.idOrder == idOrder)
                         .Select(oi => oi.OperationalArea)
                         .FirstOrDefault();

            return operationalArea;
        }

        private OrderInfo GetOrderInfoAreaByOrder(short idOrder)
        {
            OrderInfo orderInfo = db.OrderInfoes
                         .Where(oi => oi.idOrder == idOrder)
                         .FirstOrDefault();

            return orderInfo;
        }

        //private void BindDades()
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is SWTextBox swTxt)
        //        {
        //            swTxt.DataBindings.Clear();
        //            swTxt.DataBindings.Add("Text", dtgDades.DataSource, swTxt.columnName);
        //            swTxt.Validated += new EventHandler(this.ValidateTextBox);
        //        }
        //        else if(ctrl is ComboBox cb)
        //        {
        //            cb.DataBindings.Clear();
        //            cb.DataBindings.Add("SelectedValue", dtgDades.DataSource, cb.Tag.ToString());
        //        }
        //        else if (ctrl is DateTimePicker dtp)
        //        {
        //            dtp.DataBindings.Clear();
        //            dtp.DataBindings.Add("Value", dtgDades.DataSource, dtp.Tag.ToString());
        //        }
        //    }
        //}

        private void ClearBindings()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SWTextBox swTxt)
                {
                    swTxt.DataBindings.Clear();
                    swTxt.Text = "";
                    swTxt.Validated -= new EventHandler(this.ValidateTextBox);
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.DataBindings.Clear();
                    //TODO limpiar selección
                }
            }
        }

        private void ValidateTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(swtxtQuantity.Text))
            {
                lblError.Text = "The order has not been found.";
                lblError.Visible = true;
                return;
            }

            selectedOrder.IdFactory = short.Parse(cbPriority.SelectedValue.ToString());
            db.SaveChanges();

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
    }
}
