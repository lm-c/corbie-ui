﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LmCorbieUI.Controls
{
    public class LmDropdownMenu : ContextMenuStrip
    {
        //Fields
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.Empty;//No color, The default color is set in the MenuRenderer class
        private Color primaryColor = Color.Empty;//No color, The default color is set in the MenuRenderer class
        private bool naoInverterCorImagem = false;
        private Bitmap menuItemHeaderSize;
        //Constructor
        public LmDropdownMenu(IContainer container)
            : base(container)
        {
        }

        //Properties
        //Optionally, hide the properties in the toolbox to avoid the problem of displaying and/or 
        //saving control property changes in the designer at design time in Visual Studio.
        //If the problem I mention does not occur you can expose the properties and manipulate them from the toolbox.
        [Browsable(false)]
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu = value; }
        }
        [Browsable(false)]
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }
        [Browsable(false)]
        public Color MenuItemTextColor
        {
            get { return menuItemTextColor; }
            set { menuItemTextColor = value; }
        }
        [Browsable(false)]
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set { primaryColor = value; }
        }

        [Browsable(true)]
        public bool NaoInverterCorImagem
        {
            get { return naoInverterCorImagem; }
            set { naoInverterCorImagem = value; }
        }

        private int z_teste;

        public int Z_Teste
        {
            get { return z_teste; }
            set { z_teste = value; }
        }


        //Private methods
        private void LoadMenuItemHeight(ToolStripItemCollection itens)
        {
            foreach (var item in itens.OfType<ToolStripMenuItem>())
            {
                item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                if (item.Image == null) item.Image = menuItemHeaderSize;

                //Verifica filhos
                if (item.DropDownItems != null && item.DropDownItems.Count > 0)
                    LoadMenuItemHeight(item.DropDownItems);
            }

            /*
            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;
                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;
                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                        {
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItemL4.Image == null) menuItemL4.Image = menuItemHeaderSize;
                            ///Level 5++
                        }
                    }
                }
            }
            */
        }
        //Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer(NaoInverterCorImagem);

                if (isMainMenu)
                    menuItemHeaderSize = new Bitmap(25, 45);
                else menuItemHeaderSize = new Bitmap(20, menuItemHeight);

                LoadMenuItemHeight(this.Items);
            }
        }
    }
}