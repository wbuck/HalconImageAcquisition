using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;
using HalconImageAcquisition;

namespace MainUserInterface
{
    public partial class MainForm : Form, IMainView
    {
        // Collection of image windows;
        private List<HWindowControl> _hWindowControls;

        public MainForm( )
        {
            InitializeComponent( );

            triggerButton.Click += OnTriggerCameraEvent;

            _hWindowControls = mainTableLayoutPanel.Controls.OfType< HWindowControl >( ).ToList( );
        }

        public List< HWindowControl > HWindowControls
        {
            get { return _hWindowControls;}
            set { _hWindowControls = value; }
        }

        protected virtual void OnTriggerCameraEvent( object sender, EventArgs e )
        {
            var handler = TriggerCameraEvent;
            if ( handler != null )
                handler( sender, e );
        }

        public event EventHandler TriggerCameraEvent;
    }
}
