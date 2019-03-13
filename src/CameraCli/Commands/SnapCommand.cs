using System;
using System.Threading.Tasks;

#if Windows
using Windows.Foundation;
using Windows.Graphics.Imaging;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.Storage.Streams;
#endif

namespace CameraCli.Commands
{
    public class SnapCommand
    {
        // public async Task OnExecuteAsync()
        public void OnExecute()
        {
            // #if Windows
            // #region WindowsSpecific
            // MediaCapture mc = new MediaCapture();
            // // var settings = new MediaCaptureInitializationSettings();

            // await mc.InitializeAsync();

            // var myPictures = await Windows.Storage.StorageLibrary.GetLibraryAsync(KnownLibraryId.Pictures);
            // var file = await myPictures.SaveFolder.CreateFileAsync("photo.jpg", CreationCollisionOption.GenerateUniqueName);

            // using (var captureStream = new InMemoryRandomAccessStream())
            // {
            //     await mc.CapturePhotoToStreamAsync(ImageEncodingProperties.CreateJpeg(), captureStream);

            //     using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
            //     {
            //         var decoder = await BitmapDecoder.CreateAsync(captureStream);
            //         var encoder = await BitmapEncoder.CreateForTranscodingAsync(fileStream, decoder);

            //         var properties = new BitmapPropertySet
            //         {
            //             { "System.Photo.Orientation", new BitmapTypedValue(PhotoOrientation.Normal, PropertyType.UInt16) }
            //         };
            //         await encoder.BitmapProperties.SetPropertiesAsync(properties);

            //         await encoder.FlushAsync();
            //     }
            // }
            // #endregion
            // #else
            // #region UnixSpecific
            // await Task.Delay(0);
            // Console.WriteLine("Not implemented yet");
            // #endregion
            // #endif
        }
    }
}
