namespace Gennalize_Tick_Tack_Toe
{
    partial class Board
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
            this.Start_Clicked = new System.Windows.Forms.Button();
            this.Grid_Board = new System.Windows.Forms.FlowLayoutPanel();
            this.Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start_Clicked
            // 
            this.Start_Clicked.Location = new System.Drawing.Point(301, 12);
            this.Start_Clicked.Name = "Start_Clicked";
            this.Start_Clicked.Size = new System.Drawing.Size(137, 54);
            this.Start_Clicked.TabIndex = 0;
            this.Start_Clicked.Text = "Start_Game";
            this.Start_Clicked.UseVisualStyleBackColor = true;
            this.Start_Clicked.Click += new System.EventHandler(this.Start_Clicked_Click);
            // 
            // Grid_Board
            // 
            this.Grid_Board.Location = new System.Drawing.Point(20, 87);
            this.Grid_Board.Name = "Grid_Board";
            this.Grid_Board.Size = new System.Drawing.Size(722, 422);
            this.Grid_Board.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(48, 38);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(147, 28);
            this.Input.TabIndex = 2;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 532);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Grid_Board);
            this.Controls.Add(this.Start_Clicked);
            this.Name = "Board";
            this.Text = "Tick_Tack_Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Clicked;
        private System.Windows.Forms.FlowLayoutPanel Grid_Board;
        private System.Windows.Forms.TextBox Input;
    }
}

