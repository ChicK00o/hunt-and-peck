﻿using System;
using System.Windows;
using UIAutomationClient;

namespace hap.Models
{
    /// <summary>
    /// Represents a Windows UI Automation based hint
    /// </summary>
    internal class UiAutomationFocusHint : Hint
    {
        private readonly IUIAutomationElement _automationElement;

        public UiAutomationFocusHint(IntPtr owningWindow, IUIAutomationElement automationElement, Rect boundingRectangle)
            : base(owningWindow, boundingRectangle)
        {
            _automationElement = automationElement;
        }

        public override void Invoke()
        {
            _automationElement.SetFocus();
        }
    }
}
