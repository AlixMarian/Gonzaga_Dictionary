namespace Gonzaga_Dictionary
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
            this.frame = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_results = new System.Windows.Forms.Label();
            this.btn_definition = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_synonyms = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_usage = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtField_results = new System.Windows.Forms.TextBox();
            this.txtField_searchWord = new System.Windows.Forms.TextBox();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_clearResults = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clearFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.panel_control.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.ElipseRadius = 30;
            this.frame.TargetControl = this;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.RosyBrown;
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Location = new System.Drawing.Point(-7, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(829, 57);
            this.pnl_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gonzaga - Dictionary";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(738, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 27);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbl_results
            // 
            this.lbl_results.AutoSize = true;
            this.lbl_results.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_results.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_results.Location = new System.Drawing.Point(235, 250);
            this.lbl_results.Name = "lbl_results";
            this.lbl_results.Size = new System.Drawing.Size(138, 38);
            this.lbl_results.TabIndex = 3;
            this.lbl_results.Text = "Results";
            this.lbl_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_definition
            // 
            this.btn_definition.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_definition.color = System.Drawing.Color.PaleVioletRed;
            this.btn_definition.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(106)))));
            this.btn_definition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_definition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_definition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_definition.Image = ((System.Drawing.Image)(resources.GetObject("btn_definition.Image")));
            this.btn_definition.ImagePosition = 13;
            this.btn_definition.ImageZoom = 50;
            this.btn_definition.LabelPosition = 26;
            this.btn_definition.LabelText = "Definition";
            this.btn_definition.Location = new System.Drawing.Point(53, 66);
            this.btn_definition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_definition.Name = "btn_definition";
            this.btn_definition.Size = new System.Drawing.Size(106, 97);
            this.btn_definition.TabIndex = 4;
            this.btn_definition.Click += new System.EventHandler(this.btn_definition_Click);
            // 
            // btn_synonyms
            // 
            this.btn_synonyms.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_synonyms.color = System.Drawing.Color.PaleVioletRed;
            this.btn_synonyms.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(106)))));
            this.btn_synonyms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_synonyms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btn_synonyms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_synonyms.Image = ((System.Drawing.Image)(resources.GetObject("btn_synonyms.Image")));
            this.btn_synonyms.ImagePosition = 13;
            this.btn_synonyms.ImageZoom = 50;
            this.btn_synonyms.LabelPosition = 27;
            this.btn_synonyms.LabelText = "Synonyms";
            this.btn_synonyms.Location = new System.Drawing.Point(53, 186);
            this.btn_synonyms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_synonyms.Name = "btn_synonyms";
            this.btn_synonyms.Size = new System.Drawing.Size(106, 97);
            this.btn_synonyms.TabIndex = 5;
            this.btn_synonyms.Click += new System.EventHandler(this.btn_synonyms_Click);
            // 
            // btn_usage
            // 
            this.btn_usage.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_usage.color = System.Drawing.Color.PaleVioletRed;
            this.btn_usage.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(106)))));
            this.btn_usage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btn_usage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_usage.Image = ((System.Drawing.Image)(resources.GetObject("btn_usage.Image")));
            this.btn_usage.ImagePosition = 13;
            this.btn_usage.ImageZoom = 50;
            this.btn_usage.LabelPosition = 27;
            this.btn_usage.LabelText = "Usage Examples";
            this.btn_usage.Location = new System.Drawing.Point(53, 311);
            this.btn_usage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_usage.Name = "btn_usage";
            this.btn_usage.Size = new System.Drawing.Size(106, 97);
            this.btn_usage.TabIndex = 6;
            this.btn_usage.Click += new System.EventHandler(this.btn_usage_Click);
            // 
            // btn_search
            // 
            this.btn_search.Activecolor = System.Drawing.Color.MediumVioletRed;
            this.btn_search.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderRadius = 0;
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search.Iconimage = null;
            this.btn_search.Iconimage_right = null;
            this.btn_search.Iconimage_right_Selected = null;
            this.btn_search.Iconimage_Selected = null;
            this.btn_search.IconMarginLeft = 0;
            this.btn_search.IconMarginRight = 0;
            this.btn_search.IconRightVisible = true;
            this.btn_search.IconRightZoom = 0D;
            this.btn_search.IconVisible = true;
            this.btn_search.IconZoom = 90D;
            this.btn_search.IsTab = false;
            this.btn_search.Location = new System.Drawing.Point(523, 79);
            this.btn_search.Margin = new System.Windows.Forms.Padding(8);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.MediumVioletRed;
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(15)))), ((int)(((byte)(110)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(141, 52);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtField_results
            // 
            this.txtField_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtField_results.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_results.Location = new System.Drawing.Point(0, 0);
            this.txtField_results.Multiline = true;
            this.txtField_results.Name = "txtField_results";
            this.txtField_results.ReadOnly = true;
            this.txtField_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtField_results.Size = new System.Drawing.Size(528, 407);
            this.txtField_results.TabIndex = 9;
            // 
            // txtField_searchWord
            // 
            this.txtField_searchWord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtField_searchWord.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtField_searchWord.Location = new System.Drawing.Point(187, 136);
            this.txtField_searchWord.Multiline = true;
            this.txtField_searchWord.Name = "txtField_searchWord";
            this.txtField_searchWord.Size = new System.Drawing.Size(310, 52);
            this.txtField_searchWord.TabIndex = 10;
            // 
            // panel_control
            // 
            this.panel_control.AutoScroll = true;
            this.panel_control.AutoSize = true;
            this.panel_control.Controls.Add(this.txtField_results);
            this.panel_control.Location = new System.Drawing.Point(242, 295);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(528, 407);
            this.panel_control.TabIndex = 11;
            // 
            // btn_clearResults
            // 
            this.btn_clearResults.Activecolor = System.Drawing.Color.PaleVioletRed;
            this.btn_clearResults.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_clearResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearResults.BorderRadius = 0;
            this.btn_clearResults.ButtonText = "Clear Results";
            this.btn_clearResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearResults.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clearResults.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clearResults.Iconimage = null;
            this.btn_clearResults.Iconimage_right = null;
            this.btn_clearResults.Iconimage_right_Selected = null;
            this.btn_clearResults.Iconimage_Selected = null;
            this.btn_clearResults.IconMarginLeft = 0;
            this.btn_clearResults.IconMarginRight = 0;
            this.btn_clearResults.IconRightVisible = true;
            this.btn_clearResults.IconRightZoom = 0D;
            this.btn_clearResults.IconVisible = true;
            this.btn_clearResults.IconZoom = 90D;
            this.btn_clearResults.IsTab = false;
            this.btn_clearResults.Location = new System.Drawing.Point(618, 250);
            this.btn_clearResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clearResults.Name = "btn_clearResults";
            this.btn_clearResults.Normalcolor = System.Drawing.Color.MediumVioletRed;
            this.btn_clearResults.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(15)))), ((int)(((byte)(110)))));
            this.btn_clearResults.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_clearResults.selected = false;
            this.btn_clearResults.Size = new System.Drawing.Size(152, 38);
            this.btn_clearResults.TabIndex = 12;
            this.btn_clearResults.Text = "Clear Results";
            this.btn_clearResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clearResults.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearResults.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btn_clearResults.Click += new System.EventHandler(this.btn_clearResults_Click);
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbl_slogan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slogan.ForeColor = System.Drawing.Color.White;
            this.lbl_slogan.Location = new System.Drawing.Point(213, 72);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(404, 38);
            this.lbl_slogan.TabIndex = 13;
            this.lbl_slogan.Text = "Discover, Define, Learn.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(-3, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 173);
            this.panel1.TabIndex = 14;
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.Activecolor = System.Drawing.Color.MediumVioletRed;
            this.btn_clearFilter.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_clearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearFilter.BorderRadius = 0;
            this.btn_clearFilter.ButtonText = "Clear Filter";
            this.btn_clearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btn_clearFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clearFilter.Iconimage = null;
            this.btn_clearFilter.Iconimage_right = null;
            this.btn_clearFilter.Iconimage_right_Selected = null;
            this.btn_clearFilter.Iconimage_Selected = null;
            this.btn_clearFilter.IconMarginLeft = 0;
            this.btn_clearFilter.IconMarginRight = 0;
            this.btn_clearFilter.IconRightVisible = true;
            this.btn_clearFilter.IconRightZoom = 0D;
            this.btn_clearFilter.IconVisible = true;
            this.btn_clearFilter.IconZoom = 90D;
            this.btn_clearFilter.IsTab = false;
            this.btn_clearFilter.Location = new System.Drawing.Point(36, 435);
            this.btn_clearFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Normalcolor = System.Drawing.Color.MediumVioletRed;
            this.btn_clearFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(15)))), ((int)(((byte)(110)))));
            this.btn_clearFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clearFilter.selected = false;
            this.btn_clearFilter.Size = new System.Drawing.Size(141, 38);
            this.btn_clearFilter.TabIndex = 15;
            this.btn_clearFilter.Text = "Clear Filter";
            this.btn_clearFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_clearFilter.Textcolor = System.Drawing.Color.White;
            this.btn_clearFilter.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Controls.Add(this.btn_clearFilter);
            this.panel2.Controls.Add(this.lbl_filter);
            this.panel2.Controls.Add(this.btn_definition);
            this.panel2.Controls.Add(this.btn_synonyms);
            this.panel2.Controls.Add(this.btn_usage);
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 513);
            this.panel2.TabIndex = 16;
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.lbl_filter.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_filter.Location = new System.Drawing.Point(58, 21);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(101, 38);
            this.lbl_filter.TabIndex = 0;
            this.lbl_filter.Text = "Filter";
            this.lbl_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(817, 740);
            this.Controls.Add(this.lbl_slogan);
            this.Controls.Add(this.btn_clearResults);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.txtField_searchWord);
            this.Controls.Add(this.lbl_results);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse frame;
        private System.Windows.Forms.Panel pnl_header;
      
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lbl_results;
        private Bunifu.Framework.UI.BunifuTileButton btn_synonyms;
        private Bunifu.Framework.UI.BunifuTileButton btn_definition;
        private Bunifu.Framework.UI.BunifuTileButton btn_usage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private System.Windows.Forms.TextBox txtField_results;
        private System.Windows.Forms.TextBox txtField_searchWord;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clearResults;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clearFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_filter;
    }
}

