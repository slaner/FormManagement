﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamDEV.Utils.Forms;

namespace FormManagement {
    static class Program {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormTable.Register<Form1>();
            FormTable.Register<Form2>();

            Application.Run(
                FormTable.Get<Form1>()
            );
            
            FormTable.Cleanup();
        }
    }
}
