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
            this.BackPanel = new System.Windows.Forms.Panel();
            this.DebugBox = new System.Windows.Forms.RichTextBox();
            this.DBPanel = new System.Windows.Forms.Panel();
            this.DA_Panel = new System.Windows.Forms.Panel();
            this.BackPanel.SuspendLayout();
            this.DBPanel.SuspendLayout();
            this.DA_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToggleLoopCheckBox
            // 
            this.ToggleLoopCheckBox.AutoSize = true;
            this.ToggleLoopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleLoopCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggleLoopCheckBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleLoopCheckBox.ForeColor = System.Drawing.Color.White;
            this.ToggleLoopCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToggleLoopCheckBox.Location = new System.Drawing.Point(104, 0);
            this.ToggleLoopCheckBox.Name = "ToggleLoopCheckBox";
            this.ToggleLoopCheckBox.Size = new System.Drawing.Size(60, 16);
            this.ToggleLoopCheckBox.TabIndex = 0;
            this.ToggleLoopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToggleLoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToggleLoopLabel
            // 
            this.ToggleLoopLabel.AutoSize = true;
            this.ToggleLoopLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToggleLoopLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleLoopLabel.ForeColor = System.Drawing.Color.White;
            this.ToggleLoopLabel.Location = new System.Drawing.Point(0, 0);
            this.ToggleLoopLabel.Name = "ToggleLoopLabel";
            this.ToggleLoopLabel.Size = new System.Drawing.Size(104, 15);
            this.ToggleLoopLabel.TabIndex = 1;
            this.ToggleLoopLabel.Text = "Toggle RP Loop";
            // 
            // MadeByLabel
            // 
            this.MadeByLabel.AutoSize = true;
            this.MadeByLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MadeByLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadeByLabel.ForeColor = System.Drawing.Color.White;
            this.MadeByLabel.Location = new System.Drawing.Point(0, 0);
            this.MadeByLabel.Name = "MadeByLabel";
            this.MadeByLabel.Size = new System.Drawing.Size(58, 15);
            this.MadeByLabel.TabIndex = 2;
            this.MadeByLabel.Text = "Made by";
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.CreatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatorLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorLabel.LinkColor = System.Drawing.Color.Magenta;
            this.CreatorLabel.Location = new System.Drawing.Point(58, 0);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(106, 18);
            this.CreatorLabel.TabIndex = 3;
            this.CreatorLabel.TabStop = true;
            this.CreatorLabel.Text = "dr NHA#8768";
            this.CreatorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConnectionText
            // 
            this.ConnectionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionText.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectionText.Location = new System.Drawing.Point(0, 0);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(164, 15);
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
            this.Side.Location = new System.Drawing.Point(164, 0);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(10, 219);
            this.Side.TabIndex = 5;
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.DBPanel);
            this.BackPanel.Controls.Add(this.DA_Panel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackPanel.Location = new System.Drawing.Point(0, 15);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(164, 42);
            this.BackPanel.TabIndex = 7;
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.DebugBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.DebugBox.Location = new System.Drawing.Point(0, 57);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.ReadOnly = true;
            this.DebugBox.Size = new System.Drawing.Size(164, 162);
            this.DebugBox.TabIndex = 4;
            this.DebugBox.Text = "";
            this.DebugBox.WordWrap = false;
            // 
            // DBPanel
            // 
            this.DBPanel.Controls.Add(this.CreatorLabel);
            this.DBPanel.Controls.Add(this.MadeByLabel);
            this.DBPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DBPanel.Location = new System.Drawing.Point(0, 16);
            this.DBPanel.Name = "DBPanel";
            this.DBPanel.Size = new System.Drawing.Size(164, 18);
            this.DBPanel.TabIndex = 8;
            // 
            // DA_Panel
            // 
            this.DA_Panel.Controls.Add(this.ToggleLoopCheckBox);
            this.DA_Panel.Controls.Add(this.ToggleLoopLabel);
            this.DA_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DA_Panel.Location = new System.Drawing.Point(0, 0);
            this.DA_Panel.Name = "DA_Panel";
            this.DA_Panel.Size = new System.Drawing.Size(164, 16);
            this.DA_Panel.TabIndex = 8;
            // 
            // RP_Loop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(174, 219);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.ConnectionText);
            this.Controls.Add(this.Side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RP_Loop_Form";
            this.Opacity = 0.84D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP Loop";
            this.TopMost = true;
            this.BackPanel.ResumeLayout(false);
            this.DBPanel.ResumeLayout(false);
            this.DBPanel.PerformLayout();
            this.DA_Panel.ResumeLayout(false);
            this.DA_Panel.PerformLayout();
            this.ResumeLayout(false);

		}


		private CheckBox ToggleLoopCheckBox;
		private Label ToggleLoopLabel;
		private Label MadeByLabel;
		private LinkLabel CreatorLabel;
        private Label ConnectionText;
        private Panel Side;
        private Panel BackPanel;
        private RichTextBox DebugBox;
        private Panel DBPanel;
        private Panel DA_Panel;
    }
}

