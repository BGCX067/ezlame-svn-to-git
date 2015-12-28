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
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EZLame
{
	public partial class MainForm : Form
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		// configuration file.		
		Configuration config;

		#region Default Settings
		
		// default encoding method.
		readonly string defaultMethod = "vbr";
		
		// default cbr bitrate.
		readonly string defaultBitrate = "192";
		
		// default vbr preset.
		readonly string defaultPreset = "fast standard";
		
		#endregion Default Settings
		
		#region Properties
		
		// CBR encoding bitrate.
		string bitrate {
			
			get {			
				return cmbBitrate.SelectedItem.ToString();
			}
			
			set {				
				// if the value is an unsupported bitrate.
				if (!cmbBitrate.Items.Contains(value)) {					
					value = defaultBitrate;
				}				
				cmbBitrate.SelectedItem = value;
			}
		}
		
		// VBR encoding preset.
        string preset {
        	
        	get {				
	    		StringBuilder ps = new StringBuilder();
	    		
	    		if (chkVBRNew.Checked) {	    			
	    			ps.Append("fast ");
	    		}
	    		
	    		if (optMedium.Checked) {
					ps.Append("medium");
	    		}
	    		else if (optStandard.Checked) {
	    			ps.Append("standard");
	    		}
	    		else {
	    			ps.Append("extreme");
	    		}
	    		
	    		return ps.ToString();
        	}
			
			set {				
				chkVBRNew.Checked = value.StartsWith("fast ");
				
				string[] toks = value.Split(' ');
				
				string quality = (toks.Length > 1) ? toks[1] : toks[0];
				
				switch (quality) {
						
					case "medium":
						optMedium.Checked = true;
						break;
					case "standard":
						optStandard.Checked = true;
						break;
					case "extreme":
						optExtreme.Checked = true;
						break;
					default:
						optStandard.Checked = true;
						break;
				}
			}
        }
		
		#endregion Properties
		
		MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
        
        void RefreshStatus()
        {
        	// update encode button state.
        	cmdEncode.Enabled = (lstWavFiles.Items.Count > 0);
        	
        	// refresh status.
        	lblStatus.Text = lstWavFiles.Items.Count + " File(s) selected.";
        }
        
        #region Event Handlers
        
        void MainFormLoad(object sender, EventArgs e)
        {
        	// load configuration file.
			config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			
			// read the input path.
            try {
            	dlgAddWavFiles.InitialDirectory = config.AppSettings.Settings["inPath"].Value;
            } 
			catch (NullReferenceException) {
				
				// default to the current directory.
            	config.AppSettings.Settings.Add("inPath", Environment.CurrentDirectory);
        	}
            
			// read the output path.
			try {
				txtOutputPath.Text = config.AppSettings.Settings["outPath"].Value;
			} catch (NullReferenceException) {
				config.AppSettings.Settings.Add("outPath", "");
				txtOutputPath.Text = "";
			}
			chkSameIOPath.Checked = string.IsNullOrEmpty(txtOutputPath.Text);
			
            // read form position.
            try {
            	Left = int.Parse(config.AppSettings.Settings["formLeft"].Value);
            	if (Left < 0) {
            		Left = 0;
            	}
            } 
            catch (Exception) {
            	config.AppSettings.Settings.Add("formLeft", Left.ToString());
            }
            try {
            	Top = int.Parse(config.AppSettings.Settings["formTop"].Value);
            	if (Top < 0) {
            		Top = 0;
            	}
            } 
            catch (Exception) {
            	config.AppSettings.Settings.Add("formTop", Top.ToString());
            }
			
            // read form size.
            try {
            	Width = int.Parse(config.AppSettings.Settings["formWidth"].Value);
            	if (Width < MinimumSize.Width) {
            		Width = MinimumSize.Width;
            	}
            } 
            catch (Exception) {
            	config.AppSettings.Settings.Add("formWidth", Width.ToString());
            }
            try {
            	Height = int.Parse(config.AppSettings.Settings["formHeight"].Value);
            	if (Height < MinimumSize.Height) {
            		Height = MinimumSize.Height;
            	}
            } 
            catch (Exception) {
            	config.AppSettings.Settings.Add("formHeight", Height.ToString());
            }
            
            // read the general settings.
        	try {
            	chkDeleteInput.Checked = (config.AppSettings.Settings["deleteInput"].Value == "True");
        	} 
            catch (NullReferenceException) {
            	config.AppSettings.Settings.Add("deleteInput", chkDeleteInput.Checked ? "True" : "False");
        	}
            
            // read the encoding method.
            string method;
            try {
            	method = config.AppSettings.Settings["encMethod"].Value;
            } 
            catch (NullReferenceException) {
            	method = defaultMethod;
				config.AppSettings.Settings.Add("encMethod", method);
            }
            
            // set the encoding method.
        	switch (method) {            		
        		case "vbr": 
            		optVBR.PerformClick();
        			break;
        		case "cbr":        			
            		optCBR.PerformClick();
        			break;
        		default:
            		optVBR.PerformClick();
        			break;
        	}
            
            // read cbr bitrate.
            try {           	
				bitrate = config.AppSettings.Settings["cbrBitrate"].Value;
            } 
            catch (NullReferenceException) {
				config.AppSettings.Settings.Add("cbrBitrate", defaultBitrate);
            	bitrate = defaultBitrate;
            }
            
			// read VBR preset.
			try {				
				preset = config.AppSettings.Settings["vbrPreset"].Value;
			} 
			catch (NullReferenceException) {
				config.AppSettings.Settings.Add("vbrPreset", defaultPreset);
				preset = defaultPreset;
			}
			
			// check for a copy of lame.exe in the same directory
			// as this executable and use that if found.
			string localLame = 
				Path.GetDirectoryName(Application.ExecutablePath) +
				Path.DirectorySeparatorChar + "lame.exe";
			if (File.Exists(localLame)) {
				procLame.StartInfo.FileName = localLame;
			}
        }
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
        	// update form position.
        	config.AppSettings.Settings["formLeft"].Value = Left.ToString();
        	config.AppSettings.Settings["formTop"].Value = Top.ToString();
        	
        	// update form size.
        	config.AppSettings.Settings["formWidth"].Value = Width.ToString();
        	config.AppSettings.Settings["formHeight"].Value = Height.ToString();
        	
        	// save the configuration.
        	try {
        		config.Save(ConfigurationSaveMode.Modified);
        	} catch (ConfigurationErrorsException) {        		
        	}
		}
		
		void BwEncoderDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			string baseArgs = e.Argument.ToString();

            // for each wav file.
            foreach (string wavFile in lstWavFiles.Items)
            {
                // append input file name.
                StringBuilder lameArgs = new StringBuilder(baseArgs.ToString());
                lameArgs.Append(wavFile);
                lameArgs.Append("\" \"");
                                
                // append output file name.
                if (chkSameIOPath.Checked) {
                	
                	lameArgs.Append(Path.ChangeExtension(wavFile, ".mp3"));
                }
                else {
                	
                	lameArgs.Append(txtOutputPath.Text);
                	lameArgs.Append(Path.DirectorySeparatorChar);
                	lameArgs.Append(Path.GetFileNameWithoutExtension(wavFile));
                	lameArgs.Append(".mp3");
                }
                lameArgs.Append("\"");

                try {
                	
	                // begin encoding.
	                procLame.StartInfo.Arguments = lameArgs.ToString();
	                procLame.Start();
	                
	                // while the encoder process is not complete.
					while (!procLame.HasExited) {
	                
	                	// suspend thread execution for a while.
	                	Thread.Sleep(1200);
	                	
	                	// if cancellation has been requested.
	                	if (bwEncoder.CancellationPending) {
	                		procLame.Kill();
	                	}                	
	                }
                } 
                catch (Win32Exception wex) {
                	
                	if (wex.NativeErrorCode == 2) {
                		
                		MessageBox.Show(
                			"The LAME encoder (lame.exe) could not be found." + Environment.NewLine +
                			"Please verify it is installed and in your local path.",
                			"Encoding Error", 
                			MessageBoxButtons.OK, MessageBoxIcon.Error);
                	}
                	else if (wex.NativeErrorCode == 5) {
                		
                		MessageBox.Show(
                			"Access to lame.exe was denied.",
                			"Encoding Error", 
                			MessageBoxButtons.OK, MessageBoxIcon.Error);
                	}
                	break;
                }
                
                // if the delete input files option is checked.
                if (chkDeleteInput.Checked) {
                
                	// try deleting the wav file.
                	try {
                		File.Delete(wavFile);
                	} catch (Exception) {
                	}
                }
            }
		}
		
		void BwEncoderRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{			            
            cmdCancel.Enabled     = false;
            cmdEncode.Enabled     = true;
            cmdAddFile.Enabled    = true;
            cmdRemoveFile.Enabled = true;
			cmdOutputPath.Enabled = !chkSameIOPath.Checked;
			txtOutputPath.Enabled = cmdOutputPath.Enabled;
            pnlSettings.Enabled   = true;
            if (optCBR.Checked) {
            	optCBR.PerformClick();
            } else {
            	optVBR.PerformClick();
            }
		}
		
        void OptCBRCheckedChanged(object sender, EventArgs e)
        {
       		config.AppSettings.Settings["encMethod"].Value = "cbr";
            grpCBR.Enabled = true;
            grpVBR.Enabled = !grpCBR.Enabled;
        }

        void OptVBRCheckedChanged(object sender, EventArgs e)
        {
       		config.AppSettings.Settings["encMethod"].Value = "vbr";
            grpCBR.Enabled = false;
            grpVBR.Enabled = !grpCBR.Enabled;
        }
		
		void OptMediumCheckedChanged(object sender, EventArgs e)
		{
			config.AppSettings.Settings["vbrPreset"].Value = preset;
		}
		
		void OptStandardCheckedChanged(object sender, EventArgs e)
		{			
			config.AppSettings.Settings["vbrPreset"].Value = preset;
		}
		
		void OptExtremeCheckedChanged(object sender, EventArgs e)
		{			
			config.AppSettings.Settings["vbrPreset"].Value = preset;
		}
		
		void ChkVBRNewCheckedChanged(object sender, EventArgs e)
		{			
			config.AppSettings.Settings["vbrPreset"].Value = preset;
		}
        
		void ChkDeleteInputCheckedChanged(object sender, EventArgs e)
		{
			config.AppSettings.Settings["deleteInput"].Value = chkDeleteInput.Checked.ToString();
		}
		
		void ChkSameIOPathCheckedChanged(object sender, EventArgs e)
		{
			cmdOutputPath.Enabled = !chkSameIOPath.Checked;
			txtOutputPath.Enabled = cmdOutputPath.Enabled;
			
			if (chkSameIOPath.Checked) {
				
				config.AppSettings.Settings["outPath"].Value = "";
				txtOutputPath.Text = "";
			}
		}
		
		void CmbBitrateSelectedIndexChanged(object sender, EventArgs e)
		{			
       		config.AppSettings.Settings["cbrBitrate"].Value = cmbBitrate.Text;
		}
        
        void CmdAddFileClick(object sender, EventArgs e)
        {
        	// restore previous input path.
        	dlgAddWavFiles.InitialDirectory = config.AppSettings.Settings["inPath"].Value;
        	
        	// clear the previous filename(s).
        	dlgAddWavFiles.FileName = "";
        	
            if (dlgAddWavFiles.ShowDialog() == DialogResult.OK) {
        		
        		// for each selected file.
                foreach (string filename in dlgAddWavFiles.FileNames) {
            		
        			// if the file is not already added.
        			if (!lstWavFiles.Items.Contains(filename)) {        				
                    	lstWavFiles.Items.Add(filename);
        			}
        			
        			// update the input path.
        			config.AppSettings.Settings["inPath"].Value = Path.GetDirectoryName(filename);
                }
            }
        	RefreshStatus();
        }

        void CmdRemoveFileClick(object sender, EventArgs e)
        {
        	// if there are files selected.
        	if (lstWavFiles.SelectedItems.Count > 0) {
        	    
        		// create a list of objects to be removed from the listbox then remove them.
        		
				List<object> removeList = new List<object>(lstWavFiles.SelectedIndices.Count);
				
				foreach (object obj in lstWavFiles.SelectedItems) {				
				    removeList.Add(obj);
				}
				
				foreach (object obj in removeList) {			
				    lstWavFiles.Items.Remove(obj);
				}
				
        	} else {
        		
        		if (lstWavFiles.Items.Count > 0) {
        			
        			// ask if all files should be removed from the list.
	        		if (MessageBox.Show("Remove all file(s)?", "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.Yes) {	        			
        				lstWavFiles.Items.Clear();
	        		}
        		}
        	}
        	RefreshStatus();
		}
        		
		void CmdOutputPathClick(object sender, EventArgs e)
		{
        	dlgOutputPath.SelectedPath = config.AppSettings.Settings["outPath"].Value;
        	
        	if (dlgOutputPath.ShowDialog() == DialogResult.OK) {
								
				// update the output path.
				config.AppSettings.Settings["outPath"].Value = dlgOutputPath.SelectedPath;
				txtOutputPath.Text = dlgOutputPath.SelectedPath;
			}
		}
        
        void CmdEncodeClick(object sender, EventArgs e)
        {
        	if (chkSameIOPath.Checked || Directory.Exists(txtOutputPath.Text)) {
        		
	        	// disable everything but the cancel button.
				cmdCancel.Enabled     = true;
				cmdEncode.Enabled     = false;
				cmdAddFile.Enabled    = false;
				cmdRemoveFile.Enabled = false;
				cmdOutputPath.Enabled = false;
				txtOutputPath.Enabled = false;
				pnlSettings.Enabled   = false;
				        	
	        	// build the base arguments list for lame.exe.
	            StringBuilder baseArgs = new StringBuilder();
	
	            // if the encoding method is VBR.
	            if (optVBR.Checked) {
	            	
	            	// append the preset.
	                baseArgs.Append("--preset ");                
	                baseArgs.Append(preset);
	            }
	            else {
	            	
	            	// append the bitrate.
	                baseArgs.Append("-b ");
	                baseArgs.Append(bitrate);
	            }
	            baseArgs.Append(" \"");
	            
	            // start the encoder thread.
	            bwEncoder.RunWorkerAsync(baseArgs.ToString());
	            
        	} else {
        		
        		MessageBox.Show(
        			"Your output path is invalid.", 
        			"Encoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
        }
		
		void CmdCancelClick(object sender, EventArgs e)
		{
			cmdCancel.Enabled = false;
			
			// signal the encoder thread to cancel.
			bwEncoder.CancelAsync();
		}
		
		void CmdAboutClick(object sender, EventArgs e)
		{
			Form dlgAbout = new AboutDialog();
			dlgAbout.ShowDialog();
		}
		
		void TxtOutputPathLeave(object sender, EventArgs e)
		{
			// update the output path.
			config.AppSettings.Settings["outPath"].Value = txtOutputPath.Text;
		}
		
        #endregion Event Handlers		
	}
}
