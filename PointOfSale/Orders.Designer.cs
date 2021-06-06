namespace PointOfSale
{
    partial class Orders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsDgv = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grandTotallbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.resetFieldsBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grandTotalTxt = new System.Windows.Forms.Label();
            this.tlpMessage = new System.Windows.Forms.ToolTip(this.components);
            this.paymentTxt = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 61);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PointOfSale.Properties.Resources.White_Close;
            this.pictureBox3.Location = new System.Drawing.Point(867, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // productsDgv
            // 
            this.productsDgv.AllowUserToAddRows = false;
            this.productsDgv.AllowUserToDeleteRows = false;
            this.productsDgv.AllowUserToResizeColumns = false;
            this.productsDgv.AllowUserToResizeRows = false;
            this.productsDgv.BackgroundColor = System.Drawing.Color.White;
            this.productsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.productsDgv.Location = new System.Drawing.Point(6, 132);
            this.productsDgv.Name = "productsDgv";
            this.productsDgv.ReadOnly = true;
            this.productsDgv.RowHeadersVisible = false;
            this.productsDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDgv.Size = new System.Drawing.Size(308, 276);
            this.productsDgv.TabIndex = 78;
            this.productsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDgv_CellClick);
            this.productsDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDgv_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 84;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 83;
            this.label2.Text = "Name";
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.SystemColors.Control;
            this.priceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTxt.Enabled = false;
            this.priceTxt.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.priceTxt.Location = new System.Drawing.Point(19, 528);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(285, 24);
            this.priceTxt.TabIndex = 80;
            this.priceTxt.Text = "No Selected";
            // 
            // productNameTxt
            // 
            this.productNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.productNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productNameTxt.Enabled = false;
            this.productNameTxt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTxt.Location = new System.Drawing.Point(19, 449);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.ReadOnly = true;
            this.productNameTxt.Size = new System.Drawing.Size(285, 24);
            this.productNameTxt.TabIndex = 79;
            this.productNameTxt.Text = "No Selected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox1.Location = new System.Drawing.Point(6, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 89;
            this.label5.Text = "Quantity";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox5.Location = new System.Drawing.Point(10, 594);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(126, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.confirmBtn.Location = new System.Drawing.Point(158, 594);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(160, 50);
            this.confirmBtn.TabIndex = 90;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // ordersDgv
            // 
            this.ordersDgv.AllowUserToAddRows = false;
            this.ordersDgv.AllowUserToDeleteRows = false;
            this.ordersDgv.AllowUserToResizeColumns = false;
            this.ordersDgv.AllowUserToResizeRows = false;
            this.ordersDgv.BackgroundColor = System.Drawing.Color.White;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Column6,
            this.Column5,
            this.Column7,
            this.dataGridViewTextBoxColumn4});
            this.ordersDgv.Location = new System.Drawing.Point(349, 132);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.ReadOnly = true;
            this.ordersDgv.RowHeadersVisible = false;
            this.ordersDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDgv.Size = new System.Drawing.Size(551, 276);
            this.ordersDgv.TabIndex = 91;
            this.ordersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDgv_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Void";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 94;
            this.label4.Text = "Payment";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox4.Location = new System.Drawing.Point(353, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(244, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // grandTotallbl
            // 
            this.grandTotallbl.AutoSize = true;
            this.grandTotallbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotallbl.Location = new System.Drawing.Point(618, 416);
            this.grandTotallbl.Name = "grandTotallbl";
            this.grandTotallbl.Size = new System.Drawing.Size(102, 18);
            this.grandTotallbl.TabIndex = 97;
            this.grandTotallbl.Text = "Grand Total";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox6.Location = new System.Drawing.Point(625, 436);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(244, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 96;
            this.pictureBox6.TabStop = false;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.placeOrderBtn.Location = new System.Drawing.Point(421, 495);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(176, 50);
            this.placeOrderBtn.TabIndex = 98;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.UseVisualStyleBackColor = false;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // resetFieldsBtn
            // 
            this.resetFieldsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.resetFieldsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetFieldsBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFieldsBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.resetFieldsBtn.Location = new System.Drawing.Point(421, 558);
            this.resetFieldsBtn.Name = "resetFieldsBtn";
            this.resetFieldsBtn.Size = new System.Drawing.Size(176, 50);
            this.resetFieldsBtn.TabIndex = 99;
            this.resetFieldsBtn.Text = "Reset Fields";
            this.resetFieldsBtn.UseVisualStyleBackColor = false;
            this.resetFieldsBtn.Click += new System.EventHandler(this.resetFieldsBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 102;
            this.label6.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(80, 83);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(224, 24);
            this.searchTxt.TabIndex = 100;
            this.searchTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyUp);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox7.Location = new System.Drawing.Point(71, 70);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(244, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 101;
            this.pictureBox7.TabStop = false;
            // 
            // quantityTxt
            // 
            this.quantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxt.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.quantityTxt.Location = new System.Drawing.Point(14, 607);
            this.quantityTxt.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.quantityTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(120, 27);
            this.quantityTxt.TabIndex = 103;
            this.quantityTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSale.Properties.Resources.input_box;
            this.pictureBox2.Location = new System.Drawing.Point(6, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // grandTotalTxt
            // 
            this.grandTotalTxt.Font = new System.Drawing.Font("Verdana", 24F);
            this.grandTotalTxt.Location = new System.Drawing.Point(639, 459);
            this.grandTotalTxt.Name = "grandTotalTxt";
            this.grandTotalTxt.Size = new System.Drawing.Size(217, 69);
            this.grandTotalTxt.TabIndex = 104;
            this.grandTotalTxt.Text = "0";
            this.grandTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMessage
            // 
            this.tlpMessage.BackColor = System.Drawing.Color.Crimson;
            this.tlpMessage.ForeColor = System.Drawing.Color.White;
            this.tlpMessage.OwnerDraw = true;
            this.tlpMessage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tlpMessage.ToolTipTitle = "Error";
            this.tlpMessage.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.tlpMessage_Draw);
            // 
            // paymentTxt
            // 
            this.paymentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTxt.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.paymentTxt.Location = new System.Drawing.Point(364, 448);
            this.paymentTxt.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.paymentTxt.Name = "paymentTxt";
            this.paymentTxt.Size = new System.Drawing.Size(223, 27);
            this.paymentTxt.TabIndex = 105;
            this.paymentTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 668);
            this.Controls.Add(this.paymentTxt);
            this.Controls.Add(this.grandTotalTxt);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.resetFieldsBtn);
            this.Controls.Add(this.placeOrderBtn);
            this.Controls.Add(this.grandTotallbl);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productsDgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView productsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button confirmBtn;
        internal System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label grandTotallbl;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button resetFieldsBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label grandTotalTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolTip tlpMessage;
        private System.Windows.Forms.NumericUpDown paymentTxt;
    }
}