// using System;
// using System.Threading.Tasks;
// using Windows.Foundation;
// using Windows.Graphics.Imaging;
// using Windows.Media.Capture;
// using Windows.Media.MediaProperties;
// using Windows.Storage;
// using Windows.Storage.FileProperties;
// using Windows.Storage.Streams;
// using Windows.Devices.Enumeration;
// using CameraCli.Native;
// using System.Linq;
// using System.Security.Principal;
// using System.Diagnostics;
// using System.IO.Pipes;
// using System.IO;

// namespace CameraCli
// {
//     class ProgramOld
//     {
//         static async Task Startup(string[] args)
//         {

//             var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
//             Console.WriteLine(exeName);
//             Console.WriteLine("------------");

//             foreach (var a in args)
//             {
//                 Console.WriteLine(a);
//             }

//             Console.WriteLine("------------");

//             foreach (var b in System.Environment.GetCommandLineArgs())
//             {
//                 Console.WriteLine(b);
//             }

//             Console.WriteLine("------------");

//             NamedPipeClientStream clientPipeWriter = null;

//             try
//             {
//                 if (IsAdmin())
//                 {
//                     // Console.WriteLine(args[0]);
//                     clientPipeWriter = new NamedPipeClientStream(".", "cameraclipipe", PipeDirection.Out);
//                     var writer = new StreamWriter(clientPipeWriter);

//                     clientPipeWriter.Connect();
//                     writer.AutoFlush = true;
//                     // Send a 'sync message' and wait for the calling process to receive it
//                     writer.WriteLine("SYNC");
//                     // clientPipeWriter.WaitForPipeDrain();
//                     // Console.SetOut(clientPipeWriter.AsOutputStream())

//                     Console.SetOut(TextWriter.Synchronized(writer));
//                 }

//                 var devices = DeviceManager.ListDevices();

//                 // Console.WriteLine(devices.Count);
//                 var device = devices.Where(d => d.Service == "usbvideo\0")
//                     .FirstOrDefault();

//                 // var camera = await ListCameras();
//                 Console.WriteLine($"{device.Name} | {device.InstanceId} | {device.Service}");

//                 if (!IsAdmin())
//                 {
//                     Console.WriteLine("Enabling of disabling camera should be run as admin");
//                     Console.Write("Elevate process, Y/N: ");
//                     var response = Console.ReadLine();

//                     if (response == "Y") ElevateProcess();

//                     return;
//                 }

//                 if (device.ConfigurationFlags == 0)
//                 {
//                     DeviceManager.DisableDevice(device);
//                 }
//                 else
//                 {
//                     DeviceManager.EnableDevice(device);
//                 }

//                 if (clientPipeWriter != null)
//                 {
//                     Console.ReadLine();
//                     Console.WriteLine("END");
//                     await clientPipeWriter.DisposeAsync();
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine(ex);
//                 Console.ReadLine();
//             }

//         }

//         static void ElevateProcess()
//         {
//             var exeName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
//             ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
//             startInfo.Verb = "runas";
//             startInfo.UseShellExecute = true;
//             startInfo.CreateNoWindow = true;
//             startInfo.WindowStyle = ProcessWindowStyle.Hidden;

//             if (exeName.EndsWith("dotnet.exe"))
//             {
//                 foreach (var arg in System.Environment.GetCommandLineArgs())
//                 {
//                     startInfo.ArgumentList.Add(arg);
//                 }
//             }

//             using (var pipeServer = new NamedPipeServerStream("cameraclipipe", PipeDirection.In))
//             {

//                 // startInfo.Arguments = pipeRead.GetClientHandleAsString();

//                 var process = System.Diagnostics.Process.Start(startInfo);
//                 pipeServer.WaitForConnection();

//                 // pipeServer.

//                 using (var sr = new StreamReader(pipeServer))
//                 {
//                     string temp;

//                     // Wait for 'sync message' from the other process
//                     do
//                     {
//                         temp = sr.ReadLine();
//                     } while (temp == null || !temp.StartsWith("SYNC"));

//                     // Read until 'end message' from the other process
//                     while ((temp = sr.ReadLine()) != null && !temp.StartsWith("END"))
//                     {
//                         Console.WriteLine(temp);
//                     }
//                 }

//                 process.WaitForExit();
//                 process.Close();
//             }

//             return;
//         }

//         static bool IsAdmin()
//         {
//             using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
//             {
//                 WindowsPrincipal principal = new WindowsPrincipal(identity);
//                 return principal.IsInRole(WindowsBuiltInRole.Administrator);
//             }
//         }

//         static async Task TakePicture()
//         {
//             MediaCapture mc = new MediaCapture();
//             var settings = new MediaCaptureInitializationSettings()
//             {

//             };
//             await mc.InitializeAsync();

//             var myPictures = await Windows.Storage.StorageLibrary.GetLibraryAsync(KnownLibraryId.Pictures);
//             var file = await myPictures.SaveFolder.CreateFileAsync("photo.jpg", CreationCollisionOption.GenerateUniqueName);

//             using (var captureStream = new InMemoryRandomAccessStream())
//             {
//                 await mc.CapturePhotoToStreamAsync(ImageEncodingProperties.CreateJpeg(), captureStream);

//                 using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
//                 {
//                     var decoder = await BitmapDecoder.CreateAsync(captureStream);
//                     var encoder = await BitmapEncoder.CreateForTranscodingAsync(fileStream, decoder);

//                     var properties = new BitmapPropertySet
//                     {
//                         { "System.Photo.Orientation", new BitmapTypedValue(PhotoOrientation.Normal, PropertyType.UInt16) }
//                     };
//                     await encoder.BitmapProperties.SetPropertiesAsync(properties);

//                     await encoder.FlushAsync();
//                 }
//             }
//         }

//         static async Task<DeviceInformation> ListCameras()
//         {
//             var devices = await DeviceInformation.FindAllAsync(Windows.Devices.Enumeration.DeviceClass.VideoCapture);

//             if (devices.Count == 0)
//             {
//                 Console.WriteLine("No devices found");
//                 return null;
//             }

//             int cnt = 0;
//             DeviceInformation r = null;
//             foreach (var device in devices)
//             {
//                 var status = device.IsEnabled ? "Enabled" : "Disabled";
//                 var def = device.IsDefault ? "Default" : "Not Default";
//                 var instanceId = device.Properties["System.Devices.DeviceInstanceId"];
//                 Console.WriteLine($"{cnt++}. ({instanceId}) {device.Name} {status}");

//                 // foreach(var prop in device.Properties)
//                 // {
//                 //     Console.WriteLine($"Key {prop.Key}: {prop.Value}");
//                 // }

//                 r = device;
//                 break;
//             }

//             return r;
//         }
//     }
// }
