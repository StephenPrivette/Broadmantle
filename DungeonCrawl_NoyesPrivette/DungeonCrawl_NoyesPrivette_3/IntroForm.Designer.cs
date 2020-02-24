namespace DungeonCrawl_NoyesPrivette
{
    partial class IntroForm
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.instructLabel1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.instructLabel2 = new System.Windows.Forms.Label();
            this.playerComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.objectsDataSet = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.victoriesOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.titleLabel1.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel1.Location = new System.Drawing.Point(44, 31);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(311, 65);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "Broadmantle";
            this.titleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.ForeColor = System.Drawing.Color.Silver;
            this.titleLabel2.Location = new System.Drawing.Point(51, 96);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(288, 23);
            this.titleLabel2.TabIndex = 1;
            this.titleLabel2.Text = "by Chris Noyes and Stephen Privette";
            this.titleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructLabel1
            // 
            this.instructLabel1.AutoSize = true;
            this.instructLabel1.ForeColor = System.Drawing.Color.Silver;
            this.instructLabel1.Location = new System.Drawing.Point(67, 209);
            this.instructLabel1.Name = "instructLabel1";
            this.instructLabel1.Size = new System.Drawing.Size(279, 17);
            this.instructLabel1.TabIndex = 2;
            this.instructLabel1.Text = "Highlight your player, enter your password,";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DarkRed;
            this.createButton.ForeColor = System.Drawing.Color.Beige;
            this.createButton.Location = new System.Drawing.Point(37, 294);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(105, 46);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create New Player";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.DarkRed;
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.Beige;
            this.beginButton.Location = new System.Drawing.Point(259, 294);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(105, 46);
            this.beginButton.TabIndex = 6;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // instructLabel2
            // 
            this.instructLabel2.AutoSize = true;
            this.instructLabel2.ForeColor = System.Drawing.Color.Silver;
            this.instructLabel2.Location = new System.Drawing.Point(77, 226);
            this.instructLabel2.Name = "instructLabel2";
            this.instructLabel2.Size = new System.Drawing.Size(269, 17);
            this.instructLabel2.TabIndex = 7;
            this.instructLabel2.Text = "and select Begin. Or create a new player.";
            // 
            // playerComboBox
            // 
            this.playerComboBox.BackColor = System.Drawing.Color.Black;
            this.playerComboBox.ForeColor = System.Drawing.Color.Beige;
            this.playerComboBox.FormattingEnabled = true;
            this.playerComboBox.Location = new System.Drawing.Point(37, 246);
            this.playerComboBox.Name = "playerComboBox";
            this.playerComboBox.Size = new System.Drawing.Size(150, 24);
            this.playerComboBox.TabIndex = 8;
            this.playerComboBox.SelectedIndexChanged += new System.EventHandler(this.playerComboBox_SelectedIndexChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Beige;
            this.passwordTextBox.Location = new System.Drawing.Point(212, 246);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(152, 22);
            this.passwordTextBox.TabIndex = 9;
            // 
            // objectsDataSet
            // 
            this.objectsDataSet.DataSetName = "ObjectsDataSet";
            this.objectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.objectsDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArmorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CastsTableAdapter = null;
            this.tableAdapterManager.EnemiesTableAdapter = null;
            this.tableAdapterManager.LootTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.PotionsTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.TrinketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeaponsTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(168, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Victories";
            // 
            // victoriesOutLabel
            // 
            this.victoriesOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.victoriesOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoriesOutLabel.ForeColor = System.Drawing.Color.Silver;
            this.victoriesOutLabel.Location = new System.Drawing.Point(164, 301);
            this.victoriesOutLabel.Name = "victoriesOutLabel";
            this.victoriesOutLabel.Size = new System.Drawing.Size(70, 39);
            this.victoriesOutLabel.TabIndex = 11;
            this.victoriesOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(398, 371);
            this.Controls.Add(this.victoriesOutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.playerComboBox);
            this.Controls.Add(this.instructLabel2);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.instructLabel1);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel1);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label instructLabel1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Label instructLabel2;
        private System.Windows.Forms.ComboBox playerComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSet objectsDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label victoriesOutLabel;
    }
}