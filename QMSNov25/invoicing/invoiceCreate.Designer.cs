namespace QMS
{
    partial class invoiceCreate
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
            System.Windows.Forms.Label origInvNumberLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label customerOrderNoLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.Label compCustLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label suburbLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label sAddressLabel;
            System.Windows.Forms.Label sSuburbLabel;
            System.Windows.Forms.Label sStateLabel;
            System.Windows.Forms.Label sPostCodeLabel;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label invCodeLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceCreate));
            this.invitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alldata = new QMS.alldata();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.origInvNumberTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new QMS.alldataTableAdapters.TableAdapterManager();
            this.invitemsTableAdapter = new QMS.alldataTableAdapters.invitemsTableAdapter();
            this.invoicesTableAdapter = new QMS.alldataTableAdapters.invoicesTableAdapter();
            this.invitemsTableAdapter1 = new QMS.alldataTableAdapters.invitemsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.nswpcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sSuburbTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.sAddressTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerOrderNoTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.compCustTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.invoicetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceExGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNbrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusInfo = new System.Windows.Forms.StatusBarPanel();
            this.statusTime = new System.Windows.Forms.StatusBarPanel();
            this.statusDate = new System.Windows.Forms.StatusBarPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInvoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffTableAdapter = new QMS.alldataTableAdapters.staffTableAdapter();
            this.nswpcTableAdapter = new QMS.alldataTableAdapters.nswpcTableAdapter();
            this.statesTableAdapter = new QMS.alldataTableAdapters.statesTableAdapter();
            this.invoicetypeTableAdapter = new QMS.alldataTableAdapters.invoicetypeTableAdapter();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findInvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findInvTableAdapter = new QMS.alldataTableAdapters.FindInvTableAdapter();
            origInvNumberLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            customerOrderNoLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            compCustLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            suburbLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            sAddressLabel = new System.Windows.Forms.Label();
            sSuburbLabel = new System.Windows.Forms.Label();
            sStateLabel = new System.Windows.Forms.Label();
            sPostCodeLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            invCodeLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nswpcBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findInvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // origInvNumberLabel
            // 
            origInvNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            origInvNumberLabel.AutoSize = true;
            origInvNumberLabel.Location = new System.Drawing.Point(34, 0);
            origInvNumberLabel.Name = "origInvNumberLabel";
            origInvNumberLabel.Size = new System.Drawing.Size(87, 13);
            origInvNumberLabel.TabIndex = 46;
            origInvNumberLabel.Text = "Orig Inv Number:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(50, 53);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 47;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // customerOrderNoLabel
            // 
            customerOrderNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            customerOrderNoLabel.AutoSize = true;
            customerOrderNoLabel.Location = new System.Drawing.Point(21, 84);
            customerOrderNoLabel.Name = "customerOrderNoLabel";
            customerOrderNoLabel.Size = new System.Drawing.Size(100, 13);
            customerOrderNoLabel.TabIndex = 48;
            customerOrderNoLabel.Text = "Customer Order No:";
            // 
            // contactLabel
            // 
            contactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(74, 115);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 13);
            contactLabel.TabIndex = 49;
            contactLabel.Text = "Contact:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(80, 146);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 50;
            phoneLabel.Text = "Phone:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(54, 199);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(67, 13);
            accountNoLabel.TabIndex = 51;
            accountNoLabel.Text = "Account No:";
            // 
            // compCustLabel
            // 
            compCustLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            compCustLabel.AutoSize = true;
            compCustLabel.Location = new System.Drawing.Point(36, 230);
            compCustLabel.Name = "compCustLabel";
            compCustLabel.Size = new System.Drawing.Size(85, 13);
            compCustLabel.TabIndex = 52;
            compCustLabel.Text = "Company Name:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(438, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 53;
            addressLabel.Text = "Address:";
            // 
            // suburbLabel
            // 
            suburbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(442, 53);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(44, 13);
            suburbLabel.TabIndex = 54;
            suburbLabel.Text = "Suburb:";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(451, 84);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 55;
            stateLabel.Text = "State:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(427, 115);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(59, 13);
            postCodeLabel.TabIndex = 56;
            postCodeLabel.Text = "Post Code:";
            // 
            // sAddressLabel
            // 
            sAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sAddressLabel.AutoSize = true;
            sAddressLabel.Location = new System.Drawing.Point(417, 146);
            sAddressLabel.Name = "sAddressLabel";
            sAddressLabel.Size = new System.Drawing.Size(69, 13);
            sAddressLabel.TabIndex = 57;
            sAddressLabel.Text = "Site Address:";
            // 
            // sSuburbLabel
            // 
            sSuburbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sSuburbLabel.AutoSize = true;
            sSuburbLabel.Location = new System.Drawing.Point(421, 199);
            sSuburbLabel.Name = "sSuburbLabel";
            sSuburbLabel.Size = new System.Drawing.Size(65, 13);
            sSuburbLabel.TabIndex = 58;
            sSuburbLabel.Text = "Site Suburb:";
            // 
            // sStateLabel
            // 
            sStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sStateLabel.AutoSize = true;
            sStateLabel.Location = new System.Drawing.Point(430, 230);
            sStateLabel.Name = "sStateLabel";
            sStateLabel.Size = new System.Drawing.Size(56, 13);
            sStateLabel.TabIndex = 59;
            sStateLabel.Text = "Site State:";
            // 
            // sPostCodeLabel
            // 
            sPostCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sPostCodeLabel.AutoSize = true;
            sPostCodeLabel.Location = new System.Drawing.Point(406, 261);
            sPostCodeLabel.Name = "sPostCodeLabel";
            sPostCodeLabel.Size = new System.Drawing.Size(80, 13);
            sPostCodeLabel.TabIndex = 60;
            sPostCodeLabel.Text = "Site Post Code:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(3, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(32, 13);
            userLabel.TabIndex = 0;
            userLabel.Text = "User:";
            // 
            // invCodeLabel
            // 
            invCodeLabel.AutoSize = true;
            invCodeLabel.Location = new System.Drawing.Point(526, 0);
            invCodeLabel.Name = "invCodeLabel";
            invCodeLabel.Size = new System.Drawing.Size(53, 13);
            invCodeLabel.TabIndex = 2;
            invCodeLabel.Text = "Inv Code:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new System.Drawing.Point(3, 32);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(59, 13);
            commentsLabel.TabIndex = 4;
            commentsLabel.Text = "Comments:";
            // 
            // invitemBindingSource
            // 
            this.invitemBindingSource.DataMember = "invoices";
            this.invitemBindingSource.DataSource = this.alldata;
            // 
            // alldata
            // 
            this.alldata.DataSetName = "alldata";
            this.alldata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(748, 31);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.ReadOnly = true;
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(136, 29);
            this.invoiceNumberTextBox.TabIndex = 46;
            this.invoiceNumberTextBox.TabStop = false;
            this.invoiceNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // origInvNumberTextBox
            // 
            this.origInvNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "OrigInvNumber", true));
            this.origInvNumberTextBox.Location = new System.Drawing.Point(127, 3);
            this.origInvNumberTextBox.Name = "origInvNumberTextBox";
            this.origInvNumberTextBox.Size = new System.Drawing.Size(112, 20);
            this.origInvNumberTextBox.TabIndex = 4;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._06mmTableAdapter = null;
            this.tableAdapterManager._08mmTableAdapter = null;
            this.tableAdapterManager._10mmTableAdapter = null;
            this.tableAdapterManager.authTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.invitemsTableAdapter = this.invitemsTableAdapter;
            this.tableAdapterManager.invoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.invoicetypeTableAdapter = null;
            this.tableAdapterManager.invtxtTableAdapter = null;
            this.tableAdapterManager.monthsTableAdapter = null;
            this.tableAdapterManager.nswpcTableAdapter = null;
            this.tableAdapterManager.quoteitemsTableAdapter = null;
            this.tableAdapterManager.quotesTableAdapter = null;
            this.tableAdapterManager.reportsTableAdapter = null;
            this.tableAdapterManager.servicesTableAdapter = null;
            this.tableAdapterManager.shuttersalTableAdapter = null;
            this.tableAdapterManager.shutterstrTableAdapter = null;
            this.tableAdapterManager.sitesTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QMS.alldataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invitemsTableAdapter
            // 
            this.invitemsTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invitemsTableAdapter1
            // 
            this.invitemsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.96126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.16949F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.46247F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox5, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 3, 7);
            this.tableLayoutPanel1.Controls.Add(sPostCodeLabel, 2, 7);
            this.tableLayoutPanel1.Controls.Add(sStateLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(sSuburbLabel, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.sSuburbTextBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(addressLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(suburbLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.suburbTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(stateLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(postCodeLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(sAddressLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.sAddressTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.origInvNumberTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(origInvNumberLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(invoiceDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.invoiceDateDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(customerOrderNoLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customerOrderNoTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(contactLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.contactTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(phoneLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.phoneTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(accountNoLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.accountNoTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(compCustLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.compCustTextBox, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65847F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.03741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.65334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 299);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "SState", true));
            this.comboBox5.DataSource = this.statesBindingSource;
            this.comboBox5.DisplayMember = "Item";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(492, 233);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(60, 21);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.Tag = "NSW";
            this.comboBox5.ValueMember = "Item";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.alldata;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "SPostCode", true));
            this.comboBox3.DataSource = this.nswpcBindingSource;
            this.comboBox3.DisplayMember = "Pcode";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(492, 264);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "Pcode";
            // 
            // nswpcBindingSource
            // 
            this.nswpcBindingSource.DataMember = "nswpc";
            this.nswpcBindingSource.DataSource = this.alldata;
            // 
            // sSuburbTextBox
            // 
            this.sSuburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "SSuburb", true));
            this.sSuburbTextBox.Location = new System.Drawing.Point(492, 202);
            this.sSuburbTextBox.Name = "sSuburbTextBox";
            this.sSuburbTextBox.Size = new System.Drawing.Size(252, 20);
            this.sSuburbTextBox.TabIndex = 16;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(492, 3);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(298, 38);
            this.addressTextBox.TabIndex = 11;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "Suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(492, 56);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(252, 20);
            this.suburbTextBox.TabIndex = 12;
            // 
            // sAddressTextBox
            // 
            this.sAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "SAddress", true));
            this.sAddressTextBox.Location = new System.Drawing.Point(492, 149);
            this.sAddressTextBox.Multiline = true;
            this.sAddressTextBox.Name = "sAddressTextBox";
            this.sAddressTextBox.Size = new System.Drawing.Size(298, 38);
            this.sAddressTextBox.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "PostCode", true));
            this.comboBox1.DataSource = this.nswpcBindingSource;
            this.comboBox1.DisplayMember = "Pcode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(492, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "Pcode";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "State", true));
            this.comboBox2.DataSource = this.statesBindingSource;
            this.comboBox2.DisplayMember = "Item";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(492, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "Item";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invitemBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(127, 56);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 5;
            this.invoiceDateDateTimePicker.Value = new System.DateTime(2019, 1, 4, 0, 0, 0, 0);
            // 
            // customerOrderNoTextBox
            // 
            this.customerOrderNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "CustomerOrderNo", true));
            this.customerOrderNoTextBox.Location = new System.Drawing.Point(127, 87);
            this.customerOrderNoTextBox.Name = "customerOrderNoTextBox";
            this.customerOrderNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerOrderNoTextBox.TabIndex = 6;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(127, 118);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(127, 149);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 8;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "AccountNo", true));
            this.accountNoTextBox.Location = new System.Drawing.Point(127, 202);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNoTextBox.TabIndex = 9;
            // 
            // compCustTextBox
            // 
            this.compCustTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "CompCust", true));
            this.compCustTextBox.Location = new System.Drawing.Point(127, 233);
            this.compCustTextBox.Name = "compCustTextBox";
            this.compCustTextBox.Size = new System.Drawing.Size(254, 20);
            this.compCustTextBox.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.708738F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.6068F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.34466F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.21845F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(commentsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.commentsTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(invCodeLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(userLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.userComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.37255F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.62745F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(867, 102);
            this.tableLayoutPanel2.TabIndex = 49;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(87, 35);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(403, 64);
            this.commentsTextBox.TabIndex = 3;
            // 
            // userComboBox
            // 
            this.userComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invitemBindingSource, "User", true));
            this.userComboBox.DataSource = this.staffBindingSource;
            this.userComboBox.DisplayMember = "Name";
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(87, 3);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 1;
            this.userComboBox.ValueMember = "Name";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.alldata;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.invoicetypeBindingSource;
            this.comboBox4.DisplayMember = "Item";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(607, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(88, 21);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "Item";
            // 
            // invoicetypeBindingSource
            // 
            this.invoicetypeBindingSource.DataMember = "invoicetype";
            this.invoicetypeBindingSource.DataSource = this.alldata;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.priceExGSTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invNbrBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 488);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 277);
            this.dataGridView1.TabIndex = 19;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "ItemNumber";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            this.itemNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 500;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceExGSTDataGridViewTextBoxColumn
            // 
            this.priceExGSTDataGridViewTextBoxColumn.DataPropertyName = "Price (Ex GST)";
            this.priceExGSTDataGridViewTextBoxColumn.HeaderText = "Price (Ex GST)";
            this.priceExGSTDataGridViewTextBoxColumn.Name = "priceExGSTDataGridViewTextBoxColumn";
            this.priceExGSTDataGridViewTextBoxColumn.Width = 80;
            // 
            // invNbrBindingSource
            // 
            this.invNbrBindingSource.DataMember = "InvNbr";
            this.invNbrBindingSource.DataSource = this.invitemBindingSource;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 793);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusInfo,
            this.statusTime,
            this.statusDate});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(909, 18);
            this.statusBar1.TabIndex = 56;
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Width = 300;
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            // 
            // statusDate
            // 
            this.statusDate.Name = "statusDate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.deleteInvoiceToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.newInvoiceToolStripMenuItem,
            this.lastRecordToolStripMenuItem1,
            this.nextRecordToolStripMenuItem,
            this.lastRecordToolStripMenuItem,
            this.firstRecordToolStripMenuItem,
            this.searchToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            this.newToolStripMenuItem.MouseHover += new System.EventHandler(this.newToolStripMenuItem_MouseHover);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem1.Image = global::QMS.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // deleteInvoiceToolStripMenuItem1
            // 
            this.deleteInvoiceToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deleteInvoiceToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteInvoiceToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deleteInvoiceToolStripMenuItem1.Image")));
            this.deleteInvoiceToolStripMenuItem1.Name = "deleteInvoiceToolStripMenuItem1";
            this.deleteInvoiceToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.deleteInvoiceToolStripMenuItem1.Text = "Delete Invoice";
            this.deleteInvoiceToolStripMenuItem1.ToolTipText = "Delete Invoice";
            this.deleteInvoiceToolStripMenuItem1.Click += new System.EventHandler(this.deleteInvoiceToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.saveToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.saveToolStripMenuItem1.Tag = "Save Current Invoice";
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.ToolTipText = "Save changes to Invoice";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newInvoiceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newInvoiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newInvoiceToolStripMenuItem.Image")));
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.newInvoiceToolStripMenuItem.Tag = "Create New Invoice";
            this.newInvoiceToolStripMenuItem.Text = "New Invoice";
            this.newInvoiceToolStripMenuItem.ToolTipText = "Create new Invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // lastRecordToolStripMenuItem1
            // 
            this.lastRecordToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lastRecordToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastRecordToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("lastRecordToolStripMenuItem1.Image")));
            this.lastRecordToolStripMenuItem1.Name = "lastRecordToolStripMenuItem1";
            this.lastRecordToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.lastRecordToolStripMenuItem1.Text = "Last Record";
            this.lastRecordToolStripMenuItem1.ToolTipText = "Go to last Invoice";
            this.lastRecordToolStripMenuItem1.Click += new System.EventHandler(this.lastRecordToolStripMenuItem1_Click);
            // 
            // nextRecordToolStripMenuItem
            // 
            this.nextRecordToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nextRecordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nextRecordToolStripMenuItem.Image")));
            this.nextRecordToolStripMenuItem.Name = "nextRecordToolStripMenuItem";
            this.nextRecordToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.nextRecordToolStripMenuItem.Text = "Next Record";
            this.nextRecordToolStripMenuItem.ToolTipText = "Go to next Invoice";
            this.nextRecordToolStripMenuItem.Click += new System.EventHandler(this.nextRecordToolStripMenuItem_Click);
            // 
            // lastRecordToolStripMenuItem
            // 
            this.lastRecordToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lastRecordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lastRecordToolStripMenuItem.Image")));
            this.lastRecordToolStripMenuItem.Name = "lastRecordToolStripMenuItem";
            this.lastRecordToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.lastRecordToolStripMenuItem.Text = "Previous Record";
            this.lastRecordToolStripMenuItem.ToolTipText = "Go to previous Invoice";
            this.lastRecordToolStripMenuItem.Click += new System.EventHandler(this.lastRecordToolStripMenuItem_Click);
            // 
            // firstRecordToolStripMenuItem
            // 
            this.firstRecordToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.firstRecordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstRecordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firstRecordToolStripMenuItem.Image")));
            this.firstRecordToolStripMenuItem.Name = "firstRecordToolStripMenuItem";
            this.firstRecordToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.firstRecordToolStripMenuItem.Text = "First Record";
            this.firstRecordToolStripMenuItem.ToolTipText = "Go to first Invoice";
            this.firstRecordToolStripMenuItem.Click += new System.EventHandler(this.firstRecordToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem1.Image")));
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // nswpcTableAdapter
            // 
            this.nswpcTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // invoicetypeTableAdapter
            // 
            this.invoicetypeTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // invoicesBindingNavigator
            // 
            this.invoicesBindingNavigator.AddNewItem = null;
            this.invoicesBindingNavigator.BindingSource = this.invitemBindingSource;
            this.invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesBindingNavigator.DeleteItem = null;
            this.invoicesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem});
            this.invoicesBindingNavigator.Location = new System.Drawing.Point(0, 811);
            this.invoicesBindingNavigator.MoveFirstItem = null;
            this.invoicesBindingNavigator.MoveLastItem = null;
            this.invoicesBindingNavigator.MoveNextItem = null;
            this.invoicesBindingNavigator.MovePreviousItem = null;
            this.invoicesBindingNavigator.Name = "invoicesBindingNavigator";
            this.invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(909, 25);
            this.invoicesBindingNavigator.TabIndex = 45;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(584, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 58;
            this.label1.Text = "Invoice Number";
            // 
            // findInvBindingSource
            // 
            this.findInvBindingSource.DataMember = "FindInv";
            this.findInvBindingSource.DataSource = this.alldata;
            // 
            // findInvTableAdapter
            // 
            this.findInvTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(909, 836);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "invoiceCreate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Invoice | QSync by Your IT Link";
            this.Load += new System.EventHandler(this.invoiceCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nswpcBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findInvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private alldata alldata;
        private alldataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource invitemBindingSource;
        private alldataTableAdapters.invoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.TextBox origInvNumberTextBox;
        private System.Windows.Forms.BindingSource invNbrBindingSource;
        private alldataTableAdapters.invitemsTableAdapter invitemsTableAdapter;
        private alldataTableAdapters.invitemsTableAdapter invitemsTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sSuburbTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox customerOrderNoTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox compCustTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.TextBox sAddressTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceExGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusInfo;
        private System.Windows.Forms.StatusBarPanel statusTime;
        private System.Windows.Forms.StatusBarPanel statusDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private alldataTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource nswpcBindingSource;
        private alldataTableAdapters.nswpcTableAdapter nswpcTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ToolStripMenuItem firstRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteInvoiceToolStripMenuItem1;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private alldataTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.BindingSource invoicetypeBindingSource;
        private alldataTableAdapters.invoicetypeTableAdapter invoicetypeTableAdapter;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator invoicesBindingNavigator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.BindingSource findInvBindingSource;
        private alldataTableAdapters.FindInvTableAdapter findInvTableAdapter;
    }
}