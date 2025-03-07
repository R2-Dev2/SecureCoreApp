using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace EDI
{
    public class OrderEdi
    {
        SecureCoreG7Orders db;
        List<Priority> priorities;
        List<OperationalArea> operationalAreas;
        List<Agency> agencies;
        List<Factory> factories;
        List<Planet> planets;
        List<Reference> references;

        public void LoadData()
        {
            db = new SecureCoreG7Orders();

            priorities = db.Priorities.ToList();
            operationalAreas = db.OperationalAreas.ToList();
            agencies = db.Agencies.ToList();
            factories = db.Factories.ToList();
            planets = db.Planets.ToList();
            references = db.References.ToList();
        }

        public void LoadEDI()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos EDI|*.edi;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string arxiuEdi = openFileDialog.FileName;

                try
                {
                    Order order = new Order();
                    OrdersDetail orderDetail = new OrdersDetail();

                    string[] linies = File.ReadAllLines(arxiuEdi);

                    foreach (string linia in linies)
                    {
                        string[] parts = linia.Split('|');
                        if (parts.Length > 0)
                        {
                            string format = parts[0].Trim();

                            switch (format)
                            {
                                case "ORD":
                                    order = new Order();
                                    string orderNumber = parts[1].Trim();
                                    order.codeOrder = orderNumber;

                                    string codePriority = parts[2].Trim();
                                    order.IdPriority = priorities.Find(p => p.CodePriority == codePriority).idPriority;

                                    break;
                                case "DTM":
                                    DateTime orderDate = dateFormater(parts[1].Trim());
                                    order.dateOrder = orderDate;

                                    break;
                                case "NADMS":
                                    OrderInfo orderInfo = new OrderInfo();

                                    string codeOperationArea = parts[1].Trim();
                                    string codeAgency = parts[2].Trim();

                                    orderInfo.idOperationalArea = operationalAreas.Find(p => p.CodeOperationalArea == codeOperationArea).idOperationalArea;
                                    orderInfo.idAgency = agencies.Find(p => p.CodeAgency == codeAgency).idAgency;

                                    order.OrderInfoes.Add(orderInfo);
                                    db.OrderInfoes.Add(orderInfo);

                                    break;
                                case "NADMR":
                                    string codeFactory = parts[1].Trim();
                                    order.IdFactory = factories.Find(p => p.codeFactory == codeFactory).idFactory;

                                    db.Orders.Add(order);

                                    break;
                                case "LIN":
                                    orderDetail = new OrdersDetail();
                                    string codePlanet = parts[1].Trim();
                                    orderDetail.idPlanet = planets.Find(p => p.CodePlanet == codePlanet).idPlanet;

                                    string codeReference = parts[2].Trim();
                                    orderDetail.idReference = references.Find(p => p.codeReference == codeReference).idReference;

                                    break;
                                case "QTYLIN":
                                    string orderQuantityCalifier = parts[1];
                                    int quantity = int.Parse(parts[2].Trim());

                                    if (orderQuantityCalifier == "61")
                                    {
                                        quantity = -quantity;
                                    }

                                    orderDetail.Quantity = (short)quantity;

                                    break;
                                case "DTMLIN":
                                    DateTime deliveryDate = dateFormater(parts[1].Trim());
                                    orderDetail.DeliveryDate = deliveryDate;

                                    order.OrdersDetails.Add(orderDetail);
                                    db.OrdersDetails.Add(orderDetail);

                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show("The data can't be added. " + e);
                }
            }
        }

        private DateTime dateFormater(string date)
        {
            DateTime dateFormated;

            dateFormated = DateTime.ParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture);

            return dateFormated;
        }
    }
}
