using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HalconDotNet;

namespace HalconImageAcquisition
{
    public class ImageAcquisition
    {
        // Reference to MainForm.
        private readonly IMainView _mainView;

        // Dictionary of Halcon image windows and 
        // framegrabbers used to interface with the Jai cameras.
        private readonly Dictionary< string, HalconImageController > _halconImageControllerDictionary;

        public ImageAcquisition( IMainView mainView )
        {
            _mainView = mainView;
            _mainView.InitializeHalconEvent += _mainView_InitializeHalconEvent;
            _mainView.TriggerCameraEvent += ( sender, args ) => GrabImagesAndDisplay( );

            _halconImageControllerDictionary = new Dictionary< string, HalconImageController >( );           
        }

        // Fill dictionary with an instance of a framegrabber
        // and an image window. Both of these instances are
        // contained in the HalconImageController class. I did
        // this to keep the framegrabber and associated image
        // window together.
        private void FillHalconImageControllerDictionary( string key, string device )
        {
            _halconImageControllerDictionary.Add( key,
                new HalconImageController
                {
                    HalconWindowControl = _mainView.HWindowControls.FirstOrDefault( x => x.Name == key ),
                    HalconFramegrabber = CreateFrameGrabber( device )
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

        // Grab an image from the attached Jai
        // cameras. Perform a grab in a separate 
        // task to speed up the process.
        private void GrabImagesAndDisplay( )
        {
            foreach ( var imageController in _halconImageControllerDictionary.Values )
            {
                var controller = imageController;
                Task.Factory.StartNew( ( ) =>
                {
                    controller.HalconWindowControl.HalconWindow.DispObj( controller.HalconFramegrabber.GrabImage( ) );
                } );
            }
        }

        // Event is called from the mainview when the
        // form raises the Shown event.
        private void _mainView_InitializeHalconEvent( object sender, EventArgs e )
        {
            // Fill the framegrabber list with 
            // framgrabbers.
            FillHalconImageControllerDictionary( "Camera1", "000cdf09169e_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera2", "000cdf0916aa_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera3", "000cdf09169f_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera4", "000cdf0916a2_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera5", "000cdf0916a4_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera6", "000cdf0916a9_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera7", "000cdf0916a0_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera8", "000cdf0916a3_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera9", "000cdf0916a5_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera10", "000cdf0916a6_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera11", "000cdf0916a7_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera12", "000cdf0916b0_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera13", "000cdf0916af_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera14", "000cdf0916ad_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera15", "000cdf0916a1_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera16", "000cdf0916ab_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera17", "000cdf0916ac_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera18", "000cdf0916a8_JAICorporation_GO5000MPGE" );
            FillHalconImageControllerDictionary( "Camera19", "000cdf0916ae_JAICorporation_GO5000MPGE" );
        }
    }
}
