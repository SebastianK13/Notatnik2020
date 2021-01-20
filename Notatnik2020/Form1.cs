using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersOperations.IOMethods;

namespace Notatnik2020
{
    public partial class Form1 : Form
    {
        private UsersMethods usersMethods;
        private string fileText = string.Empty;
        private List<string> changesList = new List<string> { "" };
        private int currentChangesListElement = 0;
        private bool undoActionActive = false;
        private bool redoActionActive = false;
        private SoundPlayer soundPlayer;
        private StringReader stringReader;

        public Form1()
        {
            InitializeComponent();
            usersMethods = new UsersMethods();
            string mainPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string outputPath = Path.Combine(mainPath, "Sounds", "Windows_95_Startup-Microsoft-2077254053.wav");
            soundPlayer = new SoundPlayer(outputPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void otwórzctrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersMethods.WczytajPlikTekstowy();
            mainTextAreaTB.Text = usersMethods.fileText;
            statusBar.Text = "Wczytano " + usersMethods.fileName;
        }

        private void zapiszJakoctrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersMethods.ZapiszPlikTekstowy(mainTextAreaTB.Text);
            statusBar.Text = "Zapisano do " + usersMethods.savedFileName;
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoActionActive = true;
            if (changesList.Count() - 1 >= currentChangesListElement && currentChangesListElement > 0)
            {
                currentChangesListElement--;
                mainTextAreaTB.Text = changesList[currentChangesListElement];
                mainTextAreaTB.Select(mainTextAreaTB.Text.Length, 0);
            }
        }

        private void wykonajPonownieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoActionActive = true;
            if (currentChangesListElement < changesList.Count() - 1)
            {
                currentChangesListElement++;
                mainTextAreaTB.Text = changesList[currentChangesListElement];
                mainTextAreaTB.Select(mainTextAreaTB.Text.Length, 0);
            }
        }

        private void mainTextAreaTB_TextChanged(object sender, EventArgs e)
        {
            if (!undoActionActive && !redoActionActive)
            {
                bool blocked = false;
                if (currentChangesListElement <= changesList.Count() - 1)
                {
                    int lastIndex = changesList.Count() - (currentChangesListElement + 1);

                    if (changesList.Count() > 1)
                    {
                        changesList.RemoveRange(currentChangesListElement + 1, lastIndex);
                        AddNewElementToHistory();
                        currentChangesListElement = changesList.Count() - 1;
                        blocked = true;
                    }

                }

                if (!blocked)
                    AddNewElementToHistory();
            }
            else
            {
                undoActionActive = false;
                redoActionActive = false;
            }
        }
        private void AddNewElementToHistory()
        {
            changesList.Add(mainTextAreaTB.Text);
            currentChangesListElement++;
            CheckNumberOfHistoryElements();
        }
        private void CheckNumberOfHistoryElements()
        {
            if (changesList.Count() > 30)
            {
                changesList.RemoveAt(0);

                if (currentChangesListElement > 0)
                    currentChangesListElement--;
            }
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextAreaTB.SelectedText != string.Empty)
            {
                Clipboard.SetText(mainTextAreaTB.SelectedText);
                mainTextAreaTB.SelectedText = "";
            }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextAreaTB.SelectedText != string.Empty)
            {
                Clipboard.SetText(mainTextAreaTB.SelectedText);
                mainTextAreaTB.Select(mainTextAreaTB.Text.Length, 0);
            }
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextAreaTB.SelectedText != string.Empty)
                mainTextAreaTB.SelectedText = "";
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextAreaTB.SelectedText = Clipboard.GetText();
            mainTextAreaTB.Select(mainTextAreaTB.Text.Length, 0);
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextAreaTB.SelectAll();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            fontDialog.Font = mainTextAreaTB.Font;
            fontDialog.Color = mainTextAreaTB.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                mainTextAreaTB.Font = fontDialog.Font;
                mainTextAreaTB.ForeColor = fontDialog.Color;
            }
        }

        private void tłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = mainTextAreaTB.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                mainTextAreaTB.BackColor = colorDialog.Color;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.mainTextAreaTB.Width = this.Width - 16;
            this.mainTextAreaTB.Height = this.Height - 89;
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pasekStanuToolStripMenuItem.Checked)
            {
                pasekStanuToolStripMenuItem.Checked = false;
                statusStrip.Visible = false;
                this.mainTextAreaTB.Height = this.Height - 68;
            }
            else
            {
                pasekStanuToolStripMenuItem.Checked = true;
                statusStrip.Visible = true;
                this.mainTextAreaTB.Height = this.Height - 89;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Czy zapisać zmiany przed zamknięciem programu?",
                this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    this.zapiszJakoctrlSToolStripMenuItem_Click(null, null);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Sebastian Knych, Informatyka II rok II stopnia");
        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drukujctrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool stop = false;
            int i = 0;
            Font textboxFont = mainTextAreaTB.Font;
            int heightOfTextLine = (int)textboxFont.GetHeight(e.Graphics);
            int numOfLinesPerPage = e.MarginBounds.Height / heightOfTextLine;

            if (stringReader is null)
                stringReader = new StringReader(mainTextAreaTB.Text);

            e.HasMorePages = true;

            do
            {
                i++;
                string singleLine = stringReader.ReadLine();

                if (numOfLinesPerPage - 1 == i)
                {
                    stop = true;
                }
                else if (singleLine is null)
                {
                    e.HasMorePages = false;
                    stringReader = null;
                    stop = true;
                }
                else
                {
                    e.Graphics.DrawString(singleLine, textboxFont, Brushes.Black,
                        e.MarginBounds.Left, e.MarginBounds.Top + i * heightOfTextLine);
                }
            } while (!stop);
        }

        private void ustawieniaStronyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void podglądWydrukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
