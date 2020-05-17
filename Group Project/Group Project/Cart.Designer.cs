
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
            this.lbCreditCard = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
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
            this.CartPanel.Size = new System.Drawing.Size(844, 333);
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
            this.btnAddToCart.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(741, 457);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(132, 33);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Checkout";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCart.AutoSize = true;
            this.btnClearCart.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Location = new System.Drawing.Point(16, 457);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(132, 33);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
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
            // lbCreditCard
            // 
            this.lbCreditCard.AutoSize = true;
            this.lbCreditCard.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbCreditCard.Font = new System.Drawing.Font("Constantia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreditCard.ForeColor = System.Drawing.Color.White;
            this.lbCreditCard.Location = new System.Drawing.Point(394, 9);
            this.lbCreditCard.Name = "lbCreditCard";
            this.lbCreditCard.Size = new System.Drawing.Size(131, 26);
            this.lbCreditCard.TabIndex = 9;
            this.lbCreditCard.Text = "Credit Card:";
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
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Group_Project.Properties.Resources.BackgroundReduced;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.lbCreditCard);
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
        private System.Windows.Forms.Label lbCreditCard;
        private System.Windows.Forms.Label lbTax;
    }
}