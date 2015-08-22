using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HalconDotNet;

namespace HalconImageAcquisition
{
    public class ImageAcquisition
    {
        // Reference to MainForm.
        private readonly IMainView _mainView;

        // List of Halcon framegrabbers used
        // to interface with the Jai cameras.
        private readonly List< HFramegrabber > _framegrabbers;

        public ImageAcquisition( IMainView mainView )
        {
            _mainView = mainView;
            _mainView.TriggerCameraEvent += _mainView_TriggerCameraEvent;

            _framegrabbers = new List< HFramegrabber >( );

            // Fill the framegrabber list with 
            // framgrabbers.
            FillFrameGrabberList( );
        }

        private void FillFrameGrabberList( )
        {
            _framegrabbers.Add( CreateFrameGrabber( "000cdf09169e_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916aa_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf09169f_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a2_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a4_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a9_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a0_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a3_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a5_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a6_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a7_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916b0_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916af_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916ad_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a1_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916ab_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916ac_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916a8_JAICorporation_GO5000MPGE" ) );
            _framegrabbers.Add( CreateFrameGrabber( "000cdf0916ae_JAICorporation_GO5000MPGE" ) );
        }

        private void GrabImagesAndDisplay( )
        {
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 0 ].HalconWindow.DispObj( _framegrabbers[ 0 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 1 ].HalconWindow.DispObj( _framegrabbers[ 1 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 2 ].HalconWindow.DispObj( _framegrabbers[ 2 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 3 ].HalconWindow.DispObj( _framegrabbers[ 3 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 4 ].HalconWindow.DispObj( _framegrabbers[ 4 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 5 ].HalconWindow.DispObj( _framegrabbers[ 5 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 6 ].HalconWindow.DispObj( _framegrabbers[ 6 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 7 ].HalconWindow.DispObj( _framegrabbers[ 7 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 8 ].HalconWindow.DispObj( _framegrabbers[ 8 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 9 ].HalconWindow.DispObj( _framegrabbers[ 9 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 10 ].HalconWindow.DispObj( _framegrabbers[ 10 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 11 ].HalconWindow.DispObj( _framegrabbers[ 11 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 12 ].HalconWindow.DispObj( _framegrabbers[ 12 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 13 ].HalconWindow.DispObj( _framegrabbers[ 13 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 14 ].HalconWindow.DispObj( _framegrabbers[ 14 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 15 ].HalconWindow.DispObj( _framegrabbers[ 15 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 16 ].HalconWindow.DispObj( _framegrabbers[ 16 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 17 ].HalconWindow.DispObj( _framegrabbers[ 17 ].GrabImage( ) );
            } );
            Task.Factory.StartNew( ( ) =>
            {
                _mainView.HWindowControls[ 18 ].HalconWindow.DispObj( _framegrabbers[ 18 ].GrabImage( ) );
            } );
        }

        // Returns a framegrabber to be used for
        // image acquisition.
        private static HFramegrabber CreateFrameGrabber( string device )
        {
            return new HFramegrabber( name: "GigEVision",
                                      horizontalResolution: 1,
                                      verticalResolution: 1,
                                      imageWidth: 0,
                                      imageHeight: 0,
                                      startRow: 0,
                                      startColumn: 0,
                                      field: "default",
                                      bitsPerChannel: -1,
                                      colorSpace: "default",
                                      generic: -1,
                                      externalTrigger: "false",
                                      cameraType: "default",
                                      device: device,
                                      port: 0,
                                      lineIn: -1
                                    );   
        }

        private void _mainView_TriggerCameraEvent( object sender, EventArgs e )
        {
            GrabImagesAndDisplay( );
        }

    }
}
