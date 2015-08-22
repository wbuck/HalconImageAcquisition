using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HalconDotNet;
using HalconImageAcquisition;

namespace MainUserInterface
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm( )
        {
            InitializeComponent( );

            triggerButton.Click += OnTriggerCameraEvent;
            Shown += OnInitializeHalconEvent;
        }

        public List< HWindowControl > HWindowControls
        {
            get { return mainTableLayoutPanel.Controls.OfType< HWindowControl >( ).ToList( ); }
        }

        protected virtual void OnInitializeHalconEvent( object sender, EventArgs e )
        {
            var handler = InitializeHalconEvent;
            if ( handler != null )
                handler( sender, e );
        }

        protected virtual void OnTriggerCameraEvent( object sender, EventArgs e )
        {
            var handler = TriggerCameraEvent;
            if ( handler != null )
                handler( sender, e );
        }

        public event EventHandler InitializeHalconEvent;
        public event EventHandler TriggerCameraEvent;
    }
}
