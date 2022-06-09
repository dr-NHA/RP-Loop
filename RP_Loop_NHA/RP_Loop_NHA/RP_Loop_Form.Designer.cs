using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RP_Loop_NHA{
    partial class RP_Loop_Form{

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

		protected override void Dispose(bool disposing){
			if (disposing && components != null){
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_Loop_Form));
            this.ToggleLoopCheckBox = new System.Windows.Forms.CheckBox();
            this.ToggleLoopLabel = new System.Windows.Forms.Label();
            this.MadeByLabel = new System.Windows.Forms.Label();
            this.CreatorLabel = new System.Windows.Forms.LinkLabel();
            this.ConnectionText = new System.Windows.Forms.Label();
            this.Side = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ToggleLoopCheckBox
            // 
            this.ToggleLoopCheckBox.AutoSize = true;
            this.ToggleLoopCheckBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleLoopCheckBox.ForeColor = System.Drawing.Color.White;
            this.ToggleLoopCheckBox.Location = new System.Drawing.Point(122, 24);
            this.ToggleLoopCheckBox.Name = "ToggleLoopCheckBox";
            this.ToggleLoopCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ToggleLoopCheckBox.TabIndex = 0;
            this.ToggleLoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToggleLoopLabel
            // 
            this.ToggleLoopLabel.AutoSize = true;
            this.ToggleLoopLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleLoopLabel.ForeColor = System.Drawing.Color.White;
            this.ToggleLoopLabel.Location = new System.Drawing.Point(12, 23);
            this.ToggleLoopLabel.Name = "ToggleLoopLabel";
            this.ToggleLoopLabel.Size = new System.Drawing.Size(104, 15);
            this.ToggleLoopLabel.TabIndex = 1;
            this.ToggleLoopLabel.Text = "Toggle RP Loop";
            // 
            // MadeByLabel
            // 
            this.MadeByLabel.AutoSize = true;
            this.MadeByLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadeByLabel.ForeColor = System.Drawing.Color.White;
            this.MadeByLabel.Location = new System.Drawing.Point(3, 44);
            this.MadeByLabel.Name = "MadeByLabel";
            this.MadeByLabel.Size = new System.Drawing.Size(58, 15);
            this.MadeByLabel.TabIndex = 2;
            this.MadeByLabel.Text = "Made by";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorLabel.LinkColor = System.Drawing.Color.Magenta;
            this.CreatorLabel.Location = new System.Drawing.Point(61, 44);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(92, 15);
            this.CreatorLabel.TabIndex = 3;
            this.CreatorLabel.TabStop = true;
            this.CreatorLabel.Text = "dr NHA#8768";
            // 
            // ConnectionText
            // 
            this.ConnectionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionText.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectionText.Location = new System.Drawing.Point(0, 0);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(156, 15);
            this.ConnectionText.TabIndex = 4;
            this.ConnectionText.Text = "Not Connected!";
            this.ConnectionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Side
            // 
            this.Side.BackColor = System.Drawing.Color.ForestGreen;
            this.Side.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Side.Dock = System.Windows.Forms.DockStyle.Right;
            this.Side.ForeColor = System.Drawing.Color.ForestGreen;
            this.Side.Location = new System.Drawing.Point(156, 0);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(10, 65);
            this.Side.TabIndex = 5;
            // 
            // RP_Loop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(166, 65);
            this.Controls.Add(this.ConnectionText);
            this.Controls.Add(this.CreatorLabel);
            this.Controls.Add(this.MadeByLabel);
            this.Controls.Add(this.ToggleLoopLabel);
            this.Controls.Add(this.ToggleLoopCheckBox);
            this.Controls.Add(this.Side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP_Loop_Form";
            this.Opacity = 0.84D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP Loop";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		private CheckBox ToggleLoopCheckBox;
		private Label ToggleLoopLabel;
		private Label MadeByLabel;
		private LinkLabel CreatorLabel;
        private Label ConnectionText;
        private Panel Side;
    }
}

