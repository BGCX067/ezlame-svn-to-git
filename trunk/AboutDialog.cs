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

using System;
using System.Windows.Forms;

namespace EZLame
{
	/// <summary>
	/// Description of AboutDialog.
	/// </summary>
	public partial class AboutDialog : Form
	{
		public AboutDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void LnkLameLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("http://lame.sourceforge.net");
				lnkLame.LinkVisited = true;
			} catch (Exception) {				
			}
		}
		
		void LnkMailToLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("mailto:mhynonen@gmail.com");
				lnkMailTo.LinkVisited = true;
			} catch (Exception) {				
			}
		}
		
		void LnkSilkIconsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start("http://www.famfamfam.com/lab/icons/silk/");
				lnkSilkIcons.LinkVisited = true;
			} catch (Exception) {				
			}
		}
		
		void CmdOKClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
