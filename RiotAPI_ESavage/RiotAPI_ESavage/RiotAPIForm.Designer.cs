
namespace RiotAPI_ESavage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetAPIData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SummonerBox = new System.Windows.Forms.TextBox();
            this.UsernameBar = new System.Windows.Forms.Label();
            this.RotationButton = new System.Windows.Forms.Button();
            this.APIKeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoLStatusButton = new System.Windows.Forms.Button();
            this.RegionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileIconIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerV4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summonerV4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAPIData
            // 
            resources.ApplyResources(this.GetAPIData, "GetAPIData");
            this.GetAPIData.Name = "GetAPIData";
            this.GetAPIData.UseVisualStyleBackColor = true;
            this.GetAPIData.Click += new System.EventHandler(this.GetAPIData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.puuidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.profileIconIdDataGridViewTextBoxColumn,
            this.revisionDateDataGridViewTextBoxColumn,
            this.summonerLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.summonerV4BindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // SummonerBox
            // 
            resources.ApplyResources(this.SummonerBox, "SummonerBox");
            this.SummonerBox.Name = "SummonerBox";
            this.SummonerBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsernameBar
            // 
            resources.ApplyResources(this.UsernameBar, "UsernameBar");
            this.UsernameBar.Name = "UsernameBar";
            // 
            // RotationButton
            // 
            resources.ApplyResources(this.RotationButton, "RotationButton");
            this.RotationButton.Name = "RotationButton";
            this.RotationButton.UseVisualStyleBackColor = true;
            this.RotationButton.Click += new System.EventHandler(this.ClashV1Button_Click);
            // 
            // APIKeyBox
            // 
            resources.ApplyResources(this.APIKeyBox, "APIKeyBox");
            this.APIKeyBox.Name = "APIKeyBox";
            this.APIKeyBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LoLStatusButton
            // 
            resources.ApplyResources(this.LoLStatusButton, "LoLStatusButton");
            this.LoLStatusButton.Name = "LoLStatusButton";
            this.LoLStatusButton.UseVisualStyleBackColor = true;
            this.LoLStatusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegionBox
            // 
            this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Items.AddRange(new object[] {
            resources.GetString("RegionBox.Items"),
            resources.GetString("RegionBox.Items1"),
            resources.GetString("RegionBox.Items2"),
            resources.GetString("RegionBox.Items3"),
            resources.GetString("RegionBox.Items4"),
            resources.GetString("RegionBox.Items5"),
            resources.GetString("RegionBox.Items6"),
            resources.GetString("RegionBox.Items7"),
            resources.GetString("RegionBox.Items8"),
            resources.GetString("RegionBox.Items9"),
            resources.GetString("RegionBox.Items10")});
            resources.ApplyResources(this.RegionBox, "RegionBox");
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "accountId";
            resources.ApplyResources(this.accountIdDataGridViewTextBoxColumn, "accountIdDataGridViewTextBoxColumn");
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            // 
            // puuidDataGridViewTextBoxColumn
            // 
            this.puuidDataGridViewTextBoxColumn.DataPropertyName = "puuid";
            resources.ApplyResources(this.puuidDataGridViewTextBoxColumn, "puuidDataGridViewTextBoxColumn");
            this.puuidDataGridViewTextBoxColumn.Name = "puuidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // profileIconIdDataGridViewTextBoxColumn
            // 
            this.profileIconIdDataGridViewTextBoxColumn.DataPropertyName = "profileIconId";
            resources.ApplyResources(this.profileIconIdDataGridViewTextBoxColumn, "profileIconIdDataGridViewTextBoxColumn");
            this.profileIconIdDataGridViewTextBoxColumn.Name = "profileIconIdDataGridViewTextBoxColumn";
            // 
            // revisionDateDataGridViewTextBoxColumn
            // 
            this.revisionDateDataGridViewTextBoxColumn.DataPropertyName = "revisionDate";
            resources.ApplyResources(this.revisionDateDataGridViewTextBoxColumn, "revisionDateDataGridViewTextBoxColumn");
            this.revisionDateDataGridViewTextBoxColumn.Name = "revisionDateDataGridViewTextBoxColumn";
            // 
            // summonerLevelDataGridViewTextBoxColumn
            // 
            this.summonerLevelDataGridViewTextBoxColumn.DataPropertyName = "summonerLevel";
            resources.ApplyResources(this.summonerLevelDataGridViewTextBoxColumn, "summonerLevelDataGridViewTextBoxColumn");
            this.summonerLevelDataGridViewTextBoxColumn.Name = "summonerLevelDataGridViewTextBoxColumn";
            // 
            // summonerV4BindingSource
            // 
            this.summonerV4BindingSource.DataSource = typeof(RiotAPI_ESavage.SummonerV4);
            this.summonerV4BindingSource.CurrentChanged += new System.EventHandler(this.summonerV4BindingSource_CurrentChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RiotAPI_ESavage.Form1);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(RiotAPI_ESavage.Program);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegionBox);
            this.Controls.Add(this.LoLStatusButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.APIKeyBox);
            this.Controls.Add(this.RotationButton);
            this.Controls.Add(this.UsernameBar);
            this.Controls.Add(this.SummonerBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetAPIData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summonerV4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAPIData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SummonerBox;
        private System.Windows.Forms.Label UsernameBar;
        private System.Windows.Forms.BindingSource summonerV4BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileIconIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summonerLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RotationButton;
        private System.Windows.Forms.TextBox APIKeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoLStatusButton;
        private System.Windows.Forms.ComboBox RegionBox;
        private System.Windows.Forms.Label label2;
    }
}

