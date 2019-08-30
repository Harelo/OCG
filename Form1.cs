using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
namespace OneCommandGenerator
{
    public partial class OneCommandGenerator : Form
    {
        public OneCommandGenerator()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (lstCmds.Items.Count != 0)
            {
                string fullCommand = @"summon FallingSand ~ ~2 ~ {Block:redstone_block,Time:1,Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~1 ~ ~ ~1 ~" + (int)((lstCmds.Items.Count + 5) * -1) + @" ~ redstone_block},Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~ ~2 ~ ~1 ~" + (int)((lstCmds.Items.Count + 5) * -1) + " ~ air}", addCB = "}}}";
                string[] commands = new string[lstCmds.Items.Count];
                int index = 0;
                string commandSummoningCB = "}";
                foreach (string cmd in lstCmds.Items)
                {
                    commands[index] = cmd;
                    index++;
                }
                //The max height of (some of the) command blocks
                int maxHeight = lstCmds.Items.Count <= 18 ? 1 : lstCmds.Items.Count / 18 + 1;//=2
                //The amount of command blocks with the max height
                int maxHeightLeft = lstCmds.Items.Count <= 18 ? lstCmds.Items.Count : lstCmds.Items.Count % 18;//=4
                int xPos = 4, zPos = -3;
                int i, changedToLast = 0;
                index = 0;
                //Special commands (that reach maxheight)
                while (maxHeightLeft > 0)
                {
                    //if there's more than 1 layer , execute this
                    if (maxHeight > 1)
                    {
                        while (maxHeightLeft != 0)
                        {
                            index = index + (18 * (maxHeight - 1));
                            fullCommand += @",Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/summon FallingSand ~" + xPos + " 10" + " ~" + zPos + @" {Block:command_block,Time:1,TileEntityData:{Command:" + commands[index] + "}";
                            for (i = 0; i < (int)(maxHeight - 1); i++)
                            {
                                index -= 18;
                                fullCommand += @",Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:" + commands[index] + "}";
                                commandSummoningCB += "}";
                                maxHeightLeft--;
                            }
                            fullCommand += commandSummoningCB;
                            index++;
                            if (index > 0)
                            {
                                xPos += index % 2 == 0 ? 1 : 0;
                                zPos += index % 2 == 0 ? -2 : 2;
                            }
                        }
                        maxHeightLeft = 0;
                        if (maxHeightLeft == 0 && changedToLast == 0)
                        {
                            maxHeightLeft = lstCmds.Items.Count - lstCmds.Items.Count % 18;
                            changedToLast = 1;
                            maxHeight--;
                        }
                    }
                    //if there isn't more than 1 layer, execute this
                    else if (maxHeight == 1)
                    {
                        if (index > 0)
                        {
                            xPos += index % 2 == 0 ? 1 : 0;
                            zPos += index % 2 == 0 ? -2 : 2;
                        }
                        fullCommand += @",Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/summon FallingSand ~" + xPos + " 10" + " ~" + zPos + " {Block:command_block,Time:1,TileEntityData:{Command:" + commands[index] + "}}}";
                        index++;
                        addCB += "}";
                    }
                    maxHeightLeft--;
                }
                string chosenWalls = "glass", chosenTopBottom = "stone";
                int totalRows = lstCmds.Items.Count <= 18 ? 1 : lstCmds.Items.Count / 18 + 1;
                fullCommand += @",Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~3 ~-4 ~-1 ~12 ~" + (int)(totalRows - 5) + @" ~-3 air},Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~2 ~-3 ~ ~13 ~" + (int)(totalRows - 4) + @" ~-4 " + chosenWalls + @"},Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~2 ~-3 ~ ~13 ~-3 ~-4 " + chosenTopBottom + @"},Riding:{id:""FallingSand"",Block:command_block,Time:1,TileEntityData:{Command:/fill ~2 ~-2 ~ ~13 ~" + (int)(totalRows - 1) + @" ~-4 air},Riding:{id:""FallingSand"",Block:stone,Time:1}}}}}}" + addCB;
                Clipboard.SetText(fullCommand);
                MessageBox.Show("Command was copied to clipboard! Paste it in your minecraft world using CTRL + V!");
            }
            else
                MessageBox.Show("You must put at least one command for the command to be generated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rmvAll_Click(object sender, EventArgs e)
        {
            lstCmds.Items.Clear();
            command.Clear();
        }

        private void rmvSlcd_Click(object sender, EventArgs e)
        {
            if (lstCmds.SelectedIndex != -1)
                lstCmds.Items.RemoveAt(lstCmds.SelectedIndex);
            else
                MessageBox.Show("Please select a command to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addCmd_Click(object sender, EventArgs e)
        {
            if (command.Text != "")
            {
                if (!command.Text.StartsWith("/"))
                {
                    if (lstCmds.SelectedIndex == -1)
                        lstCmds.Items.Add("/" + command.Text);
                    else
                    {
                        lstCmds.Items.Insert(lstCmds.SelectedIndex, "/" + command.Text);
                        lstCmds.SelectedIndex = -1;
                    }
                    command.Text = null;
                }
                else
                {
                    MessageBox.Show("Please remove the backslash in the beggining, it is automatically being added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please type a command to add!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edtCmd_Click(object sender, EventArgs e)
        {
            if (lstCmds.SelectedIndex != -1)
            {
                if (command.Text == "")
                {
                    MessageBox.Show("Please insert a command!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lstCmds.Items.Insert(lstCmds.SelectedIndex, "/" + command.Text);
                    lstCmds.Items.RemoveAt(lstCmds.SelectedIndex);
                    command.Text = null;
                    lstCmds.SelectedIndex = -1;
                }
            }
            else
                MessageBox.Show("Please choose a command to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void opnCmdFile_Click(object sender, EventArgs e)
        {
            openFD.Title = "Choose a commands file to upload!";
            openFD.Filter = ".txt|";
            openFD.ShowDialog();
            FileInfo file = new FileInfo(openFD.FileName);
            StreamReader stRead = file.OpenText();
            while (!stRead.EndOfStream)
            {
                lstCmds.Items.Add("/" + stRead.ReadLine());
            }
        }
    }
}
