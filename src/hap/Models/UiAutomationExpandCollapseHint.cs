﻿using System;
using System.Windows;
using UIAutomationClient;

namespace hap.Models
{
    /// <summary>
    /// Represents a Windows UI Automation toggle pattern based hint
    /// </summary>
    internal class UiAutomationExpandCollapseHint : Hint
    {
        private readonly IUIAutomationExpandCollapsePattern _expandCollapsePattern;

        public UiAutomationExpandCollapseHint(IntPtr owningWindow, IUIAutomationExpandCollapsePattern expandCollapsePattern, Rect boundingRectangle)
            : base(owningWindow, boundingRectangle)
        {
            _expandCollapsePattern = expandCollapsePattern;
        }

        public override void Invoke()
        {
            switch (_expandCollapsePattern.CurrentExpandCollapseState)
            {
                case ExpandCollapseState.ExpandCollapseState_Collapsed:
                    _expandCollapsePattern.Expand();
                    break;
                case ExpandCollapseState.ExpandCollapseState_Expanded:
                case ExpandCollapseState.ExpandCollapseState_PartiallyExpanded:
                    _expandCollapsePattern.Collapse();
                    break;
            }
        }
    }
}
