namespace Grocery_Store_Online
{
    partial class Form2
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
            lgtButton = new Button();
            button1 = new Button();
            groceryListBox = new ListBox();
            cartList = new ListBox();
            addToCart = new Button();
            SuspendLayout();
            // 
            // lgtButton
            // 
            lgtButton.Location = new Point(356, 333);
            lgtButton.Name = "lgtButton";
            lgtButton.Size = new Size(75, 23);
            lgtButton.TabIndex = 0;
            lgtButton.Text = "Logout";
            lgtButton.UseVisualStyleBackColor = true;
            lgtButton.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(647, 411);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 2;
            button1.Text = "Load Groceries";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groceryListBox
            // 
            groceryListBox.FormattingEnabled = true;
            groceryListBox.ItemHeight = 15;
            groceryListBox.Location = new Point(619, 12);
            groceryListBox.Name = "groceryListBox";
            groceryListBox.Size = new Size(169, 364);
            groceryListBox.TabIndex = 3;
            // 
            // cartList
            // 
            cartList.FormattingEnabled = true;
            cartList.ItemHeight = 15;
            cartList.Location = new Point(447, 12);
            cartList.Name = "cartList";
            cartList.Size = new Size(145, 289);
            cartList.TabIndex = 4;
            // 
            // addToCart
            // 
            addToCart.Location = new Point(647, 382);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(105, 23);
            addToCart.TabIndex = 5;
            addToCart.Text = "Add To Cart";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addToCart);
            Controls.Add(cartList);
            Controls.Add(groceryListBox);
            Controls.Add(button1);
            Controls.Add(lgtButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button lgtButton;
        private Button button1;
        private ListBox groceryListBox;
        private ListBox cartList;
        private Button addToCart;
    }
}