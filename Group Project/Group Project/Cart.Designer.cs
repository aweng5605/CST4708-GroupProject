
namespace Group_Project
{
    partial class Cart
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
            this.CartPanel = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.lbTotalAmt = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartPanel
            // 
            this.CartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartPanel.AutoScroll = true;
            this.CartPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CartPanel.Location = new System.Drawing.Point(12, 63);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(844, 342);
            this.CartPanel.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUserName.Font = new System.Drawing.Font("Lucida Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Image = global::Group_Project.Properties.Resources.Black;
            this.lbUserName.Location = new System.Drawing.Point(12, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 23);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Guest";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUserName.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.AutoSize = true;
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddToCart.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(741, 466);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(132, 33);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Checkout";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCart.AutoSize = true;
            this.btnClearCart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClearCart.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Location = new System.Drawing.Point(41, 416);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(132, 33);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // lbTotalAmt
            // 
            this.lbTotalAmt.AutoSize = true;
            this.lbTotalAmt.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAmt.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmt.Location = new System.Drawing.Point(649, 416);
            this.lbTotalAmt.Name = "lbTotalAmt";
            this.lbTotalAmt.Size = new System.Drawing.Size(110, 27);
            this.lbTotalAmt.TabIndex = 8;
            this.lbTotalAmt.Text = "Total: ";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.BackColor = System.Drawing.Color.Transparent;
            this.lbTax.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.Location = new System.Drawing.Point(415, 416);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(82, 27);
            this.lbTax.TabIndex = 10;
            this.lbTax.Text = "Tax: ";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(41, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Group_Project.Properties.Resources.BackgroundReduced;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.lbTotalAmt);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.CartPanel);
            this.DoubleBuffered = true;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Label lbTotalAmt;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Button btnBack;
    }
}