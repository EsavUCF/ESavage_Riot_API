
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UsernameBar = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summonerV4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileIconIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summonerLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summonerV4BindingSource)).BeginInit();
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
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsernameBar
            // 
            resources.ApplyResources(this.UsernameBar, "UsernameBar");
            this.UsernameBar.Name = "UsernameBar";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RiotAPI_ESavage.Form1);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(RiotAPI_ESavage.Program);
            // 
            // summonerV4BindingSource
            // 
            this.summonerV4BindingSource.DataSource = typeof(RiotAPI_ESavage.SummonerV4);
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsernameBar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetAPIData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summonerV4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAPIData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UsernameBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileIconIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summonerLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource summonerV4BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}

