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
	partial class AboutDialog
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
			this.cmdOK = new System.Windows.Forms.Button();
			this.lnkMailTo = new System.Windows.Forms.LinkLabel();
			this.lnkLame = new System.Windows.Forms.LinkLabel();
			this.lnkSilkIcons = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(90, 110);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(75, 23);
			this.cmdOK.TabIndex = 1;
			this.cmdOK.Text = "OK";
			this.cmdOK.UseVisualStyleBackColor = true;
			this.cmdOK.Click += new System.EventHandler(this.CmdOKClick);
			// 
			// lnkMailTo
			// 
			this.lnkMailTo.LinkArea = new System.Windows.Forms.LinkArea(9, 24);
			this.lnkMailTo.Location = new System.Drawing.Point(13, 54);
			this.lnkMailTo.Name = "lnkMailTo";
			this.lnkMailTo.Size = new System.Drawing.Size(230, 23);
			this.lnkMailTo.TabIndex = 2;
			this.lnkMailTo.TabStop = true;
			this.lnkMailTo.Text = "(c) 2007 Michael Hynonen";
			this.lnkMailTo.UseCompatibleTextRendering = true;
			this.lnkMailTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkMailToLinkClicked);
			// 
			// lnkLame
			// 
			this.lnkLame.LinkArea = new System.Windows.Forms.LinkArea(37, 4);
			this.lnkLame.Location = new System.Drawing.Point(13, 19);
			this.lnkLame.Name = "lnkLame";
			this.lnkLame.Size = new System.Drawing.Size(230, 35);
			this.lnkLame.TabIndex = 3;
			this.lnkLame.TabStop = true;
			this.lnkLame.Text = "A simple graphical front end for the LAME command line encoder.";
			this.lnkLame.UseCompatibleTextRendering = true;
			this.lnkLame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLameLinkClicked);
			// 
			// lnkSilkIcons
			// 
			this.lnkSilkIcons.LinkArea = new System.Windows.Forms.LinkArea(9, 17);
			this.lnkSilkIcons.Location = new System.Drawing.Point(13, 77);
			this.lnkSilkIcons.Name = "lnkSilkIcons";
			this.lnkSilkIcons.Size = new System.Drawing.Size(229, 23);
			this.lnkSilkIcons.TabIndex = 4;
			this.lnkSilkIcons.TabStop = true;
			this.lnkSilkIcons.Text = "Uses the Silk Icon Set 1.3 by Mark James.";
			this.lnkSilkIcons.UseCompatibleTextRendering = true;
			this.lnkSilkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSilkIconsLinkClicked);
			// 
			// AboutDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 145);
			this.Controls.Add(this.lnkSilkIcons);
			this.Controls.Add(this.lnkLame);
			this.Controls.Add(this.lnkMailTo);
			this.Controls.Add(this.cmdOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About EZLAME";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel lnkSilkIcons;
		private System.Windows.Forms.LinkLabel lnkLame;
		private System.Windows.Forms.LinkLabel lnkMailTo;
		private System.Windows.Forms.Button cmdOK;
	}
}
