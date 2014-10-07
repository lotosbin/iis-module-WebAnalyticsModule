//
// Copyright © Microsoft Corporation.  All rights reserved.
//

namespace WebAnalyticsModule
{
    partial class WebAnalyticsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._settingsGroupBox = new System.Windows.Forms.GroupBox();
            this._pasteScriptTextBox = new System.Windows.Forms.TextBox();
            this._pasteScriptLabel = new System.Windows.Forms.Label();
            this._insertionPointComboBox = new System.Windows.Forms.ComboBox();
            this._insertionPointLabel = new System.Windows.Forms.Label();
            this._enabledCheckBox = new System.Windows.Forms.CheckBox();
            this._settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _settingsGroupBox
            // 
            this._settingsGroupBox.Controls.Add(this._pasteScriptTextBox);
            this._settingsGroupBox.Controls.Add(this._pasteScriptLabel);
            this._settingsGroupBox.Controls.Add(this._insertionPointComboBox);
            this._settingsGroupBox.Controls.Add(this._insertionPointLabel);
            this._settingsGroupBox.Controls.Add(this._enabledCheckBox);
            this._settingsGroupBox.Location = new System.Drawing.Point(0, 20);
            this._settingsGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this._settingsGroupBox.Name = "_settingsGroupBox";
            this._settingsGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this._settingsGroupBox.Size = new System.Drawing.Size(450, 280);
            this._settingsGroupBox.TabIndex = 0;
            this._settingsGroupBox.TabStop = false;
            this._settingsGroupBox.Text = "Web Analytics tracking configuration";
            // 
            // _pasteScriptTextBox
            // 
            this._pasteScriptTextBox.Location = new System.Drawing.Point(6, 129);
            this._pasteScriptTextBox.Multiline = true;
            this._pasteScriptTextBox.Name = "_pasteScriptTextBox";
            this._pasteScriptTextBox.Size = new System.Drawing.Size(438, 145);
            this._pasteScriptTextBox.TabIndex = 4;
            this._pasteScriptTextBox.TextChanged += new System.EventHandler(this.ScriptTextChanged);
            // 
            // _pasteScriptLabel
            // 
            this._pasteScriptLabel.AutoSize = true;
            this._pasteScriptLabel.Location = new System.Drawing.Point(3, 110);
            this._pasteScriptLabel.Name = "_pasteScriptLabel";
            this._pasteScriptLabel.Size = new System.Drawing.Size(197, 13);
            this._pasteScriptLabel.TabIndex = 3;
            this._pasteScriptLabel.Text = "Paste web analytics tracking script here:";
            // 
            // _insertionPointComboBox
            // 
            this._insertionPointComboBox.FormattingEnabled = true;
            this._insertionPointComboBox.Location = new System.Drawing.Point(9, 78);
            this._insertionPointComboBox.Name = "_insertionPointComboBox";
            this._insertionPointComboBox.Size = new System.Drawing.Size(194, 21);
            this._insertionPointComboBox.TabIndex = 2;
            this._insertionPointComboBox.SelectedIndexChanged += new System.EventHandler(this.InsertionPointIndexChanged);
            // 
            // _insertionPointLabel
            // 
            this._insertionPointLabel.AutoSize = true;
            this._insertionPointLabel.Location = new System.Drawing.Point(3, 59);
            this._insertionPointLabel.Name = "_insertionPointLabel";
            this._insertionPointLabel.Size = new System.Drawing.Size(105, 13);
            this._insertionPointLabel.TabIndex = 1;
            this._insertionPointLabel.Text = "Script insertion point:";
            // 
            // _enabledCheckBox
            // 
            this._enabledCheckBox.AutoSize = true;
            this._enabledCheckBox.Location = new System.Drawing.Point(6, 27);
            this._enabledCheckBox.Name = "_enabledCheckBox";
            this._enabledCheckBox.Size = new System.Drawing.Size(167, 17);
            this._enabledCheckBox.TabIndex = 0;
            this._enabledCheckBox.Text = "Enable web analytics tracking";
            this._enabledCheckBox.UseVisualStyleBackColor = true;
            this._enabledCheckBox.CheckedChanged += new System.EventHandler(this.EnabledCheckBoxChanged);
            // 
            // WebAnalyticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._settingsGroupBox);
            this.Name = "WebAnalyticsControl";
            this.Size = new System.Drawing.Size(459, 386);
            this._settingsGroupBox.ResumeLayout(false);
            this._settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _settingsGroupBox;
        private System.Windows.Forms.CheckBox _enabledCheckBox;
        private System.Windows.Forms.ComboBox _insertionPointComboBox;
        private System.Windows.Forms.Label _insertionPointLabel;
        private System.Windows.Forms.TextBox _pasteScriptTextBox;
        private System.Windows.Forms.Label _pasteScriptLabel;
    }
}
