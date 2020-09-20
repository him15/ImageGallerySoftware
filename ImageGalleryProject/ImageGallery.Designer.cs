using C1.C1Pdf;
using C1.Win.C1Tile;
using System;
using System.Windows.Forms;

namespace ImageGalleryProject
{
    partial class ImageGallery
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
        /// 
        //-------------------ALL THE REFERENCE VARIABLES-----------------------
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MaskedTextBox _searchBox;
        private Panel panel2;
        private PictureBox _search;
        private C1TileControl _imageTileControl;
        private Group group1;
        private Tile tile1;
        private Tile tile2;
        private Tile tile3;
        private Panel panel3;
        private PictureBox _exportImage;
        private Panel panel4;
        private PictureBox pictureBox2;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private C1PdfDocument imagePdfDocument;
        private Button button;
        //-------------------------------------------------------------------------//






        private void InitializeComponent()
        {

            


            //----------------ALL THE OBJECTS OF THE ELEMENT------------------------
            PanelElement panelElement1 = new PanelElement();
            ImageElement imageElement1 = new ImageElement();
            TextElement textElement1 = new TextElement();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            
            this.panel1 = new Panel();
            this.panel4 = new Panel();
            this.pictureBox2 = new PictureBox();
            this.statusStrip1 = new StatusStrip();
            this.toolStripProgressBar1 = new ToolStripProgressBar();
            this.panel2 = new Panel();
            this._search = new PictureBox();
            this._searchBox = new MaskedTextBox();
            this.panel3 = new Panel();
            this._exportImage = new PictureBox();
            this._imageTileControl = new C1TileControl();
            this.group1 = new Group();
            this.tile1 = new Tile();
            this.tile2 = new Tile();
            this.tile3 = new Tile();
            this.imagePdfDocument = new C1PdfDocument();
            this.button = new Button();
            //------------------------------------------------------------//






            //------------------- splitContainer1-------------------------------------

            this.splitContainer1 = new SplitContainer();
                           //properties
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            
                            // splitContainer1.Panel1 add control
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
           
            // splitContainer1 Panel2
          
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this._searchBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Size = new System.Drawing.Size(764, 749);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 0;





            // ----------------------------tableLayoutPanel1------------
            
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 40);
            this.tableLayoutPanel1.TabIndex = 0;



            //---------- panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 34);
            this.panel1.TabIndex = 0;



            //------------------- panel4-------------

            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 34);
            this.panel4.TabIndex = 0;
           


       // --------------------PICTURE BOX 2-----------------------------------------
            this.pictureBox2.Dock =DockStyle.Fill;
            this.pictureBox2.Image = global::ImageGalleryProject.Properties.Resources.iconimages;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 34);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
    
            

   //------------------------------ statusStrip1----------------------------
 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;





            // ----------------------toolStripProgress bar----------------

            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
          
            


            // ------------------panel2--------------------
      
            this.panel2.Controls.Add(this._search);
            this.panel2.Location = new System.Drawing.Point(679, 19);
            this.panel2.Margin = new Padding(2, 12, 45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 20);
            this.panel2.TabIndex = 1;
           
            


            //----------------------------SEARCH BTN------------------------------
            this._search.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._search.Image = global::ImageGalleryProject.Properties.Resources.searchimg;
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(31, 20);
            this._search.SizeMode =PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            //event
            this._search.Click += new System.EventHandler(this._search_ClickAsync);
            
            
            
            
             
            // -----------------------------searchBox--------------------------
            
            this._searchBox.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left)  | AnchorStyles.Right)));
            this._searchBox.Location = new System.Drawing.Point(421, 19);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(244, 20);
            this._searchBox.TabIndex = 1;
            this._searchBox.Text = "Search Image";
            


            //----------------------------------- panel3-----------------------
            this.panel3.Controls.Add(this._exportImage);
            this.panel3.Location = new System.Drawing.Point(35, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 29);
            this.panel3.TabIndex = 2;





            //----------------------------exportImage-----------------
            this._exportImage.Dock = DockStyle.Fill;
            this._exportImage.Image = global::ImageGalleryProject.Properties.Resources.exprt;
            this._exportImage.Location = new System.Drawing.Point(0, 0);
            this._exportImage.Margin = new Padding(0);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new System.Drawing.Size(147, 29);
            this._exportImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 3;
            this._exportImage.TabStop = false;
            // events
            this._exportImage.Click += new System.EventHandler(this._exportImage_Click);
            this._exportImage.Paint += new PaintEventHandler(this._exportImage_Paint);
           





   // ------------------------------imageTileControl---------------------
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowDrop = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.Anchor = ((AnchorStyles)((((AnchorStyles.Top |AnchorStyles.Bottom) 
            |AnchorStyles.Left) |AnchorStyles.Right)));
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            


            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(0, -4);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Size = new System.Drawing.Size(764, 709);
            this._imageTileControl.SurfacePadding = new Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 1;
            //events
            this._imageTileControl.TileChecked += new System.EventHandler<TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new PaintEventHandler(this._imageTileControl_Paint);
            


            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
             




            // ----------------imagePdfDocument--------------------
            this.imagePdfDocument.DocumentInfo.Author = "";
            this.imagePdfDocument.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.imagePdfDocument.DocumentInfo.Creator = "";
            this.imagePdfDocument.DocumentInfo.Keywords = "";
            this.imagePdfDocument.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.imagePdfDocument.DocumentInfo.Subject = "";
            this.imagePdfDocument.DocumentInfo.Title = "";
            this.imagePdfDocument.MaxHeaderBookmarkLevel = 0;
            this.imagePdfDocument.PdfVersion = "1.3";
            this.imagePdfDocument.RefDC = null;
            this.imagePdfDocument.RotateAngle = 0F;
            this.imagePdfDocument.UseFastTextOut = true;
            this.imagePdfDocument.UseFontShaping = true;






            //----------- button----------
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Search";




            //------------------ ImageGallery-------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode =AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 749);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.MinimizeBox = false;
            this.Name = "ImageGallery";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "ImageGallery";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.ResumeLayout(false);

       
    //---------------------ADD COMPONENT TO FORM--------------------

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.SuspendLayout();

        }




        
        #endregion


    }
}

