﻿using DataLayer.Constats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03___WinFormTest
{
    public partial class AddEditDataFrm : Form
    {
        public AddEditDataFrm()
        {
            InitializeComponent();
            cbRental.Items.Add(RentValues.D);
            cbRental.Items.Add(RentValues.M);

        }

    }
}