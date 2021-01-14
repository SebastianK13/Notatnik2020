namespace Notatnik2020
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzctrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoctrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujctrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podglądWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykonajPonownieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekStanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTextAreaTB = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzctrlOToolStripMenuItem,
            this.zapiszJakoctrlSToolStripMenuItem,
            this.toolStripSeparator1,
            this.ustawieniaStronyToolStripMenuItem,
            this.drukujctrlPToolStripMenuItem,
            this.podglądWydrukuToolStripMenuItem,
            this.toolStripSeparator2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.ShortcutKeyDisplayString = "ctrl+O";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzctrlOToolStripMenuItem
            // 
            this.otwórzctrlOToolStripMenuItem.Name = "otwórzctrlOToolStripMenuItem";
            this.otwórzctrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzctrlOToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.otwórzctrlOToolStripMenuItem.Text = "Otwórz";
            this.otwórzctrlOToolStripMenuItem.Click += new System.EventHandler(this.otwórzctrlOToolStripMenuItem_Click);
            // 
            // zapiszJakoctrlSToolStripMenuItem
            // 
            this.zapiszJakoctrlSToolStripMenuItem.Name = "zapiszJakoctrlSToolStripMenuItem";
            this.zapiszJakoctrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszJakoctrlSToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.zapiszJakoctrlSToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoctrlSToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoctrlSToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // ustawieniaStronyToolStripMenuItem
            // 
            this.ustawieniaStronyToolStripMenuItem.Name = "ustawieniaStronyToolStripMenuItem";
            this.ustawieniaStronyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ustawieniaStronyToolStripMenuItem.Text = "Ustawienia strony";
            this.ustawieniaStronyToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaStronyToolStripMenuItem_Click);
            // 
            // drukujctrlPToolStripMenuItem
            // 
            this.drukujctrlPToolStripMenuItem.Name = "drukujctrlPToolStripMenuItem";
            this.drukujctrlPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.drukujctrlPToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.drukujctrlPToolStripMenuItem.Text = "Drukuj";
            this.drukujctrlPToolStripMenuItem.Click += new System.EventHandler(this.drukujctrlPToolStripMenuItem_Click);
            // 
            // podglądWydrukuToolStripMenuItem
            // 
            this.podglądWydrukuToolStripMenuItem.Name = "podglądWydrukuToolStripMenuItem";
            this.podglądWydrukuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.podglądWydrukuToolStripMenuItem.Text = "Podgląd wydruku";
            this.podglądWydrukuToolStripMenuItem.Click += new System.EventHandler(this.podglądWydrukuToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.wykonajPonownieToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // wykonajPonownieToolStripMenuItem
            // 
            this.wykonajPonownieToolStripMenuItem.Name = "wykonajPonownieToolStripMenuItem";
            this.wykonajPonownieToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.wykonajPonownieToolStripMenuItem.Text = "Wykonaj ponownie";
            this.wykonajPonownieToolStripMenuItem.Click += new System.EventHandler(this.wykonajPonownieToolStripMenuItem_Click);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaToolStripMenuItem,
            this.tłoToolStripMenuItem,
            this.pasekStanuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // tłoToolStripMenuItem
            // 
            this.tłoToolStripMenuItem.Name = "tłoToolStripMenuItem";
            this.tłoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tłoToolStripMenuItem.Text = "Tło";
            this.tłoToolStripMenuItem.Click += new System.EventHandler(this.tłoToolStripMenuItem_Click);
            // 
            // pasekStanuToolStripMenuItem
            // 
            this.pasekStanuToolStripMenuItem.Checked = true;
            this.pasekStanuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pasekStanuToolStripMenuItem.Name = "pasekStanuToolStripMenuItem";
            this.pasekStanuToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasekStanuToolStripMenuItem.Text = "Pasek stanu";
            this.pasekStanuToolStripMenuItem.Click += new System.EventHandler(this.pasekStanuToolStripMenuItem_Click);
            // 
            // mainTextAreaTB
            // 
            this.mainTextAreaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextAreaTB.Location = new System.Drawing.Point(0, 27);
            this.mainTextAreaTB.MinimumSize = new System.Drawing.Size(100, 60);
            this.mainTextAreaTB.Multiline = true;
            this.mainTextAreaTB.Name = "mainTextAreaTB";
            this.mainTextAreaTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextAreaTB.Size = new System.Drawing.Size(784, 398);
            this.mainTextAreaTB.TabIndex = 1;
            this.mainTextAreaTB.TextChanged += new System.EventHandler(this.mainTextAreaTB_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(125, 17);
            this.statusBar.Text = "Brak wczytanego pliku";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Jednoosobowy zespół projektowy";
            this.notifyIcon1.BalloonTipTitle = "Notatnik 2020";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Notatnik 2020, Jednoosobowy zespół projektowy, Sebastian Knych.";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAutorzeToolStripMenuItem,
            this.zamknijToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem1
            // 
            this.zamknijToolStripMenuItem1.Name = "zamknijToolStripMenuItem1";
            this.zamknijToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.zamknijToolStripMenuItem1.Text = "Zamknij";
            this.zamknijToolStripMenuItem1.Click += new System.EventHandler(this.zamknijToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 448);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainTextAreaTB);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notatnik 2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzctrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoctrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasekStanuToolStripMenuItem;
        private System.Windows.Forms.TextBox mainTextAreaTB;
        private System.Windows.Forms.ToolStripMenuItem wykonajPonownieToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaStronyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujctrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podglądWydrukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

