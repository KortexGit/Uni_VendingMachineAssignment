
namespace Check_Out_Ver._1._0
{
    partial class Vending_Machine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vending_Machine));
            this.btnItem_1 = new System.Windows.Forms.Button();
            this.btnItem_2 = new System.Windows.Forms.Button();
            this.btnItem_3 = new System.Windows.Forms.Button();
            this.btnItem_4 = new System.Windows.Forms.Button();
            this.btnItem_5 = new System.Windows.Forms.Button();
            this.btnItem_6 = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtCoinSlot = new System.Windows.Forms.TextBox();
            this.txtNoteSlot = new System.Windows.Forms.TextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnMoney1 = new System.Windows.Forms.Button();
            this.btnMoney50p = new System.Windows.Forms.Button();
            this.btnMoney5 = new System.Windows.Forms.Button();
            this.btnMoney20p = new System.Windows.Forms.Button();
            this.btnMoney10 = new System.Windows.Forms.Button();
            this.btnMoney20 = new System.Windows.Forms.Button();
            this.pnlMoneySelection = new System.Windows.Forms.Panel();
            this.pnlItemSelection = new System.Windows.Forms.Panel();
            this.nudItem6Quantity = new System.Windows.Forms.NumericUpDown();
            this.nudItem5Quantity = new System.Windows.Forms.NumericUpDown();
            this.nudItem4Quantity = new System.Windows.Forms.NumericUpDown();
            this.nudItem3Quantity = new System.Windows.Forms.NumericUpDown();
            this.nudItem2Quantity = new System.Windows.Forms.NumericUpDown();
            this.nudItem1Quantity = new System.Windows.Forms.NumericUpDown();
            this.lblItemsInBasket = new System.Windows.Forms.Label();
            this.lblQuantityInBasket = new System.Windows.Forms.Label();
            this.lstItemsInBasket = new System.Windows.Forms.ListBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.txtTotalItemCount = new System.Windows.Forms.TextBox();
            this.lstQuantityInBasket = new System.Windows.Forms.ListBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.txtTotalOrderPrice = new System.Windows.Forms.TextBox();
            this.btnBackToOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.timerForFormTimeOut = new System.Windows.Forms.Timer(this.components);
            this.timerForTimeOutMessageBox = new System.Windows.Forms.Timer(this.components);
            this.lblQuantityToRemove = new System.Windows.Forms.Label();
            this.pnlQuantityToRemove = new System.Windows.Forms.Panel();
            this.btnCompleteItemRemoval = new System.Windows.Forms.Button();
            this.nudQuantityToRemoveItem6 = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityToRemoveItem5 = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityToRemoveItem4 = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityToRemoveItem3 = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityToRemoveItem2 = new System.Windows.Forms.NumericUpDown();
            this.nudQuantityToRemoveItem1 = new System.Windows.Forms.NumericUpDown();
            this.pnlMoneySelection.SuspendLayout();
            this.pnlItemSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem6Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem5Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem4Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem3Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem2Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem1Quantity)).BeginInit();
            this.pnlQuantityToRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItem_1
            // 
            this.btnItem_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_1.BackgroundImage")));
            this.btnItem_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_1.Location = new System.Drawing.Point(3, 3);
            this.btnItem_1.Name = "btnItem_1";
            this.btnItem_1.Size = new System.Drawing.Size(100, 100);
            this.btnItem_1.TabIndex = 0;
            this.btnItem_1.Text = "Fanta - $5.00";
            this.btnItem_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_1.UseVisualStyleBackColor = true;
            this.btnItem_1.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnItem_2
            // 
            this.btnItem_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_2.BackgroundImage")));
            this.btnItem_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_2.Location = new System.Drawing.Point(109, 3);
            this.btnItem_2.Name = "btnItem_2";
            this.btnItem_2.Size = new System.Drawing.Size(100, 100);
            this.btnItem_2.TabIndex = 1;
            this.btnItem_2.Text = "Coke - $6.00";
            this.btnItem_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_2.UseVisualStyleBackColor = true;
            this.btnItem_2.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnItem_3
            // 
            this.btnItem_3.BackColor = System.Drawing.SystemColors.Window;
            this.btnItem_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_3.BackgroundImage")));
            this.btnItem_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_3.Location = new System.Drawing.Point(3, 109);
            this.btnItem_3.Name = "btnItem_3";
            this.btnItem_3.Size = new System.Drawing.Size(100, 99);
            this.btnItem_3.TabIndex = 2;
            this.btnItem_3.Text = "Sausage Roll - $7.50";
            this.btnItem_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_3.UseVisualStyleBackColor = false;
            this.btnItem_3.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnItem_4
            // 
            this.btnItem_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_4.BackgroundImage")));
            this.btnItem_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_4.Location = new System.Drawing.Point(109, 109);
            this.btnItem_4.Name = "btnItem_4";
            this.btnItem_4.Size = new System.Drawing.Size(100, 99);
            this.btnItem_4.TabIndex = 3;
            this.btnItem_4.Text = "Sandwich - $10.00";
            this.btnItem_4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_4.UseVisualStyleBackColor = true;
            this.btnItem_4.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnItem_5
            // 
            this.btnItem_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_5.BackgroundImage")));
            this.btnItem_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_5.Location = new System.Drawing.Point(3, 215);
            this.btnItem_5.Name = "btnItem_5";
            this.btnItem_5.Size = new System.Drawing.Size(100, 100);
            this.btnItem_5.TabIndex = 4;
            this.btnItem_5.Text = "Crisps - $2.50 ";
            this.btnItem_5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_5.UseVisualStyleBackColor = true;
            this.btnItem_5.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnItem_6
            // 
            this.btnItem_6.BackColor = System.Drawing.SystemColors.Window;
            this.btnItem_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItem_6.BackgroundImage")));
            this.btnItem_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItem_6.Location = new System.Drawing.Point(109, 215);
            this.btnItem_6.Name = "btnItem_6";
            this.btnItem_6.Size = new System.Drawing.Size(100, 100);
            this.btnItem_6.TabIndex = 5;
            this.btnItem_6.Text = "Chocolate - $1.75";
            this.btnItem_6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItem_6.UseVisualStyleBackColor = false;
            this.btnItem_6.Click += new System.EventHandler(this.ItemClick);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(379, 342);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(215, 43);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // txtCoinSlot
            // 
            this.txtCoinSlot.AllowDrop = true;
            this.txtCoinSlot.Enabled = false;
            this.txtCoinSlot.Location = new System.Drawing.Point(379, 391);
            this.txtCoinSlot.Multiline = true;
            this.txtCoinSlot.Name = "txtCoinSlot";
            this.txtCoinSlot.ReadOnly = true;
            this.txtCoinSlot.ShortcutsEnabled = false;
            this.txtCoinSlot.Size = new System.Drawing.Size(215, 47);
            this.txtCoinSlot.TabIndex = 9;
            this.txtCoinSlot.Text = "Coin Slot";
            this.txtCoinSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCoinSlot.DragDrop += new System.Windows.Forms.DragEventHandler(this.MoneyDragDrop);
            this.txtCoinSlot.DragEnter += new System.Windows.Forms.DragEventHandler(this.CoinDragEnter);
            // 
            // txtNoteSlot
            // 
            this.txtNoteSlot.AllowDrop = true;
            this.txtNoteSlot.Enabled = false;
            this.txtNoteSlot.Location = new System.Drawing.Point(379, 445);
            this.txtNoteSlot.Multiline = true;
            this.txtNoteSlot.Name = "txtNoteSlot";
            this.txtNoteSlot.ReadOnly = true;
            this.txtNoteSlot.ShortcutsEnabled = false;
            this.txtNoteSlot.Size = new System.Drawing.Size(215, 47);
            this.txtNoteSlot.TabIndex = 10;
            this.txtNoteSlot.Text = "Note Slot";
            this.txtNoteSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoteSlot.DragDrop += new System.Windows.Forms.DragEventHandler(this.MoneyDragDrop);
            this.txtNoteSlot.DragEnter += new System.Windows.Forms.DragEventHandler(this.NoteDragEnter);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(379, 498);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(215, 47);
            this.btnCancelOrder.TabIndex = 11;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // btnMoney1
            // 
            this.btnMoney1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney1.BackgroundImage")));
            this.btnMoney1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoney1.Location = new System.Drawing.Point(0, 52);
            this.btnMoney1.Name = "btnMoney1";
            this.btnMoney1.Size = new System.Drawing.Size(59, 57);
            this.btnMoney1.TabIndex = 16;
            this.btnMoney1.Text = "1";
            this.btnMoney1.UseVisualStyleBackColor = true;
            this.btnMoney1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney1_MouseDown);
            // 
            // btnMoney50p
            // 
            this.btnMoney50p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney50p.BackgroundImage")));
            this.btnMoney50p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney50p.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMoney50p.Location = new System.Drawing.Point(79, 52);
            this.btnMoney50p.Name = "btnMoney50p";
            this.btnMoney50p.Size = new System.Drawing.Size(58, 57);
            this.btnMoney50p.TabIndex = 17;
            this.btnMoney50p.Text = "50p";
            this.btnMoney50p.UseVisualStyleBackColor = true;
            this.btnMoney50p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney50p_MouseDown);
            // 
            // btnMoney5
            // 
            this.btnMoney5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney5.BackgroundImage")));
            this.btnMoney5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney5.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMoney5.Location = new System.Drawing.Point(143, 1);
            this.btnMoney5.Name = "btnMoney5";
            this.btnMoney5.Size = new System.Drawing.Size(69, 44);
            this.btnMoney5.TabIndex = 15;
            this.btnMoney5.Text = "5";
            this.btnMoney5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney5.UseVisualStyleBackColor = true;
            this.btnMoney5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney5_MouseDown);
            // 
            // btnMoney20p
            // 
            this.btnMoney20p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney20p.BackgroundImage")));
            this.btnMoney20p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney20p.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnMoney20p.Location = new System.Drawing.Point(143, 52);
            this.btnMoney20p.Name = "btnMoney20p";
            this.btnMoney20p.Size = new System.Drawing.Size(57, 57);
            this.btnMoney20p.TabIndex = 18;
            this.btnMoney20p.Text = "20p";
            this.btnMoney20p.UseVisualStyleBackColor = true;
            this.btnMoney20p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney20p_MouseDown);
            // 
            // btnMoney10
            // 
            this.btnMoney10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney10.BackgroundImage")));
            this.btnMoney10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney10.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnMoney10.Location = new System.Drawing.Point(79, 1);
            this.btnMoney10.Name = "btnMoney10";
            this.btnMoney10.Size = new System.Drawing.Size(68, 44);
            this.btnMoney10.TabIndex = 14;
            this.btnMoney10.Text = "10";
            this.btnMoney10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoney10.UseVisualStyleBackColor = true;
            this.btnMoney10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney10_MouseDown);
            // 
            // btnMoney20
            // 
            this.btnMoney20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoney20.BackgroundImage")));
            this.btnMoney20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoney20.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnMoney20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney20.Location = new System.Drawing.Point(0, 1);
            this.btnMoney20.Name = "btnMoney20";
            this.btnMoney20.Size = new System.Drawing.Size(81, 44);
            this.btnMoney20.TabIndex = 13;
            this.btnMoney20.Text = "20";
            this.btnMoney20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMoney20.UseVisualStyleBackColor = true;
            this.btnMoney20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMoney20_MouseDown);
            // 
            // pnlMoneySelection
            // 
            this.pnlMoneySelection.Controls.Add(this.btnMoney20p);
            this.pnlMoneySelection.Controls.Add(this.btnMoney10);
            this.pnlMoneySelection.Controls.Add(this.btnMoney50p);
            this.pnlMoneySelection.Controls.Add(this.btnMoney5);
            this.pnlMoneySelection.Controls.Add(this.btnMoney1);
            this.pnlMoneySelection.Controls.Add(this.btnMoney20);
            this.pnlMoneySelection.Enabled = false;
            this.pnlMoneySelection.Location = new System.Drawing.Point(161, 388);
            this.pnlMoneySelection.Name = "pnlMoneySelection";
            this.pnlMoneySelection.Size = new System.Drawing.Size(212, 109);
            this.pnlMoneySelection.TabIndex = 21;
            // 
            // pnlItemSelection
            // 
            this.pnlItemSelection.Controls.Add(this.nudItem6Quantity);
            this.pnlItemSelection.Controls.Add(this.nudItem5Quantity);
            this.pnlItemSelection.Controls.Add(this.nudItem4Quantity);
            this.pnlItemSelection.Controls.Add(this.nudItem3Quantity);
            this.pnlItemSelection.Controls.Add(this.nudItem2Quantity);
            this.pnlItemSelection.Controls.Add(this.nudItem1Quantity);
            this.pnlItemSelection.Controls.Add(this.btnItem_1);
            this.pnlItemSelection.Controls.Add(this.btnItem_2);
            this.pnlItemSelection.Controls.Add(this.btnItem_3);
            this.pnlItemSelection.Controls.Add(this.btnItem_5);
            this.pnlItemSelection.Controls.Add(this.btnItem_4);
            this.pnlItemSelection.Controls.Add(this.btnItem_6);
            this.pnlItemSelection.Location = new System.Drawing.Point(161, 70);
            this.pnlItemSelection.Name = "pnlItemSelection";
            this.pnlItemSelection.Size = new System.Drawing.Size(212, 315);
            this.pnlItemSelection.TabIndex = 22;
            // 
            // nudItem6Quantity
            // 
            this.nudItem6Quantity.Location = new System.Drawing.Point(110, 295);
            this.nudItem6Quantity.Name = "nudItem6Quantity";
            this.nudItem6Quantity.Size = new System.Drawing.Size(99, 20);
            this.nudItem6Quantity.TabIndex = 11;
            this.nudItem6Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudItem5Quantity
            // 
            this.nudItem5Quantity.Location = new System.Drawing.Point(3, 295);
            this.nudItem5Quantity.Name = "nudItem5Quantity";
            this.nudItem5Quantity.Size = new System.Drawing.Size(100, 20);
            this.nudItem5Quantity.TabIndex = 10;
            this.nudItem5Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudItem4Quantity
            // 
            this.nudItem4Quantity.Location = new System.Drawing.Point(110, 189);
            this.nudItem4Quantity.Name = "nudItem4Quantity";
            this.nudItem4Quantity.Size = new System.Drawing.Size(99, 20);
            this.nudItem4Quantity.TabIndex = 9;
            this.nudItem4Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudItem3Quantity
            // 
            this.nudItem3Quantity.Location = new System.Drawing.Point(3, 188);
            this.nudItem3Quantity.Name = "nudItem3Quantity";
            this.nudItem3Quantity.Size = new System.Drawing.Size(100, 20);
            this.nudItem3Quantity.TabIndex = 8;
            this.nudItem3Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudItem2Quantity
            // 
            this.nudItem2Quantity.Location = new System.Drawing.Point(110, 82);
            this.nudItem2Quantity.Name = "nudItem2Quantity";
            this.nudItem2Quantity.Size = new System.Drawing.Size(99, 20);
            this.nudItem2Quantity.TabIndex = 7;
            this.nudItem2Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudItem1Quantity
            // 
            this.nudItem1Quantity.Location = new System.Drawing.Point(3, 82);
            this.nudItem1Quantity.Name = "nudItem1Quantity";
            this.nudItem1Quantity.Size = new System.Drawing.Size(100, 20);
            this.nudItem1Quantity.TabIndex = 6;
            this.nudItem1Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblItemsInBasket
            // 
            this.lblItemsInBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsInBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblItemsInBasket.Location = new System.Drawing.Point(379, 73);
            this.lblItemsInBasket.Name = "lblItemsInBasket";
            this.lblItemsInBasket.Size = new System.Drawing.Size(121, 23);
            this.lblItemsInBasket.TabIndex = 23;
            this.lblItemsInBasket.Text = "Basket:";
            // 
            // lblQuantityInBasket
            // 
            this.lblQuantityInBasket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantityInBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuantityInBasket.Location = new System.Drawing.Point(498, 73);
            this.lblQuantityInBasket.Name = "lblQuantityInBasket";
            this.lblQuantityInBasket.Size = new System.Drawing.Size(96, 23);
            this.lblQuantityInBasket.TabIndex = 24;
            this.lblQuantityInBasket.Text = "Quantity:";
            // 
            // lstItemsInBasket
            // 
            this.lstItemsInBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.1F);
            this.lstItemsInBasket.FormattingEnabled = true;
            this.lstItemsInBasket.ItemHeight = 20;
            this.lstItemsInBasket.Location = new System.Drawing.Point(379, 93);
            this.lstItemsInBasket.Name = "lstItemsInBasket";
            this.lstItemsInBasket.Size = new System.Drawing.Size(121, 184);
            this.lstItemsInBasket.TabIndex = 25;
            this.lstItemsInBasket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemListBox_MouseDown);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(161, 498);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.ShortcutsEnabled = false;
            this.txtChange.Size = new System.Drawing.Size(212, 47);
            this.txtChange.TabIndex = 12;
            this.txtChange.Text = "Change Due: $0.00";
            this.txtChange.Visible = false;
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.BackColor = System.Drawing.SystemColors.Control;
            this.txtAmountToPay.Location = new System.Drawing.Point(161, 498);
            this.txtAmountToPay.Multiline = true;
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.ReadOnly = true;
            this.txtAmountToPay.ShortcutsEnabled = false;
            this.txtAmountToPay.Size = new System.Drawing.Size(212, 47);
            this.txtAmountToPay.TabIndex = 19;
            this.txtAmountToPay.Text = "Amount to Pay: $0.00";
            // 
            // txtTotalItemCount
            // 
            this.txtTotalItemCount.Location = new System.Drawing.Point(379, 300);
            this.txtTotalItemCount.Multiline = true;
            this.txtTotalItemCount.Name = "txtTotalItemCount";
            this.txtTotalItemCount.ReadOnly = true;
            this.txtTotalItemCount.ShortcutsEnabled = false;
            this.txtTotalItemCount.Size = new System.Drawing.Size(215, 20);
            this.txtTotalItemCount.TabIndex = 8;
            this.txtTotalItemCount.Text = "Total Item Count: 0 Items";
            // 
            // lstQuantityInBasket
            // 
            this.lstQuantityInBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.1F);
            this.lstQuantityInBasket.FormattingEnabled = true;
            this.lstQuantityInBasket.ItemHeight = 20;
            this.lstQuantityInBasket.Location = new System.Drawing.Point(498, 93);
            this.lstQuantityInBasket.Name = "lstQuantityInBasket";
            this.lstQuantityInBasket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstQuantityInBasket.Size = new System.Drawing.Size(96, 184);
            this.lstQuantityInBasket.TabIndex = 26;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblOrderSummary.Location = new System.Drawing.Point(379, 278);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(99, 17);
            this.lblOrderSummary.TabIndex = 27;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // txtTotalOrderPrice
            // 
            this.txtTotalOrderPrice.Location = new System.Drawing.Point(379, 319);
            this.txtTotalOrderPrice.Multiline = true;
            this.txtTotalOrderPrice.Name = "txtTotalOrderPrice";
            this.txtTotalOrderPrice.ReadOnly = true;
            this.txtTotalOrderPrice.ShortcutsEnabled = false;
            this.txtTotalOrderPrice.Size = new System.Drawing.Size(215, 19);
            this.txtTotalOrderPrice.TabIndex = 28;
            this.txtTotalOrderPrice.Text = "Total Order Price: $0.00";
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.Location = new System.Drawing.Point(164, 44);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(83, 23);
            this.btnBackToOrder.TabIndex = 29;
            this.btnBackToOrder.Text = "<- Back";
            this.btnBackToOrder.UseVisualStyleBackColor = true;
            this.btnBackToOrder.Visible = false;
            this.btnBackToOrder.Click += new System.EventHandler(this.BtnBackToOrder_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.AllowDrop = true;
            this.btnRemoveItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.BackgroundImage")));
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.Location = new System.Drawing.Point(600, 445);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(83, 100);
            this.btnRemoveItem.TabIndex = 30;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.DragDrop += new System.Windows.Forms.DragEventHandler(this.RemoveItem_DragDrop);
            this.btnRemoveItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.RemoveItem_DragEnter);
            // 
            // timerForFormTimeOut
            // 
            this.timerForFormTimeOut.Enabled = true;
            this.timerForFormTimeOut.Interval = 10000;
            this.timerForFormTimeOut.Tick += new System.EventHandler(this.TimerForTimeOut_Tick);
            // 
            // timerForTimeOutMessageBox
            // 
            this.timerForTimeOutMessageBox.Interval = 8000;
            this.timerForTimeOutMessageBox.Tick += new System.EventHandler(this.TimerForTimeOutMessageBox_Tick);
            // 
            // lblQuantityToRemove
            // 
            this.lblQuantityToRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantityToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuantityToRemove.Location = new System.Drawing.Point(593, 73);
            this.lblQuantityToRemove.Name = "lblQuantityToRemove";
            this.lblQuantityToRemove.Size = new System.Drawing.Size(101, 23);
            this.lblQuantityToRemove.TabIndex = 31;
            this.lblQuantityToRemove.Text = "Quantity Wanted:";
            this.lblQuantityToRemove.Visible = false;
            // 
            // pnlQuantityToRemove
            // 
            this.pnlQuantityToRemove.BackColor = System.Drawing.SystemColors.Window;
            this.pnlQuantityToRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlQuantityToRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlQuantityToRemove.Controls.Add(this.btnCompleteItemRemoval);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem6);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem5);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem4);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem3);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem2);
            this.pnlQuantityToRemove.Controls.Add(this.nudQuantityToRemoveItem1);
            this.pnlQuantityToRemove.Location = new System.Drawing.Point(593, 93);
            this.pnlQuantityToRemove.Name = "pnlQuantityToRemove";
            this.pnlQuantityToRemove.Size = new System.Drawing.Size(101, 185);
            this.pnlQuantityToRemove.TabIndex = 32;
            this.pnlQuantityToRemove.Visible = false;
            // 
            // btnCompleteItemRemoval
            // 
            this.btnCompleteItemRemoval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCompleteItemRemoval.Location = new System.Drawing.Point(-2, 126);
            this.btnCompleteItemRemoval.Name = "btnCompleteItemRemoval";
            this.btnCompleteItemRemoval.Size = new System.Drawing.Size(101, 23);
            this.btnCompleteItemRemoval.TabIndex = 6;
            this.btnCompleteItemRemoval.Text = "Remove";
            this.btnCompleteItemRemoval.UseVisualStyleBackColor = true;
            this.btnCompleteItemRemoval.Visible = false;
            this.btnCompleteItemRemoval.Click += new System.EventHandler(this.BtnCompleteItemRemoval_Click);
            // 
            // nudQuantityToRemoveItem6
            // 
            this.nudQuantityToRemoveItem6.Location = new System.Drawing.Point(-2, 100);
            this.nudQuantityToRemoveItem6.Name = "nudQuantityToRemoveItem6";
            this.nudQuantityToRemoveItem6.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem6.TabIndex = 5;
            this.nudQuantityToRemoveItem6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem6.Visible = false;
            // 
            // nudQuantityToRemoveItem5
            // 
            this.nudQuantityToRemoveItem5.Location = new System.Drawing.Point(-2, 80);
            this.nudQuantityToRemoveItem5.Name = "nudQuantityToRemoveItem5";
            this.nudQuantityToRemoveItem5.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem5.TabIndex = 4;
            this.nudQuantityToRemoveItem5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem5.Visible = false;
            // 
            // nudQuantityToRemoveItem4
            // 
            this.nudQuantityToRemoveItem4.Location = new System.Drawing.Point(-2, 60);
            this.nudQuantityToRemoveItem4.Name = "nudQuantityToRemoveItem4";
            this.nudQuantityToRemoveItem4.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem4.TabIndex = 3;
            this.nudQuantityToRemoveItem4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem4.Visible = false;
            // 
            // nudQuantityToRemoveItem3
            // 
            this.nudQuantityToRemoveItem3.Location = new System.Drawing.Point(-2, 40);
            this.nudQuantityToRemoveItem3.Name = "nudQuantityToRemoveItem3";
            this.nudQuantityToRemoveItem3.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem3.TabIndex = 2;
            this.nudQuantityToRemoveItem3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem3.Visible = false;
            // 
            // nudQuantityToRemoveItem2
            // 
            this.nudQuantityToRemoveItem2.Location = new System.Drawing.Point(-2, 20);
            this.nudQuantityToRemoveItem2.Name = "nudQuantityToRemoveItem2";
            this.nudQuantityToRemoveItem2.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem2.TabIndex = 1;
            this.nudQuantityToRemoveItem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem2.Visible = false;
            // 
            // nudQuantityToRemoveItem1
            // 
            this.nudQuantityToRemoveItem1.Location = new System.Drawing.Point(-2, 0);
            this.nudQuantityToRemoveItem1.Name = "nudQuantityToRemoveItem1";
            this.nudQuantityToRemoveItem1.Size = new System.Drawing.Size(101, 20);
            this.nudQuantityToRemoveItem1.TabIndex = 0;
            this.nudQuantityToRemoveItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQuantityToRemoveItem1.Visible = false;
            // 
            // Vending_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.pnlQuantityToRemove);
            this.Controls.Add(this.lblQuantityToRemove);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnBackToOrder);
            this.Controls.Add(this.txtTotalOrderPrice);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lstQuantityInBasket);
            this.Controls.Add(this.lstItemsInBasket);
            this.Controls.Add(this.lblQuantityInBasket);
            this.Controls.Add(this.lblItemsInBasket);
            this.Controls.Add(this.pnlItemSelection);
            this.Controls.Add(this.pnlMoneySelection);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.txtNoteSlot);
            this.Controls.Add(this.txtCoinSlot);
            this.Controls.Add(this.txtTotalItemCount);
            this.Controls.Add(this.btnCheckout);
            this.Name = "Vending_Machine";
            this.Text = "30019559 Vending Machine";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.pnlMoneySelection.ResumeLayout(false);
            this.pnlItemSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudItem6Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem5Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem4Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem3Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem2Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem1Quantity)).EndInit();
            this.pnlQuantityToRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityToRemoveItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItem_1;
        private System.Windows.Forms.Button btnItem_2;
        private System.Windows.Forms.Button btnItem_3;
        private System.Windows.Forms.Button btnItem_4;
        private System.Windows.Forms.Button btnItem_5;
        private System.Windows.Forms.Button btnItem_6;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtCoinSlot;
        private System.Windows.Forms.TextBox txtNoteSlot;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnMoney1;
        private System.Windows.Forms.Button btnMoney50p;
        private System.Windows.Forms.Button btnMoney5;
        private System.Windows.Forms.Button btnMoney20p;
        private System.Windows.Forms.Button btnMoney10;
        private System.Windows.Forms.Button btnMoney20;
        private System.Windows.Forms.Panel pnlMoneySelection;
        private System.Windows.Forms.Panel pnlItemSelection;
        private System.Windows.Forms.Label lblItemsInBasket;
        private System.Windows.Forms.Label lblQuantityInBasket;
        private System.Windows.Forms.ListBox lstItemsInBasket;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.TextBox txtTotalItemCount;
        private System.Windows.Forms.NumericUpDown nudItem6Quantity;
        private System.Windows.Forms.NumericUpDown nudItem5Quantity;
        private System.Windows.Forms.NumericUpDown nudItem4Quantity;
        private System.Windows.Forms.NumericUpDown nudItem3Quantity;
        private System.Windows.Forms.NumericUpDown nudItem2Quantity;
        private System.Windows.Forms.NumericUpDown nudItem1Quantity;
        private System.Windows.Forms.ListBox lstQuantityInBasket;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.TextBox txtTotalOrderPrice;
        private System.Windows.Forms.Button btnBackToOrder;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Timer timerForFormTimeOut;
        private System.Windows.Forms.Timer timerForTimeOutMessageBox;
        private System.Windows.Forms.Label lblQuantityToRemove;
        private System.Windows.Forms.Panel pnlQuantityToRemove;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem6;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem5;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem4;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem3;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem2;
        private System.Windows.Forms.NumericUpDown nudQuantityToRemoveItem1;
        private System.Windows.Forms.Button btnCompleteItemRemoval;
    }
}

