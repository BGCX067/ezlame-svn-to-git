/*
 * Copyright (c) 2007, Michael Hynonen
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without 
 * modification, are permitted provided that the following conditions are met:
 * 
 *	* Redistributions of source code must retain the above copyright notice, 
 *	  this list of conditions and the following disclaimer.
 * 
 *	* Redistributions in binary form must reproduce the above copyright notice, 
 *	  this list of conditions and the following disclaimer in the documentation 
 *	  and/or other materials provided with the distribution.
 * 
 *	* The names of the contributors may not be used to endorse or promote 
 *	  products derived from this software without specific prior written 
 *	  permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
 * "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
 * LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
 * A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
 * EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

namespace EZLame
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bwEncoder = new System.ComponentModel.BackgroundWorker();
			this.dlgAddWavFiles = new System.Windows.Forms.OpenFileDialog();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.chkSameIOPath = new System.Windows.Forms.CheckBox();
			this.chkDeleteInput = new System.Windows.Forms.CheckBox();
			this.grpVBR = new System.Windows.Forms.GroupBox();
			this.chkVBRNew = new System.Windows.Forms.CheckBox();
			this.optMedium = new System.Windows.Forms.RadioButton();
			this.optStandard = new System.Windows.Forms.RadioButton();
			this.optExtreme = new System.Windows.Forms.RadioButton();
			this.grpCBR = new System.Windows.Forms.GroupBox();
			this.lblBitrate = new System.Windows.Forms.Label();
			this.cmbBitrate = new System.Windows.Forms.ComboBox();
			this.grpMethod = new System.Windows.Forms.GroupBox();
			this.optVBR = new System.Windows.Forms.RadioButton();
			this.optCBR = new System.Windows.Forms.RadioButton();
			this.tsToolBar = new System.Windows.Forms.ToolStrip();
			this.cmdAddFile = new System.Windows.Forms.ToolStripButton();
			this.cmdRemoveFile = new System.Windows.Forms.ToolStripButton();
			this.cmdOutputPath = new System.Windows.Forms.ToolStripButton();
			this.txtOutputPath = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmdEncode = new System.Windows.Forms.ToolStripButton();
			this.cmdCancel = new System.Windows.Forms.ToolStripButton();
			this.cmdAbout = new System.Windows.Forms.ToolStripButton();
			this.ssStatusBar = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lstWavFiles = new System.Windows.Forms.ListBox();
			this.dlgOutputPath = new System.Windows.Forms.FolderBrowserDialog();
			this.procLame = new System.Diagnostics.Process();
			this.ttTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlSettings.SuspendLayout();
			this.grpGeneral.SuspendLayout();
			this.grpVBR.SuspendLayout();
			this.grpCBR.SuspendLayout();
			this.grpMethod.SuspendLayout();
			this.tsToolBar.SuspendLayout();
			this.ssStatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// bwEncoder
			// 
			this.bwEncoder.WorkerSupportsCancellation = true;
			this.bwEncoder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwEncoderDoWork);
			this.bwEncoder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwEncoderRunWorkerCompleted);
			// 
			// dlgAddWavFiles
			// 
			this.dlgAddWavFiles.Filter = "WAV files|*.wav";
			this.dlgAddWavFiles.Multiselect = true;
			this.dlgAddWavFiles.Title = "Select Files";
			// 
			// pnlSettings
			// 
			this.pnlSettings.Controls.Add(this.grpGeneral);
			this.pnlSettings.Controls.Add(this.grpVBR);
			this.pnlSettings.Controls.Add(this.grpCBR);
			this.pnlSettings.Controls.Add(this.grpMethod);
			this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSettings.Location = new System.Drawing.Point(381, 25);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(161, 366);
			this.pnlSettings.TabIndex = 0;
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.chkSameIOPath);
			this.grpGeneral.Controls.Add(this.chkDeleteInput);
			this.grpGeneral.Location = new System.Drawing.Point(9, 11);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(144, 76);
			this.grpGeneral.TabIndex = 13;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "General Settings";
			// 
			// chkSameIOPath
			// 
			this.chkSameIOPath.Checked = true;
			this.chkSameIOPath.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSameIOPath.Location = new System.Drawing.Point(15, 40);
			this.chkSameIOPath.Name = "chkSameIOPath";
			this.chkSameIOPath.Size = new System.Drawing.Size(112, 30);
			this.chkSameIOPath.TabIndex = 1;
			this.chkSameIOPath.Text = "Same IO Path";
			this.chkSameIOPath.UseVisualStyleBackColor = true;
			this.chkSameIOPath.CheckedChanged += new System.EventHandler(this.ChkSameIOPathCheckedChanged);
			// 
			// chkDeleteInput
			// 
			this.chkDeleteInput.Location = new System.Drawing.Point(15, 19);
			this.chkDeleteInput.Name = "chkDeleteInput";
			this.chkDeleteInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkDeleteInput.Size = new System.Drawing.Size(112, 24);
			this.chkDeleteInput.TabIndex = 0;
			this.chkDeleteInput.Text = "Delete Input Files";
			this.ttTip.SetToolTip(this.chkDeleteInput, "Delete wav files when done encoding?");
			this.chkDeleteInput.UseVisualStyleBackColor = true;
			this.chkDeleteInput.CheckedChanged += new System.EventHandler(this.ChkDeleteInputCheckedChanged);
			// 
			// grpVBR
			// 
			this.grpVBR.Controls.Add(this.chkVBRNew);
			this.grpVBR.Controls.Add(this.optMedium);
			this.grpVBR.Controls.Add(this.optStandard);
			this.grpVBR.Controls.Add(this.optExtreme);
			this.grpVBR.Location = new System.Drawing.Point(9, 225);
			this.grpVBR.Name = "grpVBR";
			this.grpVBR.Size = new System.Drawing.Size(144, 128);
			this.grpVBR.TabIndex = 16;
			this.grpVBR.TabStop = false;
			this.grpVBR.Text = "VBR Settings";
			// 
			// chkVBRNew
			// 
			this.chkVBRNew.AutoSize = true;
			this.chkVBRNew.Checked = true;
			this.chkVBRNew.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkVBRNew.Location = new System.Drawing.Point(16, 96);
			this.chkVBRNew.Name = "chkVBRNew";
			this.chkVBRNew.Size = new System.Drawing.Size(64, 17);
			this.chkVBRNew.TabIndex = 3;
			this.chkVBRNew.Text = "vbr-new";
			this.ttTip.SetToolTip(this.chkVBRNew, "Use the new VBR algorithm? (recommended)");
			this.chkVBRNew.UseVisualStyleBackColor = true;
			this.chkVBRNew.CheckedChanged += new System.EventHandler(this.ChkVBRNewCheckedChanged);
			// 
			// optMedium
			// 
			this.optMedium.AutoSize = true;
			this.optMedium.Location = new System.Drawing.Point(16, 24);
			this.optMedium.Name = "optMedium";
			this.optMedium.Size = new System.Drawing.Size(62, 17);
			this.optMedium.TabIndex = 0;
			this.optMedium.Text = "Medium";
			this.ttTip.SetToolTip(this.optMedium, "Medium quality");
			this.optMedium.UseVisualStyleBackColor = true;
			this.optMedium.CheckedChanged += new System.EventHandler(this.OptMediumCheckedChanged);
			// 
			// optStandard
			// 
			this.optStandard.AutoSize = true;
			this.optStandard.Checked = true;
			this.optStandard.Location = new System.Drawing.Point(16, 48);
			this.optStandard.Name = "optStandard";
			this.optStandard.Size = new System.Drawing.Size(68, 17);
			this.optStandard.TabIndex = 1;
			this.optStandard.TabStop = true;
			this.optStandard.Text = "Standard";
			this.ttTip.SetToolTip(this.optStandard, "Standard quality (recommended)");
			this.optStandard.UseVisualStyleBackColor = true;
			this.optStandard.CheckedChanged += new System.EventHandler(this.OptStandardCheckedChanged);
			// 
			// optExtreme
			// 
			this.optExtreme.AutoSize = true;
			this.optExtreme.Location = new System.Drawing.Point(16, 72);
			this.optExtreme.Name = "optExtreme";
			this.optExtreme.Size = new System.Drawing.Size(63, 17);
			this.optExtreme.TabIndex = 2;
			this.optExtreme.Text = "Extreme";
			this.ttTip.SetToolTip(this.optExtreme, "Extreme quality");
			this.optExtreme.UseVisualStyleBackColor = true;
			this.optExtreme.CheckedChanged += new System.EventHandler(this.OptExtremeCheckedChanged);
			// 
			// grpCBR
			// 
			this.grpCBR.Controls.Add(this.lblBitrate);
			this.grpCBR.Controls.Add(this.cmbBitrate);
			this.grpCBR.Enabled = false;
			this.grpCBR.Location = new System.Drawing.Point(9, 155);
			this.grpCBR.Name = "grpCBR";
			this.grpCBR.Size = new System.Drawing.Size(144, 64);
			this.grpCBR.TabIndex = 15;
			this.grpCBR.TabStop = false;
			this.grpCBR.Text = "CBR Settings";
			// 
			// lblBitrate
			// 
			this.lblBitrate.AutoSize = true;
			this.lblBitrate.Location = new System.Drawing.Point(16, 24);
			this.lblBitrate.Name = "lblBitrate";
			this.lblBitrate.Size = new System.Drawing.Size(40, 13);
			this.lblBitrate.TabIndex = 7;
			this.lblBitrate.Text = "Bitrate:";
			// 
			// cmbBitrate
			// 
			this.cmbBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBitrate.FormattingEnabled = true;
			this.cmbBitrate.Items.AddRange(new object[] {
									"32",
									"40",
									"48",
									"56",
									"64",
									"80",
									"96",
									"112",
									"128",
									"160",
									"192",
									"224",
									"256",
									"320"});
			this.cmbBitrate.Location = new System.Drawing.Point(64, 24);
			this.cmbBitrate.Name = "cmbBitrate";
			this.cmbBitrate.Size = new System.Drawing.Size(64, 21);
			this.cmbBitrate.TabIndex = 0;
			this.ttTip.SetToolTip(this.cmbBitrate, "Bitrate (recommended:192)");
			this.cmbBitrate.SelectedIndexChanged += new System.EventHandler(this.CmbBitrateSelectedIndexChanged);
			// 
			// grpMethod
			// 
			this.grpMethod.Controls.Add(this.optVBR);
			this.grpMethod.Controls.Add(this.optCBR);
			this.grpMethod.Location = new System.Drawing.Point(9, 93);
			this.grpMethod.Name = "grpMethod";
			this.grpMethod.Size = new System.Drawing.Size(144, 56);
			this.grpMethod.TabIndex = 14;
			this.grpMethod.TabStop = false;
			this.grpMethod.Text = "Encoding Method";
			// 
			// optVBR
			// 
			this.optVBR.AutoSize = true;
			this.optVBR.Checked = true;
			this.optVBR.Location = new System.Drawing.Point(80, 24);
			this.optVBR.Name = "optVBR";
			this.optVBR.Size = new System.Drawing.Size(47, 17);
			this.optVBR.TabIndex = 1;
			this.optVBR.TabStop = true;
			this.optVBR.Text = "VBR";
			this.ttTip.SetToolTip(this.optVBR, "Variable bitrate (recommended)");
			this.optVBR.UseVisualStyleBackColor = true;
			this.optVBR.CheckedChanged += new System.EventHandler(this.OptVBRCheckedChanged);
			// 
			// optCBR
			// 
			this.optCBR.AutoSize = true;
			this.optCBR.Location = new System.Drawing.Point(16, 24);
			this.optCBR.Name = "optCBR";
			this.optCBR.Size = new System.Drawing.Size(47, 17);
			this.optCBR.TabIndex = 0;
			this.optCBR.Text = "CBR";
			this.ttTip.SetToolTip(this.optCBR, "Constant bitrate");
			this.optCBR.UseVisualStyleBackColor = true;
			this.optCBR.CheckedChanged += new System.EventHandler(this.OptCBRCheckedChanged);
			// 
			// tsToolBar
			// 
			this.tsToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tsToolBar.CanOverflow = false;
			this.tsToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cmdAddFile,
									this.cmdRemoveFile,
									this.cmdOutputPath,
									this.txtOutputPath,
									this.toolStripSeparator1,
									this.cmdEncode,
									this.cmdCancel,
									this.cmdAbout});
			this.tsToolBar.Location = new System.Drawing.Point(0, 0);
			this.tsToolBar.Name = "tsToolBar";
			this.tsToolBar.Size = new System.Drawing.Size(542, 25);
			this.tsToolBar.TabIndex = 0;
			this.tsToolBar.TabStop = true;
			// 
			// cmdAddFile
			// 
			this.cmdAddFile.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddFile.Image")));
			this.cmdAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdAddFile.Name = "cmdAddFile";
			this.cmdAddFile.Size = new System.Drawing.Size(78, 22);
			this.cmdAddFile.Text = "Add File(s)";
			this.cmdAddFile.ToolTipText = "Add wav file(s)";
			this.cmdAddFile.Click += new System.EventHandler(this.CmdAddFileClick);
			// 
			// cmdRemoveFile
			// 
			this.cmdRemoveFile.Image = ((System.Drawing.Image)(resources.GetObject("cmdRemoveFile.Image")));
			this.cmdRemoveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdRemoveFile.Name = "cmdRemoveFile";
			this.cmdRemoveFile.Size = new System.Drawing.Size(98, 22);
			this.cmdRemoveFile.Text = "Remove File(s)";
			this.cmdRemoveFile.ToolTipText = "Remove wav file(s)";
			this.cmdRemoveFile.Click += new System.EventHandler(this.CmdRemoveFileClick);
			// 
			// cmdOutputPath
			// 
			this.cmdOutputPath.Enabled = false;
			this.cmdOutputPath.Image = ((System.Drawing.Image)(resources.GetObject("cmdOutputPath.Image")));
			this.cmdOutputPath.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdOutputPath.Name = "cmdOutputPath";
			this.cmdOutputPath.Size = new System.Drawing.Size(90, 22);
			this.cmdOutputPath.Text = "Output Path:";
			this.cmdOutputPath.ToolTipText = "Set the output path";
			this.cmdOutputPath.Click += new System.EventHandler(this.CmdOutputPathClick);
			// 
			// txtOutputPath
			// 
			this.txtOutputPath.AutoToolTip = true;
			this.txtOutputPath.BackColor = System.Drawing.SystemColors.Window;
			this.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOutputPath.Enabled = false;
			this.txtOutputPath.Name = "txtOutputPath";
			this.txtOutputPath.Size = new System.Drawing.Size(100, 25);
			this.txtOutputPath.Leave += new System.EventHandler(this.TxtOutputPathLeave);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// cmdEncode
			// 
			this.cmdEncode.Enabled = false;
			this.cmdEncode.Image = ((System.Drawing.Image)(resources.GetObject("cmdEncode.Image")));
			this.cmdEncode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdEncode.Name = "cmdEncode";
			this.cmdEncode.Size = new System.Drawing.Size(62, 22);
			this.cmdEncode.Text = "Encode";
			this.cmdEncode.ToolTipText = "Begin encoding";
			this.cmdEncode.Click += new System.EventHandler(this.CmdEncodeClick);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Enabled = false;
			this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
			this.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(59, 22);
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.ToolTipText = "Cancel encoding";
			this.cmdCancel.Click += new System.EventHandler(this.CmdCancelClick);
			// 
			// cmdAbout
			// 
			this.cmdAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.cmdAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdAbout.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbout.Image")));
			this.cmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdAbout.Name = "cmdAbout";
			this.cmdAbout.Size = new System.Drawing.Size(23, 22);
			this.cmdAbout.Text = "toolStripButton1";
			this.cmdAbout.ToolTipText = "About EZLAME";
			this.cmdAbout.Click += new System.EventHandler(this.CmdAboutClick);
			// 
			// ssStatusBar
			// 
			this.ssStatusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ssStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.lblStatus});
			this.ssStatusBar.Location = new System.Drawing.Point(0, 391);
			this.ssStatusBar.Name = "ssStatusBar";
			this.ssStatusBar.Size = new System.Drawing.Size(542, 22);
			this.ssStatusBar.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(92, 17);
			this.lblStatus.Text = "0 File(s) selected.";
			// 
			// lstWavFiles
			// 
			this.lstWavFiles.BackColor = System.Drawing.SystemColors.Control;
			this.lstWavFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstWavFiles.FormattingEnabled = true;
			this.lstWavFiles.HorizontalScrollbar = true;
			this.lstWavFiles.IntegralHeight = false;
			this.lstWavFiles.Location = new System.Drawing.Point(0, 25);
			this.lstWavFiles.Name = "lstWavFiles";
			this.lstWavFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstWavFiles.Size = new System.Drawing.Size(381, 366);
			this.lstWavFiles.Sorted = true;
			this.lstWavFiles.TabIndex = 1;
			// 
			// procLame
			// 
			this.procLame.StartInfo.Domain = "";
			this.procLame.StartInfo.FileName = "lame.exe";
			this.procLame.StartInfo.LoadUserProfile = false;
			this.procLame.StartInfo.Password = null;
			this.procLame.StartInfo.StandardErrorEncoding = null;
			this.procLame.StartInfo.StandardOutputEncoding = null;
			this.procLame.StartInfo.UserName = "";
			this.procLame.SynchronizingObject = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 413);
			this.Controls.Add(this.lstWavFiles);
			this.Controls.Add(this.pnlSettings);
			this.Controls.Add(this.tsToolBar);
			this.Controls.Add(this.ssStatusBar);
			this.MinimumSize = new System.Drawing.Size(550, 440);
			this.Name = "MainForm";
			this.Text = "EZLAME Front-End";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.pnlSettings.ResumeLayout(false);
			this.grpGeneral.ResumeLayout(false);
			this.grpVBR.ResumeLayout(false);
			this.grpVBR.PerformLayout();
			this.grpCBR.ResumeLayout(false);
			this.grpCBR.PerformLayout();
			this.grpMethod.ResumeLayout(false);
			this.grpMethod.PerformLayout();
			this.tsToolBar.ResumeLayout(false);
			this.tsToolBar.PerformLayout();
			this.ssStatusBar.ResumeLayout(false);
			this.ssStatusBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chkSameIOPath;
		private System.Windows.Forms.ToolTip ttTip;
		private System.Diagnostics.Process procLame;
		private System.Windows.Forms.StatusStrip ssStatusBar;
		private System.Windows.Forms.ToolStrip tsToolBar;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.FolderBrowserDialog dlgOutputPath;
		private System.Windows.Forms.OpenFileDialog dlgAddWavFiles;
		private System.Windows.Forms.ToolStripTextBox txtOutputPath;
		private System.Windows.Forms.ToolStripButton cmdOutputPath;
		private System.Windows.Forms.CheckBox chkDeleteInput;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton cmdAbout;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Label lblBitrate;
		private System.Windows.Forms.Panel pnlSettings;
		private System.ComponentModel.BackgroundWorker bwEncoder;
		private System.Windows.Forms.ComboBox cmbBitrate;
		private System.Windows.Forms.ListBox lstWavFiles;
		private System.Windows.Forms.CheckBox chkVBRNew;
		private System.Windows.Forms.RadioButton optExtreme;
		private System.Windows.Forms.RadioButton optStandard;
		private System.Windows.Forms.RadioButton optMedium;
		private System.Windows.Forms.RadioButton optVBR;
		private System.Windows.Forms.RadioButton optCBR;
		private System.Windows.Forms.ToolStripButton cmdAddFile;
		private System.Windows.Forms.ToolStripButton cmdRemoveFile;
		private System.Windows.Forms.ToolStripButton cmdEncode;
		private System.Windows.Forms.GroupBox grpCBR;
		private System.Windows.Forms.GroupBox grpVBR;
		private System.Windows.Forms.GroupBox grpMethod;
		private System.Windows.Forms.ToolStripButton cmdCancel;
		
		
	}
}
