//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.Management.Server;

namespace WebAnalyticsModule
{
    public partial class WebAnalyticsControl : UserControl
    {
        private WebAnalyticsPage _page;
        
        bool _enabledChanged = false;
        bool _insertionPointChanged = false;
        bool _scriptChanged = false;

        public WebAnalyticsControl(WebAnalyticsPage page)
        {
            _page = page;
            InitializeComponent();
            
            this._insertionPointComboBox.Items.AddRange(new object[] {
                "<head> element", "<body> element"});

            this._insertionPointComboBox.SelectedIndex = 1;
        }

        public void SetValues(PropertyBag bag)
        {
            _enabledCheckBox.Checked = (bool)bag[WebAnalyticsGlobals.trackingEnabled];
            SetControlsEnabled(_enabledCheckBox.Checked);

            _pasteScriptTextBox.Text = (string)bag[WebAnalyticsGlobals.trackingScript];
            _insertionPointComboBox.SelectedIndex = (int)bag[WebAnalyticsGlobals.insertionPoint];
        }

        public void GetValues(PropertyBag bag)
        {
            bag[WebAnalyticsGlobals.trackingEnabled] = _enabledCheckBox.Checked;

            if (_enabledCheckBox.Checked)
            {
                bag[WebAnalyticsGlobals.trackingScript] = _pasteScriptTextBox.Text;
                bag[WebAnalyticsGlobals.insertionPoint] = _insertionPointComboBox.SelectedIndex;
            }
        }

        private void UpdateHasChanged()
        {
            _page.SetHasChanges(_enabledChanged || _insertionPointChanged || _scriptChanged);
        }

        internal void ResetHasChanges()
        {
            _enabledChanged = false;
            _insertionPointChanged = false;
            _scriptChanged = false;
        }

        private void SetControlsEnabled(bool enabled)
        {
            _insertionPointComboBox.Enabled = enabled;
            _pasteScriptTextBox.Enabled = enabled;
        }


        private void EnabledCheckBoxChanged(object sender, EventArgs e)
        {
            SetControlsEnabled(_enabledCheckBox.Checked);

            if (_page._bag != null)
            {
                _enabledChanged = (_enabledCheckBox.Checked != (bool)_page._bag[WebAnalyticsGlobals.trackingEnabled]);
                UpdateHasChanged();
            }
        }

        private void InsertionPointIndexChanged(object sender, EventArgs e)
        {
            if (_page._bag != null)
            {
                _insertionPointChanged = (_insertionPointComboBox.SelectedIndex != (int)_page._bag[WebAnalyticsGlobals.insertionPoint]);
                UpdateHasChanged();
            }
        }

        private void ScriptTextChanged(object sender, EventArgs e)
        {
            if (_page._bag != null)
            {
                _scriptChanged = (_pasteScriptTextBox.Text != (string)_page._bag[WebAnalyticsGlobals.trackingScript]);
                UpdateHasChanged();
            }
        }


    }
}
