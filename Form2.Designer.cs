namespace Pizza
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.btnLarge = new System.Windows.Forms.RadioButton();
            this.btnMedium = new System.Windows.Forms.RadioButton();
            this.btnSmall = new System.Windows.Forms.RadioButton();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.btnThinkCrust = new System.Windows.Forms.RadioButton();
            this.btnThinCrust = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.btnTakeOut = new System.Windows.Forms.RadioButton();
            this.btnEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grpOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(100, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpSize.Controls.Add(this.btnLarge);
            this.grpSize.Controls.Add(this.btnMedium);
            this.grpSize.Controls.Add(this.btnSmall);
            this.grpSize.Font = new System.Drawing.Font("Ink Free", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpSize.Location = new System.Drawing.Point(59, 92);
            this.grpSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSize.Size = new System.Drawing.Size(143, 146);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // btnLarge
            // 
            this.btnLarge.AutoSize = true;
            this.btnLarge.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarge.Location = new System.Drawing.Point(19, 98);
            this.btnLarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(70, 21);
            this.btnLarge.TabIndex = 3;
            this.btnLarge.TabStop = true;
            this.btnLarge.Tag = "40";
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.CheckedChanged += new System.EventHandler(this.btnLarge_CheckedChanged);
            // 
            // btnMedium
            // 
            this.btnMedium.AutoSize = true;
            this.btnMedium.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(19, 68);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(90, 21);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.TabStop = true;
            this.btnMedium.Tag = "30";
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.CheckedChanged += new System.EventHandler(this.btnSmall_CheckedChanged);
            // 
            // btnSmall
            // 
            this.btnSmall.AutoSize = true;
            this.btnSmall.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.Location = new System.Drawing.Point(19, 38);
            this.btnSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(71, 21);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.TabStop = true;
            this.btnSmall.Tag = "20";
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.CheckedChanged += new System.EventHandler(this.btnSmall_CheckedChanged_1);
            // 
            // grpCrust
            // 
            this.grpCrust.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpCrust.Controls.Add(this.btnThinkCrust);
            this.grpCrust.Controls.Add(this.btnThinCrust);
            this.grpCrust.Font = new System.Drawing.Font("Ink Free", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpCrust.Location = new System.Drawing.Point(59, 256);
            this.grpCrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCrust.Size = new System.Drawing.Size(143, 108);
            this.grpCrust.TabIndex = 2;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type";
            // 
            // btnThinkCrust
            // 
            this.btnThinkCrust.AutoSize = true;
            this.btnThinkCrust.Font = new System.Drawing.Font("Georgia", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThinkCrust.Location = new System.Drawing.Point(19, 57);
            this.btnThinkCrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThinkCrust.Name = "btnThinkCrust";
            this.btnThinkCrust.Size = new System.Drawing.Size(96, 17);
            this.btnThinkCrust.TabIndex = 2;
            this.btnThinkCrust.TabStop = true;
            this.btnThinkCrust.Tag = "10";
            this.btnThinkCrust.Text = "Think Crust";
            this.btnThinkCrust.UseVisualStyleBackColor = true;
            this.btnThinkCrust.CheckedChanged += new System.EventHandler(this.btnThinkCrust_CheckedChanged);
            // 
            // btnThinCrust
            // 
            this.btnThinCrust.AutoSize = true;
            this.btnThinCrust.Font = new System.Drawing.Font("Georgia", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThinCrust.Location = new System.Drawing.Point(19, 30);
            this.btnThinCrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThinCrust.Name = "btnThinCrust";
            this.btnThinCrust.Size = new System.Drawing.Size(89, 17);
            this.btnThinCrust.TabIndex = 1;
            this.btnThinCrust.TabStop = true;
            this.btnThinCrust.Tag = "0";
            this.btnThinCrust.Text = "Thin Crust";
            this.btnThinCrust.UseVisualStyleBackColor = true;
            this.btnThinCrust.CheckedChanged += new System.EventHandler(this.btnThinCrust_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpToppings.Controls.Add(this.chkPeppers);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraCheese);
            this.grpToppings.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpToppings.Location = new System.Drawing.Point(239, 92);
            this.grpToppings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpToppings.Size = new System.Drawing.Size(301, 122);
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPeppers.Location = new System.Drawing.Point(147, 85);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(125, 21);
            this.chkPeppers.TabIndex = 6;
            this.chkPeppers.Tag = "5";
            this.chkPeppers.Text = "Green Peppers ";
            this.chkPeppers.UseVisualStyleBackColor = true;
            this.chkPeppers.CheckedChanged += new System.EventHandler(this.chkPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(147, 57);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(69, 21);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(147, 30);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(68, 21);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(9, 82);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(93, 21);
            this.chkTomatoes.TabIndex = 3;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(9, 57);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(105, 21);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(9, 30);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(104, 19);
            this.chkExtraCheese.TabIndex = 1;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpWhereToEat.Controls.Add(this.btnTakeOut);
            this.grpWhereToEat.Controls.Add(this.btnEatIn);
            this.grpWhereToEat.Font = new System.Drawing.Font("Ink Free", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpWhereToEat.Location = new System.Drawing.Point(240, 277);
            this.grpWhereToEat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpWhereToEat.Size = new System.Drawing.Size(300, 62);
            this.grpWhereToEat.TabIndex = 4;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where to eat";
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.AutoSize = true;
            this.btnTakeOut.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOut.Location = new System.Drawing.Point(136, 30);
            this.btnTakeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(96, 21);
            this.btnTakeOut.TabIndex = 2;
            this.btnTakeOut.TabStop = true;
            this.btnTakeOut.Text = "Take Out";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnEatIn
            // 
            this.btnEatIn.AutoSize = true;
            this.btnEatIn.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.Location = new System.Drawing.Point(19, 30);
            this.btnEatIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(74, 21);
            this.btnEatIn.TabIndex = 1;
            this.btnEatIn.TabStop = true;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.CheckedChanged += new System.EventHandler(this.btnEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOrderPizza.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrderPizza.Location = new System.Drawing.Point(227, 386);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(112, 37);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnResetForm.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetForm.Location = new System.Drawing.Point(396, 386);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(112, 37);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpOrderSummary.Controls.Add(this.lblPrice);
            this.grpOrderSummary.Controls.Add(this.lblWhereToEat);
            this.grpOrderSummary.Controls.Add(this.lblCrustType);
            this.grpOrderSummary.Controls.Add(this.lblToppings);
            this.grpOrderSummary.Controls.Add(this.lblSize);
            this.grpOrderSummary.Controls.Add(this.lbP);
            this.grpOrderSummary.Controls.Add(this.label4);
            this.grpOrderSummary.Controls.Add(this.label3);
            this.grpOrderSummary.Controls.Add(this.label2);
            this.grpOrderSummary.Controls.Add(this.lb);
            this.grpOrderSummary.Font = new System.Drawing.Font("Ink Free", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpOrderSummary.Location = new System.Drawing.Point(568, 94);
            this.grpOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrderSummary.Size = new System.Drawing.Size(216, 288);
            this.grpOrderSummary.TabIndex = 7;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gabriola", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPrice.Location = new System.Drawing.Point(68, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 92);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "size";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWhereToEat.Location = new System.Drawing.Point(134, 164);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(31, 17);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "size";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCrustType.Location = new System.Drawing.Point(107, 140);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(27, 15);
            this.lblCrustType.TabIndex = 7;
            this.lblCrustType.Text = "size";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblToppings.Location = new System.Drawing.Point(18, 86);
            this.lblToppings.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(27, 15);
            this.lblToppings.TabIndex = 6;
            this.lblToppings.Text = "size";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSize.Location = new System.Drawing.Point(65, 37);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 21);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "size";
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.Location = new System.Drawing.Point(16, 192);
            this.lbP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(45, 17);
            this.lbP.TabIndex = 4;
            this.lbP.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Where To Eat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crust Type";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(13, 38);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(37, 17);
            this.lb.TabIndex = 0;
            this.lb.Text = "Size";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton btnMedium;
        private System.Windows.Forms.RadioButton btnLarge;
        private System.Windows.Forms.RadioButton btnSmall;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.RadioButton btnThinkCrust;
        private System.Windows.Forms.RadioButton btnThinCrust;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton btnTakeOut;
        private System.Windows.Forms.RadioButton btnEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
    }
}