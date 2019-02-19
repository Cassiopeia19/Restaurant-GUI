namespace RestaurantGUI_FourStrong_v2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamRestaurantName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pork = new System.Windows.Forms.CheckBox();
            this.Beef = new System.Windows.Forms.CheckBox();
            this.Chicken = new System.Windows.Forms.CheckBox();
            this.PorkQty = new System.Windows.Forms.TextBox();
            this.BeefQty = new System.Windows.Forms.TextBox();
            this.ChickenQty = new System.Windows.Forms.TextBox();
            this.FoodDescriptions = new System.Windows.Forms.RichTextBox();
            this.Entrees = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Milk = new System.Windows.Forms.CheckBox();
            this.Tea = new System.Windows.Forms.CheckBox();
            this.Soda = new System.Windows.Forms.CheckBox();
            this.MilkQty = new System.Windows.Forms.TextBox();
            this.TeaQty = new System.Windows.Forms.TextBox();
            this.SodaQty = new System.Windows.Forms.TextBox();
            this.Drinks = new System.Windows.Forms.Label();
            this.DrinkDescriptions = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IceCream = new System.Windows.Forms.CheckBox();
            this.Cookie = new System.Windows.Forms.CheckBox();
            this.Cake = new System.Windows.Forms.CheckBox();
            this.IceCreamQty = new System.Windows.Forms.TextBox();
            this.CookieQty = new System.Windows.Forms.TextBox();
            this.CakeQty = new System.Windows.Forms.TextBox();
            this.DessertsDescription = new System.Windows.Forms.RichTextBox();
            this.Desserts = new System.Windows.Forms.Label();
            this.MenuItems = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CashAmount = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.TextBox();
            this.ChangeDue = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.TextBox();
            this.TipCharged = new System.Windows.Forms.TextBox();
            this.TaxCharged = new System.Windows.Forms.TextBox();
            this.BeforeTaxAndTip = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.PaymentMethod = new System.Windows.Forms.Label();
            this.CashGiven = new System.Windows.Forms.TextBox();
            this.PaymentForm = new System.Windows.Forms.ComboBox();
            this.TotalBill = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.TeamRestaurantName);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 100);
            this.panel1.TabIndex = 0;
            // 
            // TeamRestaurantName
            // 
            this.TeamRestaurantName.AutoSize = true;
            this.TeamRestaurantName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TeamRestaurantName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TeamRestaurantName.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamRestaurantName.Location = new System.Drawing.Point(94, 22);
            this.TeamRestaurantName.Name = "TeamRestaurantName";
            this.TeamRestaurantName.Size = new System.Drawing.Size(1116, 52);
            this.TeamRestaurantName.TabIndex = 0;
            this.TeamRestaurantName.Text = "Four Strong Food - Restaurant and Culinary Delights";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Pork);
            this.panel3.Controls.Add(this.Beef);
            this.panel3.Controls.Add(this.Chicken);
            this.panel3.Controls.Add(this.PorkQty);
            this.panel3.Controls.Add(this.BeefQty);
            this.panel3.Controls.Add(this.ChickenQty);
            this.panel3.Controls.Add(this.FoodDescriptions);
            this.panel3.Controls.Add(this.Entrees);
            this.panel3.Location = new System.Drawing.Point(14, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 335);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Pork
            // 
            this.Pork.AutoSize = true;
            this.Pork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pork.Location = new System.Drawing.Point(92, 287);
            this.Pork.Name = "Pork";
            this.Pork.Size = new System.Drawing.Size(64, 24);
            this.Pork.TabIndex = 14;
            this.Pork.Text = "Pork";
            this.Pork.UseVisualStyleBackColor = true;
            this.Pork.CheckedChanged += new System.EventHandler(this.Pork_CheckedChanged);
            // 
            // Beef
            // 
            this.Beef.AutoSize = true;
            this.Beef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beef.Location = new System.Drawing.Point(92, 237);
            this.Beef.Name = "Beef";
            this.Beef.Size = new System.Drawing.Size(66, 24);
            this.Beef.TabIndex = 13;
            this.Beef.Text = "Beef";
            this.Beef.UseVisualStyleBackColor = true;
            this.Beef.CheckedChanged += new System.EventHandler(this.Beef_CheckedChanged);
            // 
            // Chicken
            // 
            this.Chicken.AutoSize = true;
            this.Chicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chicken.Location = new System.Drawing.Point(92, 189);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(92, 24);
            this.Chicken.TabIndex = 12;
            this.Chicken.Text = "Chicken";
            this.Chicken.UseVisualStyleBackColor = true;
            this.Chicken.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // PorkQty
            // 
            this.PorkQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorkQty.Location = new System.Drawing.Point(217, 287);
            this.PorkQty.Name = "PorkQty";
            this.PorkQty.Size = new System.Drawing.Size(59, 26);
            this.PorkQty.TabIndex = 8;
            this.PorkQty.Text = "0";
            this.PorkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BeefQty
            // 
            this.BeefQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeefQty.Location = new System.Drawing.Point(217, 237);
            this.BeefQty.Name = "BeefQty";
            this.BeefQty.Size = new System.Drawing.Size(59, 26);
            this.BeefQty.TabIndex = 7;
            this.BeefQty.Text = "0";
            this.BeefQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BeefQty.TextChanged += new System.EventHandler(this.BeefQty_TextChanged);
            // 
            // ChickenQty
            // 
            this.ChickenQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChickenQty.Location = new System.Drawing.Point(217, 189);
            this.ChickenQty.Name = "ChickenQty";
            this.ChickenQty.Size = new System.Drawing.Size(59, 26);
            this.ChickenQty.TabIndex = 6;
            this.ChickenQty.Text = "0";
            this.ChickenQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChickenQty.TextChanged += new System.EventHandler(this.ChickenQty_TextChanged);
            // 
            // FoodDescriptions
            // 
            this.FoodDescriptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FoodDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodDescriptions.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FoodDescriptions.Location = new System.Drawing.Point(-2, 51);
            this.FoodDescriptions.Name = "FoodDescriptions";
            this.FoodDescriptions.ReadOnly = true;
            this.FoodDescriptions.Size = new System.Drawing.Size(404, 107);
            this.FoodDescriptions.TabIndex = 2;
            this.FoodDescriptions.Text = "  \n  Chicken - Blackened with Cajun Spices              $12.95\n  Beef - Grilled w" +
    "ith Signature Cowboy Sauce      $16.95\n  Pork - Roasted with Mango Chutney      " +
    "             $14.95";
            this.FoodDescriptions.TextChanged += new System.EventHandler(this.FoodDescriptions_TextChanged);
            // 
            // Entrees
            // 
            this.Entrees.AutoSize = true;
            this.Entrees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Entrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrees.Location = new System.Drawing.Point(155, 10);
            this.Entrees.Name = "Entrees";
            this.Entrees.Size = new System.Drawing.Size(105, 31);
            this.Entrees.TabIndex = 0;
            this.Entrees.Text = "Entrées";
            this.Entrees.Click += new System.EventHandler(this.Entrees_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Milk);
            this.panel4.Controls.Add(this.Tea);
            this.panel4.Controls.Add(this.Soda);
            this.panel4.Controls.Add(this.MilkQty);
            this.panel4.Controls.Add(this.TeaQty);
            this.panel4.Controls.Add(this.SodaQty);
            this.panel4.Controls.Add(this.Drinks);
            this.panel4.Controls.Add(this.DrinkDescriptions);
            this.panel4.Location = new System.Drawing.Point(465, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 263);
            this.panel4.TabIndex = 2;
            // 
            // Milk
            // 
            this.Milk.AutoSize = true;
            this.Milk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Milk.Location = new System.Drawing.Point(88, 226);
            this.Milk.Name = "Milk";
            this.Milk.Size = new System.Drawing.Size(59, 24);
            this.Milk.TabIndex = 13;
            this.Milk.Text = "Milk";
            this.Milk.UseVisualStyleBackColor = true;
            this.Milk.CheckedChanged += new System.EventHandler(this.Milk_CheckedChanged);
            // 
            // Tea
            // 
            this.Tea.AutoSize = true;
            this.Tea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tea.Location = new System.Drawing.Point(89, 194);
            this.Tea.Name = "Tea";
            this.Tea.Size = new System.Drawing.Size(58, 24);
            this.Tea.TabIndex = 12;
            this.Tea.Text = "Tea";
            this.Tea.UseVisualStyleBackColor = true;
            this.Tea.CheckedChanged += new System.EventHandler(this.Tea_CheckedChanged);
            // 
            // Soda
            // 
            this.Soda.AutoSize = true;
            this.Soda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soda.Location = new System.Drawing.Point(89, 162);
            this.Soda.Name = "Soda";
            this.Soda.Size = new System.Drawing.Size(70, 24);
            this.Soda.TabIndex = 11;
            this.Soda.Text = "Soda";
            this.Soda.UseVisualStyleBackColor = true;
            this.Soda.CheckedChanged += new System.EventHandler(this.Soda_CheckedChanged);
            // 
            // MilkQty
            // 
            this.MilkQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilkQty.Location = new System.Drawing.Point(224, 226);
            this.MilkQty.Name = "MilkQty";
            this.MilkQty.Size = new System.Drawing.Size(59, 26);
            this.MilkQty.TabIndex = 7;
            this.MilkQty.Text = "0";
            this.MilkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeaQty
            // 
            this.TeaQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaQty.Location = new System.Drawing.Point(224, 194);
            this.TeaQty.Name = "TeaQty";
            this.TeaQty.Size = new System.Drawing.Size(59, 26);
            this.TeaQty.TabIndex = 6;
            this.TeaQty.Text = "0";
            this.TeaQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SodaQty
            // 
            this.SodaQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SodaQty.Location = new System.Drawing.Point(224, 162);
            this.SodaQty.Name = "SodaQty";
            this.SodaQty.Size = new System.Drawing.Size(59, 26);
            this.SodaQty.TabIndex = 5;
            this.SodaQty.Text = "0";
            this.SodaQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Drinks
            // 
            this.Drinks.AutoSize = true;
            this.Drinks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.Location = new System.Drawing.Point(180, 10);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(89, 31);
            this.Drinks.TabIndex = 1;
            this.Drinks.Text = "Drinks";
            // 
            // DrinkDescriptions
            // 
            this.DrinkDescriptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DrinkDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkDescriptions.Location = new System.Drawing.Point(37, 51);
            this.DrinkDescriptions.Name = "DrinkDescriptions";
            this.DrinkDescriptions.ReadOnly = true;
            this.DrinkDescriptions.Size = new System.Drawing.Size(381, 96);
            this.DrinkDescriptions.TabIndex = 0;
            this.DrinkDescriptions.Text = "    \n     Soda - Cola-flavored; Fizzy Goodness          $3.95\n     Tea - Earl Gre" +
    "y with Honey; Satisfying          $1.95\n     Milk - 2%; Good for the BOnes      " +
    "                 $2.95";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.IceCream);
            this.panel5.Controls.Add(this.Cookie);
            this.panel5.Controls.Add(this.Cake);
            this.panel5.Controls.Add(this.IceCreamQty);
            this.panel5.Controls.Add(this.CookieQty);
            this.panel5.Controls.Add(this.CakeQty);
            this.panel5.Controls.Add(this.DessertsDescription);
            this.panel5.Controls.Add(this.Desserts);
            this.panel5.Location = new System.Drawing.Point(937, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 335);
            this.panel5.TabIndex = 3;
            // 
            // IceCream
            // 
            this.IceCream.AutoSize = true;
            this.IceCream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IceCream.Location = new System.Drawing.Point(92, 281);
            this.IceCream.Name = "IceCream";
            this.IceCream.Size = new System.Drawing.Size(110, 24);
            this.IceCream.TabIndex = 10;
            this.IceCream.Text = "Ice Cream";
            this.IceCream.UseVisualStyleBackColor = true;
            this.IceCream.CheckedChanged += new System.EventHandler(this.IceCream_CheckedChanged);
            // 
            // Cookie
            // 
            this.Cookie.AutoSize = true;
            this.Cookie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cookie.Location = new System.Drawing.Point(92, 233);
            this.Cookie.Name = "Cookie";
            this.Cookie.Size = new System.Drawing.Size(83, 24);
            this.Cookie.TabIndex = 9;
            this.Cookie.Text = "Cookie";
            this.Cookie.UseVisualStyleBackColor = true;
            this.Cookie.CheckedChanged += new System.EventHandler(this.Cookie_CheckedChanged);
            // 
            // Cake
            // 
            this.Cake.AutoSize = true;
            this.Cake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cake.Location = new System.Drawing.Point(92, 187);
            this.Cake.Name = "Cake";
            this.Cake.Size = new System.Drawing.Size(69, 24);
            this.Cake.TabIndex = 8;
            this.Cake.Text = "Cake";
            this.Cake.UseVisualStyleBackColor = true;
            this.Cake.CheckedChanged += new System.EventHandler(this.Cake_CheckedChanged);
            // 
            // IceCreamQty
            // 
            this.IceCreamQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IceCreamQty.Location = new System.Drawing.Point(236, 281);
            this.IceCreamQty.Name = "IceCreamQty";
            this.IceCreamQty.Size = new System.Drawing.Size(59, 26);
            this.IceCreamQty.TabIndex = 7;
            this.IceCreamQty.Text = "0";
            this.IceCreamQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IceCreamQty.TextChanged += new System.EventHandler(this.IceCreamQty_TextChanged);
            // 
            // CookieQty
            // 
            this.CookieQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookieQty.Location = new System.Drawing.Point(236, 233);
            this.CookieQty.Name = "CookieQty";
            this.CookieQty.Size = new System.Drawing.Size(59, 26);
            this.CookieQty.TabIndex = 6;
            this.CookieQty.Text = "0";
            this.CookieQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CakeQty
            // 
            this.CakeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CakeQty.Location = new System.Drawing.Point(236, 187);
            this.CakeQty.Name = "CakeQty";
            this.CakeQty.Size = new System.Drawing.Size(59, 26);
            this.CakeQty.TabIndex = 5;
            this.CakeQty.Text = "0";
            this.CakeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CakeQty.TextChanged += new System.EventHandler(this.CakeQty_TextChanged);
            // 
            // DessertsDescription
            // 
            this.DessertsDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DessertsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertsDescription.Location = new System.Drawing.Point(18, 54);
            this.DessertsDescription.Name = "DessertsDescription";
            this.DessertsDescription.Size = new System.Drawing.Size(358, 96);
            this.DessertsDescription.TabIndex = 1;
            this.DessertsDescription.Text = "     \n     Cake - Yellow Cake with Icing               $5.95\n     Cookie - Chocol" +
    "ate Chip                        $2.95\n     Ice Cream - Plain Vanilla            " +
    "            $3.95";
            // 
            // Desserts
            // 
            this.Desserts.AutoSize = true;
            this.Desserts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desserts.Location = new System.Drawing.Point(135, 10);
            this.Desserts.Name = "Desserts";
            this.Desserts.Size = new System.Drawing.Size(118, 31);
            this.Desserts.TabIndex = 0;
            this.Desserts.Text = "Desserts";
            // 
            // MenuItems
            // 
            this.MenuItems.AutoSize = true;
            this.MenuItems.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItems.Location = new System.Drawing.Point(626, 115);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(154, 29);
            this.MenuItems.TabIndex = 4;
            this.MenuItems.Text = "Menu Items";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.CashAmount);
            this.panel6.Controls.Add(this.Change);
            this.panel6.Controls.Add(this.ChangeDue);
            this.panel6.Controls.Add(this.GrandTotal);
            this.panel6.Controls.Add(this.TipCharged);
            this.panel6.Controls.Add(this.TaxCharged);
            this.panel6.Controls.Add(this.BeforeTaxAndTip);
            this.panel6.Controls.Add(this.Exit);
            this.panel6.Controls.Add(this.Reset);
            this.panel6.Controls.Add(this.Total);
            this.panel6.Controls.Add(this.PaymentMethod);
            this.panel6.Controls.Add(this.CashGiven);
            this.panel6.Controls.Add(this.PaymentForm);
            this.panel6.Controls.Add(this.TotalBill);
            this.panel6.Controls.Add(this.Tip);
            this.panel6.Controls.Add(this.Tax);
            this.panel6.Controls.Add(this.Subtotal);
            this.panel6.Location = new System.Drawing.Point(465, 418);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 251);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // CashAmount
            // 
            this.CashAmount.AutoSize = true;
            this.CashAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashAmount.Location = new System.Drawing.Point(12, 103);
            this.CashAmount.Name = "CashAmount";
            this.CashAmount.Size = new System.Drawing.Size(101, 20);
            this.CashAmount.TabIndex = 20;
            this.CashAmount.Text = "Cash Given";
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(119, 137);
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Size = new System.Drawing.Size(100, 26);
            this.Change.TabIndex = 19;
            this.Change.Text = "0";
            this.Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Change.TextChanged += new System.EventHandler(this.Change_TextChanged);
            // 
            // ChangeDue
            // 
            this.ChangeDue.AutoSize = true;
            this.ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeDue.Location = new System.Drawing.Point(8, 143);
            this.ChangeDue.Name = "ChangeDue";
            this.ChangeDue.Size = new System.Drawing.Size(109, 20);
            this.ChangeDue.TabIndex = 18;
            this.ChangeDue.Text = "Change Due";
            // 
            // GrandTotal
            // 
            this.GrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotal.Location = new System.Drawing.Point(330, 158);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.ReadOnly = true;
            this.GrandTotal.Size = new System.Drawing.Size(100, 26);
            this.GrandTotal.TabIndex = 17;
            this.GrandTotal.Text = "0";
            this.GrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TipCharged
            // 
            this.TipCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipCharged.Location = new System.Drawing.Point(330, 114);
            this.TipCharged.Name = "TipCharged";
            this.TipCharged.ReadOnly = true;
            this.TipCharged.Size = new System.Drawing.Size(100, 26);
            this.TipCharged.TabIndex = 16;
            this.TipCharged.Text = "0";
            this.TipCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TaxCharged
            // 
            this.TaxCharged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxCharged.Location = new System.Drawing.Point(330, 68);
            this.TaxCharged.Name = "TaxCharged";
            this.TaxCharged.ReadOnly = true;
            this.TaxCharged.Size = new System.Drawing.Size(100, 26);
            this.TaxCharged.TabIndex = 15;
            this.TaxCharged.Text = "0";
            this.TaxCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BeforeTaxAndTip
            // 
            this.BeforeTaxAndTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeforeTaxAndTip.Location = new System.Drawing.Point(330, 30);
            this.BeforeTaxAndTip.Name = "BeforeTaxAndTip";
            this.BeforeTaxAndTip.ReadOnly = true;
            this.BeforeTaxAndTip.Size = new System.Drawing.Size(100, 26);
            this.BeforeTaxAndTip.TabIndex = 14;
            this.BeforeTaxAndTip.Text = "0";
            this.BeforeTaxAndTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BeforeTaxAndTip.TextChanged += new System.EventHandler(this.BeforeTaxAndTip_TextChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(330, 205);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 39);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(211, 205);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(83, 39);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(70, 205);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(98, 39);
            this.Total.TabIndex = 11;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = false;
            this.Total.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSize = true;
            this.PaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethod.Location = new System.Drawing.Point(12, 5);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(190, 27);
            this.PaymentMethod.TabIndex = 10;
            this.PaymentMethod.Text = "Payment Method";
            this.PaymentMethod.Click += new System.EventHandler(this.PaymentMethod_Click);
            // 
            // CashGiven
            // 
            this.CashGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashGiven.Location = new System.Drawing.Point(119, 100);
            this.CashGiven.Name = "CashGiven";
            this.CashGiven.Size = new System.Drawing.Size(100, 26);
            this.CashGiven.TabIndex = 9;
            this.CashGiven.Text = "0";
            this.CashGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashGiven.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PaymentForm
            // 
            this.PaymentForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PaymentForm.DisplayMember = "0";
            this.PaymentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentForm.FormattingEnabled = true;
            this.PaymentForm.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Mastercard",
            "Visa",
            "ApplePay"});
            this.PaymentForm.Location = new System.Drawing.Point(22, 46);
            this.PaymentForm.MaxDropDownItems = 5;
            this.PaymentForm.Name = "PaymentForm";
            this.PaymentForm.Size = new System.Drawing.Size(197, 28);
            this.PaymentForm.TabIndex = 8;
            this.PaymentForm.Text = "Choose one";
            this.PaymentForm.ValueMember = "0";
            this.PaymentForm.SelectedIndexChanged += new System.EventHandler(this.PaymentForm_SelectedIndexChanged);
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBill.Location = new System.Drawing.Point(238, 164);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(78, 20);
            this.TotalBill.TabIndex = 5;
            this.TotalBill.Text = "Total Bill";
            // 
            // Tip
            // 
            this.Tip.AutoSize = true;
            this.Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip.Location = new System.Drawing.Point(237, 120);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(90, 20);
            this.Tip.TabIndex = 4;
            this.Tip.Text = "Tip @10%";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(225, 74);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(99, 20);
            this.Tax.TabIndex = 1;
            this.Tax.Text = "Tax @8.9%";
            this.Tax.Click += new System.EventHandler(this.label2_Click);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtotal.Location = new System.Drawing.Point(238, 36);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(77, 20);
            this.Subtotal.TabIndex = 0;
            this.Subtotal.Text = "Subtotal";
            this.Subtotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1352, 761);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.MenuItems);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TeamRestaurantName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox FoodDescriptions;
        private System.Windows.Forms.Label Entrees;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label MenuItems;
        private System.Windows.Forms.TextBox PorkQty;
        private System.Windows.Forms.TextBox BeefQty;
        private System.Windows.Forms.TextBox ChickenQty;
        private System.Windows.Forms.TextBox MilkQty;
        private System.Windows.Forms.TextBox TeaQty;
        private System.Windows.Forms.TextBox SodaQty;
        private System.Windows.Forms.Label Drinks;
        private System.Windows.Forms.RichTextBox DrinkDescriptions;
        private System.Windows.Forms.RichTextBox DessertsDescription;
        private System.Windows.Forms.Label Desserts;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox IceCreamQty;
        private System.Windows.Forms.TextBox CookieQty;
        private System.Windows.Forms.TextBox CakeQty;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Total;
        private System.Windows.Forms.Label PaymentMethod;
        private System.Windows.Forms.TextBox CashGiven;
        private System.Windows.Forms.ComboBox PaymentForm;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Label Tip;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.CheckBox Chicken;
        private System.Windows.Forms.CheckBox Pork;
        private System.Windows.Forms.CheckBox Beef;
        private System.Windows.Forms.CheckBox Milk;
        private System.Windows.Forms.CheckBox Tea;
        private System.Windows.Forms.CheckBox Soda;
        private System.Windows.Forms.CheckBox IceCream;
        private System.Windows.Forms.CheckBox Cookie;
        private System.Windows.Forms.CheckBox Cake;
        private System.Windows.Forms.TextBox GrandTotal;
        private System.Windows.Forms.TextBox TipCharged;
        private System.Windows.Forms.TextBox TaxCharged;
        private System.Windows.Forms.TextBox BeforeTaxAndTip;
        private System.Windows.Forms.Label CashAmount;
        private System.Windows.Forms.TextBox Change;
        private System.Windows.Forms.Label ChangeDue;
    }
}

