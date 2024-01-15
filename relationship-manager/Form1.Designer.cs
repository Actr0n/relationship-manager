namespace relationship_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer2 = new SplitContainer();
            relationshipList = new ListBox();
            btnDesel = new Button();
            btnExport = new Button();
            btnImport = new Button();
            btnDel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            comboRelation = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            comboTo = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            comboFrom = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            diagramDesigner = new Dalssoft.DiagramNet.Designer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(diagramDesigner);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(258, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Relations";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(relationshipList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnDesel);
            splitContainer2.Panel2.Controls.Add(btnExport);
            splitContainer2.Panel2.Controls.Add(btnImport);
            splitContainer2.Panel2.Controls.Add(btnDel);
            splitContainer2.Panel2.Controls.Add(btnSave);
            splitContainer2.Panel2.Controls.Add(panel3);
            splitContainer2.Panel2.Controls.Add(panel2);
            splitContainer2.Panel2.Controls.Add(panel1);
            splitContainer2.Size = new Size(252, 416);
            splitContainer2.SplitterDistance = 185;
            splitContainer2.TabIndex = 1;
            // 
            // relationshipList
            // 
            relationshipList.Dock = DockStyle.Fill;
            relationshipList.FormattingEnabled = true;
            relationshipList.ItemHeight = 15;
            relationshipList.Location = new Point(0, 0);
            relationshipList.Name = "relationshipList";
            relationshipList.Size = new Size(252, 185);
            relationshipList.TabIndex = 0;
            relationshipList.SelectedIndexChanged += relationshipList_SelectedIndexChanged;
            // 
            // btnDesel
            // 
            btnDesel.Dock = DockStyle.Top;
            btnDesel.Location = new Point(0, 135);
            btnDesel.Name = "btnDesel";
            btnDesel.Size = new Size(252, 23);
            btnDesel.TabIndex = 8;
            btnDesel.Text = "Deselect";
            btnDesel.UseVisualStyleBackColor = true;
            btnDesel.Click += btnDesel_Click;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Bottom;
            btnExport.Location = new Point(0, 181);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(252, 23);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export JSON";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Dock = DockStyle.Bottom;
            btnImport.Location = new Point(0, 204);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(252, 23);
            btnImport.TabIndex = 5;
            btnImport.Text = "Import JSON";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnDel
            // 
            btnDel.Dock = DockStyle.Top;
            btnDel.Location = new Point(0, 112);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(252, 23);
            btnDel.TabIndex = 3;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.Location = new Point(0, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(252, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboRelation);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 30);
            panel3.TabIndex = 11;
            // 
            // comboRelation
            // 
            comboRelation.Dock = DockStyle.Right;
            comboRelation.FormattingEnabled = true;
            comboRelation.Location = new Point(45, 0);
            comboRelation.Name = "comboRelation";
            comboRelation.Size = new Size(207, 23);
            comboRelation.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Relation";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboTo);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 29);
            panel2.TabIndex = 10;
            // 
            // comboTo
            // 
            comboTo.Dock = DockStyle.Right;
            comboTo.FormattingEnabled = true;
            comboTo.Location = new Point(45, 0);
            comboTo.Name = "comboTo";
            comboTo.Size = new Size(207, 23);
            comboTo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 0;
            label2.Text = "To";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboFrom);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 30);
            panel1.TabIndex = 9;
            // 
            // comboFrom
            // 
            comboFrom.Dock = DockStyle.Right;
            comboFrom.FormattingEnabled = true;
            comboFrom.Location = new Point(45, 0);
            comboFrom.Name = "comboFrom";
            comboFrom.Size = new Size(207, 23);
            comboFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(258, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Objects";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // diagramDesigner
            // 
            diagramDesigner.AutoScroll = true;
            diagramDesigner.BackColor = SystemColors.Window;
            diagramDesigner.Dock = DockStyle.Fill;
            diagramDesigner.Location = new Point(0, 0);
            diagramDesigner.Name = "diagramDesigner";
            diagramDesigner.Size = new Size(530, 450);
            diagramDesigner.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Relationship Manager";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer2;
        private ListBox relationshipList;
        private Button btnDesel;
        private Button btnExport;
        private Button btnImport;
        private Button btnDel;
        private Button btnSave;
        private Panel panel3;
        private ComboBox comboRelation;
        private Label label3;
        private Panel panel2;
        private ComboBox comboTo;
        private Label label2;
        private Panel panel1;
        private ComboBox comboFrom;
        private Label label1;
        private TabPage tabPage2;
        private Dalssoft.DiagramNet.Designer diagramDesigner;
    }
}
