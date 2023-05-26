using Microsoft.AspNetCore.Components;
using PCSC;

namespace ParvigateUI.DTOs
{
    public partial class NFCReader : ComponentBase, IDisposable
    {
        private SCardContext _context;
        private SCardReader _reader;
        private string _readerName;
        private bool _isReading;

        protected override void OnInitialized()
        {
            _context = new SCardContext();
            _reader = new SCardReader(_context);
        }



        public async Task StartReading()
        {
            if (_isReading) return;

            //await Task.Run(async () =>
            //{
            _isReading = true;

            try
            {
                _context.Establish(SCardScope.System);
                string[] readerNames = _context.GetReaders();
                if (readerNames.Length == 0)
                {
                    // No NFC reader found
                    return;
                }

                _readerName = readerNames[0];
                SCardError connectResult = _reader.Connect(_readerName, SCardShareMode.Shared, SCardProtocol.Any);
                if (connectResult != SCardError.Success)
                {
                    // Failed to connect to the NFC reader
                    return;
                }

                //while (_isReading)
                //{
                //    SCardState state = _reader.Status(out string[] newReaderName, out SCardState sCardState,out SCardProtocol protocol, out byte[] data );
                //    if ((state & SCardState.Present) == SCardState.Present)
                //    {
                //        byte[] command = { 0xFF, 0xCA, 0x00, 0x00, 0x00 };
                //        byte[] response = new byte[256];
                //        int responseLength = response.Length;

                //        SCardError transmitResult = _reader.Transmit(command, response, ref responseLength);
                //        if (transmitResult == SCardError.Success)
                //        {
                //            byte[] responseData = response[..responseLength];
                //            // Process the NFC data as needed
                //            Console.WriteLine(BitConverter.ToString(responseData));
                //        }
                //    }

                //    await Task.Delay(500); // Delay between reading attempts
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _reader.Disconnect(SCardReaderDisposition.Reset);
                _context.Release();
            }
        //}
            //);
        }

        public void StopReading()
        {
            _isReading = false;
        }

        public void Dispose()
        {
            _reader?.Dispose();
            _context?.Dispose();
        }
    }
}
