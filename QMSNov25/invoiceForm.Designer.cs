namespace QMS
{
    partial class invoiceForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label custEmailLabel;
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label origInvNumberLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label invCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceForm));
            this.qmsDataSet = new QMS.qmsDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new QMS.qmsDataSetTableAdapters.invoicesTableAdapter();
            this.tableAdapterManager = new QMS.qmsDataSetTableAdapters.TableAdapterManager();
            this.invitemsTableAdapter = new QMS.qmsDataSetTableAdapters.invitemsTableAdapter();
            this.customerOrderNoTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.compCustTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.sAddressTextBox = new System.Windows.Forms.TextBox();
            this.sSuburbTextBox = new System.Windows.Forms.TextBox();
            this.sStateTextBox = new System.Windows.Forms.TextBox();
            this.sPostCodeTextBox = new System.Windows.Forms.TextBox();
            this.invNbrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.invCodeTextBox = new System.Windows.Forms.TextBox();
            this.origInvNumberTextBox = new System.Windows.Forms.TextBox();
            this.custEmailTextBox = new System.Windows.Forms.TextBox();
            this.niBtn = new MetroFramework.Components.MetroToolTip();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusInfo = new System.Windows.Forms.StatusBarPanel();
            this.statusTime = new System.Windows.Forms.StatusBarPanel();
            this.statusDate = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.invNbrBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceExGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            custEmailLabel = new System.Windows.Forms.Label();
            userLabel = new System.Windows.Forms.Label();
            origInvNumberLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            invCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(6, 247);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(119, 18);
            invoiceDateLabel.TabIndex = 5;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // customerOrderNoLabel
            // 
            customerOrderNoLabel.AutoSize = true;
            customerOrderNoLabel.Location = new System.Drawing.Point(6, 28);
            customerOrderNoLabel.Name = "customerOrderNoLabel";
            customerOrderNoLabel.Size = new System.Drawing.Size(111, 18);
            customerOrderNoLabel.TabIndex = 7;
            customerOrderNoLabel.Text = "PO/Order No";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(8, 79);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(78, 18);
            contactLabel.TabIndex = 9;
            contactLabel.Text = "Contact:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 130);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 18);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(6, 189);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(107, 18);
            accountNoLabel.TabIndex = 13;
            accountNoLabel.Text = "Account No:";
            // 
            // compCustLabel
            // 
            compCustLabel.AutoSize = true;
            compCustLabel.Location = new System.Drawing.Point(6, 36);
            compCustLabel.Name = "compCustLabel";
            compCustLabel.Size = new System.Drawing.Size(126, 18);
            compCustLabel.TabIndex = 15;
            compCustLabel.Text = "Comany Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 97);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(80, 18);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // suburbLabel
            // 
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(6, 189);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(71, 18);
            suburbLabel.TabIndex = 19;
            suburbLabel.Text = "Suburb:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(6, 246);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(59, 18);
            stateLabel.TabIndex = 21;
            stateLabel.Text = "State:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(101, 247);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(98, 18);
            postCodeLabel.TabIndex = 23;
            postCodeLabel.Text = "Post Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 18);
            label2.TabIndex = 17;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 123);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 18);
            label3.TabIndex = 19;
            label3.Text = "Suburb:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 18);
            label4.TabIndex = 21;
            label4.Text = "State:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(102, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(98, 18);
            label5.TabIndex = 23;
            label5.Text = "Post Code:";
            // 
            // custEmailLabel
            // 
            custEmailLabel.AutoSize = true;
            custEmailLabel.Location = new System.Drawing.Point(352, 19);
            custEmailLabel.Name = "custEmailLabel";
            custEmailLabel.Size = new System.Drawing.Size(103, 18);
            custEmailLabel.TabIndex = 37;
            custEmailLabel.Text = "Cust Email:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(246, 18);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(52, 18);
            userLabel.TabIndex = 39;
            userLabel.Text = "User:";
            // 
            // origInvNumberLabel
            // 
            origInvNumberLabel.AutoSize = true;
            origInvNumberLabel.Location = new System.Drawing.Point(718, 16);
            origInvNumberLabel.Name = "origInvNumberLabel";
            origInvNumberLabel.Size = new System.Drawing.Size(150, 18);
            origInvNumberLabel.TabIndex = 3;
            origInvNumberLabel.Text = "Orig Inv Number:";
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(98, 17);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(143, 18);
            invoiceNumberLabel.TabIndex = 1;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // invCodeLabel
            // 
            invCodeLabel.AutoSize = true;
            invCodeLabel.Location = new System.Drawing.Point(4, 17);
            invCodeLabel.Name = "invCodeLabel";
            invCodeLabel.Size = new System.Drawing.Size(88, 18);
            invCodeLabel.TabIndex = 35;
            invCodeLabel.Text = "Inv Code:";
            // 
            // qmsDataSet
            // 
            this.qmsDataSet.DataSetName = "qmsDataSet";
            this.qmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "invoices";
            this.invoicesBindingSource.DataSource = this.qmsDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.invitemsTableAdapter = this.invitemsTableAdapter;
            this.tableAdapterManager.invoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.invoicetypeTableAdapter = null;
            this.tableAdapterManager.invtxtTableAdapter = null;
            this.tableAdapterManager.statesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QMS.qmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invitemsTableAdapter
            // 
            this.invitemsTableAdapter.ClearBeforeFill = true;
            // 
            // customerOrderNoTextBox
            // 
            this.customerOrderNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CustomerOrderNo", true));
            this.customerOrderNoTextBox.Location = new System.Drawing.Point(8, 49);
            this.customerOrderNoTextBox.Name = "customerOrderNoTextBox";
            this.customerOrderNoTextBox.Size = new System.Drawing.Size(200, 27);
            this.customerOrderNoTextBox.TabIndex = 8;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(8, 100);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 27);
            this.contactTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(8, 151);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 27);
            this.phoneTextBox.TabIndex = 12;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "AccountNo", true));
            this.accountNoTextBox.Location = new System.Drawing.Point(9, 210);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(200, 27);
            this.accountNoTextBox.TabIndex = 14;
            // 
            // compCustTextBox
            // 
            this.compCustTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CompCust", true));
            this.compCustTextBox.Location = new System.Drawing.Point(9, 57);
            this.compCustTextBox.Name = "compCustTextBox";
            this.compCustTextBox.Size = new System.Drawing.Size(326, 27);
            this.compCustTextBox.TabIndex = 16;
            this.compCustTextBox.Tag = "";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(9, 118);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(326, 64);
            this.addressTextBox.TabIndex = 18;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(9, 210);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(326, 27);
            this.suburbTextBox.TabIndex = 20;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(9, 267);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(88, 27);
            this.stateTextBox.TabIndex = 22;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(103, 267);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(96, 27);
            this.postCodeTextBox.TabIndex = 24;
            // 
            // sAddressTextBox
            // 
            this.sAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SAddress", true));
            this.sAddressTextBox.Location = new System.Drawing.Point(16, 51);
            this.sAddressTextBox.Multiline = true;
            this.sAddressTextBox.Name = "sAddressTextBox";
            this.sAddressTextBox.Size = new System.Drawing.Size(350, 64);
            this.sAddressTextBox.TabIndex = 26;
            // 
            // sSuburbTextBox
            // 
            this.sSuburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SSuburb", true));
            this.sSuburbTextBox.Location = new System.Drawing.Point(16, 145);
            this.sSuburbTextBox.Name = "sSuburbTextBox";
            this.sSuburbTextBox.Size = new System.Drawing.Size(200, 27);
            this.sSuburbTextBox.TabIndex = 28;
            // 
            // sStateTextBox
            // 
            this.sStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SState", true));
            this.sStateTextBox.Location = new System.Drawing.Point(16, 202);
            this.sStateTextBox.Name = "sStateTextBox";
            this.sStateTextBox.Size = new System.Drawing.Size(76, 27);
            this.sStateTextBox.TabIndex = 30;
            // 
            // sPostCodeTextBox
            // 
            this.sPostCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "SPostCode", true));
            this.sPostCodeTextBox.Location = new System.Drawing.Point(101, 202);
            this.sPostCodeTextBox.Name = "sPostCodeTextBox";
            this.sPostCodeTextBox.Size = new System.Drawing.Size(104, 27);
            this.sPostCodeTextBox.TabIndex = 32;
            // 
            // invNbrBindingSource
            // 
            this.invNbrBindingSource.DataMember = "InvNbr";
            this.invNbrBindingSource.DataSource = this.invoicesBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(compCustLabel);
            this.groupBox2.Controls.Add(this.compCustTextBox);
            this.groupBox2.Controls.Add(addressLabel);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(suburbLabel);
            this.groupBox2.Controls.Add(this.suburbTextBox);
            this.groupBox2.Controls.Add(stateLabel);
            this.groupBox2.Controls.Add(this.stateTextBox);
            this.groupBox2.Controls.Add(this.postCodeTextBox);
            this.groupBox2.Controls.Add(postCodeLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 313);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill To";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(label5);
            this.groupBox3.Controls.Add(this.sAddressTextBox);
            this.groupBox3.Controls.Add(this.sSuburbTextBox);
            this.groupBox3.Controls.Add(this.sStateTextBox);
            this.groupBox3.Controls.Add(this.sPostCodeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(404, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 249);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Job Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(invoiceDateLabel);
            this.groupBox4.Controls.Add(this.metroDateTime1);
            this.groupBox4.Controls.Add(this.customerOrderNoTextBox);
            this.groupBox4.Controls.Add(customerOrderNoLabel);
            this.groupBox4.Controls.Add(contactLabel);
            this.groupBox4.Controls.Add(accountNoLabel);
            this.groupBox4.Controls.Add(phoneLabel);
            this.groupBox4.Controls.Add(this.accountNoTextBox);
            this.groupBox4.Controls.Add(this.contactTextBox);
            this.groupBox4.Controls.Add(this.phoneTextBox);
            this.groupBox4.Location = new System.Drawing.Point(796, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 313);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.metroDateTime1.Location = new System.Drawing.Point(8, 268);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(257, 29);
            this.metroDateTime1.TabIndex = 52;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // ItemNumber
            // 
            this.ItemNumber.DataPropertyName = "ItemNumber";
            this.ItemNumber.HeaderText = "ItemNumber";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QTY";
            this.dataGridViewTextBoxColumn6.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(invCodeLabel);
            this.metroPanel1.Controls.Add(this.userTextBox);
            this.metroPanel1.Controls.Add(invoiceNumberLabel);
            this.metroPanel1.Controls.Add(origInvNumberLabel);
            this.metroPanel1.Controls.Add(this.invoiceNumberTextBox);
            this.metroPanel1.Controls.Add(this.invCodeTextBox);
            this.metroPanel1.Controls.Add(custEmailLabel);
            this.metroPanel1.Controls.Add(this.origInvNumberTextBox);
            this.metroPanel1.Controls.Add(this.custEmailTextBox);
            this.metroPanel1.Controls.Add(userLabel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(900, 79);
            this.metroPanel1.TabIndex = 50;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // userTextBox
            // 
            this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "User", true));
            this.userTextBox.Location = new System.Drawing.Point(247, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(99, 27);
            this.userTextBox.TabIndex = 40;
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNumber", true));
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(99, 38);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(142, 27);
            this.invoiceNumberTextBox.TabIndex = 2;
            // 
            // invCodeTextBox
            // 
            this.invCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvCode", true));
            this.invCodeTextBox.Location = new System.Drawing.Point(7, 38);
            this.invCodeTextBox.Name = "invCodeTextBox";
            this.invCodeTextBox.Size = new System.Drawing.Size(85, 27);
            this.invCodeTextBox.TabIndex = 36;
            this.invCodeTextBox.TextChanged += new System.EventHandler(this.invCodeTextBox_TextChanged);
            // 
            // origInvNumberTextBox
            // 
            this.origInvNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "OrigInvNumber", true));
            this.origInvNumberTextBox.Location = new System.Drawing.Point(719, 37);
            this.origInvNumberTextBox.Name = "origInvNumberTextBox";
            this.origInvNumberTextBox.Size = new System.Drawing.Size(147, 27);
            this.origInvNumberTextBox.TabIndex = 4;
            // 
            // custEmailTextBox
            // 
            this.custEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CustEmail", true));
            this.custEmailTextBox.Location = new System.Drawing.Point(353, 38);
            this.custEmailTextBox.Name = "custEmailTextBox";
            this.custEmailTextBox.Size = new System.Drawing.Size(361, 27);
            this.custEmailTextBox.TabIndex = 38;
            // 
            // niBtn
            // 
            this.niBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.niBtn.StyleManager = null;
            this.niBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(235, 6);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(126, 36);
            this.materialFlatButton3.TabIndex = 46;
            this.materialFlatButton3.Text = "Preview Invoice";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.MouseLeave += new System.EventHandler(this.materialFlatButton3_MouseLeave);
            this.materialFlatButton3.MouseHover += new System.EventHandler(this.materialFlatButton3_MouseHover);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(370, 5);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(107, 36);
            this.materialFlatButton4.TabIndex = 47;
            this.materialFlatButton4.Text = "Print Invoice";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.MouseLeave += new System.EventHandler(this.materialFlatButton4_MouseLeave);
            this.materialFlatButton4.MouseHover += new System.EventHandler(this.materialFlatButton4_MouseHover);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(116, 6);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton2.TabIndex = 45;
            this.materialFlatButton2.Text = "Find Invoice";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.MouseLeave += new System.EventHandler(this.materialFlatButton2_MouseLeave);
            this.materialFlatButton2.MouseHover += new System.EventHandler(this.materialFlatButton2_MouseHover);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.BackColor = System.Drawing.Color.White;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialFlatButton5.Location = new System.Drawing.Point(505, 5);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(108, 36);
            this.materialFlatButton5.TabIndex = 48;
            this.materialFlatButton5.Text = "Email Invoice";
            this.materialFlatButton5.UseVisualStyleBackColor = false;
            this.materialFlatButton5.MouseLeave += new System.EventHandler(this.materialFlatButton5_MouseLeave);
            this.materialFlatButton5.MouseHover += new System.EventHandler(this.materialFlatButton5_MouseHover);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton1.Location = new System.Drawing.Point(7, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(98, 36);
            this.materialFlatButton1.TabIndex = 44;
            this.materialFlatButton1.Text = "New Invoice";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.MouseLeave += new System.EventHandler(this.materialFlatButton1_MouseLeave);
            this.materialFlatButton1.MouseHover += new System.EventHandler(this.materialFlatButton1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(109)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.materialFlatButton5);
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.materialFlatButton4);
            this.panel1.Controls.Add(this.materialFlatButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 47);
            this.panel1.TabIndex = 51;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
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
            this.fileToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
            this.fileToolStripMenuItem.MouseLeave += new System.EventHandler(this.fileToolStripMenuItem_MouseLeave);
            this.fileToolStripMenuItem.MouseHover += new System.EventHandler(this.fileToolStripMenuItem_MouseHover);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
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
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 598);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusInfo,
            this.statusTime,
            this.statusDate});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1173, 22);
            this.statusBar1.TabIndex = 55;
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // invNbrBindingSource1
            // 
            this.invNbrBindingSource1.DataMember = "InvNbr";
            this.invNbrBindingSource1.DataSource = this.invoicesBindingSource;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1149, 100);
            this.dataGridView1.TabIndex = 56;
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
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 500;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1173, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 667);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "invoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy Invoices | QSync by Your IT Link";
            this.niBtn.SetToolTip(this, "Dummy Invoice Creation");
            this.Load += new System.EventHandler(this.invoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invNbrBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qmsDataSet qmsDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private qmsDataSetTableAdapters.invoicesTableAdapter invoicesTableAdapter;
        private qmsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customerOrderNoTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox compCustTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.TextBox sAddressTextBox;
        private System.Windows.Forms.TextBox sSuburbTextBox;
        private System.Windows.Forms.TextBox sStateTextBox;
        private System.Windows.Forms.TextBox sPostCodeTextBox;
        private qmsDataSetTableAdapters.invitemsTableAdapter invitemsTableAdapter;
        private System.Windows.Forms.BindingSource invNbrBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.TextBox invCodeTextBox;
        private System.Windows.Forms.TextBox origInvNumberTextBox;
        private System.Windows.Forms.TextBox custEmailTextBox;
        private MetroFramework.Components.MetroToolTip niBtn;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
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
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBarPanel statusTime;
        private System.Windows.Forms.StatusBarPanel statusDate;
        private System.Windows.Forms.StatusBarPanel statusInfo;
        private System.Windows.Forms.BindingSource invNbrBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceExGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
    }
}