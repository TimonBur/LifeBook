﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DiaryClassLibStandart.Helpers
{
    public class HelperDialog
    {
        public static void ShowWarningDialog(string info, string caption)
        {
            MessageBox.Show(info, caption,MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        public static DialogResult ShowYesNoDialog(string info, string caption)
        {
            return MessageBox.Show(info, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);        
        }

    }
}