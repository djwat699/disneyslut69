namespace Something
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
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label disney_WorldLabel;
            System.Windows.Forms.Label disney_LandLabel;
            System.Windows.Forms.Label within_a_100_milesLabel;
            System.Windows.Forms.Label daytimeLabel;
            System.Windows.Forms.Label good_RatingsLabel;
            System.Windows.Forms.Label family_FriendlyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database4DataSet = new Something.Database4DataSet();
            this.disney_AttractionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disney_AttractionsTableAdapter = new Something.Database4DataSetTableAdapters.Disney_AttractionsTableAdapter();
            this.tableAdapterManager = new Something.Database4DataSetTableAdapters.TableAdapterManager();
            this.disney_AttractionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disney_AttractionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.disney_AttractionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.costComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.disney_WorldCheckBox = new System.Windows.Forms.CheckBox();
            this.disney_LandCheckBox = new System.Windows.Forms.CheckBox();
            this.within_a_100_milesCheckBox = new System.Windows.Forms.CheckBox();
            this.daytimeCheckBox = new System.Windows.Forms.CheckBox();
            this.good_RatingsCheckBox = new System.Windows.Forms.CheckBox();
            this.family_FriendlyCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            pictureLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            disney_WorldLabel = new System.Windows.Forms.Label();
            disney_LandLabel = new System.Windows.Forms.Label();
            within_a_100_milesLabel = new System.Windows.Forms.Label();
            daytimeLabel = new System.Windows.Forms.Label();
            good_RatingsLabel = new System.Windows.Forms.Label();
            family_FriendlyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsBindingNavigator)).BeginInit();
            this.disney_AttractionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(36, 415);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(43, 13);
            pictureLabel.TabIndex = 41;
            pictureLabel.Text = "Picture:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(272, 382);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 40;
            costLabel.Text = "Cost:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(34, 382);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 39;
            descriptionLabel.Text = "Description:";
            // 
            // disney_WorldLabel
            // 
            disney_WorldLabel.AutoSize = true;
            disney_WorldLabel.Location = new System.Drawing.Point(272, 357);
            disney_WorldLabel.Name = "disney_WorldLabel";
            disney_WorldLabel.Size = new System.Drawing.Size(73, 13);
            disney_WorldLabel.TabIndex = 37;
            disney_WorldLabel.Text = "Disney World:";
            // 
            // disney_LandLabel
            // 
            disney_LandLabel.AutoSize = true;
            disney_LandLabel.Location = new System.Drawing.Point(34, 352);
            disney_LandLabel.Name = "disney_LandLabel";
            disney_LandLabel.Size = new System.Drawing.Size(69, 13);
            disney_LandLabel.TabIndex = 35;
            disney_LandLabel.Text = "Disney Land:";
            // 
            // within_a_100_milesLabel
            // 
            within_a_100_milesLabel.AutoSize = true;
            within_a_100_milesLabel.Location = new System.Drawing.Point(270, 324);
            within_a_100_milesLabel.Name = "within_a_100_milesLabel";
            within_a_100_milesLabel.Size = new System.Drawing.Size(96, 13);
            within_a_100_milesLabel.TabIndex = 33;
            within_a_100_milesLabel.Text = "Within a 100 miles:";
            // 
            // daytimeLabel
            // 
            daytimeLabel.AutoSize = true;
            daytimeLabel.Location = new System.Drawing.Point(36, 315);
            daytimeLabel.Name = "daytimeLabel";
            daytimeLabel.Size = new System.Drawing.Size(48, 13);
            daytimeLabel.TabIndex = 31;
            daytimeLabel.Text = "Daytime:";
            // 
            // good_RatingsLabel
            // 
            good_RatingsLabel.AutoSize = true;
            good_RatingsLabel.Location = new System.Drawing.Point(270, 292);
            good_RatingsLabel.Name = "good_RatingsLabel";
            good_RatingsLabel.Size = new System.Drawing.Size(75, 13);
            good_RatingsLabel.TabIndex = 29;
            good_RatingsLabel.Text = "Good Ratings:";
            // 
            // family_FriendlyLabel
            // 
            family_FriendlyLabel.AutoSize = true;
            family_FriendlyLabel.Location = new System.Drawing.Point(34, 296);
            family_FriendlyLabel.Name = "family_FriendlyLabel";
            family_FriendlyLabel.Size = new System.Drawing.Size(78, 13);
            family_FriendlyLabel.TabIndex = 27;
            family_FriendlyLabel.Text = "Family Friendly:";
            // 
            // database4DataSet
            // 
            this.database4DataSet.DataSetName = "Database4DataSet";
            this.database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disney_AttractionsBindingSource
            // 
            this.disney_AttractionsBindingSource.DataMember = "Disney Attractions";
            this.disney_AttractionsBindingSource.DataSource = this.database4DataSet;
            // 
            // disney_AttractionsTableAdapter
            // 
            this.disney_AttractionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Disney_AttractionsTableAdapter = this.disney_AttractionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Something.Database4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disney_AttractionsBindingNavigator
            // 
            this.disney_AttractionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disney_AttractionsBindingNavigator.BindingSource = this.disney_AttractionsBindingSource;
            this.disney_AttractionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disney_AttractionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disney_AttractionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.disney_AttractionsBindingNavigatorSaveItem});
            this.disney_AttractionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disney_AttractionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disney_AttractionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disney_AttractionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disney_AttractionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disney_AttractionsBindingNavigator.Name = "disney_AttractionsBindingNavigator";
            this.disney_AttractionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disney_AttractionsBindingNavigator.Size = new System.Drawing.Size(463, 25);
            this.disney_AttractionsBindingNavigator.TabIndex = 0;
            this.disney_AttractionsBindingNavigator.Text = "bindingNavigator1";
            this.disney_AttractionsBindingNavigator.RefreshItems += new System.EventHandler(this.disney_AttractionsBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // disney_AttractionsBindingNavigatorSaveItem
            // 
            this.disney_AttractionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disney_AttractionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disney_AttractionsBindingNavigatorSaveItem.Image")));
            this.disney_AttractionsBindingNavigatorSaveItem.Name = "disney_AttractionsBindingNavigatorSaveItem";
            this.disney_AttractionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disney_AttractionsBindingNavigatorSaveItem.Text = "Save Data";
            this.disney_AttractionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.disney_AttractionsBindingNavigatorSaveItem_Click);
            // 
            // disney_AttractionsDataGridView
            // 
            this.disney_AttractionsDataGridView.AutoGenerateColumns = false;
            this.disney_AttractionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disney_AttractionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.disney_AttractionsDataGridView.DataSource = this.disney_AttractionsBindingSource;
            this.disney_AttractionsDataGridView.Location = new System.Drawing.Point(614, 302);
            this.disney_AttractionsDataGridView.Name = "disney_AttractionsDataGridView";
            this.disney_AttractionsDataGridView.Size = new System.Drawing.Size(120, 26);
            this.disney_AttractionsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Family Friendly";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Family Friendly";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Good Ratings";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Good Ratings";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Daytime";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Daytime";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Within a 100 miles";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Within a 100 miles";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Disney Land";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Disney Land";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Disney World";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Disney World";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Picture";
            this.dataGridViewTextBoxColumn4.HeaderText = "Picture";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 446);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 137);
            this.textBox1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(270, 417);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // costComboBox
            // 
            this.costComboBox.FormattingEnabled = true;
            this.costComboBox.Location = new System.Drawing.Point(378, 381);
            this.costComboBox.Name = "costComboBox";
            this.costComboBox.Size = new System.Drawing.Size(69, 21);
            this.costComboBox.TabIndex = 49;
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(123, 382);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.descriptionComboBox.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(364, 417);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 44;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disney_AttractionsBindingSource, "Picture", true));
            this.pictureTextBox.Location = new System.Drawing.Point(123, 422);
            this.pictureTextBox.Multiline = true;
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(104, 161);
            this.pictureTextBox.TabIndex = 42;
            // 
            // disney_WorldCheckBox
            // 
            this.disney_WorldCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Disney World", true));
            this.disney_WorldCheckBox.Location = new System.Drawing.Point(378, 352);
            this.disney_WorldCheckBox.Name = "disney_WorldCheckBox";
            this.disney_WorldCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disney_WorldCheckBox.TabIndex = 38;
            this.disney_WorldCheckBox.Text = "Yes/No";
            this.disney_WorldCheckBox.UseVisualStyleBackColor = true;
            // 
            // disney_LandCheckBox
            // 
            this.disney_LandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Disney Land", true));
            this.disney_LandCheckBox.Location = new System.Drawing.Point(123, 352);
            this.disney_LandCheckBox.Name = "disney_LandCheckBox";
            this.disney_LandCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disney_LandCheckBox.TabIndex = 36;
            this.disney_LandCheckBox.Text = "Yes/No";
            this.disney_LandCheckBox.UseVisualStyleBackColor = true;
            // 
            // within_a_100_milesCheckBox
            // 
            this.within_a_100_milesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Within a 100 miles", true));
            this.within_a_100_milesCheckBox.Location = new System.Drawing.Point(378, 322);
            this.within_a_100_milesCheckBox.Name = "within_a_100_milesCheckBox";
            this.within_a_100_milesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.within_a_100_milesCheckBox.TabIndex = 34;
            this.within_a_100_milesCheckBox.Text = "Yes/No";
            this.within_a_100_milesCheckBox.UseVisualStyleBackColor = true;
            // 
            // daytimeCheckBox
            // 
            this.daytimeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Daytime", true));
            this.daytimeCheckBox.Location = new System.Drawing.Point(123, 322);
            this.daytimeCheckBox.Name = "daytimeCheckBox";
            this.daytimeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.daytimeCheckBox.TabIndex = 32;
            this.daytimeCheckBox.Text = "Yes/No";
            this.daytimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // good_RatingsCheckBox
            // 
            this.good_RatingsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Good Ratings", true));
            this.good_RatingsCheckBox.Location = new System.Drawing.Point(378, 291);
            this.good_RatingsCheckBox.Name = "good_RatingsCheckBox";
            this.good_RatingsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.good_RatingsCheckBox.TabIndex = 30;
            this.good_RatingsCheckBox.Text = "Yes/No";
            this.good_RatingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // family_FriendlyCheckBox
            // 
            this.family_FriendlyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.disney_AttractionsBindingSource, "Family Friendly", true));
            this.family_FriendlyCheckBox.Location = new System.Drawing.Point(123, 292);
            this.family_FriendlyCheckBox.Name = "family_FriendlyCheckBox";
            this.family_FriendlyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.family_FriendlyCheckBox.TabIndex = 28;
            this.family_FriendlyCheckBox.Text = "Yes/No";
            this.family_FriendlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costComboBox);
            this.Controls.Add(this.descriptionComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(disney_WorldLabel);
            this.Controls.Add(this.disney_WorldCheckBox);
            this.Controls.Add(disney_LandLabel);
            this.Controls.Add(this.disney_LandCheckBox);
            this.Controls.Add(within_a_100_milesLabel);
            this.Controls.Add(this.within_a_100_milesCheckBox);
            this.Controls.Add(daytimeLabel);
            this.Controls.Add(this.daytimeCheckBox);
            this.Controls.Add(good_RatingsLabel);
            this.Controls.Add(this.good_RatingsCheckBox);
            this.Controls.Add(family_FriendlyLabel);
            this.Controls.Add(this.family_FriendlyCheckBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.disney_AttractionsDataGridView);
            this.Controls.Add(this.disney_AttractionsBindingNavigator);
            this.Name = "Form1";
            this.Text = "disney ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsBindingNavigator)).EndInit();
            this.disney_AttractionsBindingNavigator.ResumeLayout(false);
            this.disney_AttractionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disney_AttractionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database4DataSet database4DataSet;
        private System.Windows.Forms.BindingSource disney_AttractionsBindingSource;
        private Database4DataSetTableAdapters.Disney_AttractionsTableAdapter disney_AttractionsTableAdapter;
        private Database4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disney_AttractionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton disney_AttractionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView disney_AttractionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox costComboBox;
        private System.Windows.Forms.ComboBox descriptionComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.CheckBox disney_WorldCheckBox;
        private System.Windows.Forms.CheckBox disney_LandCheckBox;
        private System.Windows.Forms.CheckBox within_a_100_milesCheckBox;
        private System.Windows.Forms.CheckBox daytimeCheckBox;
        private System.Windows.Forms.CheckBox good_RatingsCheckBox;
        private System.Windows.Forms.CheckBox family_FriendlyCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

