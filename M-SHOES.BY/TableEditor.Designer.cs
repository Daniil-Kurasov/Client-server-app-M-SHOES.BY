
namespace M_SHOES.BY
{
    partial class TableEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipseTableEditor = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.foldingControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.itemsP = new Guna.UI2.WinForms.Guna2Panel();
            this.itemsFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.selectTableP = new Guna.UI2.WinForms.Guna2Panel();
            this.selectTableL = new System.Windows.Forms.Label();
            this.tablesP = new Guna.UI2.WinForms.Guna2Panel();
            this.conditionFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.tablesL = new System.Windows.Forms.Label();
            this.tablesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchAttributesL = new System.Windows.Forms.Label();
            this.searchAttributesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchConditionL = new System.Windows.Forms.Label();
            this.searchConditionCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchL = new System.Windows.Forms.Label();
            this.searchFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.searchTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchB = new Guna.UI2.WinForms.Guna2Button();
            this.deleteB = new Guna.UI2.WinForms.Guna2Button();
            this.backB = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.logoL = new System.Windows.Forms.Label();
            this.dragControlTablesP = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dragControlSelectTableP = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.itemsP.SuspendLayout();
            this.itemsFLP.SuspendLayout();
            this.selectTableP.SuspendLayout();
            this.tablesP.SuspendLayout();
            this.conditionFLP.SuspendLayout();
            this.searchFLP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseTableEditor
            // 
            this.elipseTableEditor.BorderRadius = 35;
            this.elipseTableEditor.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this;
            // 
            // foldingControlBox
            // 
            this.foldingControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foldingControlBox.Animated = true;
            this.foldingControlBox.BackColor = System.Drawing.Color.Transparent;
            this.foldingControlBox.BorderColor = System.Drawing.Color.White;
            this.foldingControlBox.BorderRadius = 15;
            this.foldingControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.foldingControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.foldingControlBox.FillColor = System.Drawing.Color.Black;
            this.foldingControlBox.HoverState.Parent = this.foldingControlBox;
            this.foldingControlBox.IconColor = System.Drawing.Color.White;
            this.foldingControlBox.Location = new System.Drawing.Point(1271, 12);
            this.foldingControlBox.Name = "foldingControlBox";
            this.foldingControlBox.ShadowDecoration.Parent = this.foldingControlBox;
            this.foldingControlBox.Size = new System.Drawing.Size(33, 32);
            this.foldingControlBox.TabIndex = 89;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.BorderColor = System.Drawing.Color.White;
            this.exitControlBox.BorderRadius = 15;
            this.exitControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.exitControlBox.FillColor = System.Drawing.Color.Black;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(1310, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 88;
            this.exitControlBox.Click += new System.EventHandler(this.ExitControlBox_Click);
            // 
            // itemsP
            // 
            this.itemsP.BackColor = System.Drawing.Color.Transparent;
            this.itemsP.BorderColor = System.Drawing.Color.Black;
            this.itemsP.BorderRadius = 20;
            this.itemsP.Controls.Add(this.itemsFLP);
            this.itemsP.FillColor = System.Drawing.Color.White;
            this.itemsP.Location = new System.Drawing.Point(690, 84);
            this.itemsP.Name = "itemsP";
            this.itemsP.ShadowDecoration.Parent = this.itemsP;
            this.itemsP.Size = new System.Drawing.Size(653, 857);
            this.itemsP.TabIndex = 94;
            // 
            // itemsFLP
            // 
            this.itemsFLP.AutoScroll = true;
            this.itemsFLP.Controls.Add(this.selectTableP);
            this.itemsFLP.Location = new System.Drawing.Point(12, 14);
            this.itemsFLP.Name = "itemsFLP";
            this.itemsFLP.Size = new System.Drawing.Size(638, 827);
            this.itemsFLP.TabIndex = 121;
            // 
            // selectTableP
            // 
            this.selectTableP.BackgroundImage = global::M_SHOES.BY.Properties.Resources.Table;
            this.selectTableP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.selectTableP.Controls.Add(this.selectTableL);
            this.selectTableP.Location = new System.Drawing.Point(3, 3);
            this.selectTableP.Name = "selectTableP";
            this.selectTableP.ShadowDecoration.Parent = this.selectTableP;
            this.selectTableP.Size = new System.Drawing.Size(624, 783);
            this.selectTableP.TabIndex = 0;
            // 
            // selectTableL
            // 
            this.selectTableL.AutoSize = true;
            this.selectTableL.BackColor = System.Drawing.Color.Transparent;
            this.selectTableL.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTableL.ForeColor = System.Drawing.Color.White;
            this.selectTableL.Location = new System.Drawing.Point(168, 206);
            this.selectTableL.Name = "selectTableL";
            this.selectTableL.Size = new System.Drawing.Size(292, 37);
            this.selectTableL.TabIndex = 123;
            this.selectTableL.Text = "Выберите таблицу";
            // 
            // tablesP
            // 
            this.tablesP.BackColor = System.Drawing.Color.Transparent;
            this.tablesP.BorderColor = System.Drawing.Color.Black;
            this.tablesP.BorderRadius = 20;
            this.tablesP.Controls.Add(this.conditionFLP);
            this.tablesP.Controls.Add(this.backB);
            this.tablesP.Controls.Add(this.panel1);
            this.tablesP.FillColor = System.Drawing.Color.White;
            this.tablesP.Location = new System.Drawing.Point(12, 84);
            this.tablesP.Name = "tablesP";
            this.tablesP.ShadowDecoration.Parent = this.tablesP;
            this.tablesP.Size = new System.Drawing.Size(653, 857);
            this.tablesP.TabIndex = 121;
            // 
            // conditionFLP
            // 
            this.conditionFLP.Controls.Add(this.tablesL);
            this.conditionFLP.Controls.Add(this.tablesCB);
            this.conditionFLP.Controls.Add(this.searchAttributesL);
            this.conditionFLP.Controls.Add(this.searchAttributesCB);
            this.conditionFLP.Controls.Add(this.searchConditionL);
            this.conditionFLP.Controls.Add(this.searchConditionCB);
            this.conditionFLP.Controls.Add(this.searchL);
            this.conditionFLP.Controls.Add(this.searchFLP);
            this.conditionFLP.Controls.Add(this.deleteB);
            this.conditionFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.conditionFLP.Location = new System.Drawing.Point(7, 450);
            this.conditionFLP.Name = "conditionFLP";
            this.conditionFLP.Size = new System.Drawing.Size(643, 391);
            this.conditionFLP.TabIndex = 133;
            // 
            // tablesL
            // 
            this.tablesL.AutoSize = true;
            this.tablesL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.tablesL.ForeColor = System.Drawing.Color.DimGray;
            this.tablesL.Location = new System.Drawing.Point(5, 0);
            this.tablesL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.tablesL.Name = "tablesL";
            this.tablesL.Size = new System.Drawing.Size(77, 23);
            this.tablesL.TabIndex = 120;
            this.tablesL.Text = "таблицы";
            // 
            // tablesCB
            // 
            this.tablesCB.Animated = true;
            this.tablesCB.BackColor = System.Drawing.Color.Transparent;
            this.tablesCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.tablesCB.BorderRadius = 10;
            this.tablesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tablesCB.DropDownHeight = 150;
            this.tablesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablesCB.FillColor = System.Drawing.Color.Gainsboro;
            this.tablesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tablesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tablesCB.FocusedState.Parent = this.tablesCB;
            this.tablesCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tablesCB.ForeColor = System.Drawing.Color.Black;
            this.tablesCB.HoverState.Parent = this.tablesCB;
            this.tablesCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tablesCB.IntegralHeight = false;
            this.tablesCB.ItemHeight = 34;
            this.tablesCB.Items.AddRange(new object[] {
            "Пользователи",
            "Заказы",
            "Отзывы",
            "Пункты самовывоза",
            "Обувь",
            "Картинки"});
            this.tablesCB.ItemsAppearance.Parent = this.tablesCB;
            this.tablesCB.Location = new System.Drawing.Point(4, 27);
            this.tablesCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.tablesCB.Name = "tablesCB";
            this.tablesCB.ShadowDecoration.Parent = this.tablesCB;
            this.tablesCB.Size = new System.Drawing.Size(369, 40);
            this.tablesCB.TabIndex = 111;
            this.tablesCB.SelectedIndexChanged += new System.EventHandler(this.TablesCB_SelectedIndexChanged);
            // 
            // searchAttributesL
            // 
            this.searchAttributesL.AutoSize = true;
            this.searchAttributesL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.searchAttributesL.ForeColor = System.Drawing.Color.DimGray;
            this.searchAttributesL.Location = new System.Drawing.Point(5, 82);
            this.searchAttributesL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.searchAttributesL.Name = "searchAttributesL";
            this.searchAttributesL.Size = new System.Drawing.Size(175, 23);
            this.searchAttributesL.TabIndex = 123;
            this.searchAttributesL.Text = "атрибуты для поиска";
            // 
            // searchAttributesCB
            // 
            this.searchAttributesCB.Animated = true;
            this.searchAttributesCB.BackColor = System.Drawing.Color.Transparent;
            this.searchAttributesCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.searchAttributesCB.BorderRadius = 10;
            this.searchAttributesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchAttributesCB.DropDownHeight = 150;
            this.searchAttributesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchAttributesCB.FillColor = System.Drawing.Color.Gainsboro;
            this.searchAttributesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAttributesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchAttributesCB.FocusedState.Parent = this.searchAttributesCB;
            this.searchAttributesCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchAttributesCB.ForeColor = System.Drawing.Color.Black;
            this.searchAttributesCB.HoverState.Parent = this.searchAttributesCB;
            this.searchAttributesCB.IntegralHeight = false;
            this.searchAttributesCB.ItemHeight = 34;
            this.searchAttributesCB.ItemsAppearance.Parent = this.searchAttributesCB;
            this.searchAttributesCB.Location = new System.Drawing.Point(4, 109);
            this.searchAttributesCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.searchAttributesCB.Name = "searchAttributesCB";
            this.searchAttributesCB.ShadowDecoration.Parent = this.searchAttributesCB;
            this.searchAttributesCB.Size = new System.Drawing.Size(369, 40);
            this.searchAttributesCB.TabIndex = 130;
            this.searchAttributesCB.SelectedIndexChanged += new System.EventHandler(this.SearchAttributesCB_SelectedIndexChanged);
            // 
            // searchConditionL
            // 
            this.searchConditionL.AutoSize = true;
            this.searchConditionL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.searchConditionL.ForeColor = System.Drawing.Color.DimGray;
            this.searchConditionL.Location = new System.Drawing.Point(5, 164);
            this.searchConditionL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.searchConditionL.Name = "searchConditionL";
            this.searchConditionL.Size = new System.Drawing.Size(133, 23);
            this.searchConditionL.TabIndex = 128;
            this.searchConditionL.Text = "условия поиска";
            // 
            // searchConditionCB
            // 
            this.searchConditionCB.Animated = true;
            this.searchConditionCB.BackColor = System.Drawing.Color.Transparent;
            this.searchConditionCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.searchConditionCB.BorderRadius = 10;
            this.searchConditionCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchConditionCB.DropDownHeight = 150;
            this.searchConditionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchConditionCB.FillColor = System.Drawing.Color.Gainsboro;
            this.searchConditionCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchConditionCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchConditionCB.FocusedState.Parent = this.searchConditionCB;
            this.searchConditionCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchConditionCB.ForeColor = System.Drawing.Color.Black;
            this.searchConditionCB.HoverState.Parent = this.searchConditionCB;
            this.searchConditionCB.IntegralHeight = false;
            this.searchConditionCB.ItemHeight = 34;
            this.searchConditionCB.Items.AddRange(new object[] {
            "содержит заданное значение",
            "равно"});
            this.searchConditionCB.ItemsAppearance.Parent = this.searchConditionCB;
            this.searchConditionCB.Location = new System.Drawing.Point(4, 191);
            this.searchConditionCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.searchConditionCB.Name = "searchConditionCB";
            this.searchConditionCB.ShadowDecoration.Parent = this.searchConditionCB;
            this.searchConditionCB.Size = new System.Drawing.Size(369, 40);
            this.searchConditionCB.TabIndex = 131;
            // 
            // searchL
            // 
            this.searchL.AutoSize = true;
            this.searchL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.searchL.ForeColor = System.Drawing.Color.DimGray;
            this.searchL.Location = new System.Drawing.Point(5, 246);
            this.searchL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.searchL.Name = "searchL";
            this.searchL.Size = new System.Drawing.Size(56, 23);
            this.searchL.TabIndex = 121;
            this.searchL.Text = "поиск";
            // 
            // searchFLP
            // 
            this.searchFLP.Controls.Add(this.searchTB);
            this.searchFLP.Controls.Add(this.searchB);
            this.searchFLP.Location = new System.Drawing.Point(3, 272);
            this.searchFLP.Name = "searchFLP";
            this.searchFLP.Size = new System.Drawing.Size(640, 40);
            this.searchFLP.TabIndex = 134;
            // 
            // searchTB
            // 
            this.searchTB.Animated = true;
            this.searchTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.searchTB.BorderRadius = 10;
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.CustomizableEdges.BottomRight = false;
            this.searchTB.CustomizableEdges.TopRight = false;
            this.searchTB.DefaultText = "";
            this.searchTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.DisabledState.Parent = this.searchTB;
            this.searchTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTB.FillColor = System.Drawing.Color.Gainsboro;
            this.searchTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.FocusedState.Parent = this.searchTB;
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchTB.ForeColor = System.Drawing.Color.Black;
            this.searchTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTB.HoverState.Parent = this.searchTB;
            this.searchTB.Location = new System.Drawing.Point(0, 0);
            this.searchTB.Margin = new System.Windows.Forms.Padding(0);
            this.searchTB.MaxLength = 500;
            this.searchTB.Name = "searchTB";
            this.searchTB.PasswordChar = '\0';
            this.searchTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchTB.PlaceholderText = "";
            this.searchTB.SelectedText = "";
            this.searchTB.ShadowDecoration.Parent = this.searchTB;
            this.searchTB.Size = new System.Drawing.Size(536, 40);
            this.searchTB.TabIndex = 122;
            this.searchTB.Tag = "";
            this.searchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // searchB
            // 
            this.searchB.Animated = true;
            this.searchB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchB.BorderRadius = 10;
            this.searchB.BorderThickness = 1;
            this.searchB.CheckedState.Parent = this.searchB;
            this.searchB.CustomImages.Parent = this.searchB;
            this.searchB.CustomizableEdges.BottomLeft = false;
            this.searchB.CustomizableEdges.TopLeft = false;
            this.searchB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchB.ForeColor = System.Drawing.Color.White;
            this.searchB.HoverState.Parent = this.searchB;
            this.searchB.Image = global::M_SHOES.BY.Properties.Resources.Search;
            this.searchB.ImageSize = new System.Drawing.Size(25, 25);
            this.searchB.Location = new System.Drawing.Point(536, 0);
            this.searchB.Margin = new System.Windows.Forms.Padding(0);
            this.searchB.Name = "searchB";
            this.searchB.ShadowDecoration.Parent = this.searchB;
            this.searchB.Size = new System.Drawing.Size(96, 40);
            this.searchB.TabIndex = 127;
            this.searchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Animated = true;
            this.deleteB.BorderRadius = 10;
            this.deleteB.CheckedState.Parent = this.deleteB;
            this.deleteB.CustomImages.Parent = this.deleteB;
            this.deleteB.FillColor = System.Drawing.Color.Gray;
            this.deleteB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteB.ForeColor = System.Drawing.Color.White;
            this.deleteB.HoverState.Parent = this.deleteB;
            this.deleteB.Location = new System.Drawing.Point(3, 342);
            this.deleteB.Margin = new System.Windows.Forms.Padding(3, 27, 3, 3);
            this.deleteB.Name = "deleteB";
            this.deleteB.ShadowDecoration.Parent = this.deleteB;
            this.deleteB.Size = new System.Drawing.Size(631, 45);
            this.deleteB.TabIndex = 125;
            this.deleteB.Text = "Удалить найденные значения";
            this.deleteB.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backB
            // 
            this.backB.Animated = true;
            this.backB.BackColor = System.Drawing.Color.Transparent;
            this.backB.BorderRadius = 10;
            this.backB.CheckedState.Parent = this.backB;
            this.backB.CustomImages.Parent = this.backB;
            this.backB.CustomizableEdges.BottomLeft = false;
            this.backB.CustomizableEdges.BottomRight = false;
            this.backB.Dock = System.Windows.Forms.DockStyle.Top;
            this.backB.FillColor = System.Drawing.Color.Transparent;
            this.backB.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.backB.ForeColor = System.Drawing.Color.DimGray;
            this.backB.HoverState.Parent = this.backB;
            this.backB.Image = ((System.Drawing.Image)(resources.GetObject("backB.Image")));
            this.backB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backB.ImageSize = new System.Drawing.Size(30, 30);
            this.backB.Location = new System.Drawing.Point(0, 0);
            this.backB.Margin = new System.Windows.Forms.Padding(0);
            this.backB.Name = "backB";
            this.backB.ShadowDecoration.Parent = this.backB;
            this.backB.Size = new System.Drawing.Size(653, 60);
            this.backB.TabIndex = 126;
            this.backB.Text = "назад";
            this.backB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 376);
            this.panel1.TabIndex = 132;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(-1, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(652, 370);
            this.dataGridView.TabIndex = 134;
            this.dataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridView.ThemeStyle.ReadOnly = true;
            this.dataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // logoL
            // 
            this.logoL.AutoSize = true;
            this.logoL.BackColor = System.Drawing.Color.Transparent;
            this.logoL.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoL.ForeColor = System.Drawing.Color.White;
            this.logoL.Location = new System.Drawing.Point(596, 17);
            this.logoL.Name = "logoL";
            this.logoL.Size = new System.Drawing.Size(172, 33);
            this.logoL.TabIndex = 122;
            this.logoL.Text = "M-SHOES.BY";
            // 
            // dragControlTablesP
            // 
            this.dragControlTablesP.ContainerControl = this;
            this.dragControlTablesP.TargetControl = this.tablesP;
            // 
            // dragControlSelectTableP
            // 
            this.dragControlSelectTableP.ContainerControl = this;
            this.dragControlSelectTableP.TargetControl = this.selectTableP;
            // 
            // TableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::M_SHOES.BY.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 953);
            this.Controls.Add(this.logoL);
            this.Controls.Add(this.tablesP);
            this.Controls.Add(this.itemsP);
            this.Controls.Add(this.foldingControlBox);
            this.Controls.Add(this.exitControlBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M-SHOES.BY";
            this.itemsP.ResumeLayout(false);
            this.itemsFLP.ResumeLayout(false);
            this.selectTableP.ResumeLayout(false);
            this.selectTableP.PerformLayout();
            this.tablesP.ResumeLayout(false);
            this.conditionFLP.ResumeLayout(false);
            this.conditionFLP.PerformLayout();
            this.searchFLP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseTableEditor;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ControlBox foldingControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private Guna.UI2.WinForms.Guna2Panel itemsP;
        private FlowLayoutPanelDoubleBuffered itemsFLP;
        private Guna.UI2.WinForms.Guna2Panel tablesP;
        private System.Windows.Forms.Label searchAttributesL;
        private Guna.UI2.WinForms.Guna2TextBox searchTB;
        private System.Windows.Forms.Label searchL;
        private System.Windows.Forms.Label tablesL;
        private Guna.UI2.WinForms.Guna2ComboBox tablesCB;
        private System.Windows.Forms.Label logoL;
        private Guna.UI2.WinForms.Guna2Button deleteB;
        private Guna.UI2.WinForms.Guna2Panel selectTableP;
        private System.Windows.Forms.Label selectTableL;
        private Guna.UI2.WinForms.Guna2DragControl dragControlTablesP;
        private Guna.UI2.WinForms.Guna2DragControl dragControlSelectTableP;
        private Guna.UI2.WinForms.Guna2Button backB;
        private Guna.UI2.WinForms.Guna2Button searchB;
        private Guna.UI2.WinForms.Guna2ComboBox searchAttributesCB;
        private System.Windows.Forms.Label searchConditionL;
        private Guna.UI2.WinForms.Guna2ComboBox searchConditionCB;
        private FlowLayoutPanelDoubleBuffered conditionFLP;
        private FlowLayoutPanelDoubleBuffered searchFLP;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
    }
}