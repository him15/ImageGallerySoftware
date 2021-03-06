﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using C1.Win.C1Tile;

namespace ImageGalleryProject
{
    public partial class ImageGallery : Form
    {
        public ImageGallery()
        {
            InitializeComponent();

            // load event handler
            Load += new EventHandler(ImageGallery_LoadAsync);
        }

      


        // Object of data Fetcher clss 
        DataFetcher datafetch = new DataFetcher();

        // instance of list of Image item class
        List<ImageItem> imagesList;
        int checkedItems = 0;

        // selected image List 




        
        // searchimage  btn click Event 
        private async void _search_ClickAsync(object sender, EventArgs e) // OnSearchClick
        {
            statusStrip1.Visible = true;  // to visible the status strip.
            imagesList = await datafetch.GetImageData(_searchBox.Text); // method to fetch the image 

            AddTiles(imagesList); // image Added to the tiles
            statusStrip1.Visible = false;
        }






        private void searchImage_TextChanged(object sender, EventArgs e)
        {

        }





        // --------------Export to pdf click Event handler
        private void _exportImage_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();

            //Iteration through all the Tiles using for each
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                // if the tile is checked then add that image to the list
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }

            ConvertToPdf(images);  // method to convert to pdf

            // To Save the Image it opens the save file Dialoge
          SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf"; // extenstion
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*"; 

            // if we press OK then it save the pdf(SAVE SELECTED IMAGE TO DISK)
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
               
                imagePdfDocument.Save(saveFile.FileName);

            }
        }





        //-----------------------Convert to PDF--------------------

        private void ConvertToPdf(List<Image> images)
        {
            RectangleF rect = imagePdfDocument.PageRectangle;
            bool firstPage = true;
            foreach (var selectedimg in images)
            {
                // not to create the page for 1st image
                if (!firstPage)
                {
                    imagePdfDocument.NewPage();
                }
                firstPage = false;
                // change the rectangle Structure in specific amount
                rect.Inflate(-72, -72);
                imagePdfDocument.DrawImage(selectedimg, rect);
            }
        }






        private void _imageTileControl_TileChecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            // increment the checked counter
            checkedItems++;
            _exportImage.Visible = true;
        }



        private void _imageTileControl_TileUnchecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            // decrement the counter if tile is unchecked.
            checkedItems--;
            _exportImage.Visible = checkedItems > 0;
        }




        private void _imageTileControl_Paint(object sender, PaintEventArgs e)
        {
            // Draw the line 
            Pen p = new Pen(Color.Gray);
            e.Graphics.DrawLine(p, 0, 54, 800, 54);
         }









        // add images to the Tiles

        private void AddTiles(List<ImageItem> imageList)
        {
            _imageTileControl.Groups[0].Tiles.Clear();  // clearing all the images
            

    // Now loop all the images  which are present in the list snd insert in tiles
            foreach (var imageitem in imageList)
            {

                //  ------------Aspect Ratio-------------------------

                // logic - find the actual width of the image and then change the size of 
                //          the tiles according to it.


                // Find the Actual Dimension of the image
                var ab = imageitem.Base64;
                byte[] imageData = ab;
                MemoryStream imageStream = new MemoryStream(imageData);
                Bitmap image = new Bitmap(imageStream);
                int width = image.Width;
                int height = image.Height;
                //--------
                

                Tile tile = new Tile();

                // set the size
                if (width > height)
                {
                    if (width<1600) {
                        tile.HorizontalSize = 2;
                        tile.VerticalSize = 1;
                    }
                    else {
                        tile.HorizontalSize = 3;
                        tile.VerticalSize = 2;
                    }
                }
                else if (height > width)
                {
                    if (height<1600) {
                        tile.HorizontalSize = 1;
                        tile.VerticalSize = 2;
                    }
                    else {
                        tile.HorizontalSize = 2;
                        tile.VerticalSize = 3;
                    }
                }
                else {
                    tile.HorizontalSize = 2;
                    tile.VerticalSize = 2;
                }


             //---------------------------------------------------- 
                
                
                _imageTileControl.Groups[0].Tiles.Add(tile);

                // convert and retrive image from base64 using Memory Stream
                Image img = Image.FromStream(new MemoryStream(imageitem.Base64));
                Template tl = new Template();

                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
            }
        }

        




    // Draw Rectangle border around Export Image button
        private void _exportImage_Paint(object sender, PaintEventArgs e)
        {
            // create rectangle in on Export btn
           Rectangle r = new Rectangle(_exportImage.Location.X,_exportImage.Location.Y, _exportImage.Width, _exportImage.Height);
           r.X += 1;
            r.Y += 1;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0,28), new Point(this.Width, 28));
           

        }



        // load Event handler (Show images in tile while loading the application)
        private async void ImageGallery_LoadAsync(object sender, System.EventArgs e)
        {
            statusStrip1.Visible = true;
            imagesList = await
           datafetch.GetImageData(_searchBox.Text);
            AddTiles(imagesList);
            statusStrip1.Visible = false;
        }

        private Bitmap MyImage;
        private object encoding;
        //------------------------ASPECT RATIO OF THE image-------------------
        //  public void aspectRatioOfMyImage(String fileToDisplay, int xSize, int ySize)
        //  {
        // Sets up an image object to be displayed.
        //  if (MyImage != null)
        // {
        //     MyImage.Dispose();
        // }

        // Stretches the image to fit the pictureBox.
        //Tile tile = new Tile();
        // tile1.SizeMode = PictureBoxSizeMode.StretchImage;
        // MyImage = new Bitmap(fileToDisplay);
        // pictureBox1.ClientSize = new Size(xSize, ySize);
        //pictureBox1.Image = (Image)MyImage;
        // }

    }
}
