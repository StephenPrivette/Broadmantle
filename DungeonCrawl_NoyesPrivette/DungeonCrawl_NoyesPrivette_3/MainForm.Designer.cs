namespace DungeonCrawl_NoyesPrivette
{
    partial class MainForm
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
            this.playerDescLabel = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryDescLabel = new System.Windows.Forms.Label();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.roomDescLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treasureChestListBox = new System.Windows.Forms.ListBox();
            this.enemyListBox = new System.Windows.Forms.ListBox();
            this.enemyDescLabel = new System.Windows.Forms.Label();
            this.treasureBoxDescLabel = new System.Windows.Forms.Label();
            this.southButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.fightButton = new System.Windows.Forms.Button();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.infoDescLabel = new System.Windows.Forms.Label();
            this.eventDescLabel = new System.Windows.Forms.Label();
            this.useItemButton = new System.Windows.Forms.Button();
            this.equipButton = new System.Windows.Forms.Button();
            this.dropItemButton = new System.Windows.Forms.Button();
            this.unequipButton = new System.Windows.Forms.Button();
            this.objectsDataSet = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSet();
            this.armorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.armorTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.ArmorTableAdapter();
            this.tableAdapterManager = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager();
            this.castsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.CastsTableAdapter();
            this.enemiesTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.EnemiesTableAdapter();
            this.lootTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.LootTableAdapter();
            this.playersTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PlayersTableAdapter();
            this.potionsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PotionsTableAdapter();
            this.racesTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RacesTableAdapter();
            this.roomsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RoomsTableAdapter();
            this.trinketsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TrinketsTableAdapter();
            this.weaponsTableAdapter = new DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.WeaponsTableAdapter();
            this.castsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enemiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weaponsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerDescLabel
            // 
            this.playerDescLabel.AutoSize = true;
            this.playerDescLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.playerDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.playerDescLabel.Location = new System.Drawing.Point(107, 17);
            this.playerDescLabel.Name = "playerDescLabel";
            this.playerDescLabel.Size = new System.Drawing.Size(68, 27);
            this.playerDescLabel.TabIndex = 0;
            this.playerDescLabel.Text = "Player";
            this.playerDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerListBox
            // 
            this.playerListBox.BackColor = System.Drawing.Color.Black;
            this.playerListBox.ForeColor = System.Drawing.Color.Beige;
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 16;
            this.playerListBox.Location = new System.Drawing.Point(51, 47);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(200, 196);
            this.playerListBox.TabIndex = 1;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged);
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.BackColor = System.Drawing.Color.Black;
            this.inventoryListBox.ForeColor = System.Drawing.Color.Beige;
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 16;
            this.inventoryListBox.Location = new System.Drawing.Point(51, 297);
            this.inventoryListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(200, 244);
            this.inventoryListBox.TabIndex = 3;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // inventoryDescLabel
            // 
            this.inventoryDescLabel.AutoSize = true;
            this.inventoryDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.inventoryDescLabel.Location = new System.Drawing.Point(93, 266);
            this.inventoryDescLabel.Name = "inventoryDescLabel";
            this.inventoryDescLabel.Size = new System.Drawing.Size(102, 27);
            this.inventoryDescLabel.TabIndex = 2;
            this.inventoryDescLabel.Text = "Inventory";
            this.inventoryDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventListBox
            // 
            this.eventListBox.BackColor = System.Drawing.Color.Black;
            this.eventListBox.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListBox.ForeColor = System.Drawing.Color.Orange;
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 27;
            this.eventListBox.Location = new System.Drawing.Point(304, 456);
            this.eventListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(400, 85);
            this.eventListBox.TabIndex = 4;
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDescLabel.ForeColor = System.Drawing.Color.Red;
            this.roomDescLabel.Location = new System.Drawing.Point(459, 10);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(90, 37);
            this.roomDescLabel.TabIndex = 6;
            this.roomDescLabel.Text = "Room";
            this.roomDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.treasureChestListBox);
            this.groupBox1.Controls.Add(this.enemyListBox);
            this.groupBox1.Controls.Add(this.enemyDescLabel);
            this.groupBox1.Controls.Add(this.treasureBoxDescLabel);
            this.groupBox1.Location = new System.Drawing.Point(304, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(400, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // treasureChestListBox
            // 
            this.treasureChestListBox.BackColor = System.Drawing.Color.Black;
            this.treasureChestListBox.ForeColor = System.Drawing.Color.Beige;
            this.treasureChestListBox.FormattingEnabled = true;
            this.treasureChestListBox.ItemHeight = 16;
            this.treasureChestListBox.Location = new System.Drawing.Point(205, 38);
            this.treasureChestListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treasureChestListBox.Name = "treasureChestListBox";
            this.treasureChestListBox.Size = new System.Drawing.Size(188, 148);
            this.treasureChestListBox.TabIndex = 10;
            this.treasureChestListBox.SelectedIndexChanged += new System.EventHandler(this.treasureChestListBox_SelectedIndexChanged);
            // 
            // enemyListBox
            // 
            this.enemyListBox.BackColor = System.Drawing.Color.Black;
            this.enemyListBox.ForeColor = System.Drawing.Color.Beige;
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.ItemHeight = 16;
            this.enemyListBox.Location = new System.Drawing.Point(5, 38);
            this.enemyListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(188, 148);
            this.enemyListBox.TabIndex = 9;
            this.enemyListBox.SelectedIndexChanged += new System.EventHandler(this.enemyListBox_SelectedIndexChanged);
            // 
            // enemyDescLabel
            // 
            this.enemyDescLabel.AutoSize = true;
            this.enemyDescLabel.BackColor = System.Drawing.Color.DarkRed;
            this.enemyDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyDescLabel.ForeColor = System.Drawing.Color.Beige;
            this.enemyDescLabel.Location = new System.Drawing.Point(63, 15);
            this.enemyDescLabel.Name = "enemyDescLabel";
            this.enemyDescLabel.Size = new System.Drawing.Size(65, 20);
            this.enemyDescLabel.TabIndex = 8;
            this.enemyDescLabel.Text = "Enemies";
            this.enemyDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treasureBoxDescLabel
            // 
            this.treasureBoxDescLabel.AutoSize = true;
            this.treasureBoxDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureBoxDescLabel.ForeColor = System.Drawing.Color.Beige;
            this.treasureBoxDescLabel.Location = new System.Drawing.Point(245, 15);
            this.treasureBoxDescLabel.Name = "treasureBoxDescLabel";
            this.treasureBoxDescLabel.Size = new System.Drawing.Size(108, 20);
            this.treasureBoxDescLabel.TabIndex = 12;
            this.treasureBoxDescLabel.Text = "Treasure Chest";
            this.treasureBoxDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // southButton
            // 
            this.southButton.BackColor = System.Drawing.Color.DarkRed;
            this.southButton.ForeColor = System.Drawing.Color.Beige;
            this.southButton.Location = new System.Drawing.Point(622, 300);
            this.southButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(82, 48);
            this.southButton.TabIndex = 20;
            this.southButton.Text = "Move South";
            this.southButton.UseVisualStyleBackColor = false;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // northButton
            // 
            this.northButton.BackColor = System.Drawing.Color.DarkRed;
            this.northButton.ForeColor = System.Drawing.Color.Beige;
            this.northButton.Location = new System.Drawing.Point(622, 248);
            this.northButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(82, 48);
            this.northButton.TabIndex = 18;
            this.northButton.Text = "Move North";
            this.northButton.UseVisualStyleBackColor = false;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.Color.DarkRed;
            this.fightButton.ForeColor = System.Drawing.Color.Beige;
            this.fightButton.Location = new System.Drawing.Point(534, 248);
            this.fightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(82, 48);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight Enemy";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.BackColor = System.Drawing.Color.Black;
            this.infoListBox.ForeColor = System.Drawing.Color.Beige;
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.ItemHeight = 16;
            this.infoListBox.Location = new System.Drawing.Point(304, 297);
            this.infoListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(188, 116);
            this.infoListBox.TabIndex = 13;
            // 
            // infoDescLabel
            // 
            this.infoDescLabel.AutoSize = true;
            this.infoDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.infoDescLabel.Location = new System.Drawing.Point(340, 266);
            this.infoDescLabel.Name = "infoDescLabel";
            this.infoDescLabel.Size = new System.Drawing.Size(123, 27);
            this.infoDescLabel.TabIndex = 22;
            this.infoDescLabel.Text = "Information";
            this.infoDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventDescLabel
            // 
            this.eventDescLabel.AutoSize = true;
            this.eventDescLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescLabel.ForeColor = System.Drawing.Color.Silver;
            this.eventDescLabel.Location = new System.Drawing.Point(461, 427);
            this.eventDescLabel.Name = "eventDescLabel";
            this.eventDescLabel.Size = new System.Drawing.Size(73, 27);
            this.eventDescLabel.TabIndex = 23;
            this.eventDescLabel.Text = "Events";
            this.eventDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useItemButton
            // 
            this.useItemButton.BackColor = System.Drawing.Color.DarkRed;
            this.useItemButton.ForeColor = System.Drawing.Color.Beige;
            this.useItemButton.Location = new System.Drawing.Point(622, 352);
            this.useItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useItemButton.Name = "useItemButton";
            this.useItemButton.Size = new System.Drawing.Size(82, 48);
            this.useItemButton.TabIndex = 24;
            this.useItemButton.Text = "Use Item";
            this.useItemButton.UseVisualStyleBackColor = false;
            this.useItemButton.Click += new System.EventHandler(this.useItemButton_Click);
            // 
            // equipButton
            // 
            this.equipButton.BackColor = System.Drawing.Color.DarkRed;
            this.equipButton.ForeColor = System.Drawing.Color.Beige;
            this.equipButton.Location = new System.Drawing.Point(534, 300);
            this.equipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(82, 48);
            this.equipButton.TabIndex = 25;
            this.equipButton.Text = "Equip";
            this.equipButton.UseVisualStyleBackColor = false;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // dropItemButton
            // 
            this.dropItemButton.BackColor = System.Drawing.Color.DarkRed;
            this.dropItemButton.ForeColor = System.Drawing.Color.Beige;
            this.dropItemButton.Location = new System.Drawing.Point(622, 404);
            this.dropItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropItemButton.Name = "dropItemButton";
            this.dropItemButton.Size = new System.Drawing.Size(82, 48);
            this.dropItemButton.TabIndex = 26;
            this.dropItemButton.Text = "Drop Item";
            this.dropItemButton.UseVisualStyleBackColor = false;
            this.dropItemButton.Click += new System.EventHandler(this.dropItemButton_Click);
            // 
            // unequipButton
            // 
            this.unequipButton.BackColor = System.Drawing.Color.DarkRed;
            this.unequipButton.ForeColor = System.Drawing.Color.Beige;
            this.unequipButton.Location = new System.Drawing.Point(534, 352);
            this.unequipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unequipButton.Name = "unequipButton";
            this.unequipButton.Size = new System.Drawing.Size(82, 48);
            this.unequipButton.TabIndex = 28;
            this.unequipButton.Text = "Unequip";
            this.unequipButton.UseVisualStyleBackColor = false;
            this.unequipButton.Click += new System.EventHandler(this.unequipButton_Click);
            // 
            // objectsDataSet
            // 
            this.objectsDataSet.DataSetName = "ObjectsDataSet";
            this.objectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // armorBindingSource
            // 
            this.armorBindingSource.DataMember = "Armor";
            this.armorBindingSource.DataSource = this.objectsDataSet;
            // 
            // armorTableAdapter
            // 
            this.armorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArmorTableAdapter = this.armorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CastsTableAdapter = this.castsTableAdapter;
            this.tableAdapterManager.EnemiesTableAdapter = this.enemiesTableAdapter;
            this.tableAdapterManager.LootTableAdapter = this.lootTableAdapter;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.PotionsTableAdapter = this.potionsTableAdapter;
            this.tableAdapterManager.RacesTableAdapter = this.racesTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.TrinketsTableAdapter = this.trinketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeaponsTableAdapter = this.weaponsTableAdapter;
            // 
            // castsTableAdapter
            // 
            this.castsTableAdapter.ClearBeforeFill = true;
            // 
            // enemiesTableAdapter
            // 
            this.enemiesTableAdapter.ClearBeforeFill = true;
            // 
            // lootTableAdapter
            // 
            this.lootTableAdapter.ClearBeforeFill = true;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // potionsTableAdapter
            // 
            this.potionsTableAdapter.ClearBeforeFill = true;
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // trinketsTableAdapter
            // 
            this.trinketsTableAdapter.ClearBeforeFill = true;
            // 
            // weaponsTableAdapter
            // 
            this.weaponsTableAdapter.ClearBeforeFill = true;
            // 
            // castsBindingSource
            // 
            this.castsBindingSource.DataMember = "Casts";
            this.castsBindingSource.DataSource = this.objectsDataSet;
            // 
            // enemiesBindingSource
            // 
            this.enemiesBindingSource.DataMember = "Enemies";
            this.enemiesBindingSource.DataSource = this.objectsDataSet;
            // 
            // lootBindingSource
            // 
            this.lootBindingSource.DataMember = "Loot";
            this.lootBindingSource.DataSource = this.objectsDataSet;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.objectsDataSet;
            // 
            // potionsBindingSource
            // 
            this.potionsBindingSource.DataMember = "Potions";
            this.potionsBindingSource.DataSource = this.objectsDataSet;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.objectsDataSet;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.objectsDataSet;
            // 
            // trinketsBindingSource
            // 
            this.trinketsBindingSource.DataMember = "Trinkets";
            this.trinketsBindingSource.DataSource = this.objectsDataSet;
            // 
            // weaponsBindingSource
            // 
            this.weaponsBindingSource.DataMember = "Weapons";
            this.weaponsBindingSource.DataSource = this.objectsDataSet;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(3)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(755, 587);
            this.Controls.Add(this.unequipButton);
            this.Controls.Add(this.dropItemButton);
            this.Controls.Add(this.equipButton);
            this.Controls.Add(this.useItemButton);
            this.Controls.Add(this.eventDescLabel);
            this.Controls.Add(this.infoDescLabel);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.roomDescLabel);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.inventoryDescLabel);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerDescLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broadmantle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerDescLabel;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label inventoryDescLabel;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Label roomDescLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox treasureChestListBox;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Label enemyDescLabel;
        private System.Windows.Forms.Label treasureBoxDescLabel;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Label infoDescLabel;
        private System.Windows.Forms.Label eventDescLabel;
        private System.Windows.Forms.Button useItemButton;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Button dropItemButton;
        private System.Windows.Forms.Button unequipButton;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSet objectsDataSet;
        private System.Windows.Forms.BindingSource armorBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.ArmorTableAdapter armorTableAdapter;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.CastsTableAdapter castsTableAdapter;
        private System.Windows.Forms.BindingSource castsBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.EnemiesTableAdapter enemiesTableAdapter;
        private System.Windows.Forms.BindingSource enemiesBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.LootTableAdapter lootTableAdapter;
        private System.Windows.Forms.BindingSource lootBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.PotionsTableAdapter potionsTableAdapter;
        private System.Windows.Forms.BindingSource potionsBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.TrinketsTableAdapter trinketsTableAdapter;
        private System.Windows.Forms.BindingSource trinketsBindingSource;
        private DungeonCrawl_NoyesPrivette_3.ObjectsDataSetTableAdapters.WeaponsTableAdapter weaponsTableAdapter;
        private System.Windows.Forms.BindingSource weaponsBindingSource;
    }
}

