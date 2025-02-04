﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms;

namespace WinformsControlsTest
{
    public partial class ToolTipTests : Form
    {
        public ToolTipTests()
        {
            InitializeComponent();

            defaultAutomaticDelayToolTip.AutomaticDelay = 500;
            defaultAutoPopDelayToolTip.AutoPopDelay = 5000;
        }
    }
}
