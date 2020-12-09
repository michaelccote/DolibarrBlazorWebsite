using System.Collections.Generic;
using VincentsShop.WASM.Shared.Models;

namespace VincentsShop.WASM.Client.Services
{
    public class OrderState
    {
        public bool showingConfigureDialog { get; private set; }
        public Order configuringOrder { get; private set; } = new Order() { lines = new List<OrderLine>() };
        public OrderLine configuringOrderLine { get; private set; }

        public void ShowConfigureOrderDialog(Product product)
        {
            configuringOrderLine = new OrderLine()
            {
                //Quantité en stock
                //Lien vers produit
                //Lors de l'ouverture du dialog, aller chercher les clients possibles pour le combobox
                product = product,
                qty = "1"
            };

            showingConfigureDialog = true;
        }

        public void CancelConfigureOrderDialog()
        {
            configuringOrderLine = null;
            showingConfigureDialog = false;
        }

        public void ConfirmConfigureOrderDialog()
        {
            //2-way data binding pour la quantité. Sinon ici
            configuringOrderLine.FinalizeOrderLine();
            configuringOrder.lines.Add(configuringOrderLine);
            configuringOrderLine = null;

            showingConfigureDialog = false;
        }

        public void RemoveProductFromOrder(OrderLine orderLine2Remove)
        {
            configuringOrder.lines.Remove(orderLine2Remove);
        }

        public void ResetOrder()
        {
            configuringOrder = new Order();
            configuringOrder.lines = new List<OrderLine>();
        }

    }
}
